using System;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace MvvX.ViewModelCommands
{
    /// <summary>
    /// Command
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ViewModelCommand<T> : BaseCommand<T>, IMvxCommand where T : IMvxViewModel
    {
        #region CanExecute

        public virtual bool CanExecute()
        {
            return true;
        }

        [Obsolete("Use the strongly typed version of CanExecute instead", false)]
        public virtual bool CanExecute(object parameter)
        {
            return CanExecute();
        }

        #endregion

        #region Execute

        public abstract void Execute();

        [Obsolete("Use the strongly typed version of CanExecute instead", false)]
        public virtual void Execute(object parameter)
        {
            Execute();
        }

        #endregion
    }
}
