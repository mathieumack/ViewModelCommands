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

        /// <summary>
        /// Called to link the Command with the ViewModel
        /// </summary>
        /// <param name="viewModel"></param>
        public virtual void Configure(T viewModel)
        {
            ViewModel = viewModel;
        }

        #endregion

        #region CanExecute changed event

        /// <summary>
        /// Called when you need to refresh the CanExecute
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler CanExecuteChanged;

        #endregion
    }
}
