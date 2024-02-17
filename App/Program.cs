using DAL;
using Repository;

GenericUnitOfWork unitOfWork = new GenericUnitOfWork(new ApplicationDbContext());
IGenericRepository<Sage> repositorySage = unitOfWork.Repository<Sage>();
IGenericRepository<Book> repositoryBook = unitOfWork.Repository<Book>();


/*Sage sage = repositorySage.FindAll(s => s.Name == "TV").First();

Book book1 = new Book { Title = "Book6" };
Book book2 = new Book { Title = "Book7" };
Book book3 = new Book { Title = "Book8" };

repositoryBook.Add(book1);
repositoryBook.Add(book2);
repositoryBook.Add(book3);

sage.Books.Add(book1);
book2.Sages.Add(sage);
sage.Books.Add(book3);*/



/*foreach (Sage sage1 in repositorySage.GetAll())
{
    Console.Write(sage1.Name + ": ");
    foreach (Book book in sage1.Books)
    {
        Console.Write(book.Title + " ");
    }
}*/

repositorySage.Add(new Sage { Name = "sageToRename" });
repositorySage.Add(new Sage { Name = "sageToDelete" });

Sage sage = repositorySage.FindById(1);
sage.Name = "SageRenamed";
repositorySage.Update(sage);

Sage sage2 = repositorySage.FindAll(c => c.Name == "sageToDelete").FirstOrDefault();
repositorySage.Remove(sage2);

repositorySage.GetAll().ToList();
foreach (var category in repositorySage.GetAll())
{
    Console.WriteLine(category.Name);
}

