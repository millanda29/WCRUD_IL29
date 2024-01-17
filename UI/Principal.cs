using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persona = WCRUD_IL29.UI.Persona.Persona;

namespace WCRUD_IL29
{
    public partial class Principal : Form
    {
        
        public Principal()
        {
            InitializeComponent();
        }

        private static Persona Instancia = null;

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Instancia == null || Instancia.IsDisposed)
            {
                Instancia = UI.Persona.Persona.ObtenerInstancia();
                Instancia.MdiParent = this;
                Instancia.Show();
            }
            else
            {
                Instancia.BringToFront();
            }
        }
    }
}
