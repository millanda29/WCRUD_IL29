using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCRUD_IL29.Clases;
using static WCRUD_IL29.Clases.PersonaBD;

namespace WCRUD_IL29.UI.Persona
{
    public partial class Persona : Form
    {
        public Persona()
        {
            InitializeComponent();
            this.FormClosed += Persona_FormClosed;
        }

        private static Persona Instancia = null;

        public static Persona ObtenerInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new Persona();
                Instancia.FormClosed += Persona_FormClosed;
            }
            return Instancia;
        }

        private static void Persona_FormClosed(object sender, FormClosedEventArgs e)
        {
            Instancia = null;
        }

        private void Persona_Load(object sender, EventArgs e)
        {
            //Verificación de la conexión con el origen de datos
            PersonaBD persona = new PersonaBD();
            if (persona.ValidarConexion())
            {
                TextConexion.Text += "Exitosa.";
                //Instancia a la clase persona
                PersonaBD personaBD = new PersonaBD();  
                //Invoca al método listar personas y asigna el resultado al dataGridview respectivo
                PersonadataGridView.DataSource = personaBD.ListarPersonas("", "");
            }
            else
            {
                TextConexion.Text += "Falló!!";
            }
        }

        private void BuscarPeBtt_Click(object sender, EventArgs e)
        {
                PersonaBD oPersona = new PersonaBD();
                string tipoFiltro = FiltrarPorPe.SelectedItem?.ToString();
                TextAlmacenado.Text = "Almacena: " + tipoFiltro;
                object filtro = null;

                switch (tipoFiltro)
                {
                    case "ID":
                        int id;
                        if (int.TryParse(FiltrarTextPersona.Text, out id))
                        {
                            filtro = id;
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;

                    case "Cedula": // Cambiado de "ID" a "Cedula"
                        filtro = FiltrarTextPersona.Text;
                        break;

                    case "Nombre":
                        filtro = FiltrarTextPersona.Text;
                        break;

                    case "Apellido":
                        filtro = FiltrarTextPersona.Text;
                        break;

                    case "Edad":
                        int edad;
                        if (int.TryParse(FiltrarTextPersona.Text, out edad))
                        {
                            filtro = edad;
                        }
                        else
                        {
                            MessageBox.Show("Ingrese una edad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;

                    case "FechaNacimiento":
                        DateTime fechaNacimiento;
                        if (DateTime.TryParse(FiltrarTextPersona.Text, out fechaNacimiento))
                        {
                            filtro = fechaNacimiento;
                        }
                        else
                        {
                            MessageBox.Show("Ingrese una fecha de nacimiento válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;

                    default:
                        MessageBox.Show("Tipo de filtro no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                try
                {
                    // Verificar si el filtro es vacío o nulo
                    if (filtro == null || string.IsNullOrWhiteSpace(filtro.ToString()))
                    {
                        PersonadataGridView.DataSource = oPersona.ListarPersonas(" ", "");
                    }
                    else
                    {
                    // Invoca al método listar personas con un parámetro de búsqueda y el tipo de filtro
                        PersonadataGridView.DataSource = oPersona.ListarPersonas(filtro.ToString(), tipoFiltro);
                    }
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void AddPeBtt_Click(object sender, EventArgs e)
        {
            NewPersona newPersona = new NewPersona();
            newPersona.ShowDialog();
        }

        private void UpdatePeBtt_Click(object sender, EventArgs e)
        {
            UpdatePersona updatePersona = new UpdatePersona();
            updatePersona.ShowDialog();
        }

        private void DeletePeBtt_Click(object sender, EventArgs e)
        {
            DeletePersona deletePersona = new DeletePersona();
            deletePersona.ShowDialog();
        }

        
    }
}
