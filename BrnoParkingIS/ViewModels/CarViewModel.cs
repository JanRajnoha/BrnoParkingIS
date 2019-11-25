using BrnoParkingIS.Controls;
using BrnoParkingIS.Modules;
using ISUF.Base.Messages;
using ISUF.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.StartScreen;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

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

            string header = "";
            object content;

            switch (paneName)
            {
                case addPivotItemName:

                    content = new AddItem(uiModule, typeof(CarAddViewModel), null);

                    if (msg.GetType() == typeof(ItemAddNewMsg))
                    {
                        header = "Add Activity";
                    }
                    else
                    {
                        header = "Edit Activity";
                    }

                    break;

                default:
                    throw new NotImplementedException();
            }

            try
            {
                if (PivotPanes.FirstOrDefault(x => x.Name == paneName) == null)
                    PivotPanes.Insert(0, new PivotItem()
                    {
                        Name = paneName,
                        Header = header,
                        Margin = new Thickness(0),
                        Content = content
                    });
                else
                {
                    PivotPanes.FirstOrDefault(x => x.Name == paneName).Header = header;
                    PivotPanes.FirstOrDefault(x => x.Name == paneName).Content = content;
                }
            }
            catch (Exception)
            {
                PivotPanes.Clear();
                PivotPanes.Insert(0, new PivotItem()
                {
                    Name = paneName,
                    Header = header,
                    Content = content
                });
            }
            finally
            {
                if (PivotPanes.FirstOrDefault(x => x.Name == paneName) != null)
                {
                    //pivotPanes = PivotPanes;
                    RaisePropertyChanged(nameof(PivotPanes));

                    PaneVisibility = true;

                    double MinNormalWidth = (double)Application.Current.Resources["NormalMinWidth"];
                    if (MinNormalWidth > ApplicationView.GetForCurrentView().VisibleBounds.Width)
                    {
                        MasterFrame = new GridLength(0);
                    }

                    Messenger.Send(msg);
                }
            }
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
