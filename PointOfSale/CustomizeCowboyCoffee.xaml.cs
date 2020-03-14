/*
 * Author: Justin Koegeboehn
 * CustomizeCowboyCoffee.xaml.cs
 * Customization for drink size and special instructions
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
    /// Interaction logic for CustomizeCowboyCoffee.xaml
    /// </summary>
    public partial class CustomizeCowboyCoffee : UserControl
    {
        public CustomizeCowboyCoffee()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Size becomes small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnSmallClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is CowboyCoffee coffee)
            {
                coffee.Size = CowboyCafe.Data.Size.Small;
            }
        }

        /// <summary>
        /// Size becomes medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnMediumClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is CowboyCoffee coffee)
            {
                coffee.Size = CowboyCafe.Data.Size.Medium;
            }
        }

        /// <summary>
        /// Size becomes large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnLargeClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is CowboyCoffee coffee)
            {
                coffee.Size = CowboyCafe.Data.Size.Large;
            }
        }
    }
}
