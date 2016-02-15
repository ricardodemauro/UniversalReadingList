using CARD10.UniversalReadingList.App.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace CARD10.UniversalReadingList.App.DataAcess
{
    public class UnityOfWork
    {
        public ICategoryDAL Category { get; set; }

        public IReadItemDAL ReadItem { get; set; }

        public UnityOfWork(Datasource datasource)
        {

        }
    }
}
