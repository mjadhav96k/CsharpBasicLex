using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Purchase
{

    public void PrintPurchaseDetails(string purchaseId, string productName,
            int quantityOrdered, string shippingAddress = "NA")
    {
        Console.WriteLine("Purchase Details are :");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Purchase Id = {0}", purchaseId);
        Console.WriteLine("Product Name = {0}", productName);
        Console.WriteLine("Quantity Ordered = {0}", quantityOrdered);
        Console.WriteLine("Shipping Address = {0}", shippingAddress);
        Console.WriteLine("----------------------------------------------");
    }
}

class MethodParameter
{

    static void Main(string[] args)
    {
        Purchase purchaseOne = new Purchase();

        // Method invocation using positional parameters
        // Values are not passed using their parameter names
        Console.WriteLine("Normal method invocation");
        purchaseOne.PrintPurchaseDetails("100001", "Coke", 20, "3rd cross,M.G road, Bangalore");

        // Positional arguments should be given before named parameters
        // Named parameters - Values are passed using their parameter names
        Console.WriteLine("Method invocation with positional parameters followed by named parameters");
        purchaseOne.PrintPurchaseDetails("100001", "Coke", quantityOrdered: 20, shippingAddress: "3rd cross,M.G road, Bangalore");

        // Uncomment the below line and observe a compilation error -positional arguments cannot be after named parameters
        //purchaseOne.PrintPurchaseDetails( quantityOrdered: 20, shippingAddress: "3rd cross,M.G road, Bangalore", "100001", "Coke");

        // Uncomment the below line and observe positional arguments mixed with named parameters results in a compiler error
        //purchaseOne.PrintPurchaseDetails( "100001",quantityOrdered: 20, shippingAddress: "3rd cross,M.G road, Bangalore",  "Coke");

        // Method invocation using only named parameters 
        Console.WriteLine("Method invocation using named parameters");
        purchaseOne.PrintPurchaseDetails(productName: "Coke", purchaseId: "100001", shippingAddress: "3rd cross,M.G road, Bangalore", quantityOrdered: 20);

        // Method invocation using optional parameters
        // ShippingAddress is omitted in the method invocation
        Console.WriteLine("Method invocation using optional parameters");
        purchaseOne.PrintPurchaseDetails("100001", "iPhone5", 20);
    }
}

