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
    public partial class EditarUsuario : ContentPage
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private async void AtualizarUsuario(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            var usuario = (Usuario)BindingContext;
            usuario.Nome = entNome.Text;
            usuario.DataNascimento = Convert.ToDateTime(entDtNasc.Text);
            usuario.Sexo = entSexo.Text;
            usuario.Cidade = entCidade.Text;
            usuario.Estado = entCidade.Text;
            usuario.Pais = entPais.Text;
            await App.Database.EditarUsuarioAsync(usuario);
            await Navigation.PopAsync();
    
        }
    }
}