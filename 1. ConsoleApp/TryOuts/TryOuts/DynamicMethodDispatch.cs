using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagement
{

    public class Employee
    {
        public double BasicSalary { set; get; }
        public int EmployeeId { set; get; }

        public virtual double GetTotalSalary()
        {
            double hra = .15 * BasicSalary;
            double da = .10 * BasicSalary;
            double totalSalary = da + hra + BasicSalary;
            return totalSalary;
        }
    }
    public class SystemsEngineer : Employee
    {
        public int Incentive { set; get; }

        public override double GetTotalSalary()
        {
            double totalSalary = base.GetTotalSalary() + Incentive;
            return totalSalary;
        }

    }
    public class TechnologyAnalyst : Employee
    {
        public double companyBonus { set; get; }

        public override double GetTotalSalary()
        {
            double totalSalary = base.GetTotalSalary() + companyBonus;
            return totalSalary;
        }
    }
    public class FinanceManagementDesk
    {
        public static void PrintEmployeeDetails(Employee employee)
        {
            // This method can receive object of type employee, SystemsEngineer or TechnologyAnalyst
            Console.WriteLine("Employee Id: " + employee.EmployeeId);
            /* Dynamic method dispatch is a mechanism by which a call to an overridden method is resolved at runtime. 
            Based on the type of the object received the corresponding method is invoked */
            //GetTotalSalary() is called based on the type of employee object  
            double totalSalary = employee.GetTotalSalary() - (0.3 * employee.GetTotalSalary());
            Console.WriteLine("Total Salary of Employee: " + totalSalary);
        }
    }
    public class DynamicMethodDispatch
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.BasicSalary = 10000;
            employee.EmployeeId = 1001;
            FinanceManagementDesk.PrintEmployeeDetails(employee);


            SystemsEngineer systemEngineer = new SystemsEngineer();
            systemEngineer.EmployeeId = 1002;
            systemEngineer.Incentive = 1000;
            systemEngineer.BasicSalary = 10000;
            // Observe the following line invokes the method which invokes GetTotalSalary() of the class systemEngineer
            FinanceManagementDesk.PrintEmployeeDetails(systemEngineer);

            TechnologyAnalyst technicalAnalyst = new TechnologyAnalyst();
            technicalAnalyst.EmployeeId = 1003;
            technicalAnalyst.companyBonus = 2050;
            technicalAnalyst.BasicSalary = 50000;
            // Observe the following line invokes the method which invokes GetTotalSalary() of the class technicalAnalyst 
            FinanceManagementDesk.PrintEmployeeDetails(technicalAnalyst);
        }
    }
}










