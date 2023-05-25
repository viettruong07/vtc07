class DivisionError
{
    static void Main(string[] args)
    {
        int numOne = 133;
        int numTwo = 0;
        int result;
        try
        {
            result = numOne / numTwo;
        }
        catch(DivideByZeroException objDivide)
        {
            Console.WriteLine("Exception caught: " + objDivide);
        }
    }
}