using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
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
    /// Lógica de interacción para RegistroWin.xaml
    /// </summary>
    public partial class RegistroWin : MetroWindow {
        public RegistroWin() {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e) {

        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        /*
         * 
            Información de los campos Usuario & Contraseña
         *
         */
        private void btnInfoUsuario_MouseEnter(object sender, MouseEventArgs e) {
            
            if (txbTitulo.Text.Equals("Player Registration")) {
                lblInfo.Text = "Username max lenght 16 characters";
            } else {
                lblInfo.Text = "El nombre de usuario no debe ser mayor a 16 caractéres";
            }
        }

        private void btnInfoUsuario_MouseLeave(object sender, MouseEventArgs e) {
            lblInfo.Text = "";
        }

        private void btnInfoPass_MouseEnter(object sender, MouseEventArgs e) {
            if (txbTitulo.Text.Equals("Player Registration")) {
                lblInfo.Text = "Password max 8 caracters";
            } else {
                lblInfo.Text = "La contraseña no debe ser mayor a 8 caractéres";
            }
        }

        private void btnInfoPass_MouseLeave(object sender, MouseEventArgs e) {
            lblInfo.Text = "";
        }

        /*
         * 
            COMPARACIÓN DE CORREOS
         *  
         */
        private void txtCorreo2_LostFocus(object sender, RoutedEventArgs e) {
            if (!txtCorreo2.Text.Equals(txtCorreo.Text)) {
                txtCorreo.BorderBrush = Brushes.Red;
                txtCorreo2.BorderBrush = Brushes.Red;
                if (txbTitulo.Text.Equals("Player Registration")) {
                    lblInfo.Text = "Mail does not match";
                } else {
                    lblInfo.Text = "El correo no coincide";
                }
            }
        }

        private void txtCorreo_GotFocus(object sender, RoutedEventArgs e) {
            txtCorreo.BorderBrush = Brushes.White;
            txtCorreo2.BorderBrush = Brushes.White;
            lblInfo.Text = "";
        }

        private void btnRegresar_MouseEnter(object sender, RoutedEventArgs e) {
            lblRegresar.Visibility = Visibility.Visible;
        }

        private void btnRegresar_MouseLeave(object sender, MouseEventArgs e) {
            lblRegresar.Visibility = Visibility.Hidden;
        }
    }
}
