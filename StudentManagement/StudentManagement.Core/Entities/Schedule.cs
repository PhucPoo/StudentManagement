using System.ComponentModel.DataAnnotations;

namespace StudentManagement.StudentManagement.Core.Entities
{
    public class Schedule
    {
        [Key]
        public int ScheduleId { get; set; }

        public int CourseClassId { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Room { get; set; }

        // Navigation
        public CourseClass CourseClass { get; set; }
    }
}
