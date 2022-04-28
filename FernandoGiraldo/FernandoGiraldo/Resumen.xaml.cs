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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre, double monto, double cuota, string variable)
        {
            InitializeComponent();
            txtNombre.Text = nombre;
            txtTotal.Text = (monto + (cuota * 5)).ToString();
            lblUser.Text = variable;
        }
    }
}