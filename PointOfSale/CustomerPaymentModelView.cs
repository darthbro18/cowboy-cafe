using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;

namespace PointOfSale
{
    public class CustomerPaymentModelView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        CashControl cc = new CashControl();

        public double RunningTotal
        {
            get => cc.RunningTotal;
            set
            {
                if (cc.RunningTotal == value) return;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RunningTotal"));
            }
        }
    }
}
