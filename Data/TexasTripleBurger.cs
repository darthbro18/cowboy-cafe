﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTripleBurger
    {
        public bool Ketchup { get; set; } = true;

        public bool Mustard { get; set; } = true;

        public bool Pickle { get; set; } = true;

        public bool Cheese { get; set; } = true;

        public bool Bun { get; set; } = true;

        public bool Tomato { get; set; } = true;

        public bool Lettuce { get; set; } = true;

        public bool Mayo { get; set; } = true;

        public bool Bacon { get; set; } = true;

        public bool Egg { get; set; } = true;

        public double Price
        {
            get
            {
                return 6.45;
            }
        }

        public uint Calories
        {
            get
            {
                return 698;
            }
        }

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
                if (!Bacon)
                    instructions.Add("hold bacon");
                if (!Egg)
                    instructions.Add("hold egg");

                return instructions;
            }
        }
    }
}
