using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLifespan
{
    public class Bear : Animal
    {
        private readonly Foods[] diet = { Foods.Carrot, Foods.Meat };
        public Bear(int maxEnergy) : base(maxEnergy)
        {
        }

        public override void Feed(Foods food)
        {
            if (this.CurrEnergy > 0)
            {
                if (diet.Contains(food))
                {
                    this.CurrEnergy++;
                }
                else
                {
                    this.CurrEnergy--;
                }

                this.DaysSurvived++;
            }
        }
    }
}
