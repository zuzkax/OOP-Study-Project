using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab_02
{
    class Student : Person
    {
        int _year, _group, _indexId;
        List<Grade> _grades;

        public int Year{ get { return _year; } set { _year = value; } }
        public int Group { get { return _group; } set { _group = value; } }
        public int indexId { get { return _indexId; } set { _indexId = value; } }

        public Student()
            :base()
        { 
            _year = 0;
            _group = 0;
            _indexId = 0;
            _grades = new List<Grade>();
        }

        public Student (string FirstName, string LastName, DateTime DateOfBirth, int year, int group, int indexId)
            : base(FirstName, LastName, DateOfBirth)
        {
            _year=year;
            _group=group;
            _indexId = indexId;
            _grades = new List<Grade>();
        }

        public override string ToString() //overide bo napisujemy metode klasy pochodnej (polimorfizm)
        {
            string resoults = $"{base.ToString()}, Student | Year: {_year}, Group: {_group}, IndexId: {_indexId}\n";
            
            if (_grades.Count == 0)
            {
                resoults += "Brak ocen \n";
            }
            
            foreach (var grade in _grades)
            {
                resoults += grade.ToString() + "\n";
            }

            return resoults;
        }

        public void AddGrade(string subjectName, double value, DateTime date)
        {
            Grade newGrade = new Grade(subjectName, value, date); //stworzenie obiektu grade
            _grades.Add(newGrade); //dodanie obiektu do listy
        } 

        public void AddGrade(Grade newGrade) 
        {
            _grades.Add(newGrade);
        }

        public void DisplayGrades()
        {

            foreach (var grade in _grades)
            {
               Console.WriteLine(grade.ToString());
            }

        }

        public void DisplayGrades(string SubjectName)
        {
            foreach (var grade in _grades)
            {
                if (grade.SubjectName == SubjectName)
                {
                    Console.WriteLine(grade.ToString());
                }
            }
        }

        public void Details()
        {
            Console.WriteLine(this);
        }

        public void DeleteGrade(string subjectName, double value, DateTime date)
        {
            _grades.RemoveAll(g => g.SubjectName == subjectName && g.Value == value && g.Date == date); //g => lambda
        }

        public void DeleteGrade(Grade grade)
        {
            _grades.Remove(grade);
        }

        public void DeleteGrades(string subjectName)
        {
            _grades.RemoveAll(g => g.SubjectName == subjectName);
        }

        public void DeleteGrades()
        {
            _grades.Clear();
        }

    }
}
