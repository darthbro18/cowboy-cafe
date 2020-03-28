using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangeTests
{
    public class OrderPropertyChangedTests
    {
        //Test 1: Order should implement the INotifyPropertyChanged interface
        [Fact]
        public void OrderShouldImplementINotifyPropertyChanged()
        {
            var order = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }

        //Test 2: Changing the property "Items" should invoke PropertyChanged for "Subtotal"
        [Fact]
        public void ChangingItemsShouldInvokePropertyChangedForSubtotal()
        {
            var order = new Order();
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Add(new CowpokeChili());
            });
        }

        //Test 3: Changing the property "Items" should invoke PropertyChanged for "Items"
        [Fact]
        public void ChangingItemsShouldInvokePropertyChangedForItems()
        {
            var order = new Order();
            Assert.PropertyChanged(order, "Items", () =>
            {
                order.Add(new CowpokeChili());
            });
        }
    }
}
