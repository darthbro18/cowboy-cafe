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
    /// Interaction logic for CustomizeWater.xaml
    /// </summary>
    public partial class CustomizeWater : UserControl
    {
        public CustomizeWater()
        {
            InitializeComponent();
        }

        public void OnSmallClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Water water)
            {
                water.Size = CowboyCafe.Data.Size.Small;
            }
        }

        public void OnMediumClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Water water)
            {
                water.Size = CowboyCafe.Data.Size.Medium;
            }
        }

        public void OnLargeClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Water water)
            {
                water.Size = CowboyCafe.Data.Size.Large;
            }
        }
    }
}
