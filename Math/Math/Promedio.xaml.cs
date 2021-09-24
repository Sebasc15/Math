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
    public partial class Promedio : ContentPage
    {
        private float VarNumber = 0.0f;
        private int Cont = 0;
        public Promedio()
        {
            InitializeComponent();
        }

        private void Agregar_Clicked(object sender, EventArgs e)
        {
            float n = 0.0f;
            Exception ex = null;
            try
            {
                n = float.Parse(txtNumero.Text);
            }
            catch(ArgumentNullException eof)
            {
                ex = eof;
            }
            catch(FormatException FE)
            {
                ex = FE;
            }

            if(ex == null){
                VarNumber += n;

                if (Cont == 0)
                {
                    lblDatos.Text = n.ToString();
                }
                else
                {
                    lblDatos.Text = $"{lblDatos.Text}, {n.ToString()}";
                }
                Cont++;
                txtNumero.Text = null;
            }
        }

        private void Calcular_Clicked(object sender, EventArgs e)
        {
            float num = VarNumber / Cont;
            string prom = "Promedio: ";
            Result.Text = $"{prom}{num}";
        }

        private void Limpiar_Clicked(object sender, EventArgs e)
        {
            VarNumber = 0;
            Cont = 0;
            lblDatos.Text = "Aqui van los numeros que has ingresado";
            Result.Text = "";
        }
    }
}