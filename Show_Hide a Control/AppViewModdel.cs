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

        ICommand _showPanel;

        public void IsShowVisible()
        {
            IspanelVisible = true;
        }
       public  ICommand showPanel
        {
            get
            {
                if(_showPanel == null)
                {
                    _showPanel = new ReplyCommand(p => IsShowVisible());
                }
                return _showPanel;
            }
        }

        ICommand _hidepanel;
        public void IsHideVisible()
        {
            IspanelVisible = false;
        }

        public ICommand hidePanel
        {
            get
            {
                if(_hidepanel == null)
                {
                    _hidepanel = new ReplyCommand(p => IsHideVisible());
                }
                return _hidepanel;
            }
        }


        ICommand _closeApp;

        public void IsCloseApp(object obj)
        {
            MainWindow win = (MainWindow)obj;
            win.Close();
        }

        public ICommand CloseApp
        {
            get
            {
                if(_closeApp == null)
                {
                    _closeApp = new ReplyCommand(p => IsCloseApp(p));
                }
                return _closeApp;
            }
        }

    }
}
