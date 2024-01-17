using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCRUD_IL29.Clases;

namespace WCRUD_IL29.UI.Credenciales
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            progressVerificacion.Visible = false;
            

            statusLabel.Text = "Verificando";
            statusLabel.Visible = false;
        }

        private void BttIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = UserNameText.Text;
            string contraseña = ContraseñaText.Text;

            progressVerificacion.Visible = true;
            statusLabel.Visible = true;

            Thread validationThread = new Thread(() => ValidarCredenciales(nombreUsuario, contraseña));
            validationThread.Start();
        }


        private void BttCancelar_Click(object sender, EventArgs e)
        {

        }

        private void BttRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void ValidarCredenciales(string nombreUsuario, string contraseña)
        {
            CredencialesBD credencialesBD = new CredencialesBD();

            bool credencialesValidas = credencialesBD.ValidarCredenciales(nombreUsuario, contraseña);

            BeginInvoke(new Action(() =>
            {
                progressVerificacion.Visible = false;
                statusLabel.Visible = false;

                if (credencialesValidas)
                {
                    MessageBox.Show("Credenciales válidas. Abriendo la otra ventana.");

                    Hide();
                    Principal principal = new Principal();
                    principal.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }));
        }


    }
}
