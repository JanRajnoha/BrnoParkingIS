using ISUF.UI.Modules;
using ISUF.UI.Views;
using System;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace BrnoParkingIS.Controls
{
    public sealed partial class DetailItem : ModuleDetailControlBase
    {
        public DetailItem(UIModule uiModule, Type viewModelType, params object[] viewModelArgs) : base(uiModule, viewModelType, viewModelArgs)
        {
            this.InitializeComponent();
        }
    }
}
