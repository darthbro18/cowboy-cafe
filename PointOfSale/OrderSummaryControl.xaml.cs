/*
 * Author: Justin Koegeboehn
 * OrderSummaryControl.xaml.cs
 * Constructs a control that displays all the menu items selected in an order along with the subtotal
 */

using CowboyCafe.Data;
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
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Removes an item from the order and therefore the order summary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnRemoveItem(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    if(button.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }                      
                }
            }
        }

        /// <summary>
        /// When an item from the order summary is selected, the screen switches to the corresponding customization screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnSelectItem(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (sender is ListBox lb)
                {
                    if (lb.SelectedItem != null)
                    {
                        var item = lb.SelectedItem;
                        FrameworkElement screen;
                        switch (item.ToString())
                        {
                            case "Trail Burger":
                                screen = new CustomizeTrailBurger();
                                break;
                            case "Dakota Double Burger":
                                screen = new CustomizeDakotaDoubleBurger();
                                break;
                            case "Texas Triple Burger":
                                screen = new CustomizeTexasTripleBurger();
                                break;
                            case "Angry Chicken":
                                screen = new CustomizeAngryChicken();
                                break;
                            case "Cowpoke Chili":
                                screen = new CustomizeCowpokeChili();
                                break;
                            case "Pecos Pulled Pork":
                                screen = new CustomizePecosPulledPork();
                                break;
                            default:
                                screen = null;
                                break;
                        }

                        if (item is Side)
                            screen = new CustomizeSide();
                        if (item is CowboyCoffee)
                            screen = new CustomizeCowboyCoffee();
                        if (item is JerkedSoda)
                            screen = new CustomizeJerkedSoda();
                        if (item is TexasTea)
                            screen = new CustomizeTexasTea();
                        if (item is Water)
                            screen = new CustomizeWater();

                        if (screen != null)
                        {
                            var orderControl = this.FindAncestor<OrderControl>();
                            if (orderControl == null) throw new Exception("An ancestor of Ordercontrol expected to not be null");

                            screen.DataContext = item;
                            orderControl.SwapScreen(screen);
                        }
                        lb.SelectedIndex = -1;
                    }
                }
            }
        }
    }
}
