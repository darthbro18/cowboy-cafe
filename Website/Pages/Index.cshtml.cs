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
        [BindProperty]
        public string SearchTerms { get; set; }

        //Filter for what categories to show
        [BindProperty]
        public string[] Categories { get; set; }

        //Filter for min calories
        [BindProperty]
        public int? CaloriesMin { get; set; }

        //Filter for max calories
        [BindProperty]
        public int? CaloriesMax { get; set; }

        //Filter for min price
        [BindProperty]
        public double? PriceMin { get; set; }

        //Filter for max price
        [BindProperty]
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
        public void OnGet(string SearchTerms, string[] Categories, int? CaloriesMin, int? CaloriesMax, double? PriceMin, double? PriceMax)
        {
            this.SearchTerms = SearchTerms;
            this.Categories = Categories;
            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;

            Items = Menu.Search(Menu.All, SearchTerms);
            Items = Menu.FilterByCategory(Items, Categories);
            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
        }
    }
}
