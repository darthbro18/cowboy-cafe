﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangeTests
{
    public class ChiliCheeseFriesPropertyChangedTests
    {
        //Test 1: Chili Cheese Fries should implement the INotifyPropertyChanged interface
        [Fact]
        public void ChiliCheeseFriesShouldImplementINotifyPropertyChanged()
        {
            var fries = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(fries);
        }

        //Test 2: Changing the "Size" property should invoke PropertyChanged for "Size"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Size", () =>
            {
                fries.Size = Size.Medium;
            });
        }

        //Test 3: Changing the "Size" property should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Price", () =>
            {
                fries.Size = Size.Medium;
            });
        }

        //Test 4: Changing the "Size" property should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Calories", () =>
            {
                fries.Size = Size.Medium;
            });
        }
    }
}
