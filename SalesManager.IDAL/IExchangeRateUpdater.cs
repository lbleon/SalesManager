using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SalesManager.IDAL
{
    public interface IExchangeRateUpdater
    {
        #region Interface

        DataSet GetExchangeRate();

        #endregion
    }
}
