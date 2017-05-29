using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorize
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello World";
            char s = 's';
            bool b = true;
            byte aByte = 0x78;
            short aShort = 54;
            int  aInt = 540;
            long aLong = 5400;
            float aFloat = 54.0F;
            double aDouble = 54.0D;
            decimal aDecimal = 54.0M;

           
            Console.WriteLine("A String: " + myString);
            Console.WriteLine("What's your name? (Type and press Enter)");
            string str = Console.ReadLine();
            Console.WriteLine("Hello " + str + " ,press the 'Enter' key to see examples of data types declared and written out in C#");
            Console.ReadLine();
            Console.WriteLine("string: " + myString + Environment.NewLine + "char: " + s + Environment.NewLine + "boolean: " + b + Environment.NewLine + "byte: " + aByte + Environment.NewLine + "short: " + aShort + Environment.NewLine + "int: " + aInt + Environment.NewLine + "long: " + aLong + Environment.NewLine + "float: " + aFloat + Environment.NewLine + "double: " + aDouble + Environment.NewLine + "decimal: " + aDecimal + " ");
            Console.ReadLine();

            Console.WriteLine("Lets declare some arrays of data to use in our program:" + Environment.NewLine);
            int[] evenNumbers = {2,4,6,8,10,12,14,16,18,20};
            int[] oddNumbers = {1,3,5,7,9,11,13,15,17,19,21};
            string[] showMonths = {"January","February","March","April","May","June","July","August","September","October","November","December"};
            //Console.WriteLine(evenNumbers.ToString(),oddNumbers.ToString(),showMonths.ToString());
             //Array.;
            Console.ReadLine();
        }
       
    }
}
