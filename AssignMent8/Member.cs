using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignMent8
{
    class Member
    {
        public string name { get; set; }
        public int age { get; set; }
        public string city { get; set; }

        public string job;
        public int fee;

        public string display()
        {
            return $"{name}\t{age}\t\t{city}\t{job}\t\t{fee:c}";
        }
            
    }
}
