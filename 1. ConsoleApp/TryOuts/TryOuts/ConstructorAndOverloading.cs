using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infosys.Constructors
{
    //class Products
    //{
    //    public void AddProducts(int qty, int categoryId)
    //    {
    //        Console.WriteLine("Int-Int");
    //    }
    //    public void AddProducts(int qty, double price)
    //    {
    //        Console.WriteLine("Int-Double");
    //    }
    //}
    //class Quiz2
    //{
    //    public static void Main()
    //    {
    //        Products prod1 = new Products();
    //        prod1.AddProducts(10, 20);
    //    }
    //}



    //class Test
    //{
    //    public void One()
    //    {
    //        Console.WriteLine("First Method");
    //    }
    //    public void Two()
    //    {
    //        One();
    //        Console.WriteLine("Second Method");
    //    }
    //    public void Two(int num)
    //    {
    //        Console.WriteLine(num);
    //        Two();
    //    }
    //}
    //class Quiz1
    //{
    //    public static void Main(string[] args)
    //    {
    //        Test obj = new Test();
    //        obj.One();
    //        obj.Two(10);
    //    }
    //}


    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public double Price { get; set; }
        public int QuantityAvailable { get; set; }

        // Constructor One - Explicit default Constructor
        //public Book()
        //{
        //    BookId = 100;
        //    BookName = "No Name";
        //    Price = 59.99;
        //    QuantityAvailable = 10;
        //}


        // Constructor Two – Parameterized Constructor
        //public Book(int bookId, string bookName, double price, int quantityAvailable)
        //{
        //    BookId = bookId;
        //    BookName = bookName;
        //    Price = price;
        //    QuantityAvailable = quantityAvailable;
        //}
    }

    class ConstructorAndOverloading
    {
        static void Main(string[] args)
        {

            /* 1. Execute the application and observe that the all the member variable values
             * are initialized to the default values based on the data types of the variables */
            Console.WriteLine("----- Book One details -----");
            Book bookOne = new Book();
            Console.WriteLine("Book One Book ID is : " + bookOne.BookId);
            Console.WriteLine("Book One Name is : " + bookOne.BookName);
            Console.WriteLine("Book One Price is : " + bookOne.Price);
            Console.WriteLine("Book One Quantity Available is : " + bookOne.QuantityAvailable);
            /* Observe that new Book() is making a call to the system provided default constructor */

            /* Uncomment Constructor One in class Book to initialize the member variables 
             * with the user defined default values and execute the application */
            /* Observe that the system defined default constructor is no longer available 
             * once user defined parameter constructor is implemented */

            /* 2. Uncomment the parameterized constructor */
            /* Uncomment the following code and execute the application */
            //Console.WriteLine("----- Book Two details -----");
            //Book bookTwo = new Book(101, "Alice in wonderland", 250, 100);
            //Console.WriteLine("Book One Book ID is : " + bookTwo.BookId);
            //Console.WriteLine("Book One Name is : " + bookTwo.BookName);
            //Console.WriteLine("Book One Price is : " + bookTwo.Price);
            //Console.WriteLine("Book One Quantity Available is : " + bookTwo.QuantityAvailable);
            /* Observe that the all the member variable values are initialized to the values 
             * passed as parameters to the parameterized constructor. 
             * No default constructors are called */
        }

    }
}





