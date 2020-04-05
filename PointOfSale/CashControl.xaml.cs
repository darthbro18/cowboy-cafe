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
        
        void OnButtonPress(object sender, RoutedEventArgs e)
        {
            if (sender is Button b)
            {
                if (b.Tag.ToString() == "Increase")
                {
                    BillControl billControl = b.FindAncestor<BillControl>();
                    if (billControl != null)
                    {
                        switch (billControl.Denomination)
                        {
                            case Bills.One:
                                RunningTotal += 1.00;
                                break;
                            case Bills.Two:
                                RunningTotal += 2.00;
                                break;
                            case Bills.Five:
                                RunningTotal += 5.00;
                                break;
                            case Bills.Ten:
                                RunningTotal += 10.00;
                                break;
                            case Bills.Twenty:
                                RunningTotal += 20.00;
                                break;
                            case Bills.Fifty:
                                RunningTotal += 50.00;
                                break;
                            case Bills.Hundred:
                                RunningTotal += 100.00;
                                break;
                            default:
                                throw new ArgumentException();
                        }
                    }
                    CoinControl coinControl = b.FindAncestor<CoinControl>();
                    if (coinControl != null)
                    {
                        switch (coinControl.Denomination)
                        {
                            case Coins.Penny:
                                RunningTotal += 0.01;
                                break;
                            case Coins.Nickel:
                                RunningTotal += 0.05;
                                break;
                            case Coins.Dime:
                                RunningTotal += 0.10;
                                break;
                            case Coins.Quarter:
                                RunningTotal += 0.25;
                                break;
                            case Coins.HalfDollar:
                                RunningTotal += 0.50;
                                break;
                            case Coins.Dollar:
                                RunningTotal += 1.00;
                                break;
                            default:
                                throw new ArgumentException();
                        }
                    }
                }
            }
        }
       
    }
}
