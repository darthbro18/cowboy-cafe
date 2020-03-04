/*
 * Author: Justin Koegeboehn
 * OrderControl.xaml.cs
 * Contains order summary and menu item selection, along with buttons to cancel and complete orders
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

            DataContext = new Order();
        }

        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }
        
        /// <summary>
        /// Returns to the Menu Item Select screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnItemSelect(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }
        
        /// <summary>
        /// Cancels current order and constructs a new one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCancelOrder(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        /// <summary>
        /// Completes current order and constructs a new one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCompleteOrder(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        


    }
}
