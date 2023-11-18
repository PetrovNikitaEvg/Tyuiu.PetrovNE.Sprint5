using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PetrovNE.Sprint5.Task0.V6.Lib
{
    public class DataService : ISprint5Task0V6
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutputFileTask0.txt";
            double y = Math.Round((x) / (Math.Sqrt(x * x + x)), 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
