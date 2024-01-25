using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Show_Hide_a_Control
{
    internal class AppViewModdel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChange(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }


        bool _ispanlShow;

        public AppViewModdel()
        {
            _ispanlShow = false;
        }

        public bool IspanlShow
        {
            get { return _ispanlShow; }
            set
            {
                _ispanlShow = value;
                OnPropertyChange("IspanlShow");
            }
        }

    }
}
