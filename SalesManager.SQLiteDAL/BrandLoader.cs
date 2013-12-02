using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using SalesManager.Model;

namespace SalesManager.SQLiteDAL
{
    public class BrandLoader
    {
        #region Methods

        public static BrandList LoadBrands()
        {
            DataTable dataTable = DBAccessor.QueryBrands();
            if (dataTable == null)
            {
                return null;
            }
            BrandList brandList = new BrandList();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Brand brand = LoadBrand(dataRow);
                brandList.AddBrand(brand);
            }
            return brandList;
        }

        private static Brand LoadBrand(DataRow dataRow)
        {
            int id = Convert.ToInt32(dataRow["BID"]);
            string name = dataRow["BrandName"].ToString();
            Brand brand = new Brand(id, name);
            return brand;
        }

        #endregion
    }
}
