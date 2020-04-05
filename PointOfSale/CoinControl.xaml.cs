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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CoinControl.xaml
    /// </summary>
    public partial class CoinControl : UserControl
    {
        /// <summary>
        /// The DependencyProperty for the DenominationProperty
        /// </summary>
        public static readonly DependencyProperty DenominationProperty =
            DependencyProperty.Register(
                    "Denomination",
                    typeof(Coins),
                    typeof(CoinControl),
                    new PropertyMetadata(Coins.Penny)
                );

        /// <summary>
        /// The Denomination this control displays and modifies
        /// </summary>
        public Coins Denomination
        {
            get { return (Coins)GetValue(DenominationProperty); }
            set { SetValue(DenominationProperty, value); }
        }

        /// <summary>
        /// The DependencyProperty for Quantity
        /// </summary>
        public static readonly DependencyProperty QuantityProperty =
            DependencyProperty.Register(
                    "Quantity",
                    typeof(int),
                    typeof(CoinControl),
                    new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
                );

        /// <summary>
        /// Gets or sets the quantity of coin
        /// </summary>
        public int Quantity
        {
            get { return (int)GetValue(QuantityProperty); }
            set { SetValue(QuantityProperty, value); }
        }

        public CoinControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Increase quantity when '+' is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnIncreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity++;
            CashControl c = this.FindAncestor<CashControl>();
            if (c != null)
            {
                switch (this.Denomination)
                {
                    case Coins.Penny:
                        c.RunningTotal += 0.01;
                        break;
                    case Coins.Nickel:
                        c.RunningTotal += 0.05;
                        break;
                    case Coins.Dime:
                        c.RunningTotal += 0.10;
                        break;
                    case Coins.Quarter:
                        c.RunningTotal += 0.25;
                        break;
                    case Coins.HalfDollar:
                        c.RunningTotal += 0.50;
                        break;
                    case Coins.Dollar:
                        c.RunningTotal += 1.00;
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }

        /// <summary>
        /// Decreases quantity when '-' is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDecreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity--;
        }
    }
}
