using Employment.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Employment.Views
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