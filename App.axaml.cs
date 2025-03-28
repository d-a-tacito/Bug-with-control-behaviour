using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using InputValidationBug.Views;
using Prism.DryIoc;
using Prism.Ioc;
using Avalonia.Controls;
using Prism.Navigation.Regions;

namespace InputValidationBug
{
    public class App : PrismApplication
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
            base.Initialize();
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                var splashScreen = MainWindow;
                desktop.MainWindow = MainWindow as Window;

                var shell = CreateShell();

                RegionManager.SetRegionManager(shell, Container.Resolve<IRegionManager>());
                RegionManager.UpdateRegions();
            }
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IRegionNavigationContentLoader, RegionNavigationContentLoader>();

            containerRegistry.RegisterForNavigation<FirstView>();
            containerRegistry.RegisterForNavigation<Views.SecondView>();
        }

        protected override AvaloniaObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
    }
}