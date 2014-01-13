using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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

        public static int AddProductType(string typeName, int parentID)
        {
            string sql = "insert into ProductType (producttype, ParentPID) values('"
                         + typeName + "'," + parentID.ToString() + ")";
            return ExcuteInsertReturnRowID(sql, "AddProductType");
        }

        public static void DeleteProductType(int pID)
        {
            string sql = "delete from ProductType where PID = " + pID.ToString();
            ExecuteNonQuery(sql, "DeleteProductType");
        }

        private static int ExecuteNonQuery(string sql, string functionName)
        {
            int result;
            try
            {
                result = SQLiteDBHelper.ExecuteNonQuery(sql);
            }
            catch (Exception e)
            {
                result = -1;
                Log.Write(functionName + " failed. exception is: " + e.Message);
            }
            return result;
        }

        private static int ExcuteInsertReturnRowID(string sql, string functionName)
        {
            int result;
            try
            {
                result = SQLiteDBHelper.ExcuteInsertReturnRowID(sql);
            }
            catch (Exception e)
            {
                result = -1;
                Log.Write(functionName + " failed. exception is: " + e.Message);
            }
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
