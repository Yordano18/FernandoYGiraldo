using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FernandoGiraldo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string pass = txtContrasena.Text;
            
                if (user == "fernandogiraldo" && pass == "uisrael2022")
                {
                    await Navigation.PushAsync(new Registro(user, pass));
                }
                else
                {
                    await DisplayAlert("Alerta! ", "Usuario/Contraseña incorrecta", "OK");
                }
            
        }
    }
}