using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_list
{
    public class Firm
    {
        public string name { get; set; }
        public int age { get; set; }
        public int id { get; set; }
        public virtual string HireEmployee()
        {
            return name;
        }
    }
}
