using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CARD10.UniversalReadingList.Common.Infrastructure
{
    public class ModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void Set<T>(ref T storage, T value, [CallerMemberName]string callerMember = null)
        {
            if (object.Equals(storage, value))
            {
                storage = value;

                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(callerMember));
            }
        }
    }
}
