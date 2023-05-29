using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Hospital
{
    class DoctorTableTest
    {
        static void Main(string[] args)
        {
            try
            {
                DoctorTable objDoctorsTable = new DoctorTable();
                objDoctorsTable.AcceptDetails();
                objDoctorsTable.DisplayDetails();

                char input = 'Y';
                do
                {
                    int choice;
                    Console.WriteLine("\nSelect one of the following options: ");
                    Console.WriteLine(" 1. Remove\n  2. Remove All\n  3. Add\n  4. Update\n  5. Search\n  6.Exit");
                    Console.Write("Enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            if (objDoctorsTable.Remove())
                            {
                                Console.WriteLine("\n----After Removing----");
                                objDoctorsTable.DisplayDetails();
                            }
                            else
                                Console.WriteLine("Doctor with this name does not exist");
                            break;

                        case 2:
                            objDoctorsTable.objDoctorDetails.Clear();
                            Console.WriteLine("\n----After removing all the doctor----");
                            Console.WriteLine("Total number of doctors: " + objDoctorsTable.objDoctorDetails.Count);
                            return;
                        case 3:
                            objDoctorsTable.Add();
                            Console.WriteLine("\n----After Adding----");
                            objDoctorsTable.DisplayDetails();
                            break;

                        case 4:
                            objDoctorsTable.Update();
                            Console.WriteLine("\n----After Updating----");
                            objDoctorsTable.DisplayDetails();
                            break;

                        case 5:
                            objDoctorsTable.Search();
                            break;
                        case 6:
                            return;
                        default:
                            Console.WriteLine("Invalid Data Entry!");
                            break;
                    }
                } while (input == 'Y' || input == 'y');
            }
            catch(Exception objEx)
            {
                Console.WriteLine("Error: {0}, objEx.Message");
            }
        }
    }
}