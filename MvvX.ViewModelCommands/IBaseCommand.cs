using System.Windows.Input;

namespace MvvX.ViewModelCommands
{
    public interface IBaseCommand : ICommand
    {
        void RaiseCanExecuteChanged();
    }
}
