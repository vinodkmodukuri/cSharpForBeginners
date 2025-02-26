namespace ReadFromConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter your first name");

            //Read the nextline of characters from the input stream - Console
            string firstName= Console.ReadLine();

            //Now write the firstname in the console
            //Create a placeholder by using {0}
            Console.WriteLine("The entered firstname is {0}", firstName);

            //We can use + for concatination as well 
            Console.WriteLine("The entered firstname is " + firstName);

            //NOTE: C# is case sensitive 

            //What if we have two values to read from 

            Console.WriteLine("Enter your last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("The entered lastname is {0}", lastName);

            //How to print both first name and last name 
            Console.WriteLine ("The full name is {0} {1}", firstName, lastName);

        }
    }
}
