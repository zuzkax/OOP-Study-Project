namespace lab_03
{
    public abstract class Item
    {
        protected int _Id;
        protected string _title, _publisher;
        protected DateTime _dateOfIssue;

        public int Id { get { return _Id; } set { _Id = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Publisher { get { return _publisher; } set { _publisher = value; } }
        public DateTime DateOfIssue {  get { return _dateOfIssue; } set { _dateOfIssue = value; }}
        
        public Item()
        {
            _Id = 0;
            _title = string.Empty;
            _publisher = string.Empty;
            _dateOfIssue = DateTime.MinValue;
        }
        public Item(string title, int id,  string publisher, DateTime dateOfIssue)
        {
            Id = id;
            Title = title;
            Publisher = publisher;
            DateOfIssue = dateOfIssue;
        }
        public override string ToString()
        {
            return $"Item | Id: {_Id}, Title: {_title}, Publisher: {_publisher}, DateOfIssue: {_dateOfIssue}";
        }
        public void Details()
        {
            Console.WriteLine(this);
        }
        public abstract string GenerateBarCode();


    }   
}
