using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesManager.Model
{
    public class ProductType
    {
        #region Properties

        public int ID { get; private set; }
        public string Name { get; set; }
        public int ParentID { get; set; }

        #endregion

        #region Constructor

        public ProductType(int id, string name, int parentID)
        {
            ID = id;
            Name = name;
            ParentID = parentID;
        }

        #endregion
    }
}
