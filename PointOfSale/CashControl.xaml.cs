using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CashRegister;
using CowboyCafe.Extensions;
using System.ComponentModel;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashControl.xaml
    /// </summary>
    public partial class CashControl : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        public CashControl()
        {
            InitializeComponent();
        }

        private double runningTotal = 0.00;
        public double RunningTotal 
        { 
            get { return runningTotal; }
            set
            {
                runningTotal = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RunningTotal"));
            }
        }
       
    }
}
