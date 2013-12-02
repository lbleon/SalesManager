using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using SalesManager.Common;

namespace SalesManager.SQLiteDAL
{
    public class DBAccessor
    {
        #region Methods

        public static DataTable QueryBrands()
        {
            string sql = "select * from BrandList";
            DataTable result = QueryDataTable(sql, "QueryBrands");
            return result;
        }

        public static DataTable QueryProductTypes()
        {
            string sql = "select * from ProductType";
            DataTable result = QueryDataTable(sql, "QueryProductTypes");
            return result;
        }

        public static DataTable QueryProducts()
        {
            string sql = "select * from Product";
            DataTable result = QueryDataTable(sql, "QueryProducts");
            return result;
        }

        private static DataTable QueryDataTable(string sql, string functionName)
        {
            DataTable result = null;
            try
            {
                result = SQLiteDBHelper.ExecuteDataTable(sql);
            }
            catch (Exception e)
            {
                result = null;
                Log.Write(functionName + " failed. exception is: " + e.Message);
            }
            return result;
        }

        #endregion
    }
}
