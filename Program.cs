using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Consoleexe3

{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Convert string to integer using TryParse
            string intStr = "Reshma";
            int convertedInt;
            if (int.TryParse(intStr, out convertedInt))
            {
                Console.WriteLine("Converted integer: " + convertedInt);
            }
            else
            {
                Console.WriteLine("Error!!!----Pls give correct one.");
            }

            // Convert string to double using Convert
            string doubleStr = "14.54";
            try
            {
                double convertedDouble = Convert.ToDouble(doubleStr);
                Console.WriteLine("Converted double: " + convertedDouble);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error!!!----Pls give correct one.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Double value is too large or too small");
            }

            // Convert string to decimal using Parse
            string decimalStr = "1.34";
            try
            {
                decimal convertedDecimal = decimal.Parse(decimalStr);
                Console.WriteLine("Converted decimal: " + convertedDecimal);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error!!!-----Pls give correct one.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Decimal value is too large or too small");
                         
            }
        }
    }
}
