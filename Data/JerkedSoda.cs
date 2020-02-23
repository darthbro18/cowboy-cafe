/*
 * Author: Justin Koegeboehn
 * JerkedSoda.cs
 * Represents ordering a Jerked Soda for a drink
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// Stores what flavor of soda was ordered
        /// </summary>
        public SodaFlavor Flavor { get; set; }

        /// <summary>
        /// Gets the price of a jerked soda given the size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the calories of a jerked soda given the size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the special instructions in making the jerked soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice)
                    instructions.Add("Hold Ice");

                return instructions;
            }
        }

        public override string ToString()
        {
            string flavor;
            switch (Flavor)
            {
                case SodaFlavor.CreamSoda:
                    flavor = "Cream Soda";
                    break;
                case SodaFlavor.OrangeSoda:
                    flavor = "Orange Soda";
                    break;
                case SodaFlavor.Sarsparilla:
                    flavor = Flavor.ToString();
                    break;
                case SodaFlavor.BirchBeer:
                    flavor = "Birch Beer";
                    break;
                case SodaFlavor.RootBeer:
                    flavor = "Root Beer";
                    break;
                default:
                    throw new NotImplementedException();
            }
            switch (Size)
            {
                case Size.Small:
                    return "Small " + flavor + " Jerked Soda";
                case Size.Medium:
                    return "Medium " + flavor + " Jerked Soda";
                case Size.Large:
                    return "Large " + flavor + " Jerked Soda";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
