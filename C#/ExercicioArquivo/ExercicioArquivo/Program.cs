using ExercicioArquivo.Entities;
using System;
using System.Globalization;
using System.IO;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\jbray\Documents\Fatima\teste.csv";
            
            try
            {
                string[] lines = File.ReadAllLines(path);
                string folderPath = Path.GetDirectoryName(path);
                string folderPathAnterior = folderPath + @"\out";
                string pathNovo = folderPathAnterior + @"\summary.csv";

                Directory.CreateDirectory(folderPathAnterior);

                using (StreamWriter sw = File.AppendText(pathNovo))
                {
                    foreach (string line in lines)
                    {

                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Produto prod = new Produto(name, price, quantity);

                        sw.WriteLine(prod.Name + "," + prod.ValorTotalProd().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}