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
    public partial class Registro : ContentPage
    {
        public Registro(string user, string pass)
        {
            InitializeComponent();
            lblUser.Text = user;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            int valor = 3000;
            double interes = 0.05;
            double montoInicial = 0;
            
                montoInicial = double.Parse(txtCuota.Text);
                double diferencia = valor - montoInicial;
                double cuotaSinInteres = (diferencia / 5);
                double cuota = cuotaSinInteres + (valor * interes);
                txtPago.Text = cuota.ToString();
                
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            double monto = double.Parse(txtCuota.Text);
            double cuota = double.Parse(txtPago.Text);
            string variable = lblUser.Text;

            if (!string.IsNullOrEmpty(nombre) && monto != null && cuota != null)
            {
                DisplayAlert("Listo ", "registro", "Ok");
                await Navigation.PushAsync(new Resumen(nombre, monto, cuota, variable));
            }

        }
    }
}