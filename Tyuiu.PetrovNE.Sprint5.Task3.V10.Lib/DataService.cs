using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PetrovNE.Sprint5.Task3.V10.Lib
{
    public class DataService : ISprint5Task3V10
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";
            double z = Math.Pow(-x, 3) + 4 * x * x - (3 / 2) * x;

            z = Math.Round(z, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(z));
            }
            return path;
        }
    }
}
