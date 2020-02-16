/*
 * Author: Justin Koegeboehn
 * Water.cs
 * Represents ordering water for a drink
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {
        /// <summary>
        /// Says whether a lemon should be included with the water
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Gets the price of water (actually the price of the cup)
        /// </summary>
        public override double Price { get; } = 0.12;

        /// <summary>
        /// Gets the calories of water (obviously 0)
        /// </summary>
        public override uint Calories { get; } = 0;

        /// <summary>
        /// Gets the special instructions in getting the water for the customer
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
    }
}
