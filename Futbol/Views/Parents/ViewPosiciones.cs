using Futbol.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futbol.Views.Parents
{
    public partial class ViewPosiciones : Form
    {
        public ViewPosiciones()
        {
            InitializeComponent();
            LoadData();
            UpdateTableToSelectedRow(0);
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"SELECT idPosicion AS Id, nombre AS Posicion FROM posiciones";
                using (var adapter = new MySqlDataAdapter(sql, conn))
                {
                    var table = new DataTable();
                    adapter.Fill(table);

                    // DataGrid
                    dataGrid.DataSource = table;
                    dataGrid.Columns["Id"].Visible = true;
                }
            }

            dataGrid.Columns["Id"].FillWeight = 20;
        }

        private void UpdateTableToSelectedRow(int rowIndex)
        {
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dataGrid.Rows[rowIndex];
                numericId.Value = Convert.ToInt32(row.Cells["Id"].Value);
                textboxPosicion.Text = row.Cells["Posicion"].Value.ToString();
            }
        }

        private void ReloadTable()
        {
            LoadData();
            UpdateTableToSelectedRow(dataGrid.SelectedRows[0].Index);
        }

        private void DataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                int rowIndex = dataGrid.SelectedRows[0].Index;
                UpdateTableToSelectedRow(rowIndex);
            }
        }

        private bool ValidateEmptyFields()
        {
            if (textboxPosicion.Text == "")
            {
                MessageBox.Show("No deben haber campos vacíos.",
                "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Insertar_btn_Click(object sender, EventArgs e)
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();
                int idPosicion;
                string posicion;

                idPosicion = (int)numericId.Value;
                posicion = textboxPosicion.Text;

                if (!ValidateEmptyFields())
                {
                    return;
                }

                string sql = "INSERT INTO posiciones (idPosicion, nombre) VALUES (@idPosicion, @posicion)";
                try
                {
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@idPosicion", MySqlDbType.Int32).Value = idPosicion;
                        cmd.Parameters.Add("@posicion", MySqlDbType.VarChar).Value = posicion = textboxPosicion.Text;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex) when (ex.Number == 1062)
                {
                    MessageBox.Show("No es posible agregar el registro porque este Id ya esta asociado a otro registro.",
                    "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            ReloadTable();
        }

        private void Actualizar_btn_Click(object sender, EventArgs e)
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                int idPosicion = Convert.ToInt32(dataGrid.SelectedRows[0].Cells["Id"].Value);
                string posicion = textboxPosicion.Text;

                if (!ValidateEmptyFields())
                {
                    return;
                }

                string sql = @"UPDATE posiciones
                          SET nombre = @posicion
                          WHERE idPosicion = @idPosicion";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@idPosicion", MySqlDbType.Int32).Value = idPosicion;
                    cmd.Parameters.Add("@posicion", MySqlDbType.VarChar).Value = posicion;
                    cmd.ExecuteNonQuery();
                }
            }

            ReloadTable();
        }

        private void Eliminar_btn_Click(object sender, EventArgs e)
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();
                int idPosicion = Convert.ToInt32(dataGrid.SelectedRows[0].Cells["Id"].Value);

                try
                {
                    string sql = "DELETE FROM posiciones WHERE idPosicion = @idPosicion";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@idPosicion", MySqlDbType.Int32).Value = idPosicion;
                        cmd.ExecuteNonQuery();
                    }

                    ReloadTable();
                }

                catch (MySqlException ex) when (ex.Number == 1451)
                {
                    MessageBox.Show("No es posible eliminar este registro porque tiene otros registros asociados.",
                    "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void numericId_ValueChanged(object sender, EventArgs e)
        {
            int targetId = (int)numericId.Value;

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (!row.IsNewRow && Convert.ToInt32(row.Cells["Id"].Value) == targetId)
                {
                    row.Selected = true;
                    UpdateTableToSelectedRow(row.Index);
                    return;
                }
            }
        }
    }
}

