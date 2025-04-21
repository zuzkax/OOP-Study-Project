namespace lab_03
{
    class Book : Item
    {

        int PageCount { get; set; }
        IList<Author> Authors { get; set; }
        
        public Book(string title, int id,  string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors)
        {
            Id = id; 
            Title = title; 
            Publisher = publisher; 
            DateOfIssue = dateOfIssue; 
            PageCount = pageCount; 
            Authors = authors;
        }
        public override string GenerateBarCode()
        {
            string output = "Barcode....";
            return output;
        }

        public void AddAuthor(Author author) 
        {
            Authors.Add(author);
        }

        public override string ToString()
        {
            string output = $"Book | {base.ToString()}, PageCount: {PageCount}";
            foreach (Author author in Authors) 
            { 
                if (Authors.Count == 0)
                {
                    output += "Brak autora";
                }
                output += author.ToString();
            }
            return output;
        }
    }
}
