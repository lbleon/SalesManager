using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesManager.Model
{
    public class Brand
    {
        #region Properties

        public int ID { get; private set; }
        public string Name { get; set; }

        #endregion

        #region Constructor
        
        public Brand(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public Brand(string name)
        {
            ID = -1;
            Name = name;
        }

        #endregion
    }
}
