
using System.Linq.Expressions;

namespace lab_03
{
    class Catalog: IItemManagement
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; } 
        
        public Catalog(IList<Item> items) 
        {
            Items = items ?? new List<Item>();
            ThematicDepartment = string.Empty;
        }
        public Catalog(string thematicDepartment, IList<Item> items ) : this(items)
        {
            ThematicDepartment = thematicDepartment;
        }
        public void AddItem(Item item) 
        {
            Items.Add(item);
        }
        public override string ToString()
        {
            string itemList = Items.Count > 0 ? string.Join("\n ", Items) : "No items in catalog";
            return $"Catalog | ThematicDepaetment: {ThematicDepartment}\nItems:\n{itemList} ";
        }
        public void ShowAllItems()
        {
            Console.WriteLine(this);
        }

        public Item FindItemBy(int id)
        {
            return Items.FirstOrDefault(item => item.Id == id);
        }
        public Item FindItemBy(string title)
        {
            return Items.FirstOrDefault(item => item.Title == title);

        }
        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {
            return Items.AsQueryable().FirstOrDefault(predicate);
        }
    }
}
