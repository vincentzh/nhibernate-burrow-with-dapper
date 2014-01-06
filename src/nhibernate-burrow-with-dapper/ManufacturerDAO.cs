using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Criterion;

namespace nhibernate_burrow_with_dapper
{
    public class ManufacturerDAO : NHibernate.Burrow.AppBlock.DAOBases.GenericDAO<Manufacturer>
    {
        private static readonly ManufacturerDAO instance = new ManufacturerDAO();

        public static ManufacturerDAO Instance {
            get { return instance; }
        }

    }
}