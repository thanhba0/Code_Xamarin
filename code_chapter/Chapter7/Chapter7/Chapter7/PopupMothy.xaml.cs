using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter7
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PopupMothy : ContentPage
	{
		public PopupMothy ()
		{
			InitializeComponent ();
		}
        protected async void ShowMenu(object sender, EventArgs args)
        {
            String action = await DisplayActionSheet("Options", "Cancel", null, "Here", "There", "Everywhere");
            Message.Text = "Action is :" + action;
        }

    }
}