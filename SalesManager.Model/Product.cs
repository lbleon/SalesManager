using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesManager.Model
{
    public class Product
    {
        #region Properties

        public int ID { get; set; }
        public ProductType Type { get; set; }
        public string Name { get; set; }
        public Brand Brand { get; set; }
        public string Remark { get; set; }

        #endregion

        #region Constructor

        public Product(int id, ProductType type, string name, Brand brand, string remark)
        {
            ID = id;
            Type = type;
            Name = name;
            Brand = brand;
            Remark = remark;
        }

        public Product(ProductType type, string name, Brand brand, string remark)
        {
            ID = -1;
            Type = type;
            Name = name;
            Brand = brand;
            Remark = remark;
        }

        #endregion
    }
}
