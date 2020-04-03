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
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {        
        public double Total
        {
            get
            {
                string price = orderSummary.Subtotal.Text.Remove(0, 1);
                return Convert.ToDouble(price) * 1.16;
            }
        }
        
        public TransactionControl()
        {
            InitializeComponent();
            //TotalTextBox.Text = String.Format("{0:C2}", Total);
        }

        public void OnCreditPayment(object sender, RoutedEventArgs e)
        {

            CardTerminal ct = new CardTerminal();
            ResultCode message = ct.ProcessTransaction(Total);
            MessageBox.Show(message.ToString());
            orderSummary.IsEnabled = true;
            TransactionContainer.Child = new OrderControl();
        }

        public void OnCashPayment(object sender, RoutedEventArgs e)
        {
            orderSummary.IsEnabled = true;
            TransactionContainer.Child = new OrderControl();
        }
        
        public void OnCancelTransaction(object sender, RoutedEventArgs e)
        {
            orderSummary.IsEnabled = true;
            TransactionContainer.Child = new OrderControl();
        }
    }
}
