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

        public void OnCreamSoda(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Flavor = SodaFlavor.CreamSoda;
            }
        }

        public void OnOrangeSoda(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Flavor = SodaFlavor.OrangeSoda;
            }
        }

        public void OnSarsparilla(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Flavor = SodaFlavor.Sarsparilla;
            }
        }

        public void OnBirchBeer(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Flavor = SodaFlavor.BirchBeer;
            }
        }
        public void OnRootBeer(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Flavor = SodaFlavor.RootBeer;
            }
        }

        public void OnSmallClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Size = CowboyCafe.Data.Size.Small;
            }
        }

        public void OnMediumClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Size = CowboyCafe.Data.Size.Medium;
            }
        }

        public void OnLargeClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda soda)
            {
                soda.Size = CowboyCafe.Data.Size.Large;
            }
        }
    }
}
