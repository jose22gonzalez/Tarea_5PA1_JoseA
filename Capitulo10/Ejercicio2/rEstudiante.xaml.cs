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


namespace Tarea_5PA1_JoseA.Capitulo10.Ejercicio2
{
    /// <summary>
    /// Interaction logic for rEstudiante.xaml
    /// </summary>
    public partial class rEstudiante : Window
    {
        Estudiante estudiante = new Estudiante();
        private List<Estudiante> estudiantes = new List<Estudiante>();
        public rEstudiante()
        {
            InitializeComponent();
            this.DataContext = estudiante;
        }

         private void Limpiar()
        {
            this.estudiante = new Estudiante();
            this.DataContext = estudiante;
        }

        public void GuardarButton_Click(object sender, RoutedEventArgs e)
        {

           this.DataContext = estudiante;
           estudiantes.Add(this.estudiante);
           
           MessageBox.Show("Se ha guardado Correctamento", "Estudiante");
           Limpiar();
        }

        public void MostrarrButton_Click(object sender, RoutedEventArgs e)
        {
             EstudianteDataGrid.ItemsSource = null;
            EstudianteDataGrid.ItemsSource = estudiantes;
        }
    }
}
