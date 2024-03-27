using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp10
{
    internal class Human
    {
        public string Name {  get; set; }
     public string Surname {  get; set; }
     public  string Gender {   get; set; }

        public byte Age;
            private byte _age {
            get
            {
                return _age;
            
            }
            set
            {
                if (_age >=24)
                {
                    _age=value;
                }
                else
                {
                    Console.WriteLine("yasi dusmur");
                }
            } 
            
        }
        public string GetInfo()
        {
            return $"Name: {Name}\nSurname: {Surname}\nGender: {Gender}\nAge: {Age}";
        }
        public void ShowInfo()
        {
            Console.WriteLine(GetInfo());
        }
    }

}
