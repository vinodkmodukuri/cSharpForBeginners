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

        }
    }
}
