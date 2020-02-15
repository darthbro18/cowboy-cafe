using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {
        public bool Lemon { get; set; } = false;

        public override double Price { get; } = 0.12;

        public override uint Calories { get; } = 0;

        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice)
                    instructions.Add("Hold Ice");
                if (Lemon)
                    instructions.Add("Add Lemon");

                return instructions;
            }
        }
    }
}
