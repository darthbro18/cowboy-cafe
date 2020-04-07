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

        static int pennies;
        static int nickels;
        static int dimes;
        static int quarters;
        static int halfdollars;
        static int dollars;
        static int ones;
        static int twos;
        static int fives;
        static int tens;
        static int twenties;
        static int fifties;
        static int hundreds;

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
                    pennies = Pennies;
                    nickels = Nickels;
                    dimes = Dimes;
                    quarters = Quarters;
                    halfdollars = HalfDollars;
                    dollars = Dollars;
                    ones = Ones;
                    twos = Twos;
                    fives = Fives;
                    tens = Tens;
                    twenties = Twenties;
                    fifties = Fifties;
                    hundreds = Hundreds;

                    changeAmount = Math.Round(runningTotal - TotalCost, 2);
                    if (changeAmount == 0.00 && Change == null)
                    {
                        Change = "Give as change:\n\nNone";
                        ChangeGiven = "None";
                    }                       
                    else
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

        private string FindChangeInstructions(double changeNeeded, StringBuilder sb)
        {
            if (changeNeeded == 0)
                return sb.ToString();
            double value;
            if (changeNeeded >= 100 && hundreds > 0)
            {
                value = 100;
                sb.Append("$100 bill\n");
                hundreds--;
                //InvokePropertyChanged("Hundreds");
            }
            else if (changeNeeded >= 50 && fifties > 0)
            {
                value = 50;
                sb.Append("$50 bill\n");
                fifties--;
                //InvokePropertyChanged("Fifties");
            }
            else if (changeNeeded >= 20 && twenties > 0)
            {
                value = 20;
                sb.Append("$20 bill\n");
                twenties--;
                //InvokePropertyChanged("Twenties");
            }
            else if (changeNeeded >= 10 && tens > 0)
            {
                value = 10;
                sb.Append("$10 bill\n");
                tens--;
                //InvokePropertyChanged("Tens");
            }
            else if (changeNeeded >= 5 && fives > 0)
            {
                value = 5;
                sb.Append("$5 bill\n");
                fives--;
                //InvokePropertyChanged("Fives");
            }
            else if (changeNeeded >= 2 && twos > 0)
            {
                value = 2;
                sb.Append("$2 bill\n");
                twos--;
                //InvokePropertyChanged("Twos");
            }
            else if (changeNeeded >= 1 && ones > 0)
            {
                value = 1;
                sb.Append("$1 bill\n");
                ones--;
                //InvokePropertyChanged("Ones");
            }
            else if (changeNeeded >= 1 && dollars > 0)
            {
                value = 1;
                sb.Append("Dollar coin\n");
                dollars--;
                //InvokePropertyChanged("Dollars");
            }
            else if (changeNeeded >= 0.5 && halfdollars > 0)
            {
                value = 0.5;
                sb.Append("Halfdollar\n");
                halfdollars--;
                //InvokePropertyChanged("HalfDollars");
            }
            else if (changeNeeded >= 0.25 && quarters > 0)
            {
                value = 0.25;
                sb.Append("Quarter\n");
                quarters--;
                //InvokePropertyChanged("Quarters");
            }
            else if (changeNeeded >= 0.1 && dimes > 0)
            {
                value = 0.1;
                sb.Append("Dime\n");
                dimes--;
                //InvokePropertyChanged("Dimes");
            }
            else if (changeNeeded >= 0.05 && nickels > 0)
            {
                value = 0.05;
                sb.Append("Nickel\n");
                nickels--;
                //InvokePropertyChanged("Nickels");
            }
            else if (pennies > 0)
            {
                value = 0.01;
                sb.Append("Penny\n");
                pennies--;
                //InvokePropertyChanged("Pennies");
            }
            else
            {
                return FindChangeInstructions(0, sb);
            }

            return FindChangeInstructions(Math.Round(changeNeeded - value,2), sb);
        }
    }
}
