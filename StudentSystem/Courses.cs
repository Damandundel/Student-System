using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    public class Courses
    {
        [Key]
        public int CourseId {  get; set; }
        [Required]
        [StringLength(80)]
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }

        public ICollection<Students> AttendingStudents { get; set; }
        public HomeworkSubmissions HomeworkSubmissions { get; set; }
    }
}
