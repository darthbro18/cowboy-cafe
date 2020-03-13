/*
 * Author: Justin Koegeboehn
 * JerkedSoda.cs
 * Represents ordering a Jerked Soda for a drink
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        private SodaFlavor flavor;
        /// <summary>
        /// Stores what flavor of soda was ordered
        /// </summary>
        public SodaFlavor Flavor 
        {
            get { return flavor; }
            set
            {
                flavor = value;
                NotifyPropertyChange("Flavor");
            }
        }

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

        /// <summary>
        /// String that is returned when Jerked Soda is added to order list
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string f;
            switch (Flavor)
            {
                case SodaFlavor.CreamSoda:
                    f = "Cream Soda";
                    break;
                case SodaFlavor.OrangeSoda:
                    f = "Orange Soda";
                    break;
                case SodaFlavor.Sarsparilla:
                    f = Flavor.ToString();
                    break;
                case SodaFlavor.BirchBeer:
                    f = "Birch Beer";
                    break;
                case SodaFlavor.RootBeer:
                    f = "Root Beer";
                    break;
                default:
                    throw new NotImplementedException();
            }
            switch (Size)
            {
                case Size.Small:
                    return "Small " + f + " Jerked Soda";
                case Size.Medium:
                    return "Medium " + f + " Jerked Soda";
                case Size.Large:
                    return "Large " + f + " Jerked Soda";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
