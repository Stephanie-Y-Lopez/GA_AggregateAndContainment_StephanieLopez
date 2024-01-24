using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_StephanieLopez
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        Suspension suspension;

        public Car(string make, string model, Engine engine, Suspension suspension = null)
        {
            Make = make;
            Model = model;
            Engine = engine;
            this.suspension = suspension;
        }

        public override string ToString()
        {
            return $"{Make} {Model}, HP: {Engine.Hp} :\n" + $"Suspension: Front Balance {suspension.FrontBalance}\n" + $"Rear Balance: {suspension.RearBalance}\n" + $"Springyness: {suspension.Springiness}";
        }

    }
}

