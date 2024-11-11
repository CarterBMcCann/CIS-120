using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _13_Classes_Rev
{
    public class Book
    {
        //Properties
        private string Title;
        private string Author;
        private int NumPages;
       public string title 
       {
            get { return Title; }
            set { Title = value; }
       }
       public string author 
       {
            get { return Author; }
            set { Author = value; }
       }
       public int numPages 
       {
            get { return NumPages; }
            set { NumPages = value < 0 ? 0 : value; }   
       }

        //Constructors
        public Book() 
        {
            
        }
        public Book(string inputTitle, string inputAuthor, int inputNumPages) 
        {
            title = inputTitle;
            author = inputAuthor;
            numPages = inputNumPages;
        }

        //Methods
        public void DisplayBookInfo() 
        {
            Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nPages: {NumPages}");
        }

        //Overrides
        public override string ToString()
        {
            return $"Title: {Title}\nAuthor: {Author}\nPages: {NumPages}";
        }
    }
}
