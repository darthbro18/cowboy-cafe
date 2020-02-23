/*
 * Author: Justin Koegeboehn
 * PecosPulledPork.cs
 * Represents ordering the Pecos Pulled Pork entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PecosPulledPork : Entree
    {
        /// <summary>
        /// If bread is included with the pulled pork
        /// </summary>
        public bool Bread { get; set; } = true;

        /// <summary>
        /// If pickles are included with the pulled pork
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// The price of Pecos Pulled Pork
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// Number of calories in Pecos Pulled Pork
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// Any special instructions in making the Pecos Pulled Pork
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
        /// String that is returned when Pecos Pulled Pork is added to order list
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
    }
}
