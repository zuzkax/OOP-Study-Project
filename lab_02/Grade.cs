using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    class Grade
    {
        string _subjectName;
        DateTime _date;
        double _value;

        public string SubjectName { get { return _subjectName; } set { _subjectName = value; } }
        public DateTime Date { get { return _date;  } set { _date = value; } }
        public double Value { get { return _value;  } set { _value = value; } }

        public Grade() 
        {
            _subjectName = string.Empty;
            _date = DateTime.MinValue;
            _value = 0;
        }
        public Grade(string subjectName, double value, DateTime date)
        {
            SubjectName = subjectName;
            Date = date;
            Value = value;
        }

        public override string ToString()
        {
            return $"Grade | SubjecName: {_subjectName}, Date: {_date}, Value: {_value}";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }


    }
}
