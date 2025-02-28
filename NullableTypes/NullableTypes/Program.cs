using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Types in C#
            //There are two broad categories 
            //Value type - int, float, double, struct, enums etc 
            //Reference Type - string, interface, cLass, delegate, arrays

            //default value for value type non nullable - To make nullable use?
            //default value for reference type is null 

            string name = null;

            //int i = null;  - The compiler cannot assign null to a value type
            //null can only be assigned to a reference type or to a nullable value type. struct is a value type.


            /*
             * 
             * How can we store null value in value type?
             * In C# - Values type divided into two types 
             * Non-nullable value types 
             * Nullable value types
             * As we know, by default value types are non nullable. To make them nullable use ?
             */


            int? i = null;

            //So we wanted to change the default value types from non nullale to nullable?
            //Let's imagine there is a form whic has the following fields 
            //FirstName, LastName, Are You Major 
            //In the form, first and last name is required, but the are you a major is optional - Either yes or no
            //The user will not fill the data and leve the field blank 
            //bool areYouMajor = null - will get an error

            bool? areYouMajor = null;

            if (areYouMajor == true)
            {
                Console.WriteLine("User is Major");
            }
            else if (areYouMajor == false)
            {
                Console.WriteLine("Usee is not major");
            }
            else
            {
                Console.WriteLine("User major is null");
            }


            //Null Coalescing Operator

            int? TicketsOnSale = null;

            int AvailableTickets;

            if (TicketsOnSale == null)
            {
                AvailableTickets = 0;
            }
            else
            {
                AvailableTickets = (int)TicketsOnSale;
            }

            Console.WriteLine("Available tickers are {0} ", AvailableTickets);

            /*
             * /You cannot implicitly convert a double to an integer.
                double d = 3.2;

                // The following line causes compiler error CS0266.
                int i1 = d;

                // However, you can resolve the error by using an explicit conversion.
                int i2 = (int)d;  
             */
            Console.ReadLine();

        }
    }
}
