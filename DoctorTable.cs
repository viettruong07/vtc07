using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Hospital
{
    class DoctorTable
    {
        public Hashtable objDoctorDetails = new Hashtable();

        public void AcceptDetails()
        {
            string name;
            string address;
            char choice = 'Y';

            try
            {
                do
                {
                    Console.Write("Enter the doctor's name: ");
                    name = Console.ReadLine();
                    Console.Write("Enter the address: ");
                    address = Console.ReadLine();

                    objDoctorDetails.Add(name, address);
                    Console.Write("Do you want to add more records? [Y/N] : ");
                    choice = Convert.ToChar(Console.ReadLine());
                } while (choice == 'Y' || choice == 'y');
            }
            catch(Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.Message);
            }
        }


        public void Add()
        {
            // Method to add a new doctor's details to the Hashtable
            try
            {
                Console.Write("Enter the doctor's name: ");
                string name = Console.ReadLine();
                Console.Write("Enter the address: ");
                string address = Console.ReadLine();

                objDoctorDetails[name] = address;
                Console.WriteLine("Doctor's details added successfully.");
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error: " + objEx.Message);
            }
        }


        public void Update()
        {
            // Method to update a doctor's details in the Hashtable
            try
            {
                Console.Write("Enter the name of the doctor to update: ");
                string name = Console.ReadLine();

                if (objDoctorDetails.ContainsKey(name))
                {
                    Console.Write("Enter the new address: ");
                    string newAddress = Console.ReadLine();

                    objDoctorDetails[name] = newAddress;
                    Console.WriteLine("Doctor's details updated successfully.");
                }
                else
                {
                    Console.WriteLine("Doctor not found. Update failed.");
                }
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error: " + objEx.Message);
            }
        }


        public void DisplayDetails()
        {
            ICollection objCollection = objDoctorDetails.Keys;

            Console.WriteLine("\nDetails of doctors: ");
            Console.WriteLine("Doctor's Name \t Address");
            Console.WriteLine("------------- \t -------");

            foreach (string details in objCollection)
            {
                Console.WriteLine(details + "\t\t " + objDoctorDetails[details]);
            }
            Console.WriteLine("Total number of doctors : " + objDoctorDetails.Count);
        }

        public bool Remove()
        {
            string choice;
            Console.Write("Enter the name of the doctor: ");
            choice = Console.ReadLine();

            if (objDoctorDetails.ContainsKey(choice))
            {
                objDoctorDetails.Remove(choice);
                return true;
            }
            else
                return false;
        }

        public void Search()
        {
            string choice;
            Console.Write("Enter the name of the doctor: ");
            choice = Console.ReadLine();
            if (choice != "")
            {
                if (objDoctorDetails.ContainsKey(choice))
                {
                    Console.WriteLine("Record Found!");
                    Console.WriteLine("Doctor's Name : {0}", choice);
                    Console.WriteLine("Address : {0}", objDoctorDetails[choice]);
                }
                else
                    Console.WriteLine("Record Nor Found!");
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}