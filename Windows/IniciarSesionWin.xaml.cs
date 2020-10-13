using MahApps.Metro.Controls;
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

        private void lblRegistrarse_MouseDown(object sender, MouseEventArgs e) {
            RegistroWin registroWin = new RegistroWin();
            registroWin.Show();
        }

        private void lblRegistrarse_MouseEnter(object sender, MouseEventArgs e) {
            lblRegistrarse.Foreground = Brushes.Blue;
        }

        private void lblRegistrarse_MouseLeave(object sender, MouseEventArgs e) {
            lblRegistrarse.Foreground = Brushes.White;
        }
    }
}
