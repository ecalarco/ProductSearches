using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductSearches.Models;

namespace ProductSearches.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ProductSearches.Models.ProductContext _context;

        public IndexModel(ProductSearches.Models.ProductContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync(string searchID,
                                     string searchDescription,
                                     string searchLastSold,
                                     string searchShelfLife,
                                     string searchDepartment,
                                     string searchPrice,
                                     string searchUnit,
                                     string searchXFor,
                                     string searchCost)
        {
            //retreive all products from the database
            var products = from p in _context.Products
                           select p;

            if (!String.IsNullOrEmpty(searchID))
            {
                products = products.Where(s => s.ProductID.Equals(Convert.ToInt32(searchID)));
            }

            if (!String.IsNullOrEmpty(searchDescription))
            {
                products = products.Where(s => s.Description.Equals(searchDescription));
            }

            if (!String.IsNullOrEmpty(searchLastSold))
            {
                products = products.Where(s => s.LastSold.Equals(DateTime.Parse(searchLastSold)));
            }

            if (!String.IsNullOrEmpty(searchShelfLife))
            {
                products = products.Where(s => s.ShelfLife.Equals(searchShelfLife));
            }

            if (!String.IsNullOrEmpty(searchDepartment))
            {
                products = products.Where(s => s.Department.Equals(searchDepartment));
            }

            if (!String.IsNullOrEmpty(searchPrice))
            {
                products = products.Where(s => s.Price.Equals(Convert.ToDecimal(searchPrice)));
            }

            if (!String.IsNullOrEmpty(searchUnit))
            {
                products = products.Where(s => s.Unit.Equals(Convert.ToInt32(searchUnit)));
            }

            if (!String.IsNullOrEmpty(searchXFor))
            {
                products = products.Where(s => s.XFor.Equals(searchXFor));
            }

            if (!String.IsNullOrEmpty(searchCost))
            {
                products = products.Where(s => s.Cost.Equals(Convert.ToDecimal(searchCost)));
            }

            Product = await products.ToListAsync();
        }
    }
}
