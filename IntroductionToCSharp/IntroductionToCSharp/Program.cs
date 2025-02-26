namespace IntroductionToCSharp
{
    //Any code what we write should be in the class
    //Name of the class in Program
    class Program
    {




        //Main() is the main function - Main method is the entry point 

        //Let's add another method with Main1

        static void Main1()
        {
            Console.WriteLine("This is main1 method");
        }

    
        static void Main(string[] args)
        {
            //In this program we are using console class
            //Next we are using WriteLine function to write something in the Console
            //For example  - Welcome to C# Training
            //Namespace - collection on classes, interface, structs, enums and delegates
            Console.WriteLine("Welcome to C# Training");
            Main1();
            Console.ReadLine();
        }
    }
}
