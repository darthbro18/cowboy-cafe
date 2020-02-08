/*
 * Author: Justin Koegeboehn
 * TexasTripleBurger.cs
 * Represents ordering the Texas Triple Burger entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTripleBurger : Entree
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
        /// If tomato is included on burger
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// If lettuce is included on burger
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// If mayo is included on burger
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// If bacon is included on burger
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// If egg is included on burger
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// The price of the Texas Triple Burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.45;
            }
        }

        /// <summary>
        /// Number of calories in the Texas Triple Burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 698;
            }
        }

        /// <summary>
        /// Any special instructions in making the burger
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
                if (!Tomato)
                    instructions.Add("hold tomato");
                if (!Lettuce)
                    instructions.Add("hold lettuce");
                if (!Mayo)
                    instructions.Add("hold mayo");
                if (!Bacon)
                    instructions.Add("hold bacon");
                if (!Egg)
                    instructions.Add("hold egg");

                return instructions;
            }
        }
    }
}
