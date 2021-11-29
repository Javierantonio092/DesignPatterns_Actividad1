using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesingPattern_Singleton
{
    public partial class VentanaVerde : Form
    {
        private static VentanaVerde _instancia;

        public static VentanaVerde ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
                _instancia = new VentanaVerde();

            _instancia.BringToFront();
            return _instancia;
        }

        private VentanaVerde()
        {
            InitializeComponent();
        }

        private void VentanaVerde_Load(object sender, EventArgs e)
        {

        }
    }
}
