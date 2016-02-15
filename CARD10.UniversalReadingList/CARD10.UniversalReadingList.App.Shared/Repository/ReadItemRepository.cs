using CARD10.UniversalReadingList.App.DataAcess;
using CARD10.UniversalReadingList.App.Infrastructure;
using CARD10.UniversalReadingList.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CARD10.UniversalReadingList.App.Repository
{
    internal class ReadItemRepository : RepositoryBase<ReadItem>, IReadItemDAL
    {
        internal Datasource Datasource { get; private set; }

        internal ReadItemRepository(Datasource datasource)
        {
            this.Datasource = datasource;
        }
    }
}
