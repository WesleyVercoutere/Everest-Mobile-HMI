using EverestMobileHmi.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace EverestMobileHmi.Views
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