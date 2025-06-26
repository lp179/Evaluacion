using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{

    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        private void CargarProductos(string Busqueda = "", int? estado = null)
        {
            string conexion = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                //if (Busqueda != "")
                //{ 
                string query = @"SELECT CodigoProd, Nombre, Existencia,
                                    CASE WHEN Estado = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado,
                                    NProveedor
                                 FROM Producto
                                 WHERE (Nombre LIKE @Busqueda OR CodigoProd LIKE @Busqueda)";

                if (estado != null)
                    query += " AND Estado = @estado";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Busqueda", $"%{Busqueda}%");

                if (estado != null)
                    cmd.Parameters.AddWithValue("@estado", estado);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                dgvProductos.DataSource = tabla;
            }
        }
        private void Productos_ini(object sender, EventArgs e)
        {
            cbEstado.Items.Add("Todos");
            cbEstado.Items.Add("Activos");
            cbEstado.Items.Add("Inactivos");
            cbEstado.SelectedIndex = 0;

            CargarProductos();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();
            int? estado = null;

            if (cbEstado.SelectedIndex == 1) estado = 1;       // prodActivos
            else if (cbEstado.SelectedIndex == 2) estado = 0;  // prodInactivos

            CargarProductos(texto, estado);
        }
    }
}
