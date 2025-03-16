﻿
namespace lab_02
{
    class Person
    {
        string _firstName, _lastName;
        DateTime _dateOfBirth;

        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }

        public DateTime DateOfBirth{ get { return _dateOfBirth; } set { _dateOfBirth = value; } }

        
        public Person()
        {
            _firstName = "";
            _lastName = "";
            _dateOfBirth = DateTime.MaxValue;

        }
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"Person | FirstName: {_firstName}, LastName: {_lastName}, DateOfBirth: {_dateOfBirth}";
        }
        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}
