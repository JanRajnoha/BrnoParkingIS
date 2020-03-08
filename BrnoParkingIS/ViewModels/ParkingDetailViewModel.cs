using BrnoParkingIS.Modules;
using ISUF.Base.Classes;
using ISUF.UI.ViewModel;
using System;

namespace BrnoParkingIS.ViewModels
{
    public class ParkingDetailViewModel : ModuleDetailVMBase<Parking>
    {
        public ParkingDetailViewModel(Messenger messenger, Type modulePage) : base(messenger, modulePage)
        {
        }
    }
}
