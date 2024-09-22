using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.Models
{
    public class Courseresult
    {
        public int Id { get; set; }

        public double Degree { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Courses { get; set; }

        [ForeignKey("trainee")]
        public int traineeId { get; set; }
        public trainee trainees { get; set; }
    }
}
