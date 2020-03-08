using ISUF.UI.Modules;
using ISUF.UI.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace BrnoParkingIS.Controls
{
    public sealed partial class AddItem : ModuleAddControlBase
    {
        public AddItem(UIModule uiModule, Type viewModelType, params object[] viewModelArgs) : base(uiModule, viewModelType, viewModelArgs)
        {
            this.InitializeComponent();
        }
    }
}
