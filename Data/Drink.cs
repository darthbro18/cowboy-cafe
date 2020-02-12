using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Drink
    {
        public abstract double Price { get; }

        public abstract uint Calories { get; }

        public abstract List<string> SpecialInstructions { get; }

        public Size Size { get; set; } = Size.Small;

        public virtual bool Ice { get; set; } = true; //only way I could get Ice to default false in CowboyCoffee was to add virtual
    }
}
