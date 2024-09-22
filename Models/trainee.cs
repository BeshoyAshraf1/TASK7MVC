using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.Models
{
    public class trainee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string image { get; set; }

        public double  Grade { get; set; }

        public string address { get; set; }

        public virtual ICollection<Courseresult> Courseresults { get; set; }


    }
}
