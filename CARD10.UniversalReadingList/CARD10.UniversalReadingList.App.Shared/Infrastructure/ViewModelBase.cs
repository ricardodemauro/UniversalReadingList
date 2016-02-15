using CARD10.UniversalReadingList.Common.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;

namespace CARD10.UniversalReadingList.App.Infrastructure
{
    public class ViewModelBase : ModelBase
    {
        public virtual Task OnNavigatedTo(object sender, NavigationEventArgs e)
        {
            return Task.FromResult<object>(null);
        }

        public virtual Task OnNavigatedFrom(object sender, NavigationEventArgs e)
        {
            return Task.FromResult<object>(null);
        }
    }
}
