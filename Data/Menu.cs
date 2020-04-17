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

        public static IEnumerable<IOrderItem> Entrees()
        {           
            return entreeItems;
        }

        public static IEnumerable<IOrderItem> Sides()
        {
            return sideItems;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            return drinkItems;
        }

        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            return menuItems;
        }
    }
}
