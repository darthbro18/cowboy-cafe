/*
 * Author: Justin Koegeboehn
 * MenuItemSelectionControl.xaml.cs
 * Control that includes all the buttons for menu items and creates new objects for each button click
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
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {       
        public MenuItemSelectionControl()
        {
            InitializeComponent();          
            
            AddCowpokeChiliButton.Click += OnCowpokeChiliAdded;
            AddRustlersRibsButton.Click += OnRustlersRibsAdded;
            AddPecosPulledPorkButton.Click += OnPecosPulledPorkAdded;
            AddAngryChickenButton.Click += OnAngryChickenAdded;
            AddTexasTripleBurgerButton.Click += OnTexasTripleBurgerAdded;
            AddDakotaDoubleBurgerButton.Click += OnDakotaDoubleBurgerAdded;
            AddTrailBurgerButton.Click += OnTrailBurgerAdded;
            AddBakedBeansButton.Click += OnBakedBeansAdded;
            AddChiliCheeseFriesButton.Click += OnChiliCheeseFriesAdded;
            AddCornDodgersButton.Click += OnCornDodgersAdded;
            AddPanDeCampoButton.Click += OnPanDeCampoAdded;
            AddWaterButton.Click += OnWaterAdded;
            AddJerkedSodaButton.Click += OnJerkedSodaAdded;
            AddCowboyCoffeeButton.Click += OnCowboyCoffeeAdded;
            AddTexasTeaButton.Click += OnTexasTeaAdded;
        }

        
        /// <summary>
        /// Switches to a customization screen for a corresponding menu item.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="screen"></param>
        void AddItemAndOpenCustomizationScreen(IOrderItem item, FrameworkElement screen)
        {
            var order = DataContext as Order;
            if (order == null) throw new Exception("DataContext expected to be an Order");
            
            if(screen != null)
            {
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) throw new Exception("An ancestor of Ordercontrol expected to not be null");

                screen.DataContext = item;
                orderControl.SwapScreen(screen);
            }
            
            order.Add(item);

        }
            
        /// <summary>
        /// Adds Cowpoke Chili to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCowpokeChiliAdded(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var entree = new CowpokeChili();
                var screen = new CustomizeCowpokeChili();
                AddItemAndOpenCustomizationScreen(entree, screen);
            }
        }

        /// <summary>
        /// Adds Rustlers Ribs to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnRustlersRibsAdded(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var entree = new RustlersRibs();
                FrameworkElement screen = null;
                AddItemAndOpenCustomizationScreen(entree, screen);
            }
        }

        /// <summary>
        /// Adds Pecos Pulled Pork to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnPecosPulledPorkAdded(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var entree = new PecosPulledPork();
                var screen = new CustomizePecosPulledPork();
                AddItemAndOpenCustomizationScreen(entree, screen);
            }
        }

        /// <summary>
        /// Adds Angry Chicken to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAngryChickenAdded(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var entree = new AngryChicken();
                var screen = new CustomizeAngryChicken();
                AddItemAndOpenCustomizationScreen(entree, screen);
            }
        }

        /// <summary>
        /// Adds Texas Triple Burger to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnTexasTripleBurgerAdded(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var entree = new TexasTripleBurger();
                var screen = new CustomizeTexasTripleBurger();
                AddItemAndOpenCustomizationScreen(entree, screen);
            }
        }

        /// <summary>
        /// Adds Dakota Double Burger to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDakotaDoubleBurgerAdded(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var entree = new DakotaDoubleBurger();
                var screen = new CustomizeDakotaDoubleBurger();
                AddItemAndOpenCustomizationScreen(entree, screen);
            }
        }

        /// <summary>
        /// Adds Trail Burger to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnTrailBurgerAdded(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var entree = new TrailBurger();
                var screen = new CustomizeTrailBurger();
                AddItemAndOpenCustomizationScreen(entree, screen);
            }
        }

        /// <summary>
        /// Adds Baked Beans to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnBakedBeansAdded(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var side = new BakedBeans();
                var screen = new CustomizeSide();
                AddItemAndOpenCustomizationScreen(side, screen);
            }
        }

        /// <summary>
        /// Adds Chili Cheese Fries to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnChiliCheeseFriesAdded(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var side = new ChiliCheeseFries();
                var screen = new CustomizeSide();
                AddItemAndOpenCustomizationScreen(side, screen);
            }
        }

        /// <summary>
        /// Adds Corn Dodgers to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCornDodgersAdded(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var side = new CornDodgers();
                var screen = new CustomizeSide();
                AddItemAndOpenCustomizationScreen(side, screen);
            }
        }

        /// <summary>
        /// Adds Pan de Campo to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnPanDeCampoAdded(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var side = new PanDeCampo();
                var screen = new CustomizeSide();
                AddItemAndOpenCustomizationScreen(side, screen);
            }
        }

        /// <summary>
        /// Adds Water to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnWaterAdded(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var drink = new Water();
                var screen = new CustomizeWater();
                AddItemAndOpenCustomizationScreen(drink, screen);
            }
        }

        /// <summary>
        /// Adds Jerked Soda to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnJerkedSodaAdded(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var drink = new JerkedSoda();
                var screen = new CustomizeJerkedSoda();
                AddItemAndOpenCustomizationScreen(drink, screen);
            }
        }

        /// <summary>
        /// Adds Cowboy Coffee to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCowboyCoffeeAdded(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var drink = new CowboyCoffee();
                var screen = new CustomizeCowboyCoffee();
                AddItemAndOpenCustomizationScreen(drink, screen);
            }
        }

        /// <summary>
        /// Adds Texas Tea to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnTexasTeaAdded(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var drink = new TexasTea();
                var screen = new CustomizeTexasTea();
                AddItemAndOpenCustomizationScreen(drink, screen);
            }
        }
    }
}
