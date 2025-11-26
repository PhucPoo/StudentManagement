using System.ComponentModel.DataAnnotations;

namespace StudentManagement.StudentManagement.Core.Entities
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedAt { get; set; }

        public ICollection<NotificationReceiver> Receivers { get; set; }
    }
}
