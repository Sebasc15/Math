using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Math
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Fibonacci : ContentPage
    {
        public Fibonacci()
        {
            InitializeComponent();

        }

        private void Calcular_Clicked(object sender, EventArgs e)
        {
            lblResutl.Text = "";
            int iteraciones = 0;
            Exception ex = null;
            try
            {
                iteraciones = int.Parse(txtIteraciones.Text);
            }
            catch (FormatException)
            {
                lblResutl.Text = "Introduce un numero entero";
            }
            catch (Exception eof)
            {
                ex = eof;
                lblResutl.Text = "Error inesperado....";
            }

            if (ex == null)
            {
                Fibo(iteraciones, 0, 1);
            }
        }

        private void Fibo(int n, int a, int b)
        {
            if (n > 0)
            {
                if (lblResutl.Text == "")
                {
                    lblResutl.Text = a.ToString();
                }
                else
                {
                    lblResutl.Text = $"{lblResutl.Text}, {a.ToString()}";
                }
                Fibo(n - 1, b, a + b);
            }
        }

        private void CLS_Clicked(object sender, EventArgs e)
        {
            lblResutl.Text = "";
        }
    }
}