using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        private static uint lastOrderNumber = 0;

        private List<IOrderItem> items = new List<IOrderItem>();

        public IEnumerable<IOrderItem> Items => items.ToArray();


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

        public uint OrderNumber => lastOrderNumber + 1;

        public event PropertyChangedEventHandler PropertyChanged;
        
        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
