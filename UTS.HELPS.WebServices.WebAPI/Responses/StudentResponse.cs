using UTS.HELPS.WebServices.DataAccess;

namespace UTS.HELPS.WebServices.WebAPI.Responses
{
    public class StudentResponse
    {
        public Student Student { get; set; }
        public bool IsSuccess { get; set; }
        public string DisplayMessage { get; set; }
    }
}
