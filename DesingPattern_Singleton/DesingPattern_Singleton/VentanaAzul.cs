using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesingPattern_Singleton
{
    public partial class VentanaAzul : Form
    {
        private static VentanaAzul _instancia;

        public static VentanaAzul ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
                _instancia = new VentanaAzul();

            _instancia.BringToFront();
            return _instancia;
        }

        private VentanaAzul()
        {
            InitializeComponent();
        }

        private void VentanaAzul_Load(object sender, EventArgs e)
        {

        }
    }
}
