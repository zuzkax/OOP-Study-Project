using System.Linq.Expressions;
namespace lab_03
{
    class Library : IItemManagement
    {
        public string Address { get; set; }
        public IList<Librarian> Librarians {  get; set; }
        public IList<Catalog> Catalogs { get; set; }
        public Library(string address, IList<Librarian> librarians, IList<Catalog> catologs) 
        {
            Address = address;
            Librarians = librarians;    
            Catalogs = catologs;
        }
        public void AddLibrarian(Librarian librarian)
        {
            Librarians.Add(librarian);
        }
        public void ShowAllLibrarians()
        {
            Console.WriteLine("Librarians list\n");
            foreach(Librarian librarian in Librarians)
            {
                Console.WriteLine(librarian.ToString());
            }
        }
        public void AddCatalog(Catalog catalog)
        {
            Catalogs.Add(catalog);
        }
        public void AddItem(Item item, string thematicDepartment)
        {
            Catalog catalog; //stworzenie obiektu katalogu ktory przechowuje referencje do pasujacego katalogu
            catalog = Catalogs.FirstOrDefault(c => c.ThematicDepartment == thematicDepartment);
            if (catalog == null) //jezeli nie znaleziono pasujacego katalogu dodaj nowy do listy
            {
                catalog = new Catalog(thematicDepartment, new List<Item>());
                Catalogs.Add(catalog);
            }
            catalog.AddItem(item);
        }

        public void ShowAllItems()
        {
            foreach (Catalog catalog in Catalogs)
            {
                catalog.ShowAllItems();
            }
        }
        public Item FindItemBy(int id)
        {
            return Catalogs.SelectMany(c => c.Items).FirstOrDefault(item => item.Id == id);
        }
        public Item FindItemBy(string title)
        {
            return Catalogs.SelectMany(c => c.Items).FirstOrDefault(item => item.Title == title);
        }
        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {
            return Catalogs.SelectMany(c => c.Items).AsQueryable().FirstOrDefault(predicate);
        }
    }
}
