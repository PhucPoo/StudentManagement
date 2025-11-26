using System.ComponentModel.DataAnnotations;

namespace StudentManagement.StudentManagement.Core.Entities
{
    public class RegradeRequest
    {
      
            [Key]
            public int RequestId { get; set; }

            public int ScoreId { get; set; }
            public int StudentId { get; set; }

            public string Reason { get; set; }
            public string Status { get; set; }
            public string Reply { get; set; }

            // Navigation
            public Score Score { get; set; }
    }
}
