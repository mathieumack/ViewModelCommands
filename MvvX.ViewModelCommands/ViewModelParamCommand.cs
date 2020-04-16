using System;
using MvvmCross.Base;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace MvvX.ViewModelCommands
{
    /// <summary>
    /// Command with parameter
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="P"></typeparam>
    public abstract class ViewModelCommand<T, P> : BaseCommand<T>, IMvxCommand<P> where T : IMvxViewModel
    {
        #region CanExecute

        public virtual bool CanExecute(P parameter)
        {
            return true;
        }

        [Obsolete("Use the strongly typed version of CanExecute instead", false)]
        public virtual bool CanExecute(object parameter)
        {
            var safeParameter = (P)typeof(P).MakeSafeValueCore(parameter);
            return CanExecute(safeParameter);
        }

        #endregion

        #region Execute

        public abstract void Execute(P parameter);

        [Obsolete("Use the strongly typed version of Execute instead", false)]
        public virtual void Execute(object parameter)
        {
            var safeParameter = (P)typeof(P).MakeSafeValueCore(parameter);
            Execute(safeParameter);
        }

        #endregion
    }
}
