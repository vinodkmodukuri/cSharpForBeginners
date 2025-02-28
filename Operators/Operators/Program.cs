namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's learn about C# Operators ");
            //Assignment Operator = 
            //Arithmetic Operators like +, -, *, / , %

            int a, b;
            Console.WriteLine("Enter the a value");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The a value is {0}", a);

            Console.WriteLine("Enter the b value");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The b value is {0}", b);

            //Addition
            int c = a + b;
            Console.WriteLine("The sum of a and b is {0}", c);

            //Subtraction
            int d = a - b;
            Console.WriteLine("The difference between a and b is {0}", d);

            //Multiplication
            int e = a * b;
            Console.WriteLine("The product of a and b is {0}", e);

            //Division
            int f = a / b;
            Console.WriteLine("The division of a and b is {0}", f);

            //Reminder 
            int g = a % b;
            Console.WriteLine("The reminder of a and b is {0}", g);


            /*
             Comparision Operators 
             == Double Equal to is used to comparision but = is for assignment 
             != Not equal to 
             > Greater than
             >= Greater than and equal to
             < Less than and equal to 
             */

            if (a == 10)
            {
                Console.WriteLine("The value is 10");
            }
            else if (a < 10)
            {
                Console.WriteLine("The a value is below 10");
            }
            else
            {
                Console.WriteLine("The value is above 10");
            }

            if (b!=30 )
            {
                Console.WriteLine("The b value is not equal to 30");
            }
            else if (b<=30)
            {
                Console.WriteLine("The b value is 30 or below 30");
            }
            else
            {
                Console.WriteLine("The b value is above 30");
            }

            /* Conditional Operations
             * && - AND 
             * || - OR 
             */

            if (a == b && b == a)

            { 
              Console.WriteLine("The a value and b value are same");
            }

            else
            {
                Console.WriteLine("The values of a and b are not same");
            }

            if (a==b || b==c)
            {
                Console.WriteLine("Either a and b values are same or b and c values are same");
            }

            else
            {
                Console.Write(" a and b values are not same and also b and c values are not same \n");
            }

            //Ternary Operator ?:  
            int number2 = 15;
            bool isNumber3 = number2 == 15 ? true : false;
            Console.WriteLine("isNumber is == number3? {0}", isNumber3);


        }
    }
}


