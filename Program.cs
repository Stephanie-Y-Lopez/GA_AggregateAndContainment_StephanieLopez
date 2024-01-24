namespace GA_AggregateAndContainment_StephanieLopez
{
    internal class Program
    {
        //Stephanie Lopez
        static List<Engine> engines;
        static void Main(string[] args)
        {
            ComputerExample(); // Display our example

            engines = new List<Engine>();
            Engine FastEngine = new Engine(250);
            Engine SlowEngine = new Engine(120);
            engines.Add(FastEngine);
            engines.Add(SlowEngine);

            Suspension suspension = new Suspension(-.4f, 5, .5f);

            Car car = new Car("Ford", "Escort", engines[0], suspension);
            Console.WriteLine(car.ToString());
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
        }
    }
}