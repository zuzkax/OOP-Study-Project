namespace lab_03
{
    class Author : Person
    {
        public string Nacionality { get; set; }

        public Author() :base()
        {
            Nacionality = string.Empty;
        }
        public Author(string firstName, string lastName, string nacionality): base(firstName, lastName) 
        {
            Nacionality = nacionality;
        }
        public override string ToString()
        {
            return $"Author | {base.ToString()}, Nacionality: {Nacionality}";
        }
    }
}
