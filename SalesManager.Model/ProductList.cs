using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesManager.Model
{
    public class ProductList
    {
        #region Properties

        public List<Product> Products { get; private set; }  

        #endregion

        #region Constructor

        public ProductList()
        {
            Products = new List<Product>();
        }

        #endregion

        #region Methods

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        #endregion
    }
}
