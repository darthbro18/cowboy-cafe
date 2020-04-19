using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        private static List<IOrderItem> menuItems = new List<IOrderItem>();

        private static List<IOrderItem> entreeItems = new List<IOrderItem>();

        private static List<IOrderItem> sideItems = new List<IOrderItem>();

        private static List<IOrderItem> drinkItems = new List<IOrderItem>();

        /// <summary>
        /// When Menu is first constructed, the private fields are filled with their respective IOrderItems
        /// </summary>
        static Menu()
        {
            entreeItems.Add(new AngryChicken());
            entreeItems.Add(new CowpokeChili());
            entreeItems.Add(new PecosPulledPork());
            entreeItems.Add(new RustlersRibs());
            entreeItems.Add(new TrailBurger());
            entreeItems.Add(new DakotaDoubleBurger());
            entreeItems.Add(new TexasTripleBurger());

            sideItems.Add(new BakedBeans());
            sideItems.Add(new ChiliCheeseFries());
            sideItems.Add(new CornDodgers());
            sideItems.Add(new PanDeCampo());

            drinkItems.Add(new JerkedSoda());
            drinkItems.Add(new TexasTea());
            drinkItems.Add(new CowboyCoffee());
            drinkItems.Add(new Water());

            foreach(IOrderItem item in entreeItems)
            {
                menuItems.Add(item);
            }
            foreach(IOrderItem item in sideItems)
            {
                menuItems.Add(item);
            }
            foreach(IOrderItem item in drinkItems)
            {
                menuItems.Add(item);
            }
        }

        /// <summary>
        /// Returns list of entree items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Entrees()
        {           
            return entreeItems;
        }

        /// <summary>
        /// Returns list of side items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            return sideItems;
        }

        /// <summary>
        /// Returns list of drink items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            return drinkItems;
        }

        /// <summary>
        /// Returns list of all menu items
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            return menuItems;
        }
    }
}
