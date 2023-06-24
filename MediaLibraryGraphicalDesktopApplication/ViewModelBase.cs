using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibraryGraphicalDesktopApplication
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChangedEventArgs args = new PropertyChangedEventArgs(propName);
            PropertyChanged?.Invoke(this, args);
        }
    }
}
