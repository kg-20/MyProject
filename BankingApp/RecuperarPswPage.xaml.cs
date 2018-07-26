using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BankingApp
{
    public partial class RecuperarPswPage : ContentPage
    {
        public RecuperarPswPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text)){

                /*var emailTask = MessagingPlugin.EmailMessenger;
                if (emailTask.CanSendEmail)
                {
                    
                    var email = new EmailMessageBuilder()
                   .To("karlagarc@gmail.com")
                        .Subject("Nueva contraseña")
                   .Body("8K71G9")
                   .Build();

                    emailTask.SendEmail(email);

                    DisplayAlert("Atención", "Se ha enviado la nueva contraseña a su email.", "OK");
                }*/

            }else{
                DisplayAlert("Error", "Ingrese la dirección de correo electrónico.", "Ok");
                return;
            }
        }
    }
}
