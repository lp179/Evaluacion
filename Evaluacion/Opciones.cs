using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Opciones : Form
    {
        private string IdProducto;
        private string nombreProd;
        private int? idOpcionSeleccionada = null;
        public Opciones(string IdProd, string nprod)
        {
            InitializeComponent();
            IdProducto = IdProd;
            nombreProd = nprod;
        }

        private void CargarOpciones()
        {
            string conexion = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string query = "SELECT IdOpcion, Nombre FROM Opciones WHERE IdProducto = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", IdProducto);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                dgvOpciones.DataSource = tabla;
            }

        }

        private void Opciones_Load(object sender, EventArgs e)
        {
            lblProducto.Text = $"Opciones del producto: {nombreProd}";

            string conexion = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string query = @"SELECT IdOpcion, Nombre
                                 FROM Opciones
                                 WHERE IdProducto = @IdProd";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdProd", IdProducto);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                dgvOpciones.DataSource = tabla;
            }
            CargarOpciones();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nueva = txtNuevaOpcion.Text.Trim();
            if (nueva == "")
            {
                MessageBox.Show("Ingrese una opción válida");
                return;
            }

            string conexion = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string query = "INSERT INTO Opciones (IdProducto, Nombre) VALUES (@id, @nombre)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", IdProducto);
                cmd.Parameters.AddWithValue("@nombre", nueva);
                cmd.ExecuteNonQuery();
            }

            txtNuevaOpcion.Clear();
            CargarOpciones();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idOpcionSeleccionada == null)
            {
                MessageBox.Show("Seleccione una opción para modificar");
                return;
            }

            string nueva = txtNuevaOpcion.Text.Trim();
            if (nueva == "")
            {
                MessageBox.Show("Ingrese un nuevo nombre válido");
                return;
            }

            string conexion = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string query = "UPDATE Opciones SET Nombre = @nombre WHERE IdOpcion = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", nueva);
                cmd.Parameters.AddWithValue("@id", idOpcionSeleccionada);
                cmd.ExecuteNonQuery();
                MessageBox.Show("La opcion se ha guardado con exito.");
            }

            txtNuevaOpcion.Clear();
            idOpcionSeleccionada = null;
            CargarOpciones();
        }

        private void dgvOpciones_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idOpcionSeleccionada = Convert.ToInt32(dgvOpciones.Rows[e.RowIndex].Cells["IdOpcion"].Value);
                txtNuevaOpcion.Text = dgvOpciones.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            }
        }
    }
}
