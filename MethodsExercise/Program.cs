namespace MethodsExercise
{
    public class Program
    
    {
        static void Main(string[] args)
        {
           Console.WriteLine("What is your name?");
            string? name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string? color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string? animal = Console.ReadLine();
            Console.WriteLine("Who is your favorite band?");
            string? band = Console.ReadLine();
            Console.WriteLine("What is your favorite dessert?");
            string? dessert = Console.ReadLine();
            Console.WriteLine("What is the worst natural disaster?");
            string? disaster = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"One night {name} was on there way to see {band} live on the Sunset Strip.");
            Console.WriteLine($"{name} had to get a rent a car and wanted to make sure it was {color}.");
            Console.WriteLine($"The owner of Hertz had to give {name} the bad news that due to a wild {animal} attack, \n" +
                $"all {color} cars were damaged beyond repair.");
            Console.WriteLine($"{name} was so upset, they decided to go home and write an angry blog about Hertz instead.");
            Console.WriteLine($"While blogging {name} grabbed there favorite snack, {dessert}!");
            Console.WriteLine($"Then {name} dropped there snack and caused a {disaster} bringing all of the {animal}s to there house.");
            Console.WriteLine($"From that day forward, {name} no longer liked {animal}, the color {color} or {band} and hasn't had {dessert} since!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // ----------------exercise 2---------------------

            int answer1 = Method.Add(2, 4);
            Console.WriteLine(answer1);
            int answer2 = Method.Multiply(10, 2);
            Console.WriteLine(answer2);
            int answer3 = Method.Divide(12, 3);
            Console.WriteLine(answer3);
            int answer4 = Method.Subtract(12, 4);
            Console.WriteLine(answer4);
            int answer5 = Method.Remainder(12, 5);
            Console.WriteLine(answer5);

        }
    }
}
