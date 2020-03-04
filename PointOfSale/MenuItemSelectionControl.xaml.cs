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

        /*public void OnItemAddButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "CowpokeChili":
                            order.Add(new CowpokeChili());
                            break;
                    }
                }
            } Tag for each button is set to "CowpokeChili", etc.
        }*/
        
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
                screen.DataContext = entree;
                data.Add(entree);
                orderControl.SwapScreen(screen);
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
                data.Add(new RustlersRibs());
                orderControl.SwapScreen(new CustomizeRustlersRibs());
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
                data.Add(new PecosPulledPork());
                orderControl.SwapScreen(new CustomizePecosPulledPork());
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
                data.Add(new AngryChicken());
                orderControl.SwapScreen(new CustomizeAngryChicken());
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
                data.Add(new TexasTripleBurger());
                orderControl.SwapScreen(new CustomizeTexasTripleBurger());
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
                data.Add(new DakotaDoubleBurger());
                orderControl.SwapScreen(new CustomizeDakotaDoubleBurger());
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
                data.Add(new TrailBurger());
                orderControl.SwapScreen(new CustomizeTrailBurger());
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
                data.Add(new BakedBeans());
                orderControl.SwapScreen(new CustomizeBakedBeans());
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
                data.Add(new ChiliCheeseFries());
                orderControl.SwapScreen(new CustomizeChiliCheeseFries());
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
                data.Add(new CornDodgers());
                orderControl.SwapScreen(new CustomizeCornDodgers());
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
                data.Add(new PanDeCampo());
                orderControl.SwapScreen(new CustomizePanDeCampo());
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
                data.Add(new Water());
                orderControl.SwapScreen(new CustomizeWater());
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
                data.Add(new JerkedSoda());
                orderControl.SwapScreen(new CustomizeJerkedSoda());
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
                data.Add(new CowboyCoffee());
                orderControl.SwapScreen(new CustomizeCowboyCoffee());
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
                data.Add(new TexasTea());
                orderControl.SwapScreen(new CustomizeTexasTea());
            }
        }
    }
}
