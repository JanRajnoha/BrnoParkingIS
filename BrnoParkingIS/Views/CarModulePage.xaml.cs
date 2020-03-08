using BrnoParkingIS.ViewModels;
using ISUF.UI.Views;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BrnoParkingIS.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CarModulePage : ModulePageBase
    {
        public CarModulePage() : base(typeof(CarViewModel))
        {
            this.InitializeComponent();
        }
    }
}
