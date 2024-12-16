using System;

class Parent
{
    public void Display()
    {
        Console.WriteLine("Parent method");
    }
}
class Child : Parent
{
    public void Display()
    {
        Console.WriteLine("Child method");
    }
}
class MethodOverriding
{
    static void Main(string[] args)
    {
        Parent parentOne = new Parent();
        Child child = new Child();
        Parent parentTwo = new Child();
        parentOne.Display();
        child.Display();
        parentTwo.Display();
        /*For parentTwo, the Display() method of parent class is called even though the object is of child class.
          Since the reference is of parent class it cannot access any members of the child class and therefore the Display() method of parent class is called.*/
        /*A warning says that the child's method hides the parent's method

        //Add keyword virtual to parent class method and keyword override to child class method and execute the the code. 
        /*In this case, the child class method is called even though the reference is of parent class.
        Here, we have used the override keyword, therefore the child class's Display() method is invoked whenever there is an object of child class*/

        //Replace the override keyword with new keyword and execute the code.
        /*In this case, again the parent class method is called. Here, the new keyword does not override the parent's method but just hides it.
         The warning that we had in the first case is now gone since we have used the new keyword*/
    }
}