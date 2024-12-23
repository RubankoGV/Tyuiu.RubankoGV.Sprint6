using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RubankoGV.Sprint6.Task5.V10.Test
{
    public class DataService : ISprint6Task5V10
    {
        public int len = 25;
        public double[] LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            double[] numsArray = lines.Select(line => Convert.ToDouble(line)).ToArray();
            numsArray = numsArray.Where(val => val != 0).ToArray();
            return numsArray;
        }
    }
}