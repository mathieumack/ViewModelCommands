using System;

namespace MvvX.ViewModelCommands
{
    /// <summary>
    /// Base command
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseCommand<T>
    {
        #region View Model

        public T ViewModel { get; private set; }

        public virtual void Configure(T viewModel)
        {
            ViewModel = viewModel;
        }

        #endregion

        #region CanExecute changed event

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler CanExecuteChanged;

        #endregion
    }
}
