using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_StephanieLopez
{
    //Step 1
    internal class Computer
    {
        // computer components:
        // cpu
        // motherboard
        // ram
        // power supply
        // fan
        // hard drive
        // graphics card

        string _cpu;
        string _mother;
        GraphicsCard _graphicsCard;

        public Computer(GraphicsCard graphicsCard)
        {
            _graphicsCard = graphicsCard;
        }
    }
}

