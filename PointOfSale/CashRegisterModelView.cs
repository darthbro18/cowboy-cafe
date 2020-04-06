using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;
using System.Windows;

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
        static CashDrawer drawer = new CashDrawer();

        private double changeAmount = 0.00;
        
        /// <summary>
        /// Total current value of the drawer
        /// </summary>
        public double TotalValue => drawer.TotalValue;

        private double runningTotal = 0.00;
        public double RunningTotal 
        { 
            get { return runningTotal; }
            set
            {
                runningTotal = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RunningTotal"));
                if (runningTotal >= TotalCost)
                {
                    changeAmount = Math.Round(runningTotal - TotalCost, 2);
                    Change = FindChangeInstructions(changeAmount, new StringBuilder("Give as change:\n\n"));
                }
            }
        }

        public double TotalCost { get; set; }

        private string change;
        public string Change 
        { 
            get { return change; } 
            private set
            {
                change = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Change"));
            } 
        }

        private string changeGiven;
        public string ChangeGiven 
        { 
            get { return changeGiven; }
            private set
            {
                changeGiven = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeGiven"));
            } 
        }

        public CashRegisterModelView(double totalCost)
        {
            TotalCost = totalCost;
        }

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
                    RunningTotal += (0.01 * quantity);
                }
                else 
                {
                    drawer.RemoveCoin(Coins.Penny, -quantity);
                    RunningTotal -= (0.01 * -quantity);
                    if (changeAmount >= 0.00)
                        ChangeGiven += "Penny\n";
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
                    RunningTotal += (0.05 * quantity);
                }
                else
                {
                    drawer.RemoveCoin(Coins.Nickel, -quantity);
                    RunningTotal -= (0.05 * -quantity);
                    if (changeAmount >= 0.00)
                        ChangeGiven += "Nickel\n";
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
                    RunningTotal += (0.10 * quantity);
                }
                else
                {
                    drawer.RemoveCoin(Coins.Dime, -quantity);
                    RunningTotal -= (0.10 * -quantity);
                    if (changeAmount >= 0.00)
                        ChangeGiven += "Dime\n";
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
                    RunningTotal += (0.25 * quantity);
                }
                else
                {
                    drawer.RemoveCoin(Coins.Quarter, -quantity);
                    RunningTotal -= (0.25 * -quantity);
                    if (changeAmount >= 0.00)
                        ChangeGiven += "Quarter\n";
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
                    RunningTotal += (0.50 * quantity);
                }
                else
                {
                    drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                    RunningTotal -= (0.50 * -quantity);
                    if (changeAmount >= 0.00)
                        ChangeGiven += "Halfdollar\n";
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
                    RunningTotal += (1.00 * quantity);
                }
                else
                {
                    drawer.RemoveCoin(Coins.Dollar, -quantity);
                    RunningTotal -= (1.00 * -quantity);
                    if (changeAmount >= 0.00)
                        ChangeGiven += "Dollar coin\n";
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
                    RunningTotal += (1.00 * quantity);
                }
                else 
                {
                    drawer.RemoveBill(Bills.One, -quantity);
                    RunningTotal -= (1.00 * -quantity);
                    if (changeAmount >= 0.00)
                        ChangeGiven += "$1 bill\n";
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
                    RunningTotal += (2.00 * quantity);
                }
                else
                {
                    drawer.RemoveBill(Bills.Two, -quantity);
                    RunningTotal -= (2.00 * -quantity);
                    if (changeAmount >= 0.00)
                        ChangeGiven += "$2 bill\n";
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
                    RunningTotal += (5.00 * quantity);
                }
                else
                {
                    drawer.RemoveBill(Bills.Five, -quantity);
                    RunningTotal -= (5.00 * -quantity);
                    if (changeAmount >= 0.00)
                        ChangeGiven += "$5 bill\n";
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
                    RunningTotal += (10.00 * quantity);
                }
                else
                {
                    drawer.RemoveBill(Bills.Ten, -quantity);
                    RunningTotal -= (10.00 * -quantity);
                    if (changeAmount >= 0.00)
                        ChangeGiven += "$10 bill\n";
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
                    RunningTotal += (20.00 * quantity);
                }
                else
                {
                    drawer.RemoveBill(Bills.Twenty, -quantity);
                    RunningTotal -= (20.00 * -quantity);
                    if (changeAmount >= 0.00)
                        ChangeGiven += "$20 bill\n";
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
                    RunningTotal += (50.00 * quantity);
                }
                else
                {
                    drawer.RemoveBill(Bills.Fifty, -quantity);
                    RunningTotal -= (50.00 * -quantity);
                    if (changeAmount >= 0.00)
                        ChangeGiven += "$50 bill\n";
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
                    RunningTotal += (100.00 * quantity);
                }
                else
                {
                    drawer.RemoveBill(Bills.Hundred, -quantity);
                    RunningTotal -= (100.00 * -quantity);
                    if (changeAmount >= 0.00)
                        ChangeGiven += "$100 bill\n";
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

        private string FindChangeInstructions(double change, StringBuilder sb)
        {
            if (change == 0)
                return sb.ToString();
            double value;
            if (change >= 100 && Hundreds > 0)
            {
                value = 100;
                sb.Append("$100 bill\n");
            }
            else if (change >= 50 && Fifties > 0)
            {
                value = 50;
                sb.Append("$50 bill\n");
            }
            else if (change >= 20 && Twenties > 0)
            {
                value = 20;
                sb.Append("$20 bill\n");
            }
            else if (change >= 10 && Tens > 0)
            {
                value = 10;
                sb.Append("$10 bill\n");
            }
            else if (change >= 5 && Fives > 0)
            {
                value = 5;
                sb.Append("$5 bill\n");
            }
            else if (change >= 2 && Twos > 0)
            {
                value = 2;
                sb.Append("$2 bill\n");
            }
            else if (change >= 1 && Ones > 0)
            {
                value = 1;
                sb.Append("$1 bill\n");
            }
            else if (change >= 1 && Dollars > 0)
            {
                value = 1;
                sb.Append("Dollar coin\n");
            }
            else if (change >= 0.5 && HalfDollars > 0)
            {
                value = 0.5;
                sb.Append("Halfdollar\n");
            }
            else if (change >= 0.25 && Quarters > 0)
            {
                value = 0.25;
                sb.Append("Quarter\n");
            }
            else if (change >= 0.1 && Dimes > 0)
            {
                value = 0.1;
                sb.Append("Dime\n");
            }
            else if (change >= 0.05 && Nickels > 0)
            {
                value = 0.05;
                sb.Append("Nickel\n");
            }
            else
            {
                value = 0.01;
                sb.Append("Penny\n");
            }

            return FindChangeInstructions(Math.Round(change - value,2), sb);
        }
    }
}
