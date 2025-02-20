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

                        Console.Write("Please enter your current earth weight: ");
                    double.TryParse(Console.ReadLine(), out weight);

                    if (weight == 0)
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
            }
        }
    }
}
