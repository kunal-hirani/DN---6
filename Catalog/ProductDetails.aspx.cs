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
    public partial class ProductDetails : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public IQueryable<Product> GetProduct(
            [QueryString("productID")] int? productId,
            [RouteData] string productName)
        {
            var query = ProductDatabase.GetProducts().AsQueryable();

            if (productId.HasValue && productId > 0)
            {
                query = query.Where(p => p.ProductID == productId);
            }
            else if (!string.IsNullOrEmpty(productName))
            {
                query = query.Where(p =>
                    string.Equals(p.ProductName, productName, StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                query = null;
            }

            return query;
        }
    }
}
