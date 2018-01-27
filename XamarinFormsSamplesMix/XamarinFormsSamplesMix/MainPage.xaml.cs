using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsSamplesMix
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void SegmentedControl_SegmentSelected(object sender, Plugin.Segmented.Event.SegmentSelectEventArgs e)
        {
            switch (e.NewValue)
            {
                case 0:
                    this.FirstGrid.IsVisible = true;
                    this.SecondGrid.IsVisible = false;
                    break;

                default:
                    this.FirstGrid.IsVisible = false;
                    this.SecondGrid.IsVisible = true;
                    break;
            }
        }

        private async void ViewPopupButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushPopupAsync(new PopupPage());
        }
	}
}
