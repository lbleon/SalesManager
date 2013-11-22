using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using SalesManager.ExchangeRateService;

namespace SalesManager
{
    internal class ExchangeRateUpdater
    {
        private void Test()
        {
            ExchangeRateWebService exchangeRate = new ExchangeRateWebService();
            DataSet dataSet = exchangeRate.getExchangeRate("A");
            return;
        }
    }
}
