using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Commands
{
    // Execute a bool using class asynccommandbase with child command base
    public abstract class AsyncCommandBase : CommandBase
    {
        private bool _isExecuting;
        private bool IsExecuting
        {
            get
            {
                return _isExecuting;
            }
            set
            {
                _isExecuting = value;
                OnCanExecutedChanged();
            }
        }

        public override bool CanExecute(object parameter)
        {
            return !IsExecuting && base.CanExecute(parameter);
        }

        public override async void Execute(object parameter)
        {
            IsExecuting = true;

            try
            {
                await ExecuteAsync(parameter);
            }
            finally
            {
                IsExecuting = false;
            }
        }
        // Abstract task that will execute async method
        public abstract Task ExecuteAsync(object parameter);
    }
}
