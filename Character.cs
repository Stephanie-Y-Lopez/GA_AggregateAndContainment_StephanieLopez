﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_StephanieLopez
{
    internal class Character
    {
        string _name;
        int _weight;

        public Character(string name, int weight)
        {
            _weight = weight;
            _name = name;
        }
        public int Weight { get => _weight; set => _weight = value; }
        public string Name { get => _name; set => _name = value; }
    }
}
