using System;

#region CASE 1
class Product
{
    public int ProdId { get; set; }
    public int Price { get; set; }

}

class Mobile : Product
{
    public string Brand { get; set; }

    public Mobile(string brand)
    {
        this.Brand = brand;
    }
}
#endregion


//#region CASE 2  
//class Product
//{
//    public int ProdId { get; set; }
//    public int Price { get; set; }

//    public Product(int prodId,int price)
//    {
//        ProdId = prodId;
//        Price = price;
//    }
//} 

//class Mobile :Product
//{
//    public string Brand { get; set; }

//    public Mobile(string brand)  // Gives an error as the parent constructor is not invoked.
//    {                            // 3. Modify the code and invoke the parent class constructor using base                   
//        Brand = brand;
//    }
//}
//#endregion


class ConstructorsAndInheritance
{
    static void Main(string[] args)
    {
        /* 1. Follow the classes present in region CASE 1. 
         * Execute the application */
        Mobile mob = new Mobile("Apple");
        /* If only the child class has a constructor then the parent class properties 
         * are instantiated automatically by the default constructor.*/

        /* 2. Comment region CASE 1
         * Uncomment and follow the classes present in region CASE 2
         * Uncomment the following statement and execute the application */
        //Mobile mob = new Mobile("Apple", 1001, 50000);
        /* If both the classes have constructors then the parent class constructor 
         * must be invoked using base keyword */

        Console.WriteLine(mob.ProdId);
        Console.WriteLine(mob.Price);
        Console.WriteLine(mob.Brand);
    }
}