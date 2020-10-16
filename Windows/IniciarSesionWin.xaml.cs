using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MaterialDesignThemes.Wpf;
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
using System.Windows.Shapes;

namespace Memorama.Windows {
    /// <summary>
    /// Lógica de interacción para IniciarSesionWin.xaml
    /// </summary>
    public partial class IniciarSesionWin : MetroWindow {
        public IniciarSesionWin() {
            InitializeComponent();
        }

        private void txtCorreo_LostFocus(object sender, RoutedEventArgs e) {

        }

        private void btnRegistrarse_Click(object sender, RoutedEventArgs e) {
            RegistroWin registroWin = new RegistroWin();
            registroWin.ShowDialog();
        }

        /*
         * 
         * BOTÓN SALIR
         * 
         */
        private void btnSalir_MouseEnter(object sender, MouseEventArgs e) {
            lblSalir.Visibility = Visibility.Visible;
        }

        private void btnSalir_MouseLeave(object sender, MouseEventArgs e) {
            lblSalir.Visibility = Visibility.Hidden;
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e) {
            Close();
        }

        private void btnRegistrarse_Click_1(object sender, RoutedEventArgs e) {

        }
    }
}
