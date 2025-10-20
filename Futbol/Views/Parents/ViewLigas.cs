using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Futbol.Views
{
    public partial class ViewLigas : Form
    {
        public ViewLigas()
        {
            InitializeComponent();
            this.Load += ViewLigas_Load;
            this.dgvLigas.CellClick += dgvLigas_CellClick;
            this.btnGuardar.Click += btnGuardar_Click;
            this.btnEliminar.Click += btnEliminar_Click;
            this.btnLimpiar.Click += btnLimpiar_Click;
            this.txtIdLiga.Leave += txtIdLiga_Leave;
        }

        private void ViewLigas_Load(object sender, EventArgs e)
        {
            txtNombre.MaxLength = 45;
            txtIdLiga.MaxLength = 10;
            txtGenero.MaxLength = 20;

            txtIdLiga.KeyPress += SoloNumeros;

            ConfigurarTabla();
            CargarLigas();
        }

        private void ConfigurarTabla()
        {
            dgvLigas.Columns.Clear();
            dgvLigas.Columns.Add("idLiga", "ID");
            dgvLigas.Columns.Add("nombre", "Nombre");
            dgvLigas.Columns.Add("fechaInicio", "Fecha Inicio");
            dgvLigas.Columns.Add("fechaFin", "Fecha Fin");
            dgvLigas.Columns.Add("genero", "Género");

            dgvLigas.Columns["idLiga"].Visible = false;
            dgvLigas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLigas.MultiSelect = false;
            dgvLigas.ReadOnly = true;
        }

        private void CargarLigas()
        {
            dgvLigas.Rows.Clear();
            using (var conn = Database.Db.GetConnection())
            {
                conn.Open();
                string query = "SELECT idLiga, nombre, fechaInicio, fechaFin, genero FROM ligas";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgvLigas.Rows.Add(
                            reader["idLiga"],
                            reader["nombre"],
                            Convert.ToDateTime(reader["fechaInicio"]).ToString("dd/MM/yyyy"),
                            Convert.ToDateTime(reader["fechaFin"]).ToString("dd/MM/yyyy"),
                            reader["genero"]
                        );
                    }
                }
            }
        }

        private bool ValidarCampos()
        {
            errorProvider1.Clear();
            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtIdLiga.Text))
            {
                errorProvider1.SetError(txtIdLiga, "ID obligatorio.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Nombre obligatorio.");
                valido = false;
            }

            if (dtpFechaInicio.Value.Date > dtpFechaFin.Value.Date)
            {
                errorProvider1.SetError(dtpFechaFin, "La fecha fin debe ser posterior a la fecha inicio.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtGenero.Text))
            {
                errorProvider1.SetError(txtGenero, "Género obligatorio.");
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

            int id = int.Parse(txtIdLiga.Text);
            bool existe = false;

            using (var conn = Database.Db.GetConnection())
            {
                conn.Open();
                string check = "SELECT COUNT(*) FROM ligas WHERE idLiga = @id";
                using (var cmd = new MySqlCommand(check, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    existe = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }

                string query = existe
                    ? "UPDATE ligas SET nombre = @nombre, fechaInicio = @fechaInicio, fechaFin = @fechaFin, genero = @genero WHERE idLiga = @id"
                    : "INSERT INTO ligas (idLiga, nombre, fechaInicio, fechaFin, genero) VALUES (@id, @nombre, @fechaInicio, @fechaFin, @genero)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@fechaInicio", dtpFechaInicio.Value.Date);
                    cmd.Parameters.AddWithValue("@fechaFin", dtpFechaFin.Value.Date);
                    cmd.Parameters.AddWithValue("@genero", txtGenero.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show(existe ? "Liga actualizada." : "Liga registrada.");
            LimpiarCampos();
            CargarLigas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLigas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una liga para eliminar.");
                return;
            }

            var fila = dgvLigas.SelectedRows[0];
            int id = Convert.ToInt32(fila.Cells["idLiga"].Value);

            using (var conn = Database.Db.GetConnection())
            {
                conn.Open();
                string check = "SELECT COUNT(*) FROM equipos WHERE idLiga = @id";
                using (var cmd = new MySqlCommand(check, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("No se puede eliminar: la liga tiene equipos registrados.");
                        return;
                    }
                }

                string delete = "DELETE FROM ligas WHERE idLiga = @id";
                using (var cmd = new MySqlCommand(delete, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Liga eliminada.");
            LimpiarCampos();
            CargarLigas();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtIdLiga.Clear();
            txtNombre.Clear();
            txtGenero.Clear();
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
        }

        private void dgvLigas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvLigas.Rows[e.RowIndex];
                txtIdLiga.Text = fila.Cells["idLiga"].Value?.ToString() ?? "";
                txtNombre.Text = fila.Cells["nombre"].Value?.ToString() ?? "";

                string fechaInicio = fila.Cells["fechaInicio"].Value?.ToString() ?? "";
                string fechaFin = fila.Cells["fechaFin"].Value?.ToString() ?? "";

                if (DateTime.TryParse(fechaInicio, out DateTime inicio))
                    dtpFechaInicio.Value = inicio;

                if (DateTime.TryParse(fechaFin, out DateTime fin))
                    dtpFechaFin.Value = fin;

                txtGenero.Text = fila.Cells["genero"].Value?.ToString() ?? "";
            }
        }

        private void txtIdLiga_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdLiga.Text, out int id)) return;

            using (var conn = Database.Db.GetConnection())
            {
                conn.Open();
                string query = "SELECT nombre, fechaInicio, fechaFin, genero FROM ligas WHERE idLiga = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtNombre.Text = reader["nombre"].ToString();
                            dtpFechaInicio.Value = Convert.ToDateTime(reader["fechaInicio"]);
                            dtpFechaFin.Value = Convert.ToDateTime(reader["fechaFin"]);
                            txtGenero.Text = reader["genero"].ToString();
                        }
                    }
                }
            }
        }

        private void txtIdLiga_TextChanged(object sender, EventArgs e)
        {

        }
    }
}