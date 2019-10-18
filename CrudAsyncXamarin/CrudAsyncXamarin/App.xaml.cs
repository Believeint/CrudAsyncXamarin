using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CrudAsyncXamarin.Data;
using System.IO;
using CrudAsyncXamarin.View;

namespace CrudAsyncXamarin
{
    public partial class App : Application
    {
        static UsuariosBD database;
        public static UsuariosBD Database
        {
            get
            {
                if(database == null)
                {
                    database = new UsuariosBD(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "usuarios.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListarUsuario());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
