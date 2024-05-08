using System.Data;
using System.Data.SqlClient;

namespace Celulares
{
    public partial class Form1 : Form
    {
        private bool Editar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        { if (string.IsNullOrEmpty(txtMarca.Text) || string.IsNullOrEmpty(txtModelo.Text) || string.IsNullOrEmpty(txtEstado.Text))
            {
                MessageBox.Show("No se permiten campos vacios");

            }
            else
            {
                if (Editar == false)
                {
                 
                    string marcar = txtMarca.Text;
                    string modelo = txtModelo.Text;
                    try { 
                    double precio = Convert.ToDouble(txtPrecio.Text);
                   

                    string estado = txtEstado.Text;
                    string queryInsert = "Insert into Marcas(Marca,Modelo,Precio,Estado)" +
                                           "VALUES('" + marcar + "','" + modelo + "',"+ precio+ ",'" + estado + "')";
                    SqlCommand comando = new SqlCommand(queryInsert, Conexion.ConexionSql());
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Ingresado correctamente");
                    txtMarca.Text = "";
                    txtModelo.Text = "";
                    txtPrecio.Text = "";
                    txtEstado.Text = "";
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Solo se permite valores numericos ");
                        txtPrecio.Focus();
                    }
                    txtMarca.Focus();
                   
                    Conexion.ConexionSql().Close();
                    mostrarDatos();
                }

                if (Editar == true)
                {
                    try
                    {
                        Actualizar(

                            txtMarca.Text,
                            txtModelo.Text,
                           Convert.ToDouble(txtPrecio.Text),
                            txtEstado.Text
                    
                        );
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Solo se permite valores numericos ");
                        txtPrecio.Focus();
                    }
                    txtMarca.Focus();

                }
            }
        }

        private void Actualizar( string nuevaMarca, string nuevoModelo, double nuevoPrecio, string nuevoEstado)
        {


            int idMarca = Convert.ToInt32(dgvMostrar.SelectedRows[0].Cells["idMarca"].Value);
            nuevoPrecio = Math.Round(nuevoPrecio, 2);
            string actualizar = "UPDATE Marcas SET Marca = '" + nuevaMarca + "', Modelo = '" + nuevoModelo + "', Precio = '" + nuevoPrecio + "', Estado = '" + nuevoEstado + "' WHERE idMarca = " + @idMarca;

            
            SqlConnection conexion = Conexion.ConexionSql();
            SqlCommand comando = new SqlCommand(actualizar, conexion);

            comando.Parameters.AddWithValue("@idMarca", idMarca);

            comando.ExecuteNonQuery();

            MessageBox.Show("Registro actualizado correctamente");
            Conexion.ConexionSql().Close();
            Editar = false;
            mostrarDatos();
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtPrecio.Text = "";
            txtEstado.Text = "";

        }

        private void mostrarDatos()
        {
            DataTable tabla = new DataTable();
            string consultar = "Select * from Marcas";

            SqlDataAdapter adapter = new SqlDataAdapter(consultar, Conexion.ConexionSql());
            adapter.Fill(tabla);
            dgvMostrar.DataSource = tabla;
            dgvMostrar.ClearSelection();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarDatos();
            ajustarDgv();
            dgvMostrar.ClearSelection();
            dgvMostrar.Columns["Precio"].DefaultCellStyle.Format = "N2";
        }


        public void ajustarDgv()
        {

            dgvMostrar.Columns["idMarca"].HeaderText = "ID";
            dgvMostrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMostrar.SelectedRows.Count == 1)
            {

                int idMarca = Convert.ToInt32(dgvMostrar.SelectedRows[0].Cells["idMarca"].Value);
                string eliminar = "delete from Marcas where idMarca=@idMarca";
                SqlCommand coma = new SqlCommand(eliminar, Conexion.ConexionSql());
                coma.Parameters.AddWithValue("@idMarca", idMarca);
                coma.ExecuteNonQuery();
                MessageBox.Show("Eliminado correctamente");
                Conexion.ConexionSql().Close();
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Seleciona una fila");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvMostrar.SelectedRows.Count == 1)
            {
                Editar = true;
                txtMarca.Text = dgvMostrar.CurrentRow.Cells[1].Value.ToString();
                txtModelo.Text = dgvMostrar.CurrentRow.Cells[2].Value.ToString();
                double precio = Convert.ToDouble(dgvMostrar.CurrentRow.Cells[3].Value);
                txtPrecio.Text = precio.ToString("N2");
                txtEstado.Text = dgvMostrar.CurrentRow.Cells[4].Value.ToString();
            }
            else {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }
    }
}
