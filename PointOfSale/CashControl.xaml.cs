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
    public partial class CashControl : UserControl
    {   
        public CashControl(string total)
        {
            InitializeComponent();
            DataContext = new CashRegisterModelView(Convert.ToDouble(total.Remove(0,1)));
            TotalTextBox.Text = total;
        }
       
    }
}
