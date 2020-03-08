using ISUF.UI.Views;
using System;
using Template10.Services.NavigationService;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BrnoParkingIS.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Shell : ShellBase
    {
        public Shell(string appDisplayName, Type mainPageType, Type settingsPageType, INavigationService navigationService) : base(appDisplayName, mainPageType, settingsPageType, navigationService)
        {
            this.InitializeComponent();

            Loading += Shell_Loading;
        }

        private void Shell_Loading(FrameworkElement sender, object args)
        {
            AddControls();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
        }
    }
}
