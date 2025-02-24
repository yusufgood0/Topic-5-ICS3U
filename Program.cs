using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace topic_5
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int run;


            while (true) 
            {
                Console.WriteLine(@"what part would you like to run?
    for part 1 enter '1'
    for part 2 enter '2'
    for part 3 enter '3'
    ");
                int.TryParse(Console.ReadLine(), out run);

                if (run == 1)
                {
                    //part 1
                    double weight;
                    string[] planet_names = { "Venus", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
                    double[] planet_gravity = { 0.78, 0.39, 2.65, 1.17, 1.05, 1.23 };
                    int visiting;

                        Console.Write("Please enter your current earth weight value: ");
                    double.TryParse(Console.ReadLine(), out weight);

                    if (weight <= 0)
                    {
                        Console.WriteLine("invalid weight");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("I have information for the following planets:");
                        for (int i = 0; i < planet_names.Length; i = i + 1)
                        {
                            Console.WriteLine($"{i+1}. {planet_names[i]}");
                        }
                        Console.WriteLine();
                        Console.Write("Which planet are you visiting? ");
                        int.TryParse(Console.ReadLine(), out visiting);
                        Console.WriteLine();
                        Console.Write($"Your weight would be {weight * planet_gravity[visiting-1]} pounds on that planet.");
                    }
                }
                else if (run == 2)
                {
                    //part 2
                    int secret_number = 7;

                    Console.Write("guess a number from 1-10: ");

                    if (Console.ReadLine() == Convert.ToString(secret_number)) 
                    { 
                        Console.WriteLine($"wow, you got it right! the number was {secret_number}"); 
                    }
                    else 
                    { 
                        Console.WriteLine($"WRONG! it was {secret_number}"); 
                    }

                }
                else if (run == 3)
                {
                    //part 3
                    int score = 0;
                    int question_1_number_1 = 2;
                    int question_1_number_2 = 4;
                    int TF_input;

                    Console.WriteLine("this is a 4 question quiz");

                    //question 1
                    Console.WriteLine($"what is {question_1_number_1} + {question_1_number_2}?");
                    if (Console.ReadLine() == Convert.ToString(question_1_number_1 + question_1_number_2))
                    {
                        Console.WriteLine("CORRECT!");
                        score += 1;

                    }
                    else
                    {
                        Console.WriteLine("INCORRECT!");
                    }
                    Console.WriteLine();

                    //question 2
                    Console.WriteLine("what is the capital of Ontario?");
                    if (Console.ReadLine().ToUpper() == "TORONTO")
                    {
                        Console.WriteLine("CORRECT!");
                        score += 1;
                    }
                    else
                    {
                        Console.WriteLine("INCORRECT!");
                        Console.WriteLine("It almost ryhmes with it, its TORONTO!");
                    }

                    Console.WriteLine(@"Who is Spiderman:
A. Peter Parker
B. Superman
C. Kent Clark
D. Batman

");
                    if (Console.ReadLine().ToUpper() == "A")
                    {
                        Console.WriteLine("CORRECT!");
                        score += 1;
                    }
                    else
                    {
                        Console.WriteLine("INCORRECT!");
                        Console.WriteLine("Maybe rewatch Spiderman. The original.");
                    }
                    
                    Console.WriteLine();
                    Console.WriteLine("waffles are healthy, 'true' or 'false'");
                    TF_input = Console.ReadLine().ToUpper()
                        
                    if (TF_input == "TRUE")
                    {
                        Console.WriteLine("CORRECT!");
                        score += 1;
                    }
                    if (TF_input == "FALSE")
                    {
                        Console.WriteLine("INCORRECT!");
                    }

                }
                Console.WriteLine();
                Console.Write("press enter to continue");
                Console.ReadLine();
                Console.Clear();

            }
        }
    }
}
