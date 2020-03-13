﻿using System;
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

        public void OnItemAddButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda soda)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "CreamSoda":
                            soda.Flavor = SodaFlavor.CreamSoda;
                            break;
                        case "OrangeSoda":
                            soda.Flavor = SodaFlavor.OrangeSoda;
                            break;
                        case "Sarsparilla":
                            soda.Flavor = SodaFlavor.Sarsparilla;
                            break;
                        case "BirchBeer":
                            soda.Flavor = SodaFlavor.BirchBeer;
                            break;
                        case "RootBeer":
                            soda.Flavor = SodaFlavor.RootBeer;
                            break;
                    }
                }
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
