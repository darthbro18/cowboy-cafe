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

        public void OnSmallClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is CowboyCoffee coffee)
            {
                coffee.Size = CowboyCafe.Data.Size.Small;
            }
        }

        public void OnMediumClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is CowboyCoffee coffee)
            {
                coffee.Size = CowboyCafe.Data.Size.Medium;
            }
        }

        public void OnLargeClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is CowboyCoffee coffee)
            {
                coffee.Size = CowboyCafe.Data.Size.Large;
            }
        }
    }
}
