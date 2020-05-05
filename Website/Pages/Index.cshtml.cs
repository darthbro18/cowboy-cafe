using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        //The items that are displayed on the page (initially it's all IOrderItems)
        public IEnumerable<IOrderItem> Items { get; protected set; }
        
        //Displayed items must contain the search terms in the item name
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; }

        //Filter for what categories to show
        [BindProperty(SupportsGet = true)]
        public string[] Categories { get; set; }

        //Filter for min calories
        [BindProperty(SupportsGet = true)]
        public int? CaloriesMin { get; set; }

        //Filter for max calories
        [BindProperty(SupportsGet = true)]
        public int? CaloriesMax { get; set; }

        //Filter for min price
        [BindProperty(SupportsGet = true)]
        public double? PriceMin { get; set; }

        //Filter for max price
        [BindProperty(SupportsGet = true)]
        public double? PriceMax { get; set; }
        
        /// <summary>
        /// Every time page is loaded, the Items on display are updated if any search or filter is applied
        /// </summary>
        /// <param name="SearchTerms"></param>
        /// <param name="Categories"></param>
        /// <param name="CaloriesMin"></param>
        /// <param name="CaloriesMax"></param>
        /// <param name="PriceMin"></param>
        /// <param name="PriceMax"></param>
        public void OnGet()
        {
            /*Items = Menu.Search(Menu.All, SearchTerms);
            Items = Menu.FilterByCategory(Items, Categories);
            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);*/

            Items = Menu.All;
            //Search menu items for SearchTerms
            if (SearchTerms != null)
            {
                Items = from item in Items
                        where item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase)
                        select item;
            }
            //Filter by Category
            if (Categories != null && Categories.Count() != 0)
            {
                Items = from item in Items
                        where (item is Entree && Categories.Contains("Entrees")) || (item is Side && Categories.Contains("Sides")) || (item is Drink && Categories.Contains("Drinks"))
                        select item;
            }
            //Filter by Calories
            if (CaloriesMin == null && CaloriesMax != null)
            {
                Items = from item in Items
                        where item.Calories <= CaloriesMax
                        select item;
            }
            if (CaloriesMin != null && CaloriesMax == null)
            {
                Items = from item in Items
                        where item.Calories >= CaloriesMin
                        select item;
            }
            if (CaloriesMin != null && CaloriesMax != null)
            {
                Items = from item in Items
                        where item.Calories >= CaloriesMin && item.Calories <= CaloriesMax
                        select item;
            }
            //Filter by Price
            if (PriceMin == null && PriceMax != null)
            {
                Items = from item in Items
                        where item.Price <= PriceMax
                        select item;
            }
            if (PriceMin != null && PriceMax == null)
            {
                Items = from item in Items
                        where item.Price >= PriceMin
                        select item;
            }
            if (PriceMin != null && PriceMax != null)
            {
                Items = from item in Items
                        where item.Price >= PriceMin && item.Price <= PriceMax
                        select item;
            }
        }
    }
}
