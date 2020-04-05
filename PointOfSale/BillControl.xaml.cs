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
    /// Interaction logic for BillControl.xaml
    /// </summary>
    public partial class BillControl : UserControl
    {
        /// <summary>
        /// The DependencyProperty for the DenominationProperty
        /// </summary>
        public static readonly DependencyProperty DenominationProperty =
            DependencyProperty.Register(
                    "Denomination",
                    typeof(Bills),
                    typeof(BillControl),
                    new PropertyMetadata(Bills.One)
                );

        /// <summary>
        /// The Denomination this control displays and modifies
        /// </summary>
        public Bills Denomination
        {
            get { return (Bills)GetValue(DenominationProperty); }
            set { SetValue(DenominationProperty, value); }
        }

        /// <summary>
        /// The DependencyProperty for Quantity
        /// </summary>
        public static readonly DependencyProperty QuantityProperty =
            DependencyProperty.Register(
                    "Quantity",
                    typeof(int),
                    typeof(BillControl),
                    new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
                );

        /// <summary>
        /// Gets or sets the quantity of bill
        /// </summary>
        public int Quantity
        {
            get { return (int)GetValue(QuantityProperty); }
            set { SetValue(QuantityProperty, value); }
        }


        public BillControl()
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
                    case Bills.One:
                        c.RunningTotal += 1.00;
                        break;
                    case Bills.Two:
                        c.RunningTotal += 2.00;
                        break;
                    case Bills.Five:
                        c.RunningTotal += 5.00;
                        break;
                    case Bills.Ten:
                        c.RunningTotal += 10.00;
                        break;
                    case Bills.Twenty:
                        c.RunningTotal += 20.00;
                        break;
                    case Bills.Fifty:
                        c.RunningTotal += 50.00;
                        break;
                    case Bills.Hundred:
                        c.RunningTotal += 100.00;
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
