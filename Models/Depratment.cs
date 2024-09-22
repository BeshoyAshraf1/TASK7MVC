using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.Models
{
    public class Depratment
    {
        public int id { get; set; }

        public string name { get; set; }

        public string managername { get; set; }

        public virtual ICollection<Instractor>? Instractors { get; set; }
    }
}
