using System.ComponentModel.DataAnnotations;

namespace StudentManagement.StudentManagement.Core.Entities
{
    public class NotificationReceiver
    {
        [Key]
        public int NotificationReceiverId { get; set; }

        public int NotificationId { get; set; }
        public int StudentId { get; set; }
        public bool IsRead { get; set; }

        // Navigation
        public Notification Notification { get; set; }
    }
}
