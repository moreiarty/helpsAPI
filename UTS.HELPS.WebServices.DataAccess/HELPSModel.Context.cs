﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UTS.HELPS.WebServices.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HELPSEntities : DbContext
    {
        public HELPSEntities()
            : base("name=HELPSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<booking> bookings { get; set; }
        public virtual DbSet<emailtemplate> emailtemplates { get; set; }
        public virtual DbSet<lecturer1> lecturer1 { get; set; }
        public virtual DbSet<appointment1> appointment1 { get; set; }
        public virtual DbSet<assignment1> assignment1 { get; set; }
        public virtual DbSet<campu> campus { get; set; }
        public virtual DbSet<emailtemplatesCategory> emailtemplatesCategories { get; set; }
        public virtual DbSet<learningissue> learningissues { get; set; }
        public virtual DbSet<message> messages { get; set; }
        public virtual DbSet<program> programs { get; set; }
        public virtual DbSet<sessionDocument> sessionDocuments { get; set; }
        public virtual DbSet<session> sessions { get; set; }
        public virtual DbSet<sessionsType> sessionsTypes { get; set; }
        public virtual DbSet<student1> student1 { get; set; }
        public virtual DbSet<waiting> waitings { get; set; }
        public virtual DbSet<workshop1> workshop1 { get; set; }
        public virtual DbSet<workShops_booking> workShops_booking { get; set; }
        public virtual DbSet<workShops_waiting> workShops_waiting { get; set; }
        public virtual DbSet<WorkShopSet1> WorkShopSet1 { get; set; }
    
        public virtual int prcCreateStudent(string studentID, Nullable<System.DateTime> dob, string gender, string degree, string status, string first_language, string country_origin, string background, Nullable<bool> hSC, string hSC_mark, Nullable<bool> iELTS, string iELTS_mark, Nullable<bool> tOEFL, string tOEFL_mark, Nullable<bool> tAFE, string tAFE_mark, Nullable<bool> cULT, string cULT_mark, Nullable<bool> insearchDEEP, string insearchDEEP_mark, Nullable<bool> insearchDiploma, string insearchDiploma_mark, Nullable<bool> foundationcourse, string foundationcourse_mark, Nullable<int> creatorID, string degree_details, string alternative_contact, string preferred_name)
        {
            var studentIDParameter = studentID != null ?
                new ObjectParameter("studentID", studentID) :
                new ObjectParameter("studentID", typeof(string));
    
            var dobParameter = dob.HasValue ?
                new ObjectParameter("dob", dob) :
                new ObjectParameter("dob", typeof(System.DateTime));
    
            var genderParameter = gender != null ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(string));
    
            var degreeParameter = degree != null ?
                new ObjectParameter("degree", degree) :
                new ObjectParameter("degree", typeof(string));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            var first_languageParameter = first_language != null ?
                new ObjectParameter("first_language", first_language) :
                new ObjectParameter("first_language", typeof(string));
    
            var country_originParameter = country_origin != null ?
                new ObjectParameter("country_origin", country_origin) :
                new ObjectParameter("country_origin", typeof(string));
    
            var backgroundParameter = background != null ?
                new ObjectParameter("background", background) :
                new ObjectParameter("background", typeof(string));
    
            var hSCParameter = hSC.HasValue ?
                new ObjectParameter("HSC", hSC) :
                new ObjectParameter("HSC", typeof(bool));
    
            var hSC_markParameter = hSC_mark != null ?
                new ObjectParameter("HSC_mark", hSC_mark) :
                new ObjectParameter("HSC_mark", typeof(string));
    
            var iELTSParameter = iELTS.HasValue ?
                new ObjectParameter("IELTS", iELTS) :
                new ObjectParameter("IELTS", typeof(bool));
    
            var iELTS_markParameter = iELTS_mark != null ?
                new ObjectParameter("IELTS_mark", iELTS_mark) :
                new ObjectParameter("IELTS_mark", typeof(string));
    
            var tOEFLParameter = tOEFL.HasValue ?
                new ObjectParameter("TOEFL", tOEFL) :
                new ObjectParameter("TOEFL", typeof(bool));
    
            var tOEFL_markParameter = tOEFL_mark != null ?
                new ObjectParameter("TOEFL_mark", tOEFL_mark) :
                new ObjectParameter("TOEFL_mark", typeof(string));
    
            var tAFEParameter = tAFE.HasValue ?
                new ObjectParameter("TAFE", tAFE) :
                new ObjectParameter("TAFE", typeof(bool));
    
            var tAFE_markParameter = tAFE_mark != null ?
                new ObjectParameter("TAFE_mark", tAFE_mark) :
                new ObjectParameter("TAFE_mark", typeof(string));
    
            var cULTParameter = cULT.HasValue ?
                new ObjectParameter("CULT", cULT) :
                new ObjectParameter("CULT", typeof(bool));
    
            var cULT_markParameter = cULT_mark != null ?
                new ObjectParameter("CULT_mark", cULT_mark) :
                new ObjectParameter("CULT_mark", typeof(string));
    
            var insearchDEEPParameter = insearchDEEP.HasValue ?
                new ObjectParameter("InsearchDEEP", insearchDEEP) :
                new ObjectParameter("InsearchDEEP", typeof(bool));
    
            var insearchDEEP_markParameter = insearchDEEP_mark != null ?
                new ObjectParameter("InsearchDEEP_mark", insearchDEEP_mark) :
                new ObjectParameter("InsearchDEEP_mark", typeof(string));
    
            var insearchDiplomaParameter = insearchDiploma.HasValue ?
                new ObjectParameter("InsearchDiploma", insearchDiploma) :
                new ObjectParameter("InsearchDiploma", typeof(bool));
    
            var insearchDiploma_markParameter = insearchDiploma_mark != null ?
                new ObjectParameter("InsearchDiploma_mark", insearchDiploma_mark) :
                new ObjectParameter("InsearchDiploma_mark", typeof(string));
    
            var foundationcourseParameter = foundationcourse.HasValue ?
                new ObjectParameter("foundationcourse", foundationcourse) :
                new ObjectParameter("foundationcourse", typeof(bool));
    
            var foundationcourse_markParameter = foundationcourse_mark != null ?
                new ObjectParameter("foundationcourse_mark", foundationcourse_mark) :
                new ObjectParameter("foundationcourse_mark", typeof(string));
    
            var creatorIDParameter = creatorID.HasValue ?
                new ObjectParameter("creatorID", creatorID) :
                new ObjectParameter("creatorID", typeof(int));
    
            var degree_detailsParameter = degree_details != null ?
                new ObjectParameter("degree_details", degree_details) :
                new ObjectParameter("degree_details", typeof(string));
    
            var alternative_contactParameter = alternative_contact != null ?
                new ObjectParameter("alternative_contact", alternative_contact) :
                new ObjectParameter("alternative_contact", typeof(string));
    
            var preferred_nameParameter = preferred_name != null ?
                new ObjectParameter("preferred_name", preferred_name) :
                new ObjectParameter("preferred_name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("prcCreateStudent", studentIDParameter, dobParameter, genderParameter, degreeParameter, statusParameter, first_languageParameter, country_originParameter, backgroundParameter, hSCParameter, hSC_markParameter, iELTSParameter, iELTS_markParameter, tOEFLParameter, tOEFL_markParameter, tAFEParameter, tAFE_markParameter, cULTParameter, cULT_markParameter, insearchDEEPParameter, insearchDEEP_markParameter, insearchDiplomaParameter, insearchDiploma_markParameter, foundationcourseParameter, foundationcourse_markParameter, creatorIDParameter, degree_detailsParameter, alternative_contactParameter, preferred_nameParameter);
        }
    
        public virtual ObjectResult<SessionType> prcListSessionTypes(Nullable<bool> active)
        {
            var activeParameter = active.HasValue ?
                new ObjectParameter("active", active) :
                new ObjectParameter("active", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SessionType>("prcListSessionTypes", activeParameter);
        }
    
        public virtual ObjectResult<SessionBooking> prcSearchSessionBookings(string studentID, Nullable<System.DateTime> startingDtBegin, Nullable<System.DateTime> startingDtEnd, Nullable<System.DateTime> endingDtBegin, Nullable<System.DateTime> endingDtEnd, string campus, Nullable<int> lecturerID, Nullable<int> sessionTypeID, Nullable<bool> active, Nullable<int> page, Nullable<int> pageSize)
        {
            var studentIDParameter = studentID != null ?
                new ObjectParameter("studentID", studentID) :
                new ObjectParameter("studentID", typeof(string));
    
            var startingDtBeginParameter = startingDtBegin.HasValue ?
                new ObjectParameter("startingDtBegin", startingDtBegin) :
                new ObjectParameter("startingDtBegin", typeof(System.DateTime));
    
            var startingDtEndParameter = startingDtEnd.HasValue ?
                new ObjectParameter("startingDtEnd", startingDtEnd) :
                new ObjectParameter("startingDtEnd", typeof(System.DateTime));
    
            var endingDtBeginParameter = endingDtBegin.HasValue ?
                new ObjectParameter("endingDtBegin", endingDtBegin) :
                new ObjectParameter("endingDtBegin", typeof(System.DateTime));
    
            var endingDtEndParameter = endingDtEnd.HasValue ?
                new ObjectParameter("endingDtEnd", endingDtEnd) :
                new ObjectParameter("endingDtEnd", typeof(System.DateTime));
    
            var campusParameter = campus != null ?
                new ObjectParameter("campus", campus) :
                new ObjectParameter("campus", typeof(string));
    
            var lecturerIDParameter = lecturerID.HasValue ?
                new ObjectParameter("lecturerID", lecturerID) :
                new ObjectParameter("lecturerID", typeof(int));
    
            var sessionTypeIDParameter = sessionTypeID.HasValue ?
                new ObjectParameter("sessionTypeID", sessionTypeID) :
                new ObjectParameter("sessionTypeID", typeof(int));
    
            var activeParameter = active.HasValue ?
                new ObjectParameter("active", active) :
                new ObjectParameter("active", typeof(bool));
    
            var pageParameter = page.HasValue ?
                new ObjectParameter("page", page) :
                new ObjectParameter("page", typeof(int));
    
            var pageSizeParameter = pageSize.HasValue ?
                new ObjectParameter("pageSize", pageSize) :
                new ObjectParameter("pageSize", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SessionBooking>("prcSearchSessionBookings", studentIDParameter, startingDtBeginParameter, startingDtEndParameter, endingDtBeginParameter, endingDtEndParameter, campusParameter, lecturerIDParameter, sessionTypeIDParameter, activeParameter, pageParameter, pageSizeParameter);
        }
    
        public virtual int prcCancelWorkshopBooking(Nullable<int> workshopId, string studentId, Nullable<int> userId)
        {
            var workshopIdParameter = workshopId.HasValue ?
                new ObjectParameter("workshopId", workshopId) :
                new ObjectParameter("workshopId", typeof(int));
    
            var studentIdParameter = studentId != null ?
                new ObjectParameter("studentId", studentId) :
                new ObjectParameter("studentId", typeof(string));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("prcCancelWorkshopBooking", workshopIdParameter, studentIdParameter, userIdParameter);
        }
    
        public virtual ObjectResult<BasicWorkshopBooking> prcGetWorkshopBooking(Nullable<int> workshopId, string studentId)
        {
            var workshopIdParameter = workshopId.HasValue ?
                new ObjectParameter("workshopId", workshopId) :
                new ObjectParameter("workshopId", typeof(int));
    
            var studentIdParameter = studentId != null ?
                new ObjectParameter("studentId", studentId) :
                new ObjectParameter("studentId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BasicWorkshopBooking>("prcGetWorkshopBooking", workshopIdParameter, studentIdParameter);
        }
    
        public virtual ObjectResult<Student> prcGetStudent(string studentID)
        {
            var studentIDParameter = studentID != null ?
                new ObjectParameter("studentID", studentID) :
                new ObjectParameter("studentID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Student>("prcGetStudent", studentIDParameter);
        }
    
        public virtual ObjectResult<BasicWorkshop> prcGetWorkshop(Nullable<int> workshopId)
        {
            var workshopIdParameter = workshopId.HasValue ?
                new ObjectParameter("workshopId", workshopId) :
                new ObjectParameter("workshopId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BasicWorkshop>("prcGetWorkshop", workshopIdParameter);
        }
    
        public virtual int prcCreateWorkshopBooking(Nullable<int> workshopId, string studentId, Nullable<int> userId)
        {
            var workshopIdParameter = workshopId.HasValue ?
                new ObjectParameter("workshopId", workshopId) :
                new ObjectParameter("workshopId", typeof(int));
    
            var studentIdParameter = studentId != null ?
                new ObjectParameter("studentId", studentId) :
                new ObjectParameter("studentId", typeof(string));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("prcCreateWorkshopBooking", workshopIdParameter, studentIdParameter, userIdParameter);
        }
    
        public virtual int prcCreateWorkshopWaiting(Nullable<int> workshopId, string studentId, Nullable<int> priority, Nullable<int> userId)
        {
            var workshopIdParameter = workshopId.HasValue ?
                new ObjectParameter("workshopId", workshopId) :
                new ObjectParameter("workshopId", typeof(int));
    
            var studentIdParameter = studentId != null ?
                new ObjectParameter("studentId", studentId) :
                new ObjectParameter("studentId", typeof(string));
    
            var priorityParameter = priority.HasValue ?
                new ObjectParameter("priority", priority) :
                new ObjectParameter("priority", typeof(int));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("prcCreateWorkshopWaiting", workshopIdParameter, studentIdParameter, priorityParameter, userIdParameter);
        }
    
        public virtual ObjectResult<BasicWorkshopWaiting> prcGetWorkshopWaiting(Nullable<int> workshopId, string studentId)
        {
            var workshopIdParameter = workshopId.HasValue ?
                new ObjectParameter("workshopId", workshopId) :
                new ObjectParameter("workshopId", typeof(int));
    
            var studentIdParameter = studentId != null ?
                new ObjectParameter("studentId", studentId) :
                new ObjectParameter("studentId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BasicWorkshopWaiting>("prcGetWorkshopWaiting", workshopIdParameter, studentIdParameter);
        }
    
        public virtual ObjectResult<BasicSession> prcGetSession(Nullable<int> sessionId)
        {
            var sessionIdParameter = sessionId.HasValue ?
                new ObjectParameter("sessionId", sessionId) :
                new ObjectParameter("sessionId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BasicSession>("prcGetSession", sessionIdParameter);
        }
    
        public virtual ObjectResult<BasicSessionBooking> prcGetSessionBooking(Nullable<int> sessionId, string studentID)
        {
            var sessionIdParameter = sessionId.HasValue ?
                new ObjectParameter("sessionId", sessionId) :
                new ObjectParameter("sessionId", typeof(int));
    
            var studentIDParameter = studentID != null ?
                new ObjectParameter("studentID", studentID) :
                new ObjectParameter("studentID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BasicSessionBooking>("prcGetSessionBooking", sessionIdParameter, studentIDParameter);
        }
    
        public virtual ObjectResult<WorkshopBooking> prcSearchWorkshopBookings(string studentID, Nullable<System.DateTime> startingDtBegin, Nullable<System.DateTime> startingDtEnd, Nullable<System.DateTime> endingDtBegin, Nullable<System.DateTime> endingDtEnd, Nullable<int> campusId, Nullable<bool> active, Nullable<int> page, Nullable<int> pageSize)
        {
            var studentIDParameter = studentID != null ?
                new ObjectParameter("studentID", studentID) :
                new ObjectParameter("studentID", typeof(string));
    
            var startingDtBeginParameter = startingDtBegin.HasValue ?
                new ObjectParameter("startingDtBegin", startingDtBegin) :
                new ObjectParameter("startingDtBegin", typeof(System.DateTime));
    
            var startingDtEndParameter = startingDtEnd.HasValue ?
                new ObjectParameter("startingDtEnd", startingDtEnd) :
                new ObjectParameter("startingDtEnd", typeof(System.DateTime));
    
            var endingDtBeginParameter = endingDtBegin.HasValue ?
                new ObjectParameter("endingDtBegin", endingDtBegin) :
                new ObjectParameter("endingDtBegin", typeof(System.DateTime));
    
            var endingDtEndParameter = endingDtEnd.HasValue ?
                new ObjectParameter("endingDtEnd", endingDtEnd) :
                new ObjectParameter("endingDtEnd", typeof(System.DateTime));
    
            var campusIdParameter = campusId.HasValue ?
                new ObjectParameter("campusId", campusId) :
                new ObjectParameter("campusId", typeof(int));
    
            var activeParameter = active.HasValue ?
                new ObjectParameter("active", active) :
                new ObjectParameter("active", typeof(bool));
    
            var pageParameter = page.HasValue ?
                new ObjectParameter("page", page) :
                new ObjectParameter("page", typeof(int));
    
            var pageSizeParameter = pageSize.HasValue ?
                new ObjectParameter("pageSize", pageSize) :
                new ObjectParameter("pageSize", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<WorkshopBooking>("prcSearchWorkshopBookings", studentIDParameter, startingDtBeginParameter, startingDtEndParameter, endingDtBeginParameter, endingDtEndParameter, campusIdParameter, activeParameter, pageParameter, pageSizeParameter);
        }
    
        public virtual ObjectResult<Workshop> prcSearchWorkshops(Nullable<int> workshopSetId, string topic, Nullable<System.DateTime> startingDtBegin, Nullable<System.DateTime> startingDtEnd, Nullable<System.DateTime> endingDtBegin, Nullable<System.DateTime> endingDtEnd, Nullable<int> campusID, Nullable<bool> active, Nullable<int> page, Nullable<int> pageSize)
        {
            var workshopSetIdParameter = workshopSetId.HasValue ?
                new ObjectParameter("workshopSetId", workshopSetId) :
                new ObjectParameter("workshopSetId", typeof(int));
    
            var topicParameter = topic != null ?
                new ObjectParameter("topic", topic) :
                new ObjectParameter("topic", typeof(string));
    
            var startingDtBeginParameter = startingDtBegin.HasValue ?
                new ObjectParameter("startingDtBegin", startingDtBegin) :
                new ObjectParameter("startingDtBegin", typeof(System.DateTime));
    
            var startingDtEndParameter = startingDtEnd.HasValue ?
                new ObjectParameter("startingDtEnd", startingDtEnd) :
                new ObjectParameter("startingDtEnd", typeof(System.DateTime));
    
            var endingDtBeginParameter = endingDtBegin.HasValue ?
                new ObjectParameter("endingDtBegin", endingDtBegin) :
                new ObjectParameter("endingDtBegin", typeof(System.DateTime));
    
            var endingDtEndParameter = endingDtEnd.HasValue ?
                new ObjectParameter("endingDtEnd", endingDtEnd) :
                new ObjectParameter("endingDtEnd", typeof(System.DateTime));
    
            var campusIDParameter = campusID.HasValue ?
                new ObjectParameter("campusID", campusID) :
                new ObjectParameter("campusID", typeof(int));
    
            var activeParameter = active.HasValue ?
                new ObjectParameter("active", active) :
                new ObjectParameter("active", typeof(bool));
    
            var pageParameter = page.HasValue ?
                new ObjectParameter("page", page) :
                new ObjectParameter("page", typeof(int));
    
            var pageSizeParameter = pageSize.HasValue ?
                new ObjectParameter("pageSize", pageSize) :
                new ObjectParameter("pageSize", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Workshop>("prcSearchWorkshops", workshopSetIdParameter, topicParameter, startingDtBeginParameter, startingDtEndParameter, endingDtBeginParameter, endingDtEndParameter, campusIDParameter, activeParameter, pageParameter, pageSizeParameter);
        }
    
        public virtual int prcUpdateSessionBooking(Nullable<int> sessionId, string studentId, Nullable<bool> cancel, string assisstance, string reason, Nullable<int> attended, Nullable<int> waitingID, Nullable<int> isgroup, string numpeople, string lecturercomment, string learningissues, Nullable<int> islocked, string assigntype, string assigntypeOther, string subject, string appointments, string appointmentsOther, string assisstanceText, Nullable<int> userId)
        {
            var sessionIdParameter = sessionId.HasValue ?
                new ObjectParameter("sessionId", sessionId) :
                new ObjectParameter("sessionId", typeof(int));
    
            var studentIdParameter = studentId != null ?
                new ObjectParameter("studentId", studentId) :
                new ObjectParameter("studentId", typeof(string));
    
            var cancelParameter = cancel.HasValue ?
                new ObjectParameter("cancel", cancel) :
                new ObjectParameter("cancel", typeof(bool));
    
            var assisstanceParameter = assisstance != null ?
                new ObjectParameter("assisstance", assisstance) :
                new ObjectParameter("assisstance", typeof(string));
    
            var reasonParameter = reason != null ?
                new ObjectParameter("reason", reason) :
                new ObjectParameter("reason", typeof(string));
    
            var attendedParameter = attended.HasValue ?
                new ObjectParameter("attended", attended) :
                new ObjectParameter("attended", typeof(int));
    
            var waitingIDParameter = waitingID.HasValue ?
                new ObjectParameter("waitingID", waitingID) :
                new ObjectParameter("waitingID", typeof(int));
    
            var isgroupParameter = isgroup.HasValue ?
                new ObjectParameter("isgroup", isgroup) :
                new ObjectParameter("isgroup", typeof(int));
    
            var numpeopleParameter = numpeople != null ?
                new ObjectParameter("numpeople", numpeople) :
                new ObjectParameter("numpeople", typeof(string));
    
            var lecturercommentParameter = lecturercomment != null ?
                new ObjectParameter("lecturercomment", lecturercomment) :
                new ObjectParameter("lecturercomment", typeof(string));
    
            var learningissuesParameter = learningissues != null ?
                new ObjectParameter("learningissues", learningissues) :
                new ObjectParameter("learningissues", typeof(string));
    
            var islockedParameter = islocked.HasValue ?
                new ObjectParameter("islocked", islocked) :
                new ObjectParameter("islocked", typeof(int));
    
            var assigntypeParameter = assigntype != null ?
                new ObjectParameter("assigntype", assigntype) :
                new ObjectParameter("assigntype", typeof(string));
    
            var assigntypeOtherParameter = assigntypeOther != null ?
                new ObjectParameter("assigntypeOther", assigntypeOther) :
                new ObjectParameter("assigntypeOther", typeof(string));
    
            var subjectParameter = subject != null ?
                new ObjectParameter("subject", subject) :
                new ObjectParameter("subject", typeof(string));
    
            var appointmentsParameter = appointments != null ?
                new ObjectParameter("appointments", appointments) :
                new ObjectParameter("appointments", typeof(string));
    
            var appointmentsOtherParameter = appointmentsOther != null ?
                new ObjectParameter("appointmentsOther", appointmentsOther) :
                new ObjectParameter("appointmentsOther", typeof(string));
    
            var assisstanceTextParameter = assisstanceText != null ?
                new ObjectParameter("assisstanceText", assisstanceText) :
                new ObjectParameter("assisstanceText", typeof(string));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("prcUpdateSessionBooking", sessionIdParameter, studentIdParameter, cancelParameter, assisstanceParameter, reasonParameter, attendedParameter, waitingIDParameter, isgroupParameter, numpeopleParameter, lecturercommentParameter, learningissuesParameter, islockedParameter, assigntypeParameter, assigntypeOtherParameter, subjectParameter, appointmentsParameter, appointmentsOtherParameter, assisstanceTextParameter, userIdParameter);
        }
    
        public virtual int prcUpdateWorkshopBooking(Nullable<int> workshopId, string studentId, Nullable<int> canceled, Nullable<int> attended, Nullable<int> userId, string notes)
        {
            var workshopIdParameter = workshopId.HasValue ?
                new ObjectParameter("workshopId", workshopId) :
                new ObjectParameter("workshopId", typeof(int));
    
            var studentIdParameter = studentId != null ?
                new ObjectParameter("studentId", studentId) :
                new ObjectParameter("studentId", typeof(string));
    
            var canceledParameter = canceled.HasValue ?
                new ObjectParameter("canceled", canceled) :
                new ObjectParameter("canceled", typeof(int));
    
            var attendedParameter = attended.HasValue ?
                new ObjectParameter("attended", attended) :
                new ObjectParameter("attended", typeof(int));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            var notesParameter = notes != null ?
                new ObjectParameter("notes", notes) :
                new ObjectParameter("notes", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("prcUpdateWorkshopBooking", workshopIdParameter, studentIdParameter, canceledParameter, attendedParameter, userIdParameter, notesParameter);
        }
    
        public virtual ObjectResult<Appointment> prcListAppointments(Nullable<bool> active)
        {
            var activeParameter = active.HasValue ?
                new ObjectParameter("active", active) :
                new ObjectParameter("active", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Appointment>("prcListAppointments", activeParameter);
        }
    
        public virtual ObjectResult<Assignment> prcListAssignments(Nullable<bool> active)
        {
            var activeParameter = active.HasValue ?
                new ObjectParameter("active", active) :
                new ObjectParameter("active", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Assignment>("prcListAssignments", activeParameter);
        }
    
        public virtual ObjectResult<Campus> prcListCampuses(Nullable<bool> active)
        {
            var activeParameter = active.HasValue ?
                new ObjectParameter("active", active) :
                new ObjectParameter("active", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Campus>("prcListCampuses", activeParameter);
        }
    
        public virtual ObjectResult<Lecturer> prcListLecturers(Nullable<bool> active)
        {
            var activeParameter = active.HasValue ?
                new ObjectParameter("active", active) :
                new ObjectParameter("active", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Lecturer>("prcListLecturers", activeParameter);
        }
    
        public virtual ObjectResult<WorkShopSet> prcListWorkShopSets(Nullable<bool> active)
        {
            var activeParameter = active.HasValue ?
                new ObjectParameter("active", active) :
                new ObjectParameter("active", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<WorkShopSet>("prcListWorkShopSets", activeParameter);
        }
    
        public virtual ObjectResult<Workshop> prcGetWorkshopDetail(Nullable<int> workshopId)
        {
            var workshopIdParameter = workshopId.HasValue ?
                new ObjectParameter("workshopId", workshopId) :
                new ObjectParameter("workshopId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Workshop>("prcGetWorkshopDetail", workshopIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> prcGetProgramWorkshops(Nullable<int> programId)
        {
            var programIdParameter = programId.HasValue ?
                new ObjectParameter("programId", programId) :
                new ObjectParameter("programId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("prcGetProgramWorkshops", programIdParameter);
        }
    
        public virtual ObjectResult<BasicWorkshopWaiting> prcGetWorkshopWaitingList(Nullable<int> workshopId)
        {
            var workshopIdParameter = workshopId.HasValue ?
                new ObjectParameter("workshopId", workshopId) :
                new ObjectParameter("workshopId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BasicWorkshopWaiting>("prcGetWorkshopWaitingList", workshopIdParameter);
        }
    }
}
