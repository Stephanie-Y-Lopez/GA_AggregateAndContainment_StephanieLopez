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

        //Part4
        internal Engine Engine 
        { 
            get => _engine;
        }

        public void TweakEngine(int newHp)
        {
            _engine.Hp = newHp;
        }

        public void SwapEngine(Engine newEngine)
        {
            _engine = newEngine;
        }

        public void SwapEngine(int hp)
        {
            _engine = new Engine(hp);
        }

        //Part3
        public override string ToString()
        {
            return $"Character {_PlayersCharacter.Name} - Weight: {_PlayersCharacter.Weight} : Engine Hp: {Engine.Hp} ";
        }
    }
}
