using Prism.Navigation.Regions;
using System.Windows.Input;
using ReactiveUI;

namespace InputValidationBug.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IRegionManager _regionManager;

        public ICommand NavigateCommand { get; private set; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            NavigateCommand = ReactiveCommand.Create<string>(Navigate);
            _regionManager = regionManager;
        }

        private void Navigate(string navigatePath)
        { 
            _regionManager.RequestNavigate("ContentRegion", navigatePath);
        }
    }
}
