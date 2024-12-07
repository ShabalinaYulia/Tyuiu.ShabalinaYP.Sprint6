using Tyuiu.ShabalinaYP.Sprint6.Task5.V29.Lib;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = @"C:\Users\User\source\repos\Tyuiu.ShabalinaYP.Sprint6\Tyuiu.ShabalinaYP.Sprint6.Task5.V29\InPutDataFileTask5V29.txt";
            Console.WriteLine(ds.LoadFromDataFile(path)[1]);
        }
    }
}
