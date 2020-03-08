using BrnoParkingIS.Modules;
using ISUF.Base.Classes;
using ISUF.UI.ViewModel;
using System;

namespace BrnoParkingIS.ViewModels
{
    public class CarDetailViewModel : ModuleDetailVMBase<Car>
    {
        public CarDetailViewModel(Messenger messenger, Type modulePage) : base(messenger, modulePage)
        {
        }
    }
}
