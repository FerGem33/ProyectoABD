using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Futbol.Views.Parents
{
    public partial class Estadios : UserControl
    {
        public Estadios()
        {
            InitializeComponent();
            this.Load += ViewEstadios_Load;
            this.dgvEstadios.CellClick += dgvEstadios_CellClick;
            this.btnGuardar.Click += btnGuardar_Click;
            this.btnEliminar.Click += btnEliminar_Click;
            this.btnLimpiar.Click += btnLimpiar_Click;
            this.txtIdEstadio.Leave += txtIdEstadio_Leave;
        }

        private void ViewEstadios_Load(object sender, EventArgs e)
        {
            txtNombre.MaxLength = 45;
            txtDireccion.MaxLength = 80;
            txtCapacidad.MaxLength = 10;
            txtIdEstadio.MaxLength = 10;

            txtCapacidad.KeyPress += SoloNumeros;
            txtIdEstadio.KeyPress += SoloNumeros;

            ConfigurarTabla();
            CargarEstadios();
        }

        private void ConfigurarTabla()
        {
            dgvEstadios.Columns.Clear();
            dgvEstadios.Columns.Add("idEstadio", "ID");
            dgvEstadios.Columns.Add("nombre", "Nombre");
            dgvEstadios.Columns.Add("capacidad", "Capacidad");
            dgvEstadios.Columns.Add("direccion", "Dirección");

            dgvEstadios.Columns["idEstadio"].Visible = false;
            dgvEstadios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstadios.MultiSelect = false;
            dgvEstadios.ReadOnly = true;
        }

        private void CargarEstadios()
        {
            dgvEstadios.Rows.Clear();
            using (var conn = Database.Db.GetConnection())
            {
                conn.Open();
                string query = "SELECT idEstadio, nombre, capacidad, direccion FROM estadios";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgvEstadios.Rows.Add(
                            reader["idEstadio"],
                            reader["nombre"],
                            reader["capacidad"],
                            reader["direccion"]
                        );
                    }
                }
            }
        }

        private bool ValidarCampos()
        {
            errorProvider1.Clear();
            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtIdEstadio.Text))
            {
                errorProvider1.SetError(txtIdEstadio, "ID obligatorio.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Nombre obligatorio.");
                valido = false;
            }

            if (!int.TryParse(txtCapacidad.Text, out int capacidad) || capacidad < 0)
            {
                errorProvider1.SetError(txtCapacidad, "Solo números positivos.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                errorProvider1.SetError(txtDireccion, "Dirección obligatoria.");
                valido = false;
            }

            return valido;
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            int id = int.Parse(txtIdEstadio.Text);
            bool existe = false;

            using (var conn = Database.Db.GetConnection())
            {
                conn.Open();
                string check = "SELECT COUNT(*) FROM estadios WHERE idEstadio = @id";
                using (var cmd = new MySqlCommand(check, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    existe = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }

                string query = existe
                    ? "UPDATE estadios SET nombre = @nombre, capacidad = @capacidad, direccion = @direccion WHERE idEstadio = @id"
                    : "INSERT INTO estadios (idEstadio, nombre, capacidad, direccion) VALUES (@id, @nombre, @capacidad, @direccion)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@capacidad", int.Parse(txtCapacidad.Text));
                    cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show(existe ? "Estadio actualizado." : "Estadio registrado.");
            LimpiarCampos();
            CargarEstadios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEstadios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un estadio para eliminar.");
                return;
            }

            var fila = dgvEstadios.SelectedRows[0];
            int id = Convert.ToInt32(fila.Cells["idEstadio"].Value);

            using (var conn = Database.Db.GetConnection())
            {
                conn.Open();
                string check = "SELECT COUNT(*) FROM partidos WHERE idEstadio = @id";
                using (var cmd = new MySqlCommand(check, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("No se puede eliminar: el estadio tiene partidos registrados.");
                        return;
                    }
                }

                string delete = "DELETE FROM estadios WHERE idEstadio = @id";
                using (var cmd = new MySqlCommand(delete, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Estadio eliminado.");
            LimpiarCampos();
            CargarEstadios();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtIdEstadio.Clear();
            txtNombre.Clear();
            txtCapacidad.Clear();
            txtDireccion.Clear();
        }

        private void dgvEstadios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvEstadios.Rows[e.RowIndex];
                txtIdEstadio.Text = fila.Cells["idEstadio"].Value?.ToString() ?? "";
                txtNombre.Text = fila.Cells["nombre"].Value?.ToString() ?? "";
                txtCapacidad.Text = fila.Cells["capacidad"].Value?.ToString() ?? "";
                txtDireccion.Text = fila.Cells["direccion"].Value?.ToString() ?? "";
            }
        }

        private void txtIdEstadio_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdEstadio.Text, out int id)) return;

            using (var conn = Database.Db.GetConnection())
            {
                conn.Open();
                string query = "SELECT nombre, capacidad, direccion FROM estadios WHERE idEstadio = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtNombre.Text = reader["nombre"].ToString();
                            txtCapacidad.Text = reader["capacidad"].ToString();
                            txtDireccion.Text = reader["direccion"].ToString();
                        }
                    }
                }
            }
        }

        private void txtIdEstadio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}