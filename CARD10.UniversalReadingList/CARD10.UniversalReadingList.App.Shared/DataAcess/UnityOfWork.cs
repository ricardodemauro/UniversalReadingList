using CARD10.UniversalReadingList.App.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace CARD10.UniversalReadingList.App.DataAcess
{
    public class UnityOfWork : IDisposable
    {
        public Datasource Datasource { get; private set; }

        private bool disposed;

        private ICategoryDAL category;
        public ICategoryDAL Category
        {
            get { return category ?? DALFactory.GetCategory(Datasource); }
            set { category = value; }
        }

        private IReadItemDAL readItem;
        public IReadItemDAL ReadItem
        {
            get { return readItem ?? DALFactory.GetReadItem(Datasource); }
            set { readItem = value; }
        }

        public UnityOfWork(Datasource datasource)
        {
            this.Datasource = datasource;
        }

        public UnityOfWork(Datasource datasource, ICategoryDAL categoryDal, IReadItemDAL readItemDal)
        {
            this.Datasource = datasource;
            this.Category = categoryDal;
            this.ReadItem = readItem;
        }

        #region Dispose
        public void Dispose()
        {
            if (!disposed)
            {
                Dispose(true);
                disposed = true;
            }
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                category = null;
                readItem = null;
            }
        }

        ~UnityOfWork()
        {
            if (!disposed)
                Dispose(!disposed);
        }
        #endregion Dispose
    }
}
