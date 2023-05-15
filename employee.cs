using System;

public class Employee
{
    private string firstName;
    private string lastName;
    private string address;
    private long sin;
    private double salary;

    public Employee(string firstName, string lastName, string address, long sin, double salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.address = address;
        this.sin = sin;
        this.salary = salary;
    }

    public override string ToString()
    {
        return $"Name: {firstName} {lastName}\nAddress: {address}\nSIN: {sin}\nSalary: {salary:C}";
    }

    public double CalculateBonus(double percentage)
    {
        return salary * percentage / 100.0;
    }
}
