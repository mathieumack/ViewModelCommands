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

        /// <summary>
        /// Check that the Command can be executed
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Execute your command with parameter
        /// </summary>
        /// <param name="parameter">Parameter that can be null</param>
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
