using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Hospital
{
    class PatientList
    {
        public ArrayList objPatientNames = new ArrayList();

        public void AcceptDetails()
        {
            char choice = 'Y';
            try
            {
                do
                {
                    Console.Write("Enter patient's name: ");
                    objPatientNames.Add(Console.ReadLine());
                    Console.Write("Do you want to add more names? [Y/N]: ");
                    choice = Convert.ToChar(Console.ReadLine());
                } while (choice == 'Y' || choice == 'y');
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error: {0}", objEx.Message);
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\nList of patients : ");
            for(int i = 0; i < objPatientNames.Count; i++)
            {
                Console.WriteLine(objPatientNames[i]);
            }
            Console.WriteLine("Total number of patients : " + objPatientNames.Count);
        }

        public bool Remove()
        {
            string choice;
            Console.Write("Enter the name of the patient : ");
            choice = Console.ReadLine();
            if (objPatientNames.Contains(choice))
            {
                objPatientNames.Remove(choice);
                return true;
            }
            else
                return false;
        }

        public void Search()
        {
            string choice;
            Console.Write("Enter the name of the patient: ");
            choice = Console.ReadLine();
            if (choice != "")
            {
                if (objPatientNames.Contains(choice))
                {
                    Console.WriteLine("Record Found!");
                    Console.WriteLine(objPatientNames[objPatientNames.IndexOf(choice)]);
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