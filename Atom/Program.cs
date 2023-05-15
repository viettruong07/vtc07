using System;
class Atom1
{

    public static void Main()
    {
        const int MAX_ATOMS = 10;

        Atom[] atoms = new Atom[MAX_ATOMS];

        int count = 0;
        while (count < MAX_ATOMS)
        {
            Atom atom = new Atom();
            if (!atom.Accept())
            {
                continue;
            }

            atoms[count] = atom;
            count++;

            Console.WriteLine();
        }

        Console.WriteLine("Thông tin nguyên tử");
        Console.WriteLine("==================");
        Console.WriteLine("Số  Ký hiệu   Tên          Khối lượng");
        Console.WriteLine("--------------------------------------");
        for (int i = 0; i < count; i++)
        {
            atoms[i].Display();
        }
    }
}