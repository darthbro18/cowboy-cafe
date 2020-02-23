/*
 * Author: Justin Koegeboehn
 * RustlersRibs.cs
 * Represents ordering the Rustlers Ribs entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustler's Ribs entree
    /// </summary>
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// The price of the ribs
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// Number of calories in the ribs
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// Any special instructions in making the ribs
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                return instructions;
            }
        }

        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}
