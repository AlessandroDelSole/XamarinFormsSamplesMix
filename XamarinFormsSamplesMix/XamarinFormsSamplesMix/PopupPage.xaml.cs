using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsSamplesMix
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PopupPage : Rg.Plugins.Popup.Pages.PopupPage
	{
		public PopupPage ()
		{
			InitializeComponent ();
		}

        private async void AnimationView_Finish(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            await PopupNavigation.PopAsync();
        }
	}
}