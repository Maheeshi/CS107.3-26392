using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Encapclass
    { 
        private int age;
        private string name;
        public void SetAge(int ageFromUser)
        {
            age = ageFromUser;
        }
        public void SetName(string nameFromUser)
        { 
            name= nameFromUser;
        }
        public int getAge()
        { 
            return age;
        }
        public string getName()
        {
            return name;
        }
    }
}
