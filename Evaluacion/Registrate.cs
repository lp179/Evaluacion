using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Registrate : Form
    {
        public Registrate()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Entradas no nulas
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
                        {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string correo = txtCorreo.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            // Valida correo
            if (!Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo no tiene un formato válido (ej: usuario@correo.com)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valida teléfono
            if (!Regex.IsMatch(telefono, @"^\d{4}-\d{4}$"))
            {
                MessageBox.Show("El teléfono debe tener el formato 0000-0000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            

            string conexion = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @usuario";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@usuario", txtUsuario.Text.Trim());

                int existe = (int)checkCmd.ExecuteScalar();

                if (existe > 0)
                {
                    MessageBox.Show("El nombre de usuario ya está en uso.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string query = @"INSERT INTO Usuarios
                               (NombreUsuario, Contraseña, Nombre, Apellido, Correo, Telefono)
                        VALUES (@usuario, @contraseña, @nombre, @apellido, @correo, @telefono)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@telefono", telefono);

                int resultado = cmd.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Usuario registrado exitosamente");
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Error al registrar usuario");
                }
            }
        }
    }
}
