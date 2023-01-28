using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLifespan
{
    public class Fox : Animal
    {
        private readonly Foods[] diet = { Foods.Meat };
        public Fox(int maxEnergy) : base(maxEnergy)
        {
        }
        public override void Feed(Foods food)
        {
            if (this.CurrEnergy > 0)
            {
                if (this.diet.Contains(food))
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
