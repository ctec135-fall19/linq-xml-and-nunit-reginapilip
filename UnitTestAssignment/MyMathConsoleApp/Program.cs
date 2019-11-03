using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathConsoleApp
{
    #region assignment specs/info.
    /*
        Author: Regina Pilipchuk
        CTEC135: Programming Assignment 5
        Unit Testing
        ** see pdf for assignment specs
        ** comments are disbursed throughout the program to describe
        ** what is being done
     */
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            // prints and calls add method
            // for test 1: within byte range
            Console.WriteLine("** Testing Add Method and Byte Range **\n");
            Console.WriteLine("55 + 65 = {0}", MyMath1.Add((byte)55, (byte)65));
            Console.WriteLine("156 + 200 = {0}", MyMath1.Add((byte)156, (byte)200));

            Console.WriteLine("\n\n");
            Console.WriteLine("** With checked keyword and try/catch block: **\n");
            try
            {
                Console.WriteLine("55 + 65 = {0}", MyMath2.Add((byte)55, (byte)65));
                Console.WriteLine("156 + 200 = {0}", MyMath2.Add((byte)156, (byte)200));
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Program stopped. Exception Caught:\n\t\t {0}", e.Message);
            }
            Console.WriteLine("\n\n");
        }
    }
}
