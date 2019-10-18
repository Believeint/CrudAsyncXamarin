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
    public partial class AdicionarUsuario : ContentPage
    {
        public AdicionarUsuario()
        {
            InitializeComponent();
        }

        private async void AddNovoUsuario(object sender, EventArgs e)
        {
            var usuario = (Usuario)BindingContext;
            usuario.Nome = entNome.Text;
            usuario.DataNascimento = Convert.ToDateTime(entDtNasc.Text);
            usuario.Sexo = entSexo.Text;
            usuario.Email = entEmail.Text;
            usuario.Cidade = entCidade.Text;
            usuario.Estado = entEstado.Text;
            usuario.Pais = entPais.Text;
            usuario.DataCadastro = DateTime.UtcNow;

            await App.Database.IncluirUsuarioAsync(usuario);
            await Navigation.PopAsync();
        }
    }
}