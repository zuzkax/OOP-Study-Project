//using System.Collections.Generic;
using lab_03;

Item item1 = new Journal("JAISCR", 1, "Springer", new DateTime(2000, 1, 1), 1);
Console.WriteLine("STWORZENIE item1");
Author author = new Author("Robert", "Cook", "Polish");
Console.WriteLine("STWORZENIE AUTORA author");
Item item2 = new Book("Agile C#", 2, "SPRINGER", new DateTime(2015, 1, 1), 500,
new List<Author>() { author });
Console.WriteLine("STWORZENIE item2");

((Book)item2).AddAuthor(author);//dodanie autora do ksiazki item2
var bookBarCode = ((Book)item2).GenerateBarCode();//generiowanie kodow kreskowych
var journalBarCode = ((Journal)item1).GenerateBarCode();

//wyswietlanie kodow kreskowych
Console.WriteLine("========= KODY KRESKOWE =========");
Console.WriteLine($"{item1} \r\n Barcode {journalBarCode}");
Console.WriteLine($"{item2} \r\n  Barcode {bookBarCode}");
Console.WriteLine("STWORZENIE LISTY ITEMOW");
IList<Item> items = new List<Item>();
items.Add(item1);
items.Add(item2);
Console.WriteLine("STWORZENIE KARALOGU");
Catalog catalog = new Catalog("IT C# development", items);
Console.WriteLine("DODANIE ITEMU DO KATALOGU");
catalog.AddItem(new Journal("Neurocomputing", 1, "IEEE", new DateTime(2020, 1, 1), 1));
Console.WriteLine("======== WYSWIETLENIE KATALOGU ========");
Console.WriteLine(catalog);
Console.WriteLine("======== ShowAllItems() ========");
catalog.ShowAllItems();
Console.WriteLine("=================== KOD TESTUJACY 2 ===================\n");
string searchedValue = "Agile C#";
Item foundedItemById = catalog.FindItem(item => item.Id == 1);
Item foundedItemByTitle = catalog.FindItem(item => item.Title == searchedValue);
Item foundedItemByDateRange = catalog.FindItem(item => item.DateOfIssue >= new DateTime(2014, 12, 31) &&
                                                       item.DateOfIssue <= new DateTime(2015, 12, 31));
Console.WriteLine("Wypisywanie znalezionych Itemow:\n");
Console.WriteLine(foundedItemById);
Console.WriteLine(foundedItemByTitle);
Console.WriteLine(foundedItemByDateRange);

Item foundedItemByIdOld = catalog.FindItemBy(1);
Item foundedItemByTitleOld = catalog.FindItemBy(searchedValue);
Console.WriteLine("Found old way");
Console.WriteLine(foundedItemByIdOld);
Console.WriteLine(foundedItemByTitleOld);

Console.WriteLine("\nWypisywanie bibliotekarzy\n");
Person librarian = new Librarian("John", "Kowalsky", DateTime.Now.Date, 2000);
Library library = new Library("Czestochowa, Armii Krajowej 36", new List<Librarian>(), new List<Catalog>());
library.AddLibrarian((Librarian)librarian);
library.ShowAllLibrarians();

Catalog catalog2 = new Catalog("Novels", new List<Item>());
library.AddCatalog(catalog2);
library.AddCatalog(catalog);
Item newItem = new Book("Song of Ice and Fire", 4, "Publisher", new DateTime(2011, 1, 1), 800,new List<Author>() { author });
library.AddItem(newItem, "Novels");
Console.WriteLine("library");
Console.WriteLine(library); //lab_03.Library ?
Console.WriteLine("===========================All Items=======================\r\n");
library.ShowAllItems();
Console.WriteLine("===========================FIND BY=======================\r\n");
var foundedById = library.FindItemBy(4);
var foundedByTitle = library.FindItemBy(searchedValue);
var foundedByLambda = library.FindItem(x => x.Publisher == "Springer");
Console.WriteLine(foundedById);
Console.WriteLine(foundedByTitle);
Console.WriteLine(foundedByLambda);