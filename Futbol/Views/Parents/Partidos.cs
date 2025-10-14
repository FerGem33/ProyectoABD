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
    public partial class Partidos : UserControl
    {
        public Partidos()
        {
            InitializeComponent();
            LoadData();
            UpdateToSelectedRow(0);
        }

        private void LoadData()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"SELECT 
                                p.idLocal   AS idLocal,
                                p.idVisitante AS idVisitante,
                                p.idEstadio AS idEstadio,
                                p.idArbitro AS idArbitro,
                               local.nombre AS Local, visitante.nombre AS Visitante, 
                               e.nombre AS Estadio, fecha AS Fecha, hora AS Hora, 
                               CONCAT(a.nombre, ' ', a.apellidoPaterno, ' ', a.apellidoMaterno) AS Arbitro
                               FROM partidos p
                               JOIN equipos local ON p.idLocal = local.idEquipo
                               JOIN equipos visitante ON p.idVisitante = visitante.idEquipo
                               JOIN estadios e ON p.idEstadio = e.idEstadio
                               JOIN arbitros a ON p.idArbitro = a.idArbitro;";
                using (var adapter = new MySqlDataAdapter(sql, conn))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    tablaPartidos.DataSource = table;

                    tablaPartidos.Columns["idLocal"].Visible = false;
                    tablaPartidos.Columns["idVisitante"].Visible = false;
                    tablaPartidos.Columns["idEstadio"].Visible = false;
                    tablaPartidos.Columns["idArbitro"].Visible = false;
                }

                sql = "SELECT idEquipo, nombre FROM equipos";
                using (var adapter = new MySqlDataAdapter(sql, conn))
                {
                    var table = new DataTable();
                    var table2 = new DataTable();
                    adapter.Fill(table);
                    adapter.Fill(table2);

                    comboLocal.DataSource = table;
                    comboLocal.ValueMember = "idEquipo";
                    comboLocal.DisplayMember = "nombre";

                    comboVisitante.DataSource = table2;
                    comboVisitante.ValueMember = "idEquipo";
                    comboVisitante.DisplayMember = "nombre";
                }

                sql = "SELECT idEstadio, nombre FROM estadios";
                using (var adapter = new MySqlDataAdapter(sql, conn))
                {
                    var table = new DataTable();
                    adapter.Fill(table);

                    comboEstadio.DataSource = table;
                    comboEstadio.ValueMember = "idEstadio";
                    comboEstadio.DisplayMember = "nombre";
                }

                sql = "SELECT idEstadio, nombre FROM estadios";
                using (var adapter = new MySqlDataAdapter(sql, conn))
                {
                    var table = new DataTable();
                    adapter.Fill(table);

                    comboEstadio.DataSource = table;
                    comboEstadio.ValueMember = "idEstadio";
                    comboEstadio.DisplayMember = "nombre";
                }

                sql = "SELECT idArbitro, CONCAT(nombre, ' ', apellidoPaterno, ' ', apellidoMaterno) AS nombre FROM arbitros";
                using (var adapter = new MySqlDataAdapter(sql, conn))
                {
                    var table = new DataTable();
                    adapter.Fill(table);

                    comboArbitro.DataSource = table;
                    comboArbitro.ValueMember = "idArbitro";
                    comboArbitro.DisplayMember = "nombre";
                }

            }
        }
        private void UpdateToSelectedRow(int rowIndex)
        {
            if (rowIndex >= 0)
            {
                DataGridViewRow row = tablaPartidos.Rows[rowIndex];

                comboLocal.SelectedValue = row.Cells["idLocal"].Value;
                comboVisitante.SelectedValue = row.Cells["idVisitante"].Value;
                comboEstadio.SelectedValue = row.Cells["idEstadio"].Value;
                comboArbitro.SelectedValue = row.Cells["idArbitro"].Value;

                datePicker.Value = Convert.ToDateTime(row.Cells["Fecha"].Value);
                TimeSpan hora = TimeSpan.Parse(row.Cells["Hora"].Value.ToString());
                timePicker.Value = datePicker.Value.Date + hora;
            }
        }

        private void tablaPartidos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateToSelectedRow(e.RowIndex);
        }
    }
}
