using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGit
{
    public class Teacher
    {

        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Teacher(string ID, string Name, int Age)
        {
            this.ID = ID;
            this.Name = Name;
            this.Age = Age;
        }
    }
}
