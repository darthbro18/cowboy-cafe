/*
 * Author: Justin Koegeboehn
 * CustomizeSide.xaml.cs
 * Customization for the size of the side
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
    /// Interaction logic for CustomizeSide.xaml
    /// </summary>
    public partial class CustomizeSide : UserControl
    {
        public CustomizeSide()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Side becomes small size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnSmallClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Side side)
            {
                side.Size = CowboyCafe.Data.Size.Small;
            }
        }

        /// <summary>
        /// Side becomes medium size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnMediumClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Side side)
            {
                side.Size = CowboyCafe.Data.Size.Medium;
            }
        }

        /// <summary>
        /// Side becomes large size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnLargeClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Side side)
            {
                side.Size = CowboyCafe.Data.Size.Large;
            }
        }
    }

}
