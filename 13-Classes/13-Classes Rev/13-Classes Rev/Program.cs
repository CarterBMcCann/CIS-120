using System.Reflection;

namespace _13_Classes_Rev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book();

            myBook.title = "Moby Dick";
            myBook.author = "Herman Melville";
            myBook.numPages = -800;

            Console.WriteLine(myBook);


            Book myBook2 = new Book("War of the Worlds", "H.G. Wells", 850);

            myBook2.DisplayBookInfo();
        }
    } 
}


