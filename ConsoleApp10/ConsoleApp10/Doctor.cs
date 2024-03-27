using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp10
{
    internal class Doctor : Human
    {
        public string Speciality { get; set; }
        private int _experience;



        public int Experience
        {
            get { return _experience; }
            set
            {
                if (value >= 0)
                    _experience = value;
                else
                    Console.WriteLine("menfi olmaz");
            }
        }
        public string GetInfo()
        {
            return $"{base.GetInfo()}\nSpeciality: {Speciality}\nExperience: {_experience} years";
        }

        public void ShowInfo()
        {
            Console.WriteLine(GetInfo());
        }

    }
}




