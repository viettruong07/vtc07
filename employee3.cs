using System;
class Employee
{
    private string empName;
    private int empID;
    public Employee()
    {
        empName = "David";
        empID = 101;
    }
    static void Main(string[] args)
    {
        Employee objEmployee = new Employee();
        Employee objEmp = objEmployee;
        objEmployee = null;
        try
        {
            Console.WriteLine("Employee Name: " + objEmployee.empName);
            Console.WriteLine("Employee ID: " + objEmployee.empID);
        }
        catch(NullReferenceException objNull)
        {
            Console.WriteLine("Error: " + objNull);
        }
        catch(Exception objEx)
        {
            Console.WriteLine("Error: " + objEx);
        }
    }
}