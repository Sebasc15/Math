using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Math
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnFibonacci_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Fibonacci());
        }

        private void BtnCalculadora_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Promedio());
        }

        private void BtnMedidas_Clicked(object sender, EventArgs e)
        {

        }
    }
}
