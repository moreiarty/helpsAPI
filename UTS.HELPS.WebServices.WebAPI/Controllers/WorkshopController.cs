using System;
using System.Collections.Generic;
using System.Web.Http;
using UTS.HELPS.WebServices.DataAccess;
using UTS.HELPS.WebServices.DataObjects.Requests;
using UTS.HELPS.WebServices.WebAPI.Constants;
using UTS.HELPS.WebServices.WebAPI.Responses;

namespace UTS.HELPS.WebServices.WebAPI.Controllers
{
    public class WorkshopController : BaseController
    {
        [HttpGet]
        [Route("api/workshop/workshopSets/{active?}")]
        public WorkShopSetListResponse ListWorkShopSets(bool? active = null)
        {
            try
            {
                base.CheckApplicationKey();

                List<WorkShopSet> list = WorkshopDb.ListWorkShopSets(active);
                return new WorkShopSetListResponse()
                {
                    IsSuccess = true,
                    Results = list
                };
            }
            catch (Exception e)
            {
                string msg = CreateExceptionMessage(e);
                return new WorkShopSetListResponse()
                {
                    IsSuccess = false,
                    DisplayMessage = string.Format(ErrorMessages.LIST_ERROR, msg)
                };
            }
        }

        [HttpPost]
        [Route("api/workshop/booking/create")]
        public Response CreateWorkshopBooking(int workshopId, string studentId, int userId)
        {
            try
            {
                base.CheckApplicationKey();

                // Check the workshop exists
                BasicWorkshop workshop = WorkshopDb.GetWorkshop(workshopId);
                if (workshop == null)
                {
                    return new Response()
                    {
                        IsSuccess = false,
                        DisplayMessage = ErrorMessages.WORKSHOP_NOT_FOUND
                    };
                }

                // Check the student exists
                Student student = StudentDb.GetStudent(studentId);
                if (student == null)
                {
                    return new Response()
                    {
                        IsSuccess = false,
                        DisplayMessage = ErrorMessages.STUDENT_NOT_FOUND
                    };                    
                }

                // Check booking doesn't already exist
                BasicWorkshopBooking booking = WorkshopDb.GetWorkshopBooking(workshopId, studentId);
                if (booking != null)
                {
                    return new Response()
                    {
                        IsSuccess = false,
                        DisplayMessage = ErrorMessages.CREATE_WORKSHOP_BOOKING_EXISTS_ERROR
                    };                      
                }

                // Check there are booking spots available
                if (workshop.cutoff.HasValue && workshop.cutoff <= workshop.BookingCount)
                {
                    return new Response()
                    {
                        IsSuccess = false,
                        DisplayMessage = ErrorMessages.MAXIMUM_WORKSHOP_BOOKINGS_ERROR
                    };                      
                }

                WorkshopDb.CreateWorkshopBooking(workshopId, studentId, userId);
            }
            catch (Exception e)
            {
                string msg = CreateExceptionMessage(e);
                return new Response()
                {
                    IsSuccess = false,
                    DisplayMessage = string.Format(ErrorMessages.CREATE_WORKSHOP_BOOKING_ERROR, msg)
                };
            }

            return new Response()
            {
                IsSuccess = true
            };
        }

        [HttpPost]
        [Route("api/program/booking/create")]
        public Response CreateProgramBooking(int programId, string studentId, int userId)
        {
            var workshops = WorkshopDb.GetProgramWorkshops(programId);
            string reason = null;
            foreach (int? workshop in workshops)
            {
                if (workshop.HasValue)
                {
                    var response = CreateWorkshopBooking(workshop.Value, studentId, userId);
                    if (!response.IsSuccess)
                        reason = response.DisplayMessage;
                }
            }
            if (reason != null)
                return new Response()
                {
                    IsSuccess = false,
                    DisplayMessage = reason
                };
            return new Response() {IsSuccess = true};
        }


        [HttpPost]
        [Route("api/program/booking/cancel")]
        public Response CancelProgramBooking(int programId, string studentId, int userId)
        {
            var workshops = WorkshopDb.GetProgramWorkshops(programId);
            string reason = null;
            foreach (int? workshop in workshops)
            {
                if (workshop.HasValue)
                {
                    var response = CancelWorkshopBooking(workshop.Value, studentId, userId);
                    if (!response.IsSuccess)
                        reason = response.DisplayMessage;
                }
            }
            if (reason != null)
                return new Response()
                {
                    IsSuccess = false,
                    DisplayMessage = reason
                };
            return new Response() { IsSuccess = true };
        }

        [HttpPost]
        [Route("api/workshop/wait/create")]
        public Response CreateWorkshopWaiting(int workshopId, string studentId, int userId, int? priority = null)
        {
            try
            {
                base.CheckApplicationKey();

                // Check the workshop exists
                BasicWorkshop workshop = WorkshopDb.GetWorkshop(workshopId);
                if (workshop == null)
                {
                    return new Response()
                    {
                        IsSuccess = false,
                        DisplayMessage = ErrorMessages.WORKSHOP_NOT_FOUND
                    };
                }

                // Check the student exists
                Student student = StudentDb.GetStudent(studentId);
                if (student == null)
                {
                    return new Response()
                    {
                        IsSuccess = false,
                        DisplayMessage = ErrorMessages.STUDENT_NOT_FOUND
                    };
                }

                // Check student doesn't have booking
                BasicWorkshopBooking booking = WorkshopDb.GetWorkshopBooking(workshopId, studentId);
                if (booking != null && !booking.archived.HasValue)
                {
                    return new Response()
                    {
                        IsSuccess = false,
                        DisplayMessage = ErrorMessages.CREATE_WORKSHOP_WAITING_BOOKING_EXISTS_ERROR
                    };
                }

                // Check student isn't already on the wait-list
                BasicWorkshopWaiting waiting = WorkshopDb.GetWorkshopWaiting(workshopId, studentId);
                if (waiting != null && !waiting.archived.HasValue)
                {
                    return new Response()
                    {
                        IsSuccess = false,
                        DisplayMessage = ErrorMessages.CREATE_WORKSHOP_WAITING_EXISTS_ERROR
                    };                    
                }

                WorkshopDb.CreateWorkshopWaiting(workshopId, studentId, priority, userId);
            }
            catch (Exception e)
            {
                string msg = CreateExceptionMessage(e);
                return new Response()
                {
                    IsSuccess = false,
                    DisplayMessage = string.Format(ErrorMessages.CREATE_WORKSHOP_WAITING_ERROR, msg)
                };                
            }

            return new Response()
            {
                IsSuccess = true
            };
        }

        [HttpGet]
        [Route("api/workshop/wait/count")]
        public WaitListCountResponse CountWorkshopWaiting(int workshopId)
        {
            try
            {
                base.CheckApplicationKey();

                // Check the workshop exists
                BasicWorkshop workshop = WorkshopDb.GetWorkshop(workshopId);
                if (workshop == null)
                {
                    return new WaitListCountResponse()
                    {
                        Count = -1,
                        IsSuccess = false,
                        DisplayMessage = ErrorMessages.WORKSHOP_NOT_FOUND
                    };
                }

                //Count the waitlist and return
                List<BasicWorkshopWaiting> waiting = WorkshopDb.GetWorkshopWaitingList(workshopId);
                return new WaitListCountResponse()
                {
                    IsSuccess = true,
                    Count = waiting.Count
                };
            }
            catch (Exception e)
            {
                string msg = CreateExceptionMessage(e);
                return new WaitListCountResponse()
                {
                    Count = -1,
                    IsSuccess = false,
                    DisplayMessage = string.Format(ErrorMessages.CREATE_WORKSHOP_WAITING_ERROR, msg)
                };
            }
        }

        [
            HttpPost]
        [Route("api/workshop/booking/cancel")]
        public Response CancelWorkshopBooking(int workshopId, string studentId, int userId)
        {
            try
            {
                base.CheckApplicationKey();

                // Check the booking exists
                BasicWorkshopBooking workshopBooking = WorkshopDb.GetWorkshopBooking(workshopId, studentId);
                if (workshopBooking == null)
                {
                    return new Response()
                    {
                        IsSuccess = false,
                        DisplayMessage = ErrorMessages.WORKSHOP_BOOKING_NOT_FOUND
                    };
                }

                WorkshopDb.CancelWorkshopBooking(workshopId, studentId, userId);
            }
            catch (Exception e)
            {
                string msg = CreateExceptionMessage(e);
                return new Response()
                {
                    IsSuccess = false,
                    DisplayMessage = string.Format(ErrorMessages.CANCEL_WORKSHOP_BOOKING_ERROR, msg)
                };
            }

            return new Response()
            {
                IsSuccess = true
            };
        }

        [HttpGet]
        [Route("api/workshop/booking/search")]
        public WorkshopBookingListResponse SearchWorkshopBookings([FromUri] WorkshopBookingSearch bookingSearch)
        {
            try
            {
                base.CheckApplicationKey();

                if (bookingSearch == null)
                {
                    return new WorkshopBookingListResponse()
                    {
                        IsSuccess = false,
                        DisplayMessage = ErrorMessages.SEARCH_CRITERIA_REQ_ERROR
                    };
                }

                List<WorkshopBooking> list = WorkshopDb.SearchWorkshopBookings(bookingSearch);
                return new WorkshopBookingListResponse()
                {
                    IsSuccess = true,
                    Results = list
                };
            }
            catch (Exception e)
            {
                string msg = CreateExceptionMessage(e);
                return new WorkshopBookingListResponse()
                {
                    IsSuccess = false,
                    DisplayMessage = string.Format(ErrorMessages.SEARCH_WORKSHOP_BOOKING_ERROR, msg)
                };
            }
        }

        [HttpGet]
        [Route("api/workshop/search")]
        public WorkshopListResponse SearchWorkshops([FromUri] WorkshopSearch workshopSearch)
        {
            try
            {
                base.CheckApplicationKey();

                if (workshopSearch == null)
                {
                    return new WorkshopListResponse()
                    {
                        IsSuccess = false,
                        DisplayMessage = ErrorMessages.SEARCH_CRITERIA_REQ_ERROR
                    };
                }

                List<Workshop> list = WorkshopDb.SearchWorkshops(workshopSearch);
                return new WorkshopListResponse()
                {
                    IsSuccess = true,
                    Results = list
                };
            }
            catch (Exception e)
            {
                string msg = CreateExceptionMessage(e);
                return new WorkshopListResponse()
                {
                    IsSuccess = false,
                    DisplayMessage = string.Format(ErrorMessages.SEARCH_WORKSHOP_ERROR, msg)
                };
            }
        }


        [HttpGet]
        [Route("api/workshop/{id?}")]
        public WorkshopListResponse Workshop(int? id)
        {
            try
            {
                base.CheckApplicationKey();

                if (id == null)
                {
                    return new WorkshopListResponse()
                    {
                        IsSuccess = false,
                        DisplayMessage = ErrorMessages.SEARCH_CRITERIA_REQ_ERROR
                    };
                }

                List<Workshop> list = new List<Workshop>();
                list.Add(WorkshopDb.GetWorkshopDetail(id.Value));
                return new WorkshopListResponse()
                {
                    IsSuccess = true,
                    Results = list
                };
            }
            catch (Exception e)
            {
                string msg = CreateExceptionMessage(e);
                return new WorkshopListResponse()
                {
                    IsSuccess = false,
                    DisplayMessage = string.Format(ErrorMessages.SEARCH_WORKSHOP_ERROR, msg)
                };
            }
        }

        [HttpPut]
        [Route("api/workshop/booking/update")]
        public Response UpdateWorkshopBooking(UpdateWorkshopBooking update)
        {
            try
            {
                base.CheckApplicationKey();
                if (update == null)
                {
                    return new Response()
                    {
                        IsSuccess = false,
                        DisplayMessage = ErrorMessages.UPDATE_REQ_ERROR
                    };
                }

                var workshop = WorkshopDb.GetWorkshopDetail(update.WorkshopId);
                if (workshop == null)
                {
                    return new Response()
                    {
                        IsSuccess = false,
                        DisplayMessage = ErrorMessages.WORKSHOP_NOT_FOUND
                    };
                }
                if (DateTime.UtcNow.AddDays(-7) > workshop.EndDate && update.Notes != null)
                {
                    return new Response()
                    {
                        IsSuccess = false,
                        DisplayMessage = ErrorMessages.NOTES_LOCKOUT
                    };
                }

                WorkshopDb.UpdateWorkshopBooking(update);
            }
            catch (Exception e)
            {
                string msg = CreateExceptionMessage(e);
                return new Response()
                {
                    IsSuccess = false,
                    DisplayMessage = string.Format(ErrorMessages.UPDATE_WORKSHOP_BOOKING_ERROR, msg)
                };
            }

            return new Response()
            {
                IsSuccess = true
            };
        }
    }
}
