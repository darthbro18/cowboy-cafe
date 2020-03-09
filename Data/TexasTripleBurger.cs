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
        private bool ketchup = true;
        /// <summary>
        /// If ketchup is included on burger
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                ketchup = value;
                NotifyPropertyChange("Ketchup");
            }
        }

        private bool mustard = true;
        /// <summary>
        /// If mustard is included on burger
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                mustard = value;
                NotifyPropertyChange("Mustard");
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If pickles are included on burger
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                NotifyPropertyChange("Pickle");
            }
        }

        private bool cheese = true;
        /// <summary>
        /// If cheese is included on burger
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
                NotifyPropertyChange("Cheese");
            }
        }

        private bool bun = true;
        /// <summary>
        /// If bun is included on burger
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set
            {
                bun = value;
                NotifyPropertyChange("Bun");
            }
        }

        private bool tomato = true;
        /// <summary>
        /// If tomato is included on burger
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                tomato = value;
                NotifyPropertyChange("Tomato");
            }
        }

        private bool lettuce = true;
        /// <summary>
        /// If lettuce is included on burger
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                lettuce = value;
                NotifyPropertyChange("Lettuce");
            }
        }

        private bool mayo = true;
        /// <summary>
        /// If mayo is included on burger
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set
            {
                mayo = value;
                NotifyPropertyChange("Mayo");
            }
        }

        private bool bacon = true;
        /// <summary>
        /// If bacon is included on burger
        /// </summary>
        public bool Bacon 
        {
            get { return bacon; }
            set
            {
                bacon = value;
                NotifyPropertyChange("Bacon");
            } 
        }

        private bool egg = true;
        /// <summary>
        /// If egg is included on burger
        /// </summary>
        public bool Egg 
        {
            get { return egg; }
            set
            {
                egg = value;
                NotifyPropertyChange("Egg");
            }
        }

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

        /// <summary>
        /// String that is returned when Texas Triple Burger is added to order list
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Texas Triple Burger";
        }
    }
}
