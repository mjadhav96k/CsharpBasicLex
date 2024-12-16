using System;

abstract class StudentDetails
{
    protected int rollNo;
    public abstract int RollNo
    {
        get;
        set;
    }

}
class Student : StudentDetails
{
    //Overriding the abstract property
    public override int RollNo
    {
        get { return rollNo; }
        set { rollNo = value; }
    }

}

class AbstractClass
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.RollNo = 1001;
        Console.WriteLine(student.RollNo);
        //Change the access specifier of abstract RollNo from public to protected and observe.
        //The access specifier of the abstract member and the overriden member must be same.
    }
}
