using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using Xamarin.Forms;

namespace BankingApp
{
    public partial class RegistrarUsrPage : ContentPage
    {
        public RegistrarUsrPage()
        {
            InitializeComponent();
        }

        async void RegistrarUsr_Clicked(object sender, System.EventArgs e)
        {
            if (ValidarDatosformulario()){
                await DisplayAlert("Atención", "Usuario registrado satisfactoriamente.", "OK");
                await Navigation.PushAsync(new LoginPage());
            }
        }

        bool ValidarDatosformulario()
        {
            bool result;
            var nombre = txtNombre.Text;
            var apell = txtApellidos.Text;
            var id = txtId.Text;
            var email = txtEmail.Text;
            var telef = txtTelefono.Text;
            var psw = txtPsw.Text;
            var confirmPsw = txtConfirmarPsw.Text;

            var regExpTel = new Regex(@"^\d{8}$");

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apell) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(email) || 
                string.IsNullOrEmpty(telef) || string.IsNullOrEmpty(psw) || string.IsNullOrEmpty(confirmPsw) ){

                DisplayAlert("Error", "Datos incompletos", "OK");
                result = false;

            }else if(!regExpTel.IsMatch(telef))
            {
                DisplayAlert("Error", "El telefono debe ser numerico", "OK");
                result = false;

                }else if (!Regex.Match(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)  {
                    DisplayAlert("Error", "Email inválido", "OK");
                    result = false;
                }else if(!psw.Equals(confirmPsw)){
                    DisplayAlert("Error", "La contraseña no coincide.", "OK");
                    result = false;
                }else{
                result = true;
                }

            return result;
        }

    }
}
