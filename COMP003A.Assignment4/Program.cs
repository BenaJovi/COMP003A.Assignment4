// Author: Jovani Benavides 
// Course: COMP-003A
// Purpose: This program will go through different types of loops that will out put 
// a rigth triagnle, the list of friends, numbers 1-50 by 5's, and numbers divisible by
// 2, 5, and both. 
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

            Console.Write("Please Enter a Positive Whole Number:");     // Line 20-34
            string Num = Console.ReadLine();                            // includes a for-loop that will take a positive number entered by the user
            int limit = Convert.ToInt32(Num);                           // and will generate a right triangle pattern with the number entered 
            int i;                                                      // being the amount of rows the triangle will have.
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
            Console.WriteLine("Output all of the friends in the array.");
            Console.WriteLine("".PadRight(50, '*'));

            string[] simpleArray = new string[]                        // lines 41-49
            {                                                          // Will output the names entered in the array and out put them in a list format. 
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

            int counter = 0;                                           // lines 57-64   
                                                                       // includes a do-while loop that will count by 5's up to 50 and out put the values. 
            do      
            {
                Console.WriteLine($"Counter: {counter}");
                counter +=5; 
            }
            while (counter <= 50);
            
            Console.WriteLine("\n"); 
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("while Section");
            Console.WriteLine("Output 1-20");
            Console.WriteLine("If number is divisible by 2. output Foo");
            Console.WriteLine("If number is divisible by 5, output Bar");
            Console.WriteLine("If number is divisible by 2 & 5, output FooBar.");
            Console.WriteLine("".PadRight(50, '*'));


              
            for (int counter2 = 1; counter2 <= 20; counter2++)          // lines 77-98
            {                                                           // while loop that will out put a list 1-20 and will state wether a number is divisble by 2
                if ((counter2 % 5 == 0) && (counter2 % 2 == 0))         // or 5 and if a number is divisble by both 2 and 5. They will be replaces with the phrase
                {                                                       // Foo if the number is divisble by 2. Bar if it is divisible by 5. FooBar if it is divisible by both.
                    
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