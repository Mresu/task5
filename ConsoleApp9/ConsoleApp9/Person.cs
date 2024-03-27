using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Person(string name, string surname, byte age)
    {
      public string Name = name;
        public string Surname = surname;
        byte _age = age;
            public byte Age
            {
            get
            {
                return _age;   
            } 
            set
            { if (0< value) 
                {
                    _age = value;
                }
            else
                {
                    Console.WriteLine(  "menfi no");
                }

            } 
            
        }

        public void ShowInfo()
        {
            Console.WriteLine(Name+" "+Surname+" "+_age);
        }
    }
}
