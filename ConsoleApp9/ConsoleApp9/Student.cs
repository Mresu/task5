using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Student:Person
        
    {
        private static double point;
        private static int studentid;
        public int StudentId= studentid;
        double _point = point;

        public Student( string name, string surname, byte age, int studentid, double point):base(name,surname,age)
        {

        }
        public int Point
        {
            get

            {
                return (int)_point;
            }
            set
            {
                if (Point>0 && Point<100) 

                { 

                    _point = value;
                }
                else
                {
                    Console.WriteLine("sehv");
                }

            }
        }
        public void Showinfo()
        {
            Console.WriteLine(Name+" "+Surname+" "+Age+" "+studentid+" "+point);
        }
    }
}
