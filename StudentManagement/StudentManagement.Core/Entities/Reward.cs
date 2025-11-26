using System.ComponentModel.DataAnnotations;

namespace StudentManagement.StudentManagement.Core.Entities
{
    public class Reward
    {
        [Key]
        public int RewardId { get; set; }

        public int StudentId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public string Date { get; set; }

        // Navigation
    }
}
