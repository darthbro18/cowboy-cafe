using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;

namespace PointOfSale
{
    public class CashRegisterModelView : INotifyPropertyChanged
    {
        /// <summary>
        /// Notifies of property changed events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The CashDrawer this class uses
        /// </summary>
        CashDrawer drawer = new CashDrawer();

        /// <summary>
        /// Total current value of the drawer
        /// </summary>
        public double TotalValue => drawer.TotalValue;

        //public double RunningTotal { get; set; } = 0.00;

        public int Pennies
        {
            get => drawer.Pennies;

            set
            {
                if (drawer.Pennies == value || value < 0) return;
                var quantity = value - drawer.Pennies;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Penny, quantity);
                    //RunningTotal += (0.01 * quantity);
                }
                else 
                {
                    drawer.RemoveCoin(Coins.Penny, -quantity);
                    //RunningTotal -= (0.01 * quantity);
                }               
                InvokePropertyChanged("Pennies");
            }
        }

        public int Nickels
        {
            get => drawer.Nickels;

            set
            {
                if (drawer.Nickels == value || value < 0) return;
                var quantity = value - drawer.Nickels;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Nickel, quantity);
                    //RunningTotal += (0.05 * quantity);
                }
                else
                {
                    drawer.RemoveCoin(Coins.Nickel, -quantity);
                    //RunningTotal -= (0.05 * quantity);
                }
                InvokePropertyChanged("Nickels");
            }
        }

        public int Dimes
        {
            get => drawer.Dimes;

            set
            {
                if (drawer.Dimes == value || value < 0) return;
                var quantity = value - drawer.Dimes;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Dime, quantity);
                    //RunningTotal += (0.10 * quantity);
                }
                else
                {
                    drawer.RemoveCoin(Coins.Dime, -quantity);
                    //RunningTotal -= (0.10 * quantity);
                }
                InvokePropertyChanged("Dimes");
            }
        }

        public int Quarters
        {
            get => drawer.Quarters;

            set
            {
                if (drawer.Quarters == value || value < 0) return;
                var quantity = value - drawer.Quarters;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Quarter, quantity);
                    //RunningTotal += (0.25 * quantity);
                }
                else
                {
                    drawer.RemoveCoin(Coins.Quarter, -quantity);
                    //RunningTotal -= (0.25 * quantity);
                }
                InvokePropertyChanged("Quarters");
            }
        }

        public int HalfDollars
        {
            get => drawer.HalfDollars;

            set
            {
                if (drawer.HalfDollars == value || value < 0) return;
                var quantity = value - drawer.HalfDollars;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.HalfDollar, quantity);
                    //RunningTotal += (0.50 * quantity);
                }
                else
                {
                    drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                    //RunningTotal -= (0.50 * quantity);
                }
                InvokePropertyChanged("HalfDollars");
            }
        }

        public int Dollars
        {
            get => drawer.Dollars;

            set
            {
                if (drawer.Dollars == value || value < 0) return;
                var quantity = value - drawer.Dollars;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Dollar, quantity);
                    //RunningTotal += (1.00 * quantity);
                }
                else
                {
                    drawer.RemoveCoin(Coins.Dollar, -quantity);
                    //RunningTotal -= (1.00 * quantity);
                }
                InvokePropertyChanged("Dollars");
            }
        }

        public int Ones
        {
            get => drawer.Ones;

            set
            {
                if (drawer.Ones == value || value < 0) return;
                var quantity = value - drawer.Ones;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.One, quantity);
                    //RunningTotal += (1.00 * quantity);
                }
                else 
                {
                    drawer.RemoveBill(Bills.One, -quantity);
                    //RunningTotal -= (1.00 * quantity);
                }               
                InvokePropertyChanged("Ones");
            }
        }

        public int Twos
        {
            get => drawer.Twos;

            set
            {
                if (drawer.Twos == value || value < 0) return;
                var quantity = value - drawer.Twos;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Two, quantity);
                    //RunningTotal += (2.00 * quantity);
                }
                else
                {
                    drawer.RemoveBill(Bills.Two, -quantity);
                    //RunningTotal -= (2.00 * quantity);
                }
                InvokePropertyChanged("Twos");
            }
        }

        public int Fives
        {
            get => drawer.Fives;

            set
            {
                if (drawer.Fives == value || value < 0) return;
                var quantity = value - drawer.Fives;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Five, quantity);
                    //RunningTotal += (5.00 * quantity);
                }
                else
                {
                    drawer.RemoveBill(Bills.Five, -quantity);
                    //RunningTotal -= (5.00 * quantity);
                }
                InvokePropertyChanged("Fives");
            }
        }

        public int Tens
        {
            get => drawer.Tens;

            set
            {
                if (drawer.Tens == value || value < 0) return;
                var quantity = value - drawer.Tens;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Ten, quantity);
                    //RunningTotal += (10.00 * quantity);
                }
                else
                {
                    drawer.RemoveBill(Bills.Ten, -quantity);
                    //RunningTotal -= (10.00 * quantity);
                }
                InvokePropertyChanged("Tens");
            }
        }

        public int Twenties
        {
            get => drawer.Twenties;

            set
            {
                if (drawer.Twenties == value || value < 0) return;
                var quantity = value - drawer.Twenties;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Twenty, quantity);
                    //RunningTotal += (20.00 * quantity);
                }
                else
                {
                    drawer.RemoveBill(Bills.Twenty, -quantity);
                    //RunningTotal -= (20.00 * quantity);
                }
                InvokePropertyChanged("Twenties");
            }
        }

        public int Fifties
        {
            get => drawer.Fifties;

            set
            {
                if (drawer.Fifties == value || value < 0) return;
                var quantity = value - drawer.Fifties;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Fifty, quantity);
                    //RunningTotal += (50.00 * quantity);
                }
                else
                {
                    drawer.RemoveBill(Bills.Fifty, -quantity);
                    //RunningTotal -= (50.00 * quantity);
                }
                InvokePropertyChanged("Fifties");
            }
        }

        public int Hundreds
        {
            get => drawer.Hundreds;

            set
            {
                if (drawer.Hundreds == value || value < 0) return;
                var quantity = value - drawer.Hundreds;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Hundred, quantity);
                    //RunningTotal += (100.00 * quantity);
                }
                else
                {
                    drawer.RemoveBill(Bills.Hundred, -quantity);
                    //RunningTotal -= (100.00 * quantity);
                }
                InvokePropertyChanged("Hundreds");
            }
        }

        /// <summary>
        /// Helper method for triggering PropertyChanged events
        /// </summary>
        /// <param name="denomination"></param>
        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }
    }
}
