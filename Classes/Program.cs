namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car()
            {
                Make = "Tesla",

                Model = "S Plaid",

                Year = 2023

            };

            Console.WriteLine($"My car is a {myCar.Year} {myCar.Make} {myCar.Model}");

        }
    }
}
