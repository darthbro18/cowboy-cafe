using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {
        public bool Sweet { get; set; } = true;

        public bool Lemon { get; set; } = false;

        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        if (Sweet)
                            return 10;
                        else
                            return 5;
                    case Size.Medium:
                        if (Sweet)
                            return 22;
                        else
                            return 11;
                    case Size.Large:
                        if (Sweet)
                            return 36;
                        else
                            return 18;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice)
                    instructions.Add("hold ice");
                if (Lemon)
                    instructions.Add("add lemon");

                return instructions;
            }
        }
    }
}
