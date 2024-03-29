﻿namespace GA_AggregateAndContainment_StephanieLopez
{
    internal class Program
    {
        //Stephanie Lopez
        static List<Engine> engines;
        static void Main(string[] args)
        {
            ComputerExample();

            engines = new List<Engine>();
            Engine FastEngine = new Engine(250);
            Engine SlowEngine = new Engine(120);
            engines.Add(FastEngine);
            engines.Add(SlowEngine);

            Suspension suspension = new Suspension(-.4f, 5, .5f);

            Car car = new Car("Ford", "Escort", engines[0], suspension);
            Console.WriteLine(car.ToString());
            Console.WriteLine("");

            Character donkeyKong = new Character("Donkey Kong", 150);
            GoKart goKart = new GoKart(donkeyKong);

            Console.WriteLine(goKart);

            Character toad = new Character("Toad", 50);
            GoKart goKartToad = new GoKart(toad);
            Console.WriteLine(goKartToad);
            Console.WriteLine("");

            //Part4
            Console.WriteLine("Before our try catch");
            goKartToad.TweakEngine(-50);
            try
            {
                Console.WriteLine("We reached this line of code");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("This is after our try catch");
            Engine e = new Engine(100);
            Console.WriteLine(e.Hp);
            ChangeEngineHP(e);
            Console.WriteLine(e.Hp);
        }

        public static void ChangeEngineHP(Engine e)
        {
            e.Hp = 1000;
        }

        public static void ComputerExample()
        {
            // Creates a GraphicsCard object with brand Intel
            GraphicsCard gc = new GraphicsCard(GraphicsCard.Brand.Intel);

            // Creates a Computer object and initialize it with the GraphicsCard
            Computer comp = new Computer(gc);

            // Display information about the GraphicsCard from the Computer
            Console.WriteLine("Computer Information:");
            Console.WriteLine("Graphics Card Brand: ");
            Console.WriteLine("");
        }
    }
}