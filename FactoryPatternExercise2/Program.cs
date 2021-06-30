using System;

namespace FactoryPatternExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which database would you like to use?");
            Console.WriteLine("Type: sql");
            Console.WriteLine("Type: mongo");
            Console.WriteLine("Type: list");

            var userInput = Console.ReadLine();
           IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);
           var products = db.LoadData();
            db.SaveData();

            foreach(var product in products)
            {
                Console.WriteLine($"Name: {product.Name} Price: {product.Price} ");
            }
        }
    }
}
