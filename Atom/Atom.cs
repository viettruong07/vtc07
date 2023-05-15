using System;

public class Atom
{
    private int atomicNumber;
    private string symbol;
    private string name;
    private double weight;

    public bool Accept()
    {
        Console.Write("Nhập số nguyên tử: ");
        if (!int.TryParse(Console.ReadLine(), out atomicNumber))
        {
            Console.WriteLine("Đầu vào không hợp lệ. Vui lòng nhập một số nguyên cho số nguyên tử.");
            return false;
        }

        Console.Write("Nhập ký hiệu: ");
        symbol = Console.ReadLine();

        Console.Write("Nhập tên đầy đủ: ");
        name = Console.ReadLine();

        Console.Write("Nhập khối lượng nguyên tử: ");
        if (!double.TryParse(Console.ReadLine(), out weight))
        {
            Console.WriteLine("Đầu vào không hợp lệ. Vui lòng nhập một số thực cho khối lượng nguyên tử.");
            return false;
        }

        return true;
    }

    public void Display()
    {
        Console.WriteLine($"{atomicNumber,-3} {symbol,-2} {name,-10} {weight,-10:F3}");
    }
}