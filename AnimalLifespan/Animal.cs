using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLifespan
{
    public abstract class Animal
    {
        private int maxEnergy;
        private int currEnergy;

        protected Animal(int maxEnergy)
        {
            this.maxEnergy = maxEnergy;
            this.currEnergy = maxEnergy;
        }

        public int MaxEnergy { get; private set; }

        public int CurrEnergy
        {
            get
            { 
                return this.currEnergy; 
            }
            protected set 
            { 
                if (value > this.maxEnergy)
                {
                    value = this.maxEnergy;
                }
                else if (value <= 0)
                {
                    value = 0;
                }

                this.currEnergy = value;
            }
        }

        public int DaysSurvived { get; protected set; } = 0;

        public abstract void Feed(Foods food);
    }
}
