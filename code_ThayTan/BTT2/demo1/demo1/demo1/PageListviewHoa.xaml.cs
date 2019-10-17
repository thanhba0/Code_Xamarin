using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace demo1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListviewHoa : ContentPage
    {
        public ObservableCollection<hoa> Hoas = new ObservableCollection<hoa>();

        public PageListviewHoa()
        {
            InitializeComponent();
            Hoas.Add(new hoa { TenHoa = "Đón Xuân",Hinh="cuc.jpg", Gia = 50000, MoTa = "Hoa cúc các màu:trắng,vàng cam" });
            Hoas.Add(new hoa { TenHoa = "Hồn Nhiên", Hinh = "cuc.jpg", Gia = 60000, MoTa = "Hoa cúc các màu:trắng" });
            Hoas.Add(new hoa { TenHoa = "Tím Thủy Chung", Hinh = "cuc.jpg", Gia = 70000, MoTa = "Hoa cúc tím" });

            /*Items = new ObservableCollection<string>
          {
              "Item 1",
              "Item 2",
              "Item 3",
              "Item 4",
              "Item 5"
          };

          MyListView.ItemsSource = Items;*/



        }
        

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
