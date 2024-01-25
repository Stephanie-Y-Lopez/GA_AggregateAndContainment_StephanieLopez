using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_StephanieLopez
{
    //Step 3
    internal class GoKart
    {
        string _make;
        string _model;
        Engine _engine;
        Character _PlayersCharacter;

        public GoKart(Character PlayersCharacter)
        {
            _PlayersCharacter = PlayersCharacter;
            _engine = new Engine(250 - (_PlayersCharacter.Weight / 4));
        }

        public override string ToString()
        {
            return $"Character {_PlayersCharacter.Name} - Weight: {_PlayersCharacter.Weight} : Engine Hp: {_engine.Hp} ";
        }
    }
}
