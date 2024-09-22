using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.Models
{
    public class Instractor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string image { get; set; }

        public int  Salary { get; set; }

        public string address { get; set; }

        [ForeignKey("Depratment")]
        public int DepratmentId { get; set; }
        public Depratment Depratments { get; set; }


        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Courses { get; set; }

    }
}
