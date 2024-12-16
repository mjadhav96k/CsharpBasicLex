using System;

class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }

    /* 1. Change the access specifier of EmpId to private.
     * The code in the Main() now gives a compilation error.
     * By default the accessors (get and set) have the same 
     * visibility of the property.*/

    // 2. Uncomment the below line and comment the previous declaration of EmpId property.
    //public int EmpId { private get; set; }
    /* Access specifier of the accessors (get and set) can be modified.
     * A compilation error would be thrown in Main() while accessing the get */

    // 3. Uncomment the below line and comment the previous declaration of EmpId property.
    //public int EmpId { private get; private set; }
    /* The code gives a compilation error. 
     * The modifier is permitted on only one of the two accessors (get and set). */

    // 4. Uncomment the below line and comment the previous declaration of EmpId property.
    //public int EmpId { private get;}
    /* The code gives a compilation error. 
     * Accessor modifiers can only be used if the property 
     * has both set and get accessors. */

}

class Properties
{
    static void Main(string[] args)
    {
        Employee obj = new Employee();
        obj.EmpId = 1001;
        obj.EmpName = "Harry";
        Console.WriteLine(obj.EmpId + " " + obj.EmpName);

    }
}
