using BrnoParkingIS.Modules;
using ISUF.Base.Classes;
using ISUF.Base.Messages;
using ISUF.UI.ViewModel;
using ISUF.UI.Views;
using System;

namespace BrnoParkingIS.ViewModels
{
    public class CarAddViewModel : ModuleAddVMBase<Car>
    {
        public CarAddViewModel(Messenger messenger, Type modulePage, ModuleAddControlBase form) : base(messenger, modulePage, form)
        {

        }

        protected override void AddNewItem(ItemAddNewMsg obj)
        {
            if (obj != null && obj.ItemType != typeof(Car))
                return;

            AddEditItem = new Car();
        }
    }
}
