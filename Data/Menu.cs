using System;
using System.Collections.Generic;
using System.Linq;
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
            entreeItems.Add(new DakotaDoubleBurger());
            entreeItems.Add(new PecosPulledPork());
            entreeItems.Add(new RustlersRibs());
            entreeItems.Add(new TexasTripleBurger());
            entreeItems.Add(new TrailBurger());           
            
            sideItems.Add(new BakedBeans());
            sideItems.Add(new ChiliCheeseFries());
            sideItems.Add(new CornDodgers());
            sideItems.Add(new PanDeCampo());

            drinkItems.Add(new CowboyCoffee());
            drinkItems.Add(new JerkedSoda());
            drinkItems.Add(new TexasTea());            
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

        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> items, string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            
            if (terms == null) return items;

            foreach (IOrderItem item in items)
            {
                if (item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                    results.Add(item);
            }

            return results;
        }

        public static string[] Categories
        {
            get => new string[]
            {
                "Entrees",
                "Sides",
                "Drinks"
            };
        }

        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> categories)
        {
            if (categories == null || categories.Count() == 0) return items;

            List<IOrderItem> results = new List<IOrderItem>();

            foreach (IOrderItem item in items)
            {
                if (item is Entree && categories.Contains("Entrees"))
                    results.Add(item);
                else if (item is Side && categories.Contains("Sides"))
                    results.Add(item);
                else if (item is Drink && categories.Contains("Drinks"))
                    results.Add(item);
            }

            return results;
        }

        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {
            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max) results.Add(item);
            }
            return results;
        }

        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max) results.Add(item);
            }
            return results;
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
