using System;
using System.Drawing;
using System.Windows.Forms;

namespace Futbol.Views.Children
{
    partial class Partidos
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.eliminar_btn = new System.Windows.Forms.Button();
            this.actualizar_btn = new System.Windows.Forms.Button();
            this.insertar_btn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.comboArbitro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboEstadio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboVisitante = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboLocal = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.DarkOliveGreen;
            this.dataGrid.Location = new System.Drawing.Point(12, 229);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowTemplate.Height = 28;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(969, 265);
            this.dataGrid.TabIndex = 15;
            this.dataGrid.SelectionChanged += new System.EventHandler(this.DataGrid_SelectionChanged);
            // 
            // eliminar_btn
            // 
            this.eliminar_btn.BackColor = System.Drawing.Color.IndianRed;
            this.eliminar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar_btn.ForeColor = System.Drawing.Color.White;
            this.eliminar_btn.Location = new System.Drawing.Point(795, 178);
            this.eliminar_btn.Name = "eliminar_btn";
            this.eliminar_btn.Size = new System.Drawing.Size(171, 30);
            this.eliminar_btn.TabIndex = 32;
            this.eliminar_btn.Text = "Eliminar";
            this.eliminar_btn.UseVisualStyleBackColor = false;
            this.eliminar_btn.Click += new System.EventHandler(this.Eliminar_btn_Click);
            // 
            // actualizar_btn
            // 
            this.actualizar_btn.BackColor = System.Drawing.Color.Goldenrod;
            this.actualizar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizar_btn.ForeColor = System.Drawing.Color.White;
            this.actualizar_btn.Location = new System.Drawing.Point(795, 142);
            this.actualizar_btn.Name = "actualizar_btn";
            this.actualizar_btn.Size = new System.Drawing.Size(171, 30);
            this.actualizar_btn.TabIndex = 31;
            this.actualizar_btn.Text = "Actualizar";
            this.actualizar_btn.UseVisualStyleBackColor = false;
            this.actualizar_btn.Click += new System.EventHandler(this.Actualizar_btn_Click);
            // 
            // insertar_btn
            // 
            this.insertar_btn.BackColor = System.Drawing.Color.OliveDrab;
            this.insertar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertar_btn.ForeColor = System.Drawing.Color.White;
            this.insertar_btn.Location = new System.Drawing.Point(795, 106);
            this.insertar_btn.Name = "insertar_btn";
            this.insertar_btn.Size = new System.Drawing.Size(171, 30);
            this.insertar_btn.TabIndex = 30;
            this.insertar_btn.Text = "Registrar";
            this.insertar_btn.UseVisualStyleBackColor = false;
            this.insertar_btn.Click += new System.EventHandler(this.Insertar_btn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Transparent;
            this.title.Location = new System.Drawing.Point(20, 24);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(3);
            this.title.Size = new System.Drawing.Size(128, 37);
            this.title.TabIndex = 29;
            this.title.Text = "Partidos";
            // 
            // comboArbitro
            // 
            this.comboArbitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboArbitro.FormattingEnabled = true;
            this.comboArbitro.Location = new System.Drawing.Point(269, 182);
            this.comboArbitro.Name = "comboArbitro";
            this.comboArbitro.Size = new System.Drawing.Size(226, 24);
            this.comboArbitro.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(269, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Arbitro";
            // 
            // timePicker
            // 
            this.timePicker.AllowDrop = true;
            this.timePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(529, 182);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(93, 26);
            this.timePicker.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(525, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Hora";
            // 
            // datePicker
            // 
            this.datePicker.AllowDrop = true;
            this.datePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.CustomFormat = "";
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(636, 118);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(126, 26);
            this.datePicker.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(632, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Fecha";
            // 
            // comboEstadio
            // 
            this.comboEstadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstadio.FormattingEnabled = true;
            this.comboEstadio.Location = new System.Drawing.Point(376, 118);
            this.comboEstadio.Name = "comboEstadio";
            this.comboEstadio.Size = new System.Drawing.Size(226, 24);
            this.comboEstadio.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(376, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Estadio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Equipo Visitante";
            // 
            // comboVisitante
            // 
            this.comboVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboVisitante.FormattingEnabled = true;
            this.comboVisitante.Location = new System.Drawing.Point(26, 182);
            this.comboVisitante.Name = "comboVisitante";
            this.comboVisitante.Size = new System.Drawing.Size(210, 24);
            this.comboVisitante.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(129, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Equipo Local";
            // 
            // comboLocal
            // 
            this.comboLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLocal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboLocal.FormattingEnabled = true;
            this.comboLocal.Location = new System.Drawing.Point(133, 118);
            this.comboLocal.Name = "comboLocal";
            this.comboLocal.Size = new System.Drawing.Size(210, 24);
            this.comboLocal.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(22, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Id";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(26, 118);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(51, 26);
            this.numericUpDown1.TabIndex = 34;
            // 
            // Partidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.eliminar_btn);
            this.Controls.Add(this.actualizar_btn);
            this.Controls.Add(this.insertar_btn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.comboArbitro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboEstadio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboVisitante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboLocal);
            this.Controls.Add(this.dataGrid);
            this.Name = "Partidos";
            this.Size = new System.Drawing.Size(992, 504);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button eliminar_btn;
        private System.Windows.Forms.Button actualizar_btn;
        private System.Windows.Forms.Button insertar_btn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ComboBox comboArbitro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboEstadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboVisitante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboLocal;
        private Label label7;
        private NumericUpDown numericUpDown1;
    }
}
