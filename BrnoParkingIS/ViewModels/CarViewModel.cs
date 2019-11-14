using BrnoParkingIS.Modules;
using ISUF.Base.Messages;
using ISUF.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.StartScreen;

namespace BrnoParkingIS.ViewModels
{
    public class CarViewModel : ModuleVMBase<Car>
    {
        public CarViewModel(Type modulePage) : base(modulePage)
        {
        }

        public CarViewModel(Type modulePage, SecondaryTile secondaryTile, string itemType) : base(modulePage, secondaryTile, itemType)
        {
        }

        public override Task OnLoadAsync(bool SecureChanged = false)
        {
            throw new NotImplementedException();
        }

        protected override void AddPane<TMessage>(string paneName, TMessage msg)
        {
            throw new NotImplementedException();
        }

        protected override void NewItemAdded(ItemAddSavedMsg obj)
        {
            throw new NotImplementedException();
        }

        protected override void ShowModal(ShowModalActivationMsg obj)
        {
            throw new NotImplementedException();
        }

        protected override Task UpdateSourceAsync(bool secureChanged = false)
        {
            throw new NotImplementedException();
        }
    }
}
