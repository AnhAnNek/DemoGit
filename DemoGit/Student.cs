using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGit
{
    public class Student
    {
        private string id;
        private string name;
        private int age;
        public string ID
        { get { return id; } set { id = value; } }
        public string Name
        { get { return name; } set { name = value; } }
        public int Age
        { get { return age; } set { age = value; } }
    }
}
