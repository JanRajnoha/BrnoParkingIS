using BrnoParkingIS.Modules;
using ISUF.Base.Classes;
using ISUF.Base.Messages;
using ISUF.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;

namespace BrnoParkingIS.ViewModels
{
    public class CarAddViewModel : ModuleAddVMBase<Car>
    {
        public CarAddViewModel(Messenger messenger, Type modulePage) : base(messenger, modulePage)
        {

        }

        public override DelegateCommand<Car> SaveItem { get => new DelegateCommand<Car>((Car car) => { }); set => new DelegateCommand<Car>((Car car) => { }); }

        public override DelegateCommand<Car> SaveItemClose { get => new DelegateCommand<Car>((Car car) => { }); set => new DelegateCommand<Car>((Car car) => { }); }

        protected override void AddNewItem(ItemAddNewMsg obj)
        {
            if (obj != null)
                if (obj.ItemType != typeof(Car))
                    return;

            DetailItem = new Car();
            RaisePropertyChanged(nameof(DetailItem));
        }

        protected override void SelectedItemChanged(ItemSelectedAddMsg obj)
        {
        }
    }
}
