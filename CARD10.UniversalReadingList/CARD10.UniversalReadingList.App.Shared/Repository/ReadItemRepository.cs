using CARD10.UniversalReadingList.App.DataAcess;
using CARD10.UniversalReadingList.App.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace CARD10.UniversalReadingList.App.Repository
{
    internal class ReadItemRepository : IReadItemDAL
    {
        internal Datasource Datasource { get; private set; }

        internal ReadItemRepository(Datasource datasource)
        {
            this.Datasource = datasource;
        }
    }
}
