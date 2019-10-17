using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BT1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MH_Chao());

        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MH_TinhTong());
        }
        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
        private void cmdAbsoluteLayout_Clicked(object sender, EventArgs e)
        {

        }
        private void cmdgridLayout_Clicked(object sender, EventArgs e)
        {

        }
        private void cmdlogin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MH_Login());
        }
        private void cmdFlexLayout_Clicked(object sender, EventArgs e)
        {

        }
        private void cmdScrollView_Clicked(object sender, EventArgs e)
        {

        }
        private void cmdEntry_Clicked(object sender, EventArgs e)
        {

        }


        private void cmdListview1_Clicked(object sender, EventArgs e)
        {

        }

    }
}
