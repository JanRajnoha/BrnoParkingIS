using BrnoParkingIS.ViewModels;
using ISUF.Base.Enum;
using ISUF.UI.Controls;
using ISUF.UI.Views;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BrnoParkingIS.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : MainPageBase
    {
        public MainPage() : base(typeof(MainPageViewModel))
        {
            InitializeComponent();
            Loading += MainPageLoading;
        }

        private void MainPageLoading(FrameworkElement sender, object args)
        {
            //mainPageMenu.ItemsSource = App.Current.AppUIModules;
        }

        //protected override void MainPage_Loading(FrameworkElement sender, object args)
        //{
        //    //throw new NotImplementedException();
        //}
    }
}
