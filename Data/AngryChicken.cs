/*
 * Author: Justin Koegeboehn
 * AngryChicken.cs
 * Represents ordering the Angry Chicken entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Angry Chicken entree
    /// </summary>
    public class AngryChicken : Entree
    {
        /// <summary>
        /// If bread is included with the chicken sandwich
        /// </summary>
        public bool Bread { get; set; } = true;

        /// <summary>
        /// If pickles are included with the chicken sandwich
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// The price of Angry Chicken
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// Number of calories in Angry Chicken
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// Any special instructions in making the Angry Chicken
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Bread)
                    instructions.Add("hold bread");
                if (!Pickle)
                    instructions.Add("hold pickle");

                return instructions;
            }
        }

        /// <summary>
        /// String that is returned when Angry Chicken is added to order list
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
