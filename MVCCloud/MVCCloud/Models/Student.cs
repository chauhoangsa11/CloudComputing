using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCloud.Models
{
    public class Student
    {
        public int id { get; set; }
        
        public string name { get; set; }
        public int listenning { get; set; }
        public int speaking { get; set; }
        public int writing { get; set; }
        public int reading { get; set; }

        public int year { get; set; }
        public string address { get; set; }
        public Student()
        {

        }

    }
}
