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

        public Opciones(string IdProd, string nprod)
        {
            InitializeComponent();
            IdProducto = IdProd;
            nombreProd = nprod;
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
        }


    }
}
