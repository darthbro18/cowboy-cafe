/*
 * Author: Justin Koegeboehn
 * Entree.cs
 * A base class that encompasses all the entrees you can order
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Entree
    {
        /// <summary>
        /// Abstract class to get the price of an entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Abstract class to get the calories of an entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Abstract class to get a list of special instructions in making the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
