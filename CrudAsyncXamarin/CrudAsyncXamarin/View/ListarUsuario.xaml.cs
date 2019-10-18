using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudAsyncXamarin.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrudAsyncXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListarUsuario : ContentPage
    {
        public ListarUsuario()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var usuarios = new List<Usuario>();
            usuarios = await App.Database.GetUsuarios();
        }

        private async void AddUsuarioClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdicionarUsuario() { BindingContext = new Usuario() });
        }

        private async void SelectUsuarioClicked(object sender, ItemTappedEventArgs e)
        {
            if(e.Item != null)
            {
                await Navigation.PushAsync(new DetalharUsuario());
            }
        }
    }
}