using BrnoParkingIS.Controls;
using BrnoParkingIS.Modules;
using ISUF.Base.Messages;
using ISUF.UI.ViewModel;
using System;
using System.Linq;
using System.Threading.Tasks;
using Windows.UI.StartScreen;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace BrnoParkingIS.ViewModels
{
    public class ParkingViewModel : ModuleVMBase<Parking>
    {
        public ParkingViewModel(Type modulePage) : base(modulePage)
        {
        }

        public ParkingViewModel(Type modulePage, SecondaryTile secondaryTile) : base(modulePage, secondaryTile)
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

                    content = new AddItem(uiModule, typeof(ParkingAddViewModel), Messenger, modulePage);

                    if (msg.GetType() == typeof(ItemAddNewMsg))
                    {
                        header = "Add";
                    }
                    else
                    {
                        header = "Edit";
                    }

                    break;

                case detailPivotItemName:

                    content = new DetailItem(uiModule, typeof(ParkingDetailViewModel), Messenger, modulePage);

                    header = "Detail";
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
            catch (Exception e)
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

        protected override void ShowModal(ShowModalActivationMsg obj)
        {
            throw new NotImplementedException();
        }
    }
}
