using BrnoParkingIS.Modules;
using ISUF.Base.Classes;
using ISUF.Base.Messages;
using ISUF.UI.ViewModel;
using ISUF.UI.Views;
using System;

namespace BrnoParkingIS.ViewModels
{
    public class ParkingAddViewModel : ModuleAddVMBase<Parking>
    {
        public ParkingAddViewModel(Messenger messenger, Type modulePage, ModuleAddControlBase form) : base(messenger, modulePage, form)
        {

        }

        protected override void AddNewItem(ItemAddNewMsg obj)
        {
            if (obj != null && obj.ItemType != typeof(Parking))
                return;

            AddEditItem = new Parking();
        }

        protected override void SelectedItemChanged(ItemSelectedAddMsg obj)
        {
        }
    }
    }
