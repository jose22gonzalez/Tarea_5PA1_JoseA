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
using Tarea_5PA1_JoseA.Capitulo10.Ejercicio1;
using Tarea_5PA1_JoseA.Capitulo10.Ejercicio2;
using Tarea_5PA1_JoseA.Capitulo10.Ejercicio3_4_5;

namespace Tarea_5PA1_JoseA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ClickEjercicio1_Menu(object sender, RoutedEventArgs e)
        {
            rTienda tienda = new rTienda();
            tienda.Show();
        }

        public void ClcikEjercicio2_Menu(object sender, RoutedEventArgs e)
        {
            rEstudiante estudiante = new rEstudiante();
            estudiante.Show();
        }

        public void ClcikEjercico1_2_3_Menu(object sender, RoutedEventArgs e)
        {
            rPoligonos poligono =  new rPoligonos();
            poligono.Show();
        }
    }
}
