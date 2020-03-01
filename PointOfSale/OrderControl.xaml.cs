/*
 * Author: Justin Koegeboehn
 * OrderControl.xaml.cs
 * Sets up the controls for the contents in the window such as the buttons and order list
 */

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
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Constructs the controls. Sets up the click event handlers for the buttons
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
            SelectItemButton.Click += OnItemSelect;
            CancelOrderButton.Click += OnCancelOrder;
            CompleteOrderButton.Click += OnCompleteOrder;

            this.DataContext = new Order();
        }

        public void OnItemSelect(object sender, RoutedEventArgs e)
        {

        }
        
        public void OnCancelOrder(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        public void OnCompleteOrder(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        


    }
}
