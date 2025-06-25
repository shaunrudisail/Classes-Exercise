namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var newCar = new Car()
            {
                Make = "Honda",
                Model = "Civic",
                Year = 1993
            };

            Console.WriteLine("This was my first car's year, make, and model:");
            Console.WriteLine(newCar.Year);
            Console.WriteLine(newCar.Make);
            Console.WriteLine(newCar.Model);
        }
    }
}