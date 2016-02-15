using CARD10.UniversalReadingList.App.Infrastructure;
using CARD10.UniversalReadingList.App.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CARD10.UniversalReadingList.App.DataAcess
{
    internal static class DALFactory
    {
        internal static ICategoryDAL GetCategory(Datasource datasource)
        {
            return new CategoryRepository(datasource);
        }

        internal static IReadItemDAL GetReadItem(Datasource datasource)
        {
            return new ReadItemRepository(datasource);
        }

        internal static UnityOfWork GetUnityOfWork(Datasource datasource)
        {
            return new UnityOfWork(datasource);
        }
    }
}
