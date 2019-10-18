using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudAsyncXamarin.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Threading;
using System.Globalization;

namespace CrudAsyncXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalharUsuario : ContentPage
    {
        public DetalharUsuario()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR", false);
            InitializeComponent();
        }

        private async void EditarUsuario(object sender, EventArgs e)
        {
            //var usuario = (Usuario)BindingContext;
            await Navigation.PushAsync(new EditarUsuario() { BindingContext = BindingContext as Usuario });
        }

        private async void ExcluirUsuario(object sender, EventArgs e)
        {
            var usuario = (Usuario)BindingContext;
            await App.Database.ExcluirUsuarioAsync(usuario);
            await Navigation.PopAsync();
        }

    }
}