using System;
class employee1
{
    public static void Main()
    {
        Employee emp = new Employee("VIET", "TRUONG", "37 Nghe An", 0707070707, 7000.0);
        Console.WriteLine(emp);

        double bonus = emp.CalculateBonus(10.0);
        Console.WriteLine($"Bonus: {bonus:C}");
    }

}