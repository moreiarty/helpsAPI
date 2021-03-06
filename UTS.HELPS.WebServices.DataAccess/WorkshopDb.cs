﻿using System.Collections.Generic;
using System.Linq;
using UTS.HELPS.WebServices.DataObjects.Requests;

namespace UTS.HELPS.WebServices.DataAccess
{
    public class WorkshopDb
    {
        public static BasicWorkshop GetWorkshop(int workshopId)
        {
            using (HELPSEntities ctx = new HELPSEntities())
            {
                return ctx.prcGetWorkshop(workshopId).FirstOrDefault();
            }
        }

        public static Workshop GetWorkshopDetail(int workshopId)
        {
            using (HELPSEntities ctx = new HELPSEntities())
            {
                return ctx.prcGetWorkshopDetail(workshopId).FirstOrDefault();
            }
        }

        public static List<WorkShopSet> ListWorkShopSets(bool? active)
        {
            using (HELPSEntities ctx = new HELPSEntities())
            {
                return ctx.prcListWorkShopSets(active).ToList();
            }
        }

        public static int?[] GetProgramWorkshops(int programId)
        {
            using (HELPSEntities ctx = new HELPSEntities())
            {
                return ctx.prcGetProgramWorkshops(programId).ToArray();
            }
        }

        public static BasicWorkshopBooking GetWorkshopBooking(int workshopId, string studentId)
        {
            using (HELPSEntities ctx = new HELPSEntities())
            {
                return ctx.prcGetWorkshopBooking(workshopId, studentId).FirstOrDefault(x => x.archived == null);
            }            
        }

        public static BasicWorkshopWaiting GetWorkshopWaiting(int workshopId, string studentId)
        {
            using (HELPSEntities ctx = new HELPSEntities())
            {
                return ctx.prcGetWorkshopWaiting(workshopId, studentId).FirstOrDefault();
            }
        }

        public static List<BasicWorkshopWaiting> GetWorkshopWaitingList(int workshopId)
        {
            using (HELPSEntities ctx = new HELPSEntities())
            {
                return ctx.prcGetWorkshopWaitingList(workshopId).ToList();
            }
        }

        public static void CreateWorkshopBooking(int workshopId, string studentId, int userId)
        {
            using (HELPSEntities ctx = new HELPSEntities())
            {
                ctx.prcCreateWorkshopBooking(workshopId, studentId, userId);
            }
        }

        public static void CreateWorkshopWaiting(int workshopId, string studentId, int? priority, int userId)
        {
            using (HELPSEntities ctx = new HELPSEntities())
            {
                ctx.prcCreateWorkshopWaiting(workshopId, studentId, priority, userId);
            }            
        }

        public static void CancelWorkshopBooking(int workshopId, string studentId, int userId)
        {
            using (HELPSEntities ctx = new HELPSEntities())
            {
                ctx.prcCancelWorkshopBooking(workshopId, studentId, userId);
            }            
        }

        public static List<WorkshopBooking> SearchWorkshopBookings(WorkshopBookingSearch bookingSearch)
        {
            using (HELPSEntities ctx = new HELPSEntities())
            {
                return ctx.prcSearchWorkshopBookings(bookingSearch.StudentId, 
                        bookingSearch.StartingDtBegin, bookingSearch.StartingDtEnd,
                        bookingSearch.EndingDtBegin, bookingSearch.EndingDtEnd, bookingSearch.CampusId,
                        bookingSearch.Active, bookingSearch.Page, bookingSearch.PageSize).ToList();
            }
        }

        public static List<Workshop> SearchWorkshops(WorkshopSearch workshopSearch)
        {
            using (HELPSEntities ctx = new HELPSEntities())
            {
                return ctx.prcSearchWorkshops(workshopSearch.WorkshopSetId, workshopSearch.Topic,
                    workshopSearch.StartingDtBegin, workshopSearch.StartingDtEnd, workshopSearch.EndingDtBegin,
                    workshopSearch.EndingDtEnd, workshopSearch.CampusId, workshopSearch.Active, workshopSearch.Page,
                    workshopSearch.PageSize).ToList();
            }
        }
        
        public static void UpdateWorkshopBooking(UpdateWorkshopBooking update)
        {
            using (HELPSEntities ctx = new HELPSEntities())
            {
                ctx.prcUpdateWorkshopBooking(update.WorkshopId, update.StudentId, 
                    update.Canceled, update.Attended, update.UserId, update.Notes);
            }
        }
    }
}
