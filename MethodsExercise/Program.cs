namespace MethodsExercise
{
    public class Program
    
    {
        static void Main(string[] args)
        {
           Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("Who is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"One night {name} was on there way to see {band} live on the Sunset Strip.");
            Console.WriteLine($"{name} had to get a rent a car and wanted to make sure it was {color}.");
            Console.WriteLine($"The owner of Hertz had to give {name} the bad news that due to a wild {animal} attack, \n" +
                $"all {color} cars were damaged beyond repair.");
            Console.WriteLine($"{name} was so upset, they decided to go home and write an angry blog about Hertz instead.");
            Console.WriteLine();
            Console.WriteLine();
            int answer1 = Method.Add(2, 4);
            Console.WriteLine(answer1);
            Console.WriteLine();
            int answer2 = Method.Multiply(10, 2);
            Console.WriteLine(answer2);

        }
    }
}
