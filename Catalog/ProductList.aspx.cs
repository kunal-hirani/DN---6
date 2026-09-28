using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingtipToys.Models;

namespace WingtipToys.Catalog
{
    public partial class ProductList : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public IQueryable<Product> GetProducts(
            [QueryString("id")] int? categoryId,
            [RouteData] string categoryName)
        {
            var query = ProductDatabase.GetProducts().AsQueryable();

            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }

            if (!string.IsNullOrEmpty(categoryName))
            {
                query = query.Where(p =>
                    string.Equals(p.CategoryName, categoryName, StringComparison.OrdinalIgnoreCase));
            }

            return query;
        }
    }
}
