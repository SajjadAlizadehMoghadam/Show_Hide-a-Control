using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Show_Hide_a_Control
{
    internal class AppViewModdel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChange(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }


        public AppViewModdel()
        {
            IspanelVisible = false;
        }

        bool ispanelVisible;

       public bool IspanelVisible
        {
            get
            {
                return ispanelVisible;
            }
            set
            {
                ispanelVisible = value;
                OnPropertyChange("IspanelVisible");
            }
        }




    }
}
