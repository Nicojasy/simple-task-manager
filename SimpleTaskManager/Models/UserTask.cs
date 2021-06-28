using System;

namespace SimpleTaskManager.Models
{
    public enum StatusEnum {
        NotStarted,
        InProcess,
        Completed,
        Expired,
        Rejected
    }

    public class UserTask
    {
        public int ID { get; set; }
        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public StatusEnum status { get; set; }
    }
}
