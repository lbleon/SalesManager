using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using SalesManager.Model;

namespace SalesManager.SQLiteDAL
{
    public class ProductTypeLoader
    {
        #region Methods

        public static ProductTypeList LoadProductTypeList()
        {
            DataTable dataTable = DBAccessor.QueryProductTypes();
            if (dataTable == null)
            {
                return null;
            }
            ProductTypeList productTypeList = new ProductTypeList();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                ProductType productType = LoadProductType(dataRow);
                productTypeList.AddType(productType);
            }
            return productTypeList;
        }

        private static ProductType LoadProductType(DataRow dataRow)
        {
            int id = Convert.ToInt32(dataRow["PID"]);
            string name = dataRow["ProductType"].ToString();
            int parentID = Convert.ToInt32(dataRow["ParentPID"]);
            ProductType productType = new ProductType(id, name, parentID);
            return productType;
        }

        #endregion
    }
}
