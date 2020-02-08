/*
 * Author: Justin Koegeboehn
 * Trailburger.cs
 * Represents ordering the Trailburger entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Trailburger entree
    /// </summary>
    public class TrailBurger : Entree
    {
        /// <summary>
        /// If ketchup is included on burger
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// If mustard is included on burger
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// If pickles are included on burger
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// If cheese is included on burger
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// If bun is included on burger
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// The price of the Trailburger
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }

        /// <summary>
        /// Number of calories in the Trailburger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
            }
        }

        /// <summary>
        /// Any special instructions in making the Trailburger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ketchup)
                    instructions.Add("hold ketchup");
                if (!Mustard)
                    instructions.Add("hold mustard");
                if (!Pickle)
                    instructions.Add("hold pickle");
                if (!Cheese)
                    instructions.Add("hold cheese");
                if (!Bun)
                    instructions.Add("hold bun");

                return instructions;
            }
        }
    }
}
