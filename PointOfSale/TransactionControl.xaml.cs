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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        public TransactionControl()
        {
            InitializeComponent();
        }

        public void OnCreditPayment(object sender, RoutedEventArgs e)
        {
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
