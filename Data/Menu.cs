using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        public static IEnumerable<IOrderItem> Entrees => new List<IOrderItem>
        {
            new AngryChicken(),
            new CowpokeChili(),
            new DakotaDoubleBurger(),
            new PecosPulledPork(),
            new RustlersRibs(),
            new TexasTripleBurger(),
            new TrailBurger()
        };

        public static IEnumerable<IOrderItem> Sides
        {
            get
            {
                List<IOrderItem> list = new List<IOrderItem>();
                foreach (Size size in Size.GetValues(typeof(Size)))
                {
                    BakedBeans bb = new BakedBeans();
                    bb.Size = size;
                    list.Add(bb);
                }
                foreach (Size size in Size.GetValues(typeof(Size)))
                {
                    ChiliCheeseFries ccf = new ChiliCheeseFries();
                    ccf.Size = size;
                    list.Add(ccf);
                }
                foreach (Size size in Size.GetValues(typeof(Size)))
                {
                    CornDodgers cd = new CornDodgers();
                    cd.Size = size;
                    list.Add(cd);
                }
                foreach (Size size in Size.GetValues(typeof(Size)))
                {
                    PanDeCampo pdc = new PanDeCampo();
                    pdc.Size = size;
                    list.Add(pdc);
                }
                return list;
            }
        }

        public static IEnumerable<IOrderItem> Drinks
        {
            get
            {
                List<IOrderItem> list = new List<IOrderItem>();
                foreach (Size size in Size.GetValues(typeof(Size)))
                {
                    CowboyCoffee cc = new CowboyCoffee();
                    cc.Size = size;
                    list.Add(cc);
                }
                foreach (Size size in Size.GetValues(typeof(Size)))
                {
                    JerkedSoda js = new JerkedSoda();
                    js.Size = size;
                    list.Add(js);
                }
                foreach (Size size in Size.GetValues(typeof(Size)))
                {
                    TexasTea tt = new TexasTea();
                    tt.Size = size;
                    list.Add(tt);
                }
                foreach (Size size in Size.GetValues(typeof(Size)))
                {
                    Water w = new Water();
                    w.Size = size;
                    list.Add(w);
                }
                return list;
            }
        }

        public static IEnumerable<IOrderItem> All
        {
            get
            {
                List<IOrderItem> list = new List<IOrderItem>();
                foreach (IOrderItem item in Entrees)
                {
                    list.Add(item);
                }
                foreach (IOrderItem item in Sides)
                {
                    list.Add(item);
                }
                foreach (IOrderItem item in Drinks)
                {
                    list.Add(item);
                }
                return list;
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
        
    }
}
