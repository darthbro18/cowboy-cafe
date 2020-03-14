/*
 * Author: Justin Koegeboehn
 * CustomizeWater.xaml.cs
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
    /// Interaction logic for CustomizeWater.xaml
    /// </summary>
    public partial class CustomizeWater : UserControl
    {
        public CustomizeWater()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Drink size becomes small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnSmallClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Water water)
            {
                water.Size = CowboyCafe.Data.Size.Small;
            }
        }

        /// <summary>
        /// Drink size becomes medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnMediumClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Water water)
            {
                water.Size = CowboyCafe.Data.Size.Medium;
            }
        }

        /// <summary>
        /// Drink size becomes large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnLargeClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Water water)
            {
                water.Size = CowboyCafe.Data.Size.Large;
            }
        }
    }
}
