using System;
class ExceptionMethods
{
    static void Main(string[] args)
    {
        byte numOne = 200;
        byte numTwo = 5;
        byte result = 0;
        try
        {
            result = checked((byte)(numOne * numTwo));
            Console.WriteLine("Result={0}", result);
        }
        catch(Exception objEx)
        {
            Console.WriteLine("Error Description : {0}", objEx.ToString());
            Console.WriteLine("Exception: {0}", objEx.GetType());
        }
    }
}