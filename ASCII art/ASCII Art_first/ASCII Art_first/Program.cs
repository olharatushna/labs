using System;

namespace ASCII 
{
    class Program 
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how many dogs you need: ");
            int dogQ = Console.Read();
            Console.WriteLine("Please enter dog eye shape: ");
            var UserInput = Console.ReadKey().KeyChar;
            var dogEye = UserInput;
            Console.WriteLine("");
            Console.WriteLine(@"Please enter dog nose shape: ");
            var UserInput2 = Console.ReadKey().KeyChar;
            var dogNose = UserInput2;
            string padding = ("\t\t\t\t\t\t\t");
            var lines = 4;
            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine("");
            }
            for (int y = 0; y < dogQ; y++) { 
            Console.WriteLine(@$"{padding}  /^ ^\");
            Console.WriteLine(@$"{padding} / {dogEye} {dogEye} \");
            Console.WriteLine(@$"{padding}V \ {dogNose} / V");
            Console.WriteLine(@$"{padding}  / - \");
            Console.WriteLine(@$"{padding} /    |");
            Console.WriteLine(@$"{padding}V__) ||)");
            Console.WriteLine();
            Console.ReadLine();
            }
          
        }
    
    }

}
    


