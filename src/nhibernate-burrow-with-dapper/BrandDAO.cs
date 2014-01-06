using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Criterion;

namespace nhibernate_burrow_with_dapper
{
    public class BrandDAO : NHibernate.Burrow.AppBlock.DAOBases.GenericDAO<Brand>
    {
        private static readonly BrandDAO instance = new BrandDAO();

        public static BrandDAO Instance {
            get { return instance; }
        }

    }
}