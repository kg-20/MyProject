using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BankingApp
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void Ingresar_Clicked(object sender, System.EventArgs e)
        {
            if (validarDatosUsr())
            {
                await Navigation.PushAsync(new MenuPrincipalPage());
            }

        }

        async void RecuperarPsw_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RecuperarPswPage());
        }

        async void RegistrarNuevoUsr_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RegistrarUsrPage());
        }


        bool validarDatosUsr(){

            bool result = true;
            var usr = txtUsuario.Text;          
            var psw = txtContrasena.Text;

            if (string.IsNullOrEmpty(usr) || string.IsNullOrEmpty(psw))
            {

                DisplayAlert("Error", "No puede ingresar. Datos incompletos.", "OK");
                result = false;
            }
            return result;
        }
    }
}
