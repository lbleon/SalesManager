using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using SalesManager.Control.ExchangeRateService;
using SalesManager.IDAL;

namespace SalesManager.ExchangeRateDAL
{
    public class ExchangeRateUpdater : IExchangeRateUpdater
    {
        #region Implementation of IExchangeRateUpdater

        public DataSet GetExchangeRate()
        {
            ExchangeRateWebService exchangeRate = new ExchangeRateWebService();
            DataSet dataSet = exchangeRate.getExchangeRate("A");
            return dataSet;
        }

        #endregion
    }
}
