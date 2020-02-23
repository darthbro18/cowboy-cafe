/*
 * Author: Justin Koegeboehn
 * TexasTea.cs
 * Represents ordering a Texas Tea for a drink
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {
        /// <summary>
        /// Says whether tea should be sweet or not
        /// </summary>
        public bool Sweet { get; set; } = true;

        /// <summary>
        /// Says whether a lemon should be included with the tea or not
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Gets the price of Texas Tea given the size
        /// </summary>
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

        /// <summary>
        /// Gets the calories of Texas Tea given the size and whether it's sweet
        /// </summary>
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

        /// <summary>
        /// Gets the special instructions in making the Texas Tea
        /// </summary>
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

        public override string ToString()
        {
            string sweetened;
            if (Sweet)
                sweetened = "Sweet";
            else
                sweetened = "Plain";

            switch (Size)
            {
                case Size.Small:
                    return "Small Texas " + sweetened + " Tea";
                case Size.Medium:
                    return "Medium Texas " + sweetened + " Tea";
                case Size.Large:
                    return "Large Texas " + sweetened + " Tea";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
