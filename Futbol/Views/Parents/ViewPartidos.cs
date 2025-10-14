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

namespace Futbol.Views
{
    public partial class ViewPartidos : Form
    {
        public ViewPartidos()
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

                string sql = @"SELECT 
                                p.idPartido AS idPartido,
                                p.idLocal   AS idLocal,
                                p.idVisitante AS idVisitante,
                                p.idEstadio AS idEstadio,
                                p.idArbitro AS idArbitro,
                                p.idliga AS idLiga,
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

                    tablaPartidos.Columns["idPartido"].Visible = false;
                    tablaPartidos.Columns["idLiga"].Visible = false;
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

        private void UpdateTableToSelectedRow(int rowIndex)
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
        private void ReloadTable()
        {
            LoadData();
            UpdateTableToSelectedRow(tablaPartidos.SelectedRows[0].Index);
        }

        private void tablaPartidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateTableToSelectedRow(e.RowIndex);
        }

        private void insertar_btn_Click(object sender, EventArgs e)
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();
                int idLiga, idLocal, idVisitante, idEstadio, idArbitro;

                idLiga = Convert.ToInt32(tablaPartidos.SelectedRows[0].Cells["idLiga"].Value);
                idLocal = Convert.ToInt32(comboLocal.SelectedValue);
                idVisitante = Convert.ToInt32(comboVisitante.SelectedValue);
                idEstadio = Convert.ToInt32(comboEstadio.SelectedValue);
                idArbitro = Convert.ToInt32(comboArbitro.SelectedValue);

                DateTime fecha = datePicker.Value.Date;
                TimeSpan hora = timePicker.Value.TimeOfDay;

                var sql = @"INSERT INTO partidos (idEstadio, idLocal, idVisitante, idArbitro, idLiga, fecha, hora)
                    VALUES (@estadio, @local, @visitante, @arbitro, @liga, @fecha, @hora)";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@local", MySqlDbType.Int32).Value = idLocal;
                    cmd.Parameters.Add("@visitante", MySqlDbType.Int32).Value = idVisitante;
                    cmd.Parameters.Add("@estadio", MySqlDbType.Int32).Value = idEstadio;
                    cmd.Parameters.Add("@arbitro", MySqlDbType.Int32).Value = idArbitro;
                    cmd.Parameters.Add("@liga", MySqlDbType.Int32).Value = idLiga;
                    cmd.Parameters.Add("@fecha", MySqlDbType.Date).Value = datePicker.Value.Date;
                    cmd.Parameters.Add("@hora", MySqlDbType.Time).Value = timePicker.Value.TimeOfDay;
                   
                    cmd.ExecuteNonQuery();
                }
            }

            ReloadTable();
        }

        private void actualizar_btn_Click(object sender, EventArgs e)
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();
                int idPartido, idLiga, idLocal, idVisitante, idEstadio, idArbitro;

                idPartido = Convert.ToInt32(tablaPartidos.SelectedRows[0].Cells["idPartido"].Value);
                idLiga = Convert.ToInt32(tablaPartidos.SelectedRows[0].Cells["idLiga"].Value);
                idLocal = Convert.ToInt32(comboLocal.SelectedValue);
                idVisitante = Convert.ToInt32(comboVisitante.SelectedValue);
                idEstadio = Convert.ToInt32(comboEstadio.SelectedValue);
                idArbitro = Convert.ToInt32(comboArbitro.SelectedValue);

                DateTime fecha = datePicker.Value.Date;
                TimeSpan hora = timePicker.Value.TimeOfDay;

                var sql = @"UPDATE partidos
                          SET idEstadio = @estadio,
                              idLocal = @local,
                              idVisitante = @visitante,
                              idArbitro = @arbitro,
                              idLiga = @liga,
                              fecha = @fecha,
                              hora = @hora
                          WHERE idPartido = @partido"
                        ;
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@partido", MySqlDbType.Int32).Value = idPartido;
                    cmd.Parameters.Add("@local", MySqlDbType.Int32).Value = idLocal;
                    cmd.Parameters.Add("@visitante", MySqlDbType.Int32).Value = idVisitante;
                    cmd.Parameters.Add("@estadio", MySqlDbType.Int32).Value = idEstadio;
                    cmd.Parameters.Add("@arbitro", MySqlDbType.Int32).Value = idArbitro;
                    cmd.Parameters.Add("@liga", MySqlDbType.Int32).Value = idLiga;
                    cmd.Parameters.Add("@fecha", MySqlDbType.Date).Value = datePicker.Value.Date;
                    cmd.Parameters.Add("@hora", MySqlDbType.Time).Value = timePicker.Value.TimeOfDay;

                    cmd.ExecuteNonQuery();
                }
            }

            ReloadTable();
        }

        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();
                int idPartido = Convert.ToInt32(tablaPartidos.SelectedRows[0].Cells["idPartido"].Value);

                var sql = "DELETE FROM partidos WHERE idPartido = @partido";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@partido", MySqlDbType.Int32).Value = idPartido;
                    cmd.ExecuteNonQuery();
                }
            }

            ReloadTable();
        }
    }
}
