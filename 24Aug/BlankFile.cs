using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class CreateFile
    {
        public static void FirstFile()
        {
            string path = @"C:\Users\Raajesh M P\source\repos\Aug24Handson\BlankFile.txt";
            File.Create(path);
        }
    }
}