using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project8
{
    //Inheritance is referred to as an "is a" relationship
    public class Person : Object //Inheritance  - Person is a subclass of Object
    {

        //Members:
        //Instance Fields (data)
        //Methods

        //it's ALL ABOUT THE INSTANCE FIELDS!
        //all instance fields have default values when an object is created
        //strins are empty
        //integers are 0
        //booleans are false
        //floating point are 0.0
        private string _firstName; //Data Hiding - fields are private and can only be accessed by methods
        private string _lastName;
        private int _age;

        //Constructor - Method that has the same name as a class, no return type
        //used to initialize the object with default values
        public Person() //default constructor
        {
        }
        public Person(string firstName, string lastName, int age) // Overloaded constructor
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }
      
        //Accessor and Mutator Methods

        //Accessor Method
        public string GetFirstName() 
        { 
            return _firstName;    
        }
        public string GetLastName()
        {
            return _lastName;
        }

        //Mutator Method
        public void SetFirstName(string firstName)
        {
            _firstName = firstName;
        }
        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }

        public int GetAge()
        {
            return _age;
        }
        public void SetAge(int age)
        {
            _age = age;
        }

        public int CalcDaysOld()
        {
            return _age * 365;
        }

        public override string ToString()
        {
            return $"The person's name is {_firstName} {_lastName} and is {_age} and is {CalcDaysOld()} days old";
        }

    }
}
