using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class DakotaDoubleBurger
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
        /// The price of the Dakota Double Burger
        /// </summary>
        public double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// Number of calories in the Dakota Double Burger
        /// </summary>
        public uint Calories
        {
            get
            {
                return 464;
            }
        }

        /// <summary>
        /// Any special instructions in making the burger
        /// </summary>
        public List<string> SpecialInstructions
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

                return instructions;
            }
        }
    }
}
