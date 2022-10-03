using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    public class AddressBook
    {
        private static string path = @"C:\Users\Administrator\Desktop\Day27\FileIO\FileIO.txt";
        public static void ReadFromStreamReader()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s = " ";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void WriteUsingStreamReader()
        {
            
            using (StreamWriter sr = File.AppendText(path))
            {
                Console.WriteLine();
                sr.WriteLine(" Firstname = Suresh, Lastname = Gaikwad, Contact number = 844614462, ZipCode = 411025 ");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
}
