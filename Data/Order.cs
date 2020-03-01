/*
 * Author: Justin Koegeboehn
 * Order.cs
 * Builds an order containing all the items selected, order number, and subtotal
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        //stores the last order number used
        private static uint lastOrderNumber = 0;

        //stores the items for the order
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Constructor to increment the lastOrderNumber every time a new Order is made
        /// </summary>
        public Order()
        {
            lastOrderNumber++;
        }

        /// <summary>
        /// Takes the items from the private list and makes it an IEnumerable property
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();


        /// <summary>
        /// Calculates the subtotal by adding up all the prices of order items in Items
        /// </summary>
        public double Subtotal
        {
            get
            {
                double price = 0;
                foreach(IOrderItem item in Items)
                {
                    price += item.Price;
                }
                return price;
            }
        }

        /// <summary>
        /// A property that returns the order number by adding 1 to the lastOrderNumber
        /// </summary>
        public uint OrderNumber => lastOrderNumber + 1;

        /// <summary>
        /// Event handler for when a property in Order.cs is changed through data binding
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        
        /// <summary>
        /// Function that adds item to the list of order items, then notifies of a property change for Items and Subtotal
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Function that removes item from list of order items, then notifies of a property change for Items and Subtotal
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
