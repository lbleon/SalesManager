using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using SalesManager.Common;

namespace SalesManager.SQLiteDAL
{
    public class ProductAccessor
    {
        #region Methods

        public static DataTable QueryBrands()
        {
            string sql = "select * from BrandList";
            DataTable result = null;
            try
            {
                result = SQLiteDBHelper.ExecuteDataTable(sql);
            }
            catch (Exception e)
            {
                result = null;
                Log.Write("QueryBrands failed. exception is: " + e.Message);
            }
            return result;
        }

        public static DataTable QueryProductTypes()
        {
            string sql = "select * from ProductType";
            DataTable result = null;
            try
            {
                result = SQLiteDBHelper.ExecuteDataTable(sql);
            }
            catch (Exception e)
            {
                result = null;
                Log.Write("QueryProductTypes failed. exception is: " + e.Message);
            }
            return result;
        }

        #endregion
    }
}
