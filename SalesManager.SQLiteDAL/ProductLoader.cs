using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using SalesManager.Common;
using SalesManager.Model;

namespace SalesManager.SQLiteDAL
{
    public class ProductLoader
    {
        #region Constructor

        public ProductLoader()
        {
            
        }

        #endregion

        #region Methods

        public static ProductList LoadProducts(ProductTypeList productTypeList, BrandList brandList)
        {
            if (productTypeList == null || brandList == null)
            {
                return null;
            }
            ProductList productList = LoadProductList(productTypeList, brandList);
            return productList;
        }

        private static ProductList LoadProductList(ProductTypeList productTypeList, BrandList brandList)
        {
            DataTable dataTable = DBAccessor.QueryProducts();
            if (dataTable == null)
            {
                return null;
            }
            ProductList productList = new ProductList();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Product product = LoadProduct(dataRow, productTypeList, brandList);
                if (product == null)
                {
                    continue;
                }
                productList.AddProduct(product);
            }
            return productList;
        }

        private static Product LoadProduct(DataRow dataRow, ProductTypeList productTypeList, BrandList brandList)
        {
            int id = Convert.ToInt32(dataRow["PID"]);
            int typeID = Convert.ToInt32(dataRow["ProductType"]);
            int brandID = Convert.ToInt32(dataRow["Brand"]);
            string name = dataRow["ProductName"].ToString();
            string remark = dataRow["Remark"].ToString();
            ProductType type = productTypeList.GetType(typeID);
            if (type == null)
            {
                Log.Write("LoadProduct failed. Can't find type:" + typeID.ToString());
                return null;
            }
            Brand brand = brandList.GetBrand(brandID);
            if (brand == null)
            {
                Log.Write("LoadProduct failed. Can't find brand:" + brandID.ToString());
                return null;
            }
            Product result = new Product(id, type, name, brand, remark);
            return result;
        }

        #endregion
    }
}
