using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class ChiliCheeseFries : Side
    {
        public override Size Size
        {
            get { return Size.Small; }
        }

        public override double Price
        {
            get { return 1.99; }
        } 

        public override uint Calories
        {
            get { return 433; }
        }
    }
}
