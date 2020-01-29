﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TrailBurger
    {
        public bool Ketchup { get; set; } = true;

        public bool Mustard { get; set; } = true;

        public bool Pickle { get; set; } = true;

        public bool Cheese { get; set; } = true;

        public bool Bun { get; set; } = true;

        public double Price
        {
            get
            {
                return 4.50;
            }
        }

        public uint Calories
        {
            get
            {
                return 288;
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

                return instructions;
            }
        }
    }
}