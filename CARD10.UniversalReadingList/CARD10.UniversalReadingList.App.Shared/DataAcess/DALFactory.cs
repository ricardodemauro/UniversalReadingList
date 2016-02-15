using CARD10.UniversalReadingList.App.Infrastructure;
using CARD10.UniversalReadingList.App.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CARD10.UniversalReadingList.App.DataAcess
{
    public static class DALFactory
    {
        public static ICategoryDAL GetCategory(Datasource datasource)
        {
            return new CategoryRepository()
        }
    }
}
