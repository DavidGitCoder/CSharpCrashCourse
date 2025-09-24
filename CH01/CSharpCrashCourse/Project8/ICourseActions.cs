using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8
{
    internal interface ICourseActions
    {
        //Defines the methods that a class must implement
        //Interface methods are public and abstract by default
        public void StartCourse();
        public void StopCourse(); //just a method signature
    }
}
