namespace ConsoleApp
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new DataReader();
            try
            {
                reader.ImportAndPrintData("data.csv");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
        }
    }
}
