using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        uint lastOrderItem;

        List<IOrderItem> items;
        
        public IEnumerable<IOrderItem> Items => throw new NotImplementedException();

        public double Subtotal => 0;

        uint OrderNumber => 0;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            //include something about Subtotal. Maybe in new method?
        }
        
        public void Add(IOrderItem item)
        {

        }

        public void Remove(IOrderItem item)
        {

        }
    }
}
