using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    class people
    {
        private int ID;
        private string Name;
        private string Email;

        public void People()
        {
            Console.Write("Nhập ID: ");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập Tên: ");
            Name = Console.ReadLine();
            Console.Write("Nhập Email: ");
            Email = Console.ReadLine();

        }
        public void showPeople()
        {
            Console.WriteLine("ID : " + ID);
            Console.WriteLine("Tên : " + Name);
            Console.WriteLine("Email: " + Email);
        }
    }


    class staff : people
    {
        private double salary;
        public void Staff()
        {
            Console.Write("Nhập lương: ");
            salary = Convert.ToDouble(Console.ReadLine());
        }
        public void showSalary()
        {
            Console.WriteLine("Mức lương: " + salary);
        }

    }
    class manage : staff
    {
        private int level;
        public void Level()
        {
            Console.Write("Nhap level: ");
            level = Convert.ToInt32(Console.ReadLine());
        }
        public void showLevel()
        {
            Console.WriteLine("Level: " + level);
        }
        static void Main(string[] args)
        {
            manage objManage = new manage();
            objManage.People();
            objManage.Staff();
            objManage.Level();
            objManage.showPeople();
            objManage.showSalary();
            objManage.showLevel();

            Console.ReadLine();

        }

    }

}
