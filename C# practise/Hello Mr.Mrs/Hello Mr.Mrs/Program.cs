using System;
namespace Hello { 
    class Program
    {
    static void Main (string[] args)
    { Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter your sex: type m for man, w for women ");
        var sex = Console.ReadLine();
        Console.WriteLine("How old are you? ");
        var age = Convert.ToInt32(Console.ReadLine());
        if (sex == "m")
        {
            Console.WriteLine("Hello, Mr. " + name);
        }
        else if (sex == "w"); {
            if (age<40)
            {
                Console.WriteLine("Hello, Mrs. " + name);
            }
            else if (age>40) {
                Console.WriteLine("Hello, Miss " + name);
            }
        }
    
    
    }  

    }
}