using System;
using NHibernate.Burrow.AppBlock.EntityBases;

namespace nhibernate_burrow_with_dapper
{
    public class Brand : PersistantObj<int>
    {
        #region fields

        #endregion

        #region Constrcutors

        #endregion

        #region Public Properties

        /// <summary>
        ///     for nhibernate to use
        /// </summary>
        /// <summary>
        ///     Gets, Sets the Name of the Brand
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        ///     Gets, Sets the Abbreviation of the Brand
        /// </summary>
        public virtual string Abbrev { get; set; }

        /// <summary>
        ///     Gets, Sets the Abbreviation of the Brand
        /// </summary>
        public virtual bool IsDisabled { get; set; }

        /// <summary>
        ///     Gets, Sets the Unique Identifier for this Document
        /// </summary>
        /// <remarks></remarks>
        public override int Id { get; set; }

        /// <summary>
        ///     Gets the BusinessKey, that is, <see cref="Id" /> for this plan
        /// </summary>
        public override IComparable BusinessKey
        {
            get { return Id; }
        }

        #endregion

        #region Public Methods

        #endregion
    }
}