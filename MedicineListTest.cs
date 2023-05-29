using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Hospital
{
    class MedicineListTest
    {
        static void Main(string[] args)
        {
            try
            {
                MedicineList objMedicines = new MedicineList();
                objMedicines.AcceptDetails();
                objMedicines.DisplayDetails();

                char input = 'Y';
                do
                {
                    int choice;
                    Console.WriteLine("\nSelect one of the following options : ");
                    Console.WriteLine(" 1. Modify\n 2. Remove\n 3. Remove All\n 4. Search\n 5. Exit");
                    Console.Write("Enter your choice : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            if (objMedicines.Modify())
                            {
                                Console.WriteLine("\n-----After Modifying-----");
                                objMedicines.DisplayDetails();
                            }
                            else
                                Console.WriteLine("Medicine with this name does not exist");
                            break;
                        case 2:
                            if (objMedicines.Remove())
                            {
                                Console.WriteLine("\n----After Removing----");
                                objMedicines.DisplayDetails();
                            }
                            else
                                Console.WriteLine("Medice with this name does nots exist");
                            break;
                        case 3:
                            objMedicines.objMedicineDetails.Clear();
                            Console.WriteLine("\n----Afetr removing all the medicines----");
                            Console.WriteLine("Total number or medicines : ");
                            return;
                        case 4:
                            objMedicines.Search();
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("Invalid Data Entry");
                            break;
                    }
                } while (input == 'Y' || input == 'y');
            }
            catch(Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.Message);
            }
        }
    }
}