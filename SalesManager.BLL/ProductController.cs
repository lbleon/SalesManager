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

        public bool AddProductType(string typeName, int parentID)
        {
            int id = DBAccessor.AddProductType(typeName, parentID);
            if (id == -1)
            {
                return false;
            }
            ProductType type = new ProductType(id, typeName, parentID);
            productTypeList.AddType(type);
            return true;
        }

        public void DeleteProductType(ProductType type)
        {
            productTypeList.RemoveType(type);
            DBAccessor.DeleteProductType(type.ID);
        }

        #endregion
    }
}
