using System;
class Artist
{
    protected string name;
    protected int age;

}
class Singer : Artist
{
    public void SingerDetails()
    {
        // 1.1 Uncomment the following lines of code and execute the program.
        //Artist aObj = new Artist();
        //aObj.name = "Madhur";
        /* The statement aObj.name="Madhur" generates an error because a protected member
         * of a base class is accessible in a derived class only if the access occurs
         * through the derived class type. */


        // 1.2 Uncomment the following lines of code and execute the program.
        //this.name = "Surili";
        //this.age = 23;
        //Console.WriteLine("Singer Details:");
        //Console.WriteLine("Name = {0}, Age = {1}", name, age);

        /* Protected members can be directly accessed through the derived class type. */
    }
}

class Program
{
    static void Main(string[] args)
    {
        Singer s = new Singer();
        s.SingerDetails();

        // 1.3 Uncomment the following line of code and execute the program.
        //s.name="Geet";
        /* Protected members are accessible within its class and in derived classes. */
    }
}


