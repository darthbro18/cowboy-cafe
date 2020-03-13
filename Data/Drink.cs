/*
 * Author: Justin Koegeboehn
 * Drink.cs
 * A base class that encompasses all the drinks you can order
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        /// <summary>
        /// Abstract class to get the price of a drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Abstract class to get the calories of a drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Abstract class to get a list of special instructions in making the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        private Size size = Size.Small;

        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        protected bool ice = true;
        /// <summary>
        /// Contains whether a drink should have ice or not
        /// </summary>
        public virtual bool Ice 
        {
            get { return ice; }
            set
            {
                ice = value;
                NotifyPropertyChange("Ice");
            } 
        } //only way I could get Ice to default false in CowboyCoffee was to add virtual

        protected void NotifyPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}
