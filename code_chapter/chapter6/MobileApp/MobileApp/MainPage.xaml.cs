using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnBindingListString_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BindingListString());
        }

        private void BtnBindingDataModel_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BindingDataModel());
        }

        private void BtnListViewImage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewImage());
        }

        private void BtnCustomizingListRows_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CustomizingListRow());
        }

        private void BtnButtonView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ButtonView());
        }
    }
}
