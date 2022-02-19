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

namespace Tarea_5PA1_JoseA.Capitulo10.Ejercicio1
{
    /// <summary>
    /// Interaction logic for rTienda.xaml
    /// </summary>
    public partial class rTienda : Window
    {
        Tienda tienda = new Tienda();
         private List<Tienda> tiendas = new List<Tienda>();
        public rTienda()
        {
            InitializeComponent();
            this.DataContext = tienda;
        }

        private void Limpiar()
        {
            this.tienda = new Tienda();
            this.DataContext = tienda;
        }

        public void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            int Valorinventario = Convert.ToInt32(ValorinventarioTextBox.Text);
            Valorinventario = (tienda.Cantidad * tienda.Costo);
            tienda.ValorInventario = Valorinventario;
            ValorinventarioTextBox.Text = tienda.ValorInventario.ToString();
           this.DataContext = tienda;
           tiendas.Add(this.tienda);
           
           MessageBox.Show("Se ha guardado Correctamento", "Articulo");
           Limpiar();
        }

        public void MostrarrButton_Click(object sender, RoutedEventArgs e)
        {
            ArticuloDataGrid.ItemsSource = null;
            ArticuloDataGrid.ItemsSource = tiendas;
        }
    }
}
