using System;
using System.Collections.Generic;
using Iesi.Collections.Generic;
using NHibernate.Burrow.AppBlock.EntityBases;

namespace nhibernate_burrow_with_dapper
{
    
    public class Manufacturer : PersistantObj<int>
    {
        readonly Iesi.Collections.Generic.ISet<Brand> brands =
            new HashedSet<Brand>();

        public string Name { get; set; }

        public ICollection<Brand> Brands
        {
            get { return brands; }
        }

        public override IComparable BusinessKey
        {
            get { return Id; }
        }

        public override int Id { get; set; }

        public void AddBrand(Brand brand)
        {
            if (!brands.Contains(brand))
                brands.Add(brand);
        }

        public void RemoveBrand(Brand brand)
        {
            if (brands.Contains(brand))
                brands.Remove(brand);
        }
    }
}