/*
 * Author: Justin Koegeboehn
 * CowboyCoffee.cs
 * Represents ordering a Cowboy Coffee for a drink
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// Says whether the coffee should have room for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Says whether the coffee should be decaf or not
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Determines wheter the coffee should be iced or not
        /// </summary>
        public override bool Ice { get; set; } = false;

        /// <summary>
        /// Gets the price of the coffee given the size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the calories of the coffee given the size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the special instructions in making the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Ice)
                    instructions.Add("Add Ice");
                if (RoomForCream)
                    instructions.Add("Room for Cream");

                return instructions;
            }
        }

        /// <summary>
        /// String that is returned when Cowboy Coffee is added to order list
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    if (Decaf)
                        return "Small Decaf Cowboy Coffee";
                    else
                        return "Small Cowboy Coffee";
                case Size.Medium:
                    if (Decaf)
                        return "Medium Decaf Cowboy Coffee";
                    else
                        return "Medium Cowboy Coffee";
                case Size.Large:
                    if (Decaf)
                        return "Large Decaf Cowboy Coffee";
                    else
                        return "Large Cowboy Coffee";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
