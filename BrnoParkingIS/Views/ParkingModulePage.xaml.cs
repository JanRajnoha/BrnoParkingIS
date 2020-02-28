using BrnoParkingIS.ViewModels;
using ISUF.UI.Views;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BrnoParkingIS.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ParkingModulePage : ModulePageBase
    {
        public ParkingModulePage() : base(typeof(ParkingViewModel))
        {
            this.InitializeComponent();
        }
    }
}
