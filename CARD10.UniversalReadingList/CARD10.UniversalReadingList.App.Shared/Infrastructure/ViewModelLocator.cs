using CARD10.UniversalReadingList.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CARD10.UniversalReadingList.App.Infrastructure
{
    public class ViewModelLocator
    {
        public HomeViewModel Home
        {
            get
            {
                return new HomeViewModel();
            }
        }
    }
}
