namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets's learn Data Types");
            //Boolean Data Types - Only True or False 
            //We use keyword b

            bool b = true;            
            Console.WriteLine(b);

            //Integral Datatypes - sbyte, byte, short, ushort, int, uint, long, ulong
            //Sbyte 

            sbyte i = 0;
            Console.WriteLine("Minimum value for the sbyte is {0} ", sbyte.MinValue);
            Console.WriteLine("Maximum value for the sbyte is {0} ", sbyte.MaxValue);

            byte h = 0;
            Console.WriteLine("Minimum value for the byte is {0} ", byte.MinValue);
            Console.WriteLine("Maximum value for the byte is {0} ", byte.MaxValue);

            short j = 0;
            Console.WriteLine("Minimum value for the short is {0} ", short.MinValue);
            Console.WriteLine("Maximum value for the short is {0} ", short.MaxValue);

            int l = 0;
            Console.WriteLine("Minimum value for the int is {0} ", int.MinValue);
            Console.WriteLine("Maximum value for the int is {0} ", int.MaxValue);

            uint m = 0;
            Console.WriteLine("Minimum value for the uint is {0} ", uint.MinValue);
            Console.WriteLine("Maximum value for the uint is {0} ", uint.MaxValue);


            long n = 0;
            Console.WriteLine("Minimum value for the long is {0} ", long.MinValue);
            Console.WriteLine("Maximum value for the long is {0} ", long.MaxValue);


            ulong o = 0;
            Console.WriteLine("Minimum value for the ulong is {0} ", ulong.MinValue);
            Console.WriteLine("Maximum value for the ulong is {0} ", ulong.MaxValue);

            //Floating-Point Types - Depends on the requirement for precision we use the following
            //Float, Double, and Decimal

            float f = 1.2144444442424f;
            Console.WriteLine(f);

            double d = 2.3424252525;
            Console.WriteLine(d);

            decimal s = 23424.2424223242424m;
            Console.WriteLine(s);


            //String Data Type
            //In CSharp the strings are enclosed in double quotes " "

            string name = "This is a string";
            Console.WriteLine("Here we are printing the string: {0} ", name);

            //If we want to print double code we need to use escape sequence = /
            string lastname = "\"This is a string\"";
            Console.WriteLine("Here we are printing the string: {0} ", lastname);

            string number = "\n " +
                "one \n two \n three";
            Console.WriteLine("Printers the numbers line by line {0}", number);

            //Let's look at another example when we are using a path

            string path1 = "c:\\programsdotnet\\training\\da1";
            Console.WriteLine(path1);

            //Instead of using \\ everytime we can use @ symbole to include all the characters in the double quotes , this is called Verbatim Literal

            string path2 = @"c:\programsdotnet\training\da1";
            Console.WriteLine(path2);



        }
    }
}

