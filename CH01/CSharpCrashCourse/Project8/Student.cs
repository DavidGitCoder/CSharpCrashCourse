using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8
{
    internal class Student : Person, ICourseActions //Single Inheritance in C# means you can only have 1 parent
                                    //however you CAN implement multiple interfaces
    {
        private double _gpa;
        //Student will inherit the non-private fields and methods of Person
        public Student() { }
        public Student(string fn, string ln, int age, double gpa) : base(fn, ln, age) //means we reuse the Persons base constructor, no need to rewrite that part
        {
            if(gpa<0|| gpa> 4.0)
            {
                throw new ArgumentException("GPA must be between 0 and 4.0");
            }
            _gpa = gpa; //specific to students
        }

        public double GetGPA()
        {
            return _gpa;
        }
        public void SetGPA(double gpa)
        {
            _gpa = gpa;
        }

        public void StartCourse()
        {
            Console.WriteLine("Student turns on laptop, takes out notebook and pen and is WIDE AWAKE");
        }

        public void StopCourse()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString() + $" has a GPA of: {_gpa}";
        }

    }
}
