using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesManager.Model
{
    public class ProductTypeList
    {
        #region Properties

        public List<ProductType> Types { get; private set; } 

        #endregion

        #region Constructor

        public ProductTypeList()
        {
            Types = new List<ProductType>();
        }

        #endregion

        #region Methods

        public void AddType(ProductType type)
        {
            Types.Add(type);
        }

        public void RemoveType(ProductType type)
        {
            Types.Remove(type);
        }

        public ProductType GetType(int id)
        {
            ProductType result = Types.Find(type => type.ID == id);
            return result;
        }

        #endregion
    }
}
