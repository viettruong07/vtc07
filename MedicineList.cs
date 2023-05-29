using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Hospital
{
    class MedicineList
    {
        public SortedList objMedicineDetails = new SortedList();
        public void AcceptDetails()
        {
            string name;
            double price;
            char choice = 'Y';
            try
            {
                do
                {
                    Console.Write("Enter the medicine name: ");
                    name = Console.ReadLine();
                    Console.Write("Enter the price: ");
                    price = Convert.ToDouble(Console.ReadLine());
                    objMedicineDetails.Add(name, price);
                    Console.Write("Do you want to add more names? [Y/N] : ");
                    choice = Convert.ToChar(Console.ReadLine());
                } while (choice == 'Y' || choice == 'y');
            }
            catch(Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.Message);
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Details of Medicines: ");
            Console.WriteLine("Medicine Name \t Price");
            for(int i = 0; i < objMedicineDetails.Count; i++)
            {
                Console.WriteLine("{0}\t\t {1:C2}", objMedicineDetails.GetKey(i), objMedicineDetails.GetByIndex(i));
            }
            Console.WriteLine("Total number of medicines : " + objMedicineDetails.Count);
        }

        public bool Modify()
        {
            string name;
            double price;
            Console.Write("Enter the name of the medicine to change its price : ");
            name = Console.ReadLine();
            if (objMedicineDetails.Contains(name))
            {
                Console.Write("Enter new price : ");
                price = Convert.ToDouble(Console.ReadLine());
                int index = objMedicineDetails.IndexOfKey(name);

                objMedicineDetails.SetByIndex(index, price);
                return true;
            }
            else
                return false;
        }

        public bool Remove()
        {
            string choice;
            Console.Write("Enter the name of the medicine : ");
            choice = Console.ReadLine();

            if (objMedicineDetails.Contains(choice))
            {
                objMedicineDetails.Remove(choice);
                return true;
            }
            else
                return false;
        }

        public void Search()
        {
            string choice;
            Console.Write("Enter the name of the medicine : ");
            choice = Console.ReadLine();
            if (choice != "")
            {
                if (objMedicineDetails.ContainsKey(choice))
                {
                    Console.WriteLine("Record Found!");
                    Console.WriteLine("Medicine Name : {0}", choice);

                    Console.WriteLine("Price : {0:C2}", objMedicineDetails[choice]);

                }
                else
                    Console.WriteLine("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}