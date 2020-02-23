/*
 * Author: Justin Koegeboehn
 * ChiliCheeseFries.cs
 * Represents ordering a side of Chili Cheese Fries
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class ChiliCheeseFries : Side
    {

        /// <summary>
        /// Returns the price of Chili Cheese Fries given the size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Returns the calories of Chili Cheese Fries given the size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 433;
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// String that is returned when Chili Cheese Fries is added to order list
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Chili Cheese Fries";
                case Size.Medium:
                    return "Medium Chili Cheese Fries";
                case Size.Large:
                    return "Large Chili Cheese Fries";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
