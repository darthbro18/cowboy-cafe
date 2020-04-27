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

        public IEnumerable<IOrderItem> Items { get; protected set; }
        
        [BindProperty]
        public string SearchTerms { get; set; }

        [BindProperty]
        public string[] Categories { get; set; }

        [BindProperty]
        public int? CaloriesMin { get; set; }

        [BindProperty]
        public int? CaloriesMax { get; set; }

        [BindProperty]
        public double? PriceMin { get; set; }

        [BindProperty]
        public double? PriceMax { get; set; }
        
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
