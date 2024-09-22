using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Course Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]

        public string Name { get; set; }
        [Required(ErrorMessage = "The Degree is required.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Degree must be between 2 and 100 characters.")]

        public double  Degree { get; set; }
        [Required(ErrorMessage = "The Minimum Degree is required.")]
        [Range(0, 100, ErrorMessage = "MinDegree must be a non-negative number.")]

        [Remote("ValidateMinDegree", "Courses", HttpMethod = "POST", ErrorMessage = "Minimum Degree cannot be greater than the Degree.")]

        public double MinDegree { get; set; }

        public virtual ICollection<Instractor>? Instractors { get; set; }

        public virtual ICollection<Courseresult>? Courseresults { get; set; }


    }
}
