namespace lab_03
{
    class Librarian: Person
    {
        public DateTime HireDate { get; set; }
        public decimal Salary {  get; set; }
        public Librarian():base()
        {
            HireDate = DateTime.Now;    
            Salary = 0;
        }
        public Librarian(string FirstName, string LastName, DateTime HireDate, decimal Salary)
        :base(FirstName,LastName)
        {
            HireDate = HireDate;
            Salary = Salary;
        }
        public override string ToString()
        {
            return $"Librarian |{base.ToString()}, HireDate: {HireDate}, Salary: {Salary}";
        }


    }
}
