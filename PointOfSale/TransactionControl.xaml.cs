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
        //static CashControl cashControl = new CashControl();
        
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
        }

        public void OnCreditPayment(object sender, RoutedEventArgs e)
        {
            CardTerminal ct = new CardTerminal();
            ResultCode message = ct.ProcessTransaction(Total);
            if (message != ResultCode.Success)
                MessageBox.Show(message.ToString());
            else
            {
                ReceiptPrinter rp = new ReceiptPrinter();
                StringBuilder sb = new StringBuilder();
                sb.Append("Order #" + orderSummary.OrderNumber.Text + "\n" + DateTime.Now.ToString() + "\n\n");
                foreach (IOrderItem i in orderSummary.listBox.Items)
                {
                    sb.Append(i.ToString() + String.Format(" {0:C2}", i.Price) + "\n");
                    foreach (string s in i.SpecialInstructions)
                        sb.Append(s + "\n");
                }
                sb.Append("\n");
                sb.Append("Subtotal: " + orderSummary.Subtotal.Text + "\n");
                sb.Append(String.Format("Total: {0:C2}\n", Total));
                sb.Append("Credit\n\n");
                rp.Print(sb.ToString());
                MessageBox.Show(sb.ToString());
                orderSummary.IsEnabled = true;
                TransactionContainer.Child = new OrderControl();
            }
        }

        public void OnCashPayment(object sender, RoutedEventArgs e)
        {
            TransactionContainer.Child = new CashControl();
            //orderSummary.IsEnabled = true;
            //TransactionContainer.Child = new OrderControl();
        }
        
        public void OnCancelTransaction(object sender, RoutedEventArgs e)
        {
            orderSummary.IsEnabled = true;
            TransactionContainer.Child = new OrderControl();
        }
    }
}
