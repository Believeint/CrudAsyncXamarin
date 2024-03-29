﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudAsyncXamarin.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Globalization;
using System.Threading;

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
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            CultureInfo culture = new CultureInfo("pt-BR");
            var usuario = (Usuario)BindingContext;
            usuario.Nome = entNome.Text;
            //var tirabarra = entDtNasc.Text.Replace("/", "");
            //var data = tirabarra.Substring(4, 4) + "/" + tirabarra.Substring(2, 2) + "/" + tirabarra.Substring(0, 2);
            usuario.DataNascimento = Convert.ToDateTime(entDtNasc.Text);
            usuario.Sexo = entSexo.Text;
            usuario.Email = entEmail.Text;
            usuario.Cidade = entCidade.Text;
            usuario.Estado = entEstado.Text;
            usuario.Pais = entPais.Text;
            var data = DateTime.Now;

            usuario.DataCadastro = data.ToLocalTime();
            
            await App.Database.IncluirUsuarioAsync(usuario);
            await Navigation.PopAsync();
        }
    }
}