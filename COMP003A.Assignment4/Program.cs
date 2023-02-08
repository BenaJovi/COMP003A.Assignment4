// Author: Jovani Benavides 
// Course: COMP-003A
// Purpose: 


using System.Diagnostics.Metrics;

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("for-loop Section");
            Console.WriteLine("Output a Right Triangle Based On User Input.");
            Console.WriteLine("".PadRight(50, '*'));

            Console.Write("Please Enter a Positive Whole Number:");
            string Num = Console.ReadLine();
            int limit = Convert.ToInt32(Num);
            int i;
            int j;
            Console.WriteLine(" ");

            for( i=1; i <= limit; i++)
            {
                for( j=1; j<=i; j++)
                    {
                        Console.Write("#");
                    }
                Console.WriteLine(" ");
            }

            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("For Each Section");
            Console.WriteLine("Output all of the friends it the array.");
            Console.WriteLine("".PadRight(50, '*'));

            string[] simpleArray = new string[] 
            { 
                "Rachel", "Chandler", "Monica",
                "Ross", "Phobee", "Joey"
            };
            foreach (var Friend in simpleArray)
            {
                Console.WriteLine($"Friends Name: {Friend}");
            }
             
            Console.WriteLine("\n");
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("do-while Section");
            Console.WriteLine("Output 0-50 by 5's");
            Console.WriteLine("".PadRight(50, '*'));

            int counter = 0; 

            do
            {
                Console.WriteLine($"Counter: {counter}");
                counter +=5; 
            }
            while (counter < 50);
            
            Console.WriteLine("\n"); 
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("while Section");
            Console.WriteLine("Output 1-20");
            Console.WriteLine("If number is divisible by 2. output Foo");
            Console.WriteLine("If number is divisible by 5, output Bar");
            Console.WriteLine("If number is divisible by 2 & 5, output FooBar.");
            Console.WriteLine("".PadRight(50, '*'));



            for (int counter2 = 1; counter2 <= 20; counter2++)
            {
                if ((counter2 % 5 == 0) && (counter2 % 2 == 0))
                {
                    
                    Console.WriteLine($"FooBar");
                }
                else if (counter2 % 5 == 0)
                {
                   
                    Console.WriteLine($"Bar");
                }
                else if (counter2 % 2 == 0)
                {
                    
                    Console.WriteLine($"Foo");
                }
                else
                {
                    
                    Console.WriteLine($"{counter2}");
                }

                
            }
         
        }
        
    }
}