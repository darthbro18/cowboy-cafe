using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class MenuTest
    {
        //Entrees should contain every entree in the menu
        [Fact]
        public void MenuEntreesShouldContainExpectedItems()
        {
            var entrees = new List<IOrderItem>(Menu.Entrees());
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
            var sides = new List<IOrderItem>(Menu.Sides());
            sides.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                sides,
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); }
                );
        }

        //Drinks should contain cowboy coffee, jerked soda, texas tea, and water
        [Fact]
        public void MenuDrinksShouldContainExpectedItems()
        {
            var drinks = new List<IOrderItem>(Menu.Drinks());
            drinks.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                drinks,
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        //CompleteMenu should contain all menu items
        [Fact]
        public void CompleteMenuShouldContainAllMenuItems()
        {
            Assert.Collection(
                Menu.CompleteMenu(),
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cch) => { Assert.IsType<CowpokeChili>(cch); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (ccof) => { Assert.IsType<CowboyCoffee>(ccof); },
                (js) => { Assert.IsType<JerkedSoda>(js); },              
                (tt) => { Assert.IsType<TexasTea>(tt); },              
                (w) => { Assert.IsType<Water>(w); }
                );
        }
    }
}
