using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharp_Completo.Library.Cap.Arquivo
{
    class Aquivo
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\amandasilva\Desktop";
            string path2 = @"C:\Users\amandasilva\Desktop";


            try
            {
                string[] lines = File.ReadAllLines(path);
                using (StreamWriter streamWriter = File.AppendText(path2))
                {
                    foreach (string line in lines)
                    {
                        streamWriter.WriteLine($"Name: {line[0]}, Total:$ {line[1] * line[2]}");
                    }
                }
            }
            catch (IOException e)
            {
                System.Console.WriteLine("ERROR OCCURED");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
