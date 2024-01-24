using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_StephanieLopez
{
    internal class Suspension
    {
        public float _FrontBalance { get; set; }
        public float _RearBalance { get; set; }
        public float _Springiness { get; set; }

        public Suspension(float FrontBalance, float RearBalance, float Springiness)
        {
            _FrontBalance = FrontBalance;
            _RearBalance = RearBalance;
            _Springiness = Springiness;
        }

        public float FrontBalance 
        {
            get => _FrontBalance;
            set
            {
                if(value >= -1 && value <= 1)
                {
                    _FrontBalance = value;
                }
            }
        }

        public float Springiness { get => _Springiness; set => _Springiness = value; }
        public float RearBalance { get => _RearBalance; set => _RearBalance = value; }
    }
}
