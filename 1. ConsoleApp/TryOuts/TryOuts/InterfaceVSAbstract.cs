using System;

//Implementation using Interfaces
interface ISquare
{
    void AreaSquare(int side);
}
interface ICircle
{
    void AreaCircle(double radius);
}

class CalculateAreaInterface : ISquare, ICircle
{
    public void AreaSquare(int side)
    {
        Console.WriteLine("Area of Square is " + side * side);
    }

    public void AreaCircle(double radius)
    {
        Console.WriteLine("Area of Circle is " + 3.14 * radius * radius);
    }
}


//Implementation using Abstract classes
abstract class Square
{
    public abstract void AreaSquare(int side);
}
abstract class Circle
{
    public abstract void AreaCircle(double radius);
}


//Uncomment the below class and observe
//class CalculateAreaClass : Square, Circle
//{
//    public void AreaSquare(int side)
//    {
//        Console.WriteLine("Area of Square is " + side * side);
//    }

//    public void AreaCircle(double radius)
//    {
//        Console.WriteLine("Area of Circle is " + 3.14 * radius * radius);
//    }
//}

//class CalculateAreaClass tries to inherit two abstract classes which is not possible in C#
class InterfaceVSAbstract
{
    static void Main(string[] args)
    {
        CalculateAreaInterface area = new CalculateAreaInterface();
        area.AreaSquare(5);
        area.AreaCircle(5.9);


        //Uncomment the below code to observe the implementation using Abstract classes
        //CalculateAreaClass areaClass = new CalculateAreaClass();
        //areaClass.AreaSquare(5);
        //areaClass.AreaCircle(5.9);

        /*Interfaces are useful if we want to include behaviour from multuiple classes.
        This feature is not possible if we use abstract classes. 
        Also, interfaces are used to enforce rules to be implemented by child classes.*/
    }
}
