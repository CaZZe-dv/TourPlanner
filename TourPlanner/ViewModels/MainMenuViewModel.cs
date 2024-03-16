using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TourPlanner.Commands;

namespace TourPlanner.ViewModels
{
    public class MainMenuViewModel : ViewModelBase
    {
        public ICommand MainMenuFileCommand { get; }
        public ICommand MainMenuEditCommand { get; }
        public ICommand MainMenuOptionsCommand { get; }
        public ICommand MainMenuHelpCommand { get; }

        public MainMenuViewModel()
        {
            TestCommand testCommand = new TestCommand();
            MainMenuFileCommand = testCommand;
            MainMenuEditCommand = testCommand;
            MainMenuOptionsCommand = testCommand;
            MainMenuHelpCommand = testCommand;
        }
    }
}
