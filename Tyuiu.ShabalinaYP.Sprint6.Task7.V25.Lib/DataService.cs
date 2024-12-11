namespace Tyuiu.ShabalinaYP.Sprint6.Task7.V25.Lib
{
    public class DataService
    {
        public int[,] GetMatrix(string path)
        {
            int[,] matrix;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                { 
                    
                }
            }
        }
    }
}
