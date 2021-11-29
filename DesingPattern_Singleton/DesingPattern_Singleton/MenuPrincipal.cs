using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesingPattern_Singleton
{
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void ventana1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VentanaAzul ventanaAzul = VentanaAzul.ObtenerInstancia();
            ventanaAzul.MdiParent = this;
            ventanaAzul.Show();
        }

        private void ventana2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaVerde ventanaVerde = VentanaVerde.ObtenerInstancia();
            ventanaVerde.MdiParent = this;
            ventanaVerde.Show();
        }

        private void ventana1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {
           
        }
    }
}
