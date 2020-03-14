/*
 * Author: Justin Koegeboehn
 * CustomizeJerkedSoda.xaml.cs
 * Customization for drink size and flavor
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
    /// Interaction logic for CustomizeJerkedSoda.xaml
    /// </summary>
    public partial class CustomizeJerkedSoda : UserControl
    {
        public CustomizeJerkedSoda()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Flavor becomes Cream Soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCreamSoda(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Flavor = SodaFlavor.CreamSoda;
            }
        }

        /// <summary>
        /// Flavor becomes Orange Soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnOrangeSoda(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Flavor = SodaFlavor.OrangeSoda;
            }
        }

        /// <summary>
        /// Flavor becomes Sarsparilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnSarsparilla(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Flavor = SodaFlavor.Sarsparilla;
            }
        }

        /// <summary>
        /// Flavor becomes Birch Beer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnBirchBeer(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Flavor = SodaFlavor.BirchBeer;
            }
        }
        
        /// <summary>
        /// Flavor becomes Root Beer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnRootBeer(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Flavor = SodaFlavor.RootBeer;
            }
        }

        /// <summary>
        /// Size becomes small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnSmallClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Size = CowboyCafe.Data.Size.Small;
            }
        }

        /// <summary>
        /// Size becomes medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnMediumClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Size = CowboyCafe.Data.Size.Medium;
            }
        }

        /// <summary>
        /// Size becomes large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnLargeClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Size = CowboyCafe.Data.Size.Large;
            }
        }
    }
}
