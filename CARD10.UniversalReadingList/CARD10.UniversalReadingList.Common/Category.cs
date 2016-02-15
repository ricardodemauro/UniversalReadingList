using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARD10.UniversalReadingList.Common
{
    public class Category
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public ICollection<ReadItem> ReadItemCollection { get; set; }
    }
}
