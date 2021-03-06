﻿using System;
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
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashControl.xaml
    /// </summary>
    public partial class CashControl : UserControl
    {
        /// <summary>
        /// Constructor that takes in the total cost as a string and the order summary from previous controls
        /// </summary>
        /// <param name="total"></param>
        /// <param name="osc"></param>
        public CashControl(string total, OrderSummaryControl osc)
        {
            InitializeComponent();
            this.orderSummary.DataContext = osc.DataContext;
            DataContext = new CashRegisterModelView(Convert.ToDouble(total.Remove(0,1)));
            TotalTextBox.Text = total;
            GivenChangeTitle.Text = "Given Change:\n";
        }

        /// <summary>
        /// When instructions for giving change are updated, the initial instructions are kept.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnChangeInstructionGiven(object sender, RoutedEventArgs e)
        {
            if (ChangeInstructions.Text != "")
            {
                RunningTotalBox.Text = RunningTotalBox.Text;
                ChangeInstructions.Text = ChangeInstructions.Text;
            }            
        }

        /// <summary>
        /// Event handler for when cashier gives back cash. When instructions and given change are equal, the receipt is printed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnChangeReceived(object sender, RoutedEventArgs e)
        {
            if(GivenChange.Text != "")
            {
                GivenChangeTitle.Visibility = Visibility.Visible;
            }


            if (("Give as change:\n\n" + GivenChange.Text) == ChangeInstructions.Text)
            {               
                ReceiptPrinter rp = new ReceiptPrinter();
                StringBuilder sb = new StringBuilder();
                double total = Convert.ToDouble(TotalTextBox.Text.Remove(0,1));
                double amountPaid = Convert.ToDouble(RunningTotalBox.Text.Remove(0,1));
                sb.Append("Order #" + orderSummary.OrderNumber.Text + "\n" + DateTime.Now.ToString() + "\n\n");
                foreach (IOrderItem i in orderSummary.listBox.Items)
                {
                    sb.Append(i.ToString() + String.Format(" {0:C2}", i.Price) + "\n");
                    foreach (string s in i.SpecialInstructions)
                        sb.Append(s + "\n");
                }
                sb.Append("\n");
                sb.Append("Subtotal: " + orderSummary.Subtotal.Text + "\n");
                sb.Append(String.Format("Total: {0:C2}\n", total));
                sb.Append(String.Format("Amount Paid: {0:C2}\n", amountPaid));
                sb.Append(String.Format("Change given: {0:C2}\n", amountPaid - total));
                sb.Append("Cash\n\n");
                rp.Print(sb.ToString());
                MessageBox.Show(sb.ToString());
                RegisterContainer.Child = new OrderControl();
            }
        }
       
    }
}
