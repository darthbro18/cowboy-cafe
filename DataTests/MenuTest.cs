using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.Linq;

namespace CowboyCafe.DataTests
{
    public class MenuTest
    {
        //Entrees should contain every entree in the menu
        [Fact]
        public void MenuEntreesShouldContainExpectedItems()
        {
            var entrees = new List<IOrderItem>(Menu.Entrees);
            entrees.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                entrees,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); }
                );
        }

        //Sides should contain chili cheese fries, baked beans, corn dodgers, and pan de campo
        [Fact]
        public void MenuSidesShouldContainExpectedItems()
        {
            Assert.Collection(
                Menu.Sides,
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); }
                );
        }

        //Drinks should contain cowboy coffee, jerked soda, texas tea, and water
        [Fact]
        public void MenuDrinksShouldContainExpectedItems()
        {
            Assert.Collection(
                Menu.Drinks,
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); },
                (w) => { Assert.IsType<Water>(w); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        //CompleteMenu should contain all menu items
        [Fact]
        public void CompleteMenuShouldContainAllMenuItems()
        {
            Assert.Collection(
                Menu.All,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cch) => { Assert.IsType<CowpokeChili>(cch); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); },
                (w) => { Assert.IsType<Water>(w); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        //Search function should return items that contain given string
        [Theory]
        [InlineData("burger")]
        [InlineData("")]
        [InlineData("BuRGer")]
        [InlineData("tea")]
        [InlineData("nonexistent item")]
        public void SearchShouldReturnItemsThatContainGivenString(string searchTerm)
        {
            IEnumerable<IOrderItem> items = new List<IOrderItem>
            {
                new TrailBurger(),
                new DakotaDoubleBurger(),
                new TexasTripleBurger(),
                new RustlersRibs(),
                new PanDeCampo(),
                new ChiliCheeseFries(),
                new Water()
            };

            IEnumerable<IOrderItem> results = Menu.Search(items, searchTerm);
            foreach (IOrderItem i in results)
            {
                Assert.True(i.ToString().Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase) || searchTerm == null);
            }
        }

        //FilterByCategory should return items that belong in the given categories
        [Theory]
        [InlineData("Entrees")]
        [InlineData("Sides")]
        [InlineData("Drinks")]
        [InlineData(null)]
        [InlineData("Entrees", "Drinks")]
        public void FilterByCategoryShouldContainExpectedItems(params string[] terms)
        {
            IEnumerable<IOrderItem> items = new List<IOrderItem>
            {
                new TrailBurger(),
                new DakotaDoubleBurger(),
                new TexasTripleBurger(),
                new RustlersRibs(),
                new PanDeCampo(),
                new ChiliCheeseFries(),
                new Water()
            };

            IEnumerable<string> categories = terms;

            IEnumerable<IOrderItem> results = Menu.FilterByCategory(items, categories);

            if (categories == null || categories.Count() == 0)
                Assert.Equal(items, results);

            else
            {
                foreach (IOrderItem item in results)
                {
                    if (item is Entree)
                        Assert.Contains("Entrees", categories);
                    else if (item is Side)
                        Assert.Contains("Sides", categories);
                    else if (item is Drink)
                        Assert.Contains("Drinks", categories);
                }
            }            
        }

        //FilterByCalories should return items that are in given calorie range
        [Theory]
        [InlineData(100, 300)]
        [InlineData(0, 1000)]
        [InlineData(null, 200)]
        [InlineData(100, null)]
        [InlineData(null, null)]
        public void FilterByCaloriesShouldContainExpectedItems(int? min, int? max)
        {
            IEnumerable<IOrderItem> items = new List<IOrderItem>
            {
                new TrailBurger(),
                new DakotaDoubleBurger(),
                new TexasTripleBurger(),
                new RustlersRibs(),
                new PanDeCampo(),
                new ChiliCheeseFries(),
                new Water()
            };

            IEnumerable<IOrderItem> results = Menu.FilterByCalories(items, min, max);

            if (min == null && max == null)
                Assert.Equal(items, results);
            
            else
            {
                foreach (IOrderItem item in results)
                {
                    if (min == null)
                        Assert.InRange<int>((int)item.Calories, 0, (int)max);
                    else if (max == null)
                        Assert.InRange<int>((int)item.Calories, (int)min, 1500);
                    else
                        Assert.InRange<int>((int)item.Calories, (int)min, (int)max);
                }
            }
            
        }

        //FilterByPrice should return items that are in given price range
        [Theory]
        [InlineData(1.00, 5.00)]
        [InlineData(0.00, 15.00)]
        [InlineData(null, 2.00)]
        [InlineData(1.00, null)]
        [InlineData(null, null)]
        public void FilterByPriceShouldContainExpectedItems(double? min, double? max)
        {
            IEnumerable<IOrderItem> items = new List<IOrderItem>
            {
                new TrailBurger(),
                new DakotaDoubleBurger(),
                new TexasTripleBurger(),
                new RustlersRibs(),
                new PanDeCampo(),
                new ChiliCheeseFries(),
                new Water()
            };

            IEnumerable<IOrderItem> results = Menu.FilterByPrice(items, min, max);

            if (min == null && max == null)
                Assert.Equal(items, results);

            else
            {
                foreach (IOrderItem item in results)
                {
                    if (min == null)
                        Assert.InRange<double>((double)item.Price, 0.00, (double)max);
                    else if (max == null)
                        Assert.InRange<double>((double)item.Price, (double)min, 15.00);
                    else
                        Assert.InRange<double>((double)item.Price, (double)min, (double)max);
                }
            }

        }
    }
}
