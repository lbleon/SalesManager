using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SalesManager.Model;
using SalesManager.SQLiteDAL;

namespace SalesManager.BLL
{
    public class ProductController
    {
        #region Members

        private BrandList brandList = null;
        private ProductTypeList productTypeList = null;
        private ProductList productList = null;

        #endregion

        #region Constructor

        public ProductController()
        {
            
        }

        #endregion

        #region Methods

        public ProductList GetProducts()
        {
            if (productList == null)
            {
                productList = ProductLoader.LoadProducts(GetProductTypes(), GetBrands());
            }
            return productList;
        }

        public BrandList GetBrands()
        {
            if (brandList == null)
            {
                brandList = BrandLoader.LoadBrands();
            }
            return brandList;
        }

        public ProductTypeList GetProductTypes()
        {
            if (productTypeList == null)
            {
                productTypeList = ProductTypeLoader.LoadProductTypeList();
            }
            return productTypeList;
        }

        #endregion
    }
}
