using System;
class Students
{
    string[] names = { "James", "John", "Alexander" };
    static void Main(string[] args)
    {
        Students objStudents = new Students();
        try
        {
            objStudents.names[4] = "Michael";
        }
        catch(Exception objException)
        {
            Console.WriteLine("Error: " + objException);
        }
    }
}