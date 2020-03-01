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
        /// Adds Cowpoke Chili to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCowpokeChiliAdded(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CowpokeChili());
            }
        }

        /// <summary>
        /// Adds Rustlers Ribs to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnRustlersRibsAdded(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new RustlersRibs());
            }
        }

        /// <summary>
        /// Adds Pecos Pulled Pork to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnPecosPulledPorkAdded(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new PecosPulledPork());
            }
        }

        /// <summary>
        /// Adds Angry Chicken to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAngryChickenAdded(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new AngryChicken());
            }
        }

        /// <summary>
        /// Adds Texas Triple Burger to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnTexasTripleBurgerAdded(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new TexasTripleBurger());
            }
        }

        /// <summary>
        /// Adds Dakota Double Burger to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnDakotaDoubleBurgerAdded(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new DakotaDoubleBurger());
            }
        }

        /// <summary>
        /// Adds Trail Burger to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnTrailBurgerAdded(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new TrailBurger());
            }
        }

        /// <summary>
        /// Adds Baked Beans to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnBakedBeansAdded(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new BakedBeans());
            }
        }

        /// <summary>
        /// Adds Chili Cheese Fries to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnChiliCheeseFriesAdded(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new ChiliCheeseFries());
            }
        }

        /// <summary>
        /// Adds Corn Dodgers to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCornDodgersAdded(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CornDodgers());
            }
        }

        /// <summary>
        /// Adds Pan de Campo to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnPanDeCampoAdded(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new PanDeCampo());
            }
        }

        /// <summary>
        /// Adds Water to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnWaterAdded(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new Water());
            }
        }

        /// <summary>
        /// Adds Jerked Soda to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnJerkedSodaAdded(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new JerkedSoda());
            }
        }

        /// <summary>
        /// Adds Cowboy Coffee to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCowboyCoffeeAdded(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CowboyCoffee());
            }
        }

        /// <summary>
        /// Adds Texas Tea to order list when corresponding button is pushed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnTexasTeaAdded(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new TexasTea());
            }
        }
    }
}
