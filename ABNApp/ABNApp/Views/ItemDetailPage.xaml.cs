using System.ComponentModel;
using Xamarin.Forms;
using ABNApp.ViewModels;

namespace ABNApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}