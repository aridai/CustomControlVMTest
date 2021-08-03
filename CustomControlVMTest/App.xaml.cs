using Prism.Ioc;
using Prism.Unity;

namespace CustomControlVMTest
{
    public partial class App : PrismApplication
    {
        public App()
        {
            this.InitializeComponent();
        }

        protected override void OnInitialized()
        {
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
        }
    }
}
