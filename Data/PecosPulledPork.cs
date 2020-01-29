using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PecosPulledPork
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
        public double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// Number of calories in Pecos Pulled Pork
        /// </summary>
        public uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// Any special instructions in making the Pecos Pulled Pork
        /// </summary>
        public List<string> SpecialInstructions
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
    }
}
