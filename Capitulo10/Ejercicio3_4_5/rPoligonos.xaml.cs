using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tarea_5PA1_JoseA.Capitulo10.Ejercicio3_4_5
{
    /// <summary>
    /// Interaction logic for rPoligonos.xaml
    /// </summary>
    public partial class rPoligonos : Window
    {


        public rPoligonos()
        {
            InitializeComponent();


        }

        public void PerimetroButton_Click(object sender, RoutedEventArgs e)
        {
            int lado1 = int.Parse(Lado1Textbox.Text);
            int lado2 = int.Parse(Lado2TextBox.Text);
            int lado3 = int.Parse(Lado3TextBox.Text);

            Poligonos poligonos = new Poligonos(lado1, lado2, lado3);

            if (!poligonos.ValidarValores(lado1, lado2, lado3))
            {
                MessageBox.Show("Debe ingresar un  valor mayor que 0", "Lado");
            }
            else
            {
                MessageBox.Show("Valores Correcto", "Poligonos");
                PerimetroTextBox.Text = poligonos.ToString();

            }
        }

    }
}
