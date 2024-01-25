using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Show_Hide_a_Control
{
    internal class ReplyCommand : ICommand
    {
        readonly Action<object> _action;
        readonly Predicate<object> _predicate;


        public ReplyCommand(Action<object> action)
        {
            _action = action;
            _predicate = null;
        }

        public event EventHandler CanExecuteChanged {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }

        }

        public bool CanExecute(object parameter)
        {
            return _predicate == null || CanExecute(parameter);
        }

        public void Execute(object parameter)
        {
           _action(parameter);
        }
    }
}
