using System;
using MvvmCross.Core.ViewModels;

namespace MvvX.ViewModelCommands
{
    public abstract class ViewModelCommand<T> : IBaseCommand where T : MvxViewModel
    {
        public T ViewModel { get; private set; }

        public virtual void Execute()
        {
            Execute(null);
        }

        public abstract void Execute(object parameter);

        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        public virtual void Configure(T viewModel)
        {
            this.ViewModel = viewModel;
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler CanExecuteChanged;
    }
}
