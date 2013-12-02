using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesManager.Model
{
    public class BrandList
    {
        #region Properties

        public List<Brand> Brands { get; private set; } 

        #endregion

        #region Constructor

        public BrandList()
        {
            Brands = new List<Brand>();
        }

        #endregion

        #region Methods

        public void AddBrand(Brand brand)
        {
            Brands.Add(brand);
        }

        public void RemoveBrand(Brand brand)
        {
            Brands.Remove(brand);
        }

        public Brand GetBrand(int id)
        {
            Brand result = Brands.Find(brand => brand.ID == id);
            return result;
        }

        #endregion
    }
}
