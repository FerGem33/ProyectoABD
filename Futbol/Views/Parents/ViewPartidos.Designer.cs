using System.Windows.Forms;

namespace Futbol.Views
{
    partial class ViewPartidos
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablaPartidos = new System.Windows.Forms.DataGridView();
            this.comboLocal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboVisitante = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboEstadio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboArbitro = new System.Windows.Forms.ComboBox();
            this.title = new System.Windows.Forms.Label();
            this.insertar_btn = new System.Windows.Forms.Button();
            this.actualizar_btn = new System.Windows.Forms.Button();
            this.eliminar_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPartidos)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaPartidos
            // 
            this.tablaPartidos.AllowUserToAddRows = false;
            this.tablaPartidos.AllowUserToDeleteRows = false;
            this.tablaPartidos.AllowUserToOrderColumns = true;
            this.tablaPartidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPartidos.Location = new System.Drawing.Point(12, 266);
            this.tablaPartidos.MultiSelect = false;
            this.tablaPartidos.Name = "tablaPartidos";
            this.tablaPartidos.ReadOnly = true;
            this.tablaPartidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPartidos.Size = new System.Drawing.Size(969, 272);
            this.tablaPartidos.TabIndex = 0;
            this.tablaPartidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPartidos_CellDoubleClick);
            // 
            // comboLocal
            // 
            this.comboLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLocal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboLocal.FormattingEnabled = true;
            this.comboLocal.Location = new System.Drawing.Point(28, 145);
            this.comboLocal.Name = "comboLocal";
            this.comboLocal.Size = new System.Drawing.Size(210, 24);
            this.comboLocal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(22)))));
            this.label1.Location = new System.Drawing.Point(24, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Equipo Local";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(22)))));
            this.label2.Location = new System.Drawing.Point(24, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Equipo Visitante";
            // 
            // comboVisitante
            // 
            this.comboVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboVisitante.FormattingEnabled = true;
            this.comboVisitante.Location = new System.Drawing.Point(28, 209);
            this.comboVisitante.Name = "comboVisitante";
            this.comboVisitante.Size = new System.Drawing.Size(210, 24);
            this.comboVisitante.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(22)))));
            this.label3.Location = new System.Drawing.Point(271, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estadio";
            // 
            // comboEstadio
            // 
            this.comboEstadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstadio.FormattingEnabled = true;
            this.comboEstadio.Location = new System.Drawing.Point(271, 145);
            this.comboEstadio.Name = "comboEstadio";
            this.comboEstadio.Size = new System.Drawing.Size(226, 24);
            this.comboEstadio.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(22)))));
            this.label4.Location = new System.Drawing.Point(527, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha";
            // 
            // datePicker
            // 
            this.datePicker.AllowDrop = true;
            this.datePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.CustomFormat = "";
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(531, 145);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(126, 26);
            this.datePicker.TabIndex = 8;
            // 
            // timePicker
            // 
            this.timePicker.AllowDrop = true;
            this.timePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(531, 209);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(93, 26);
            this.timePicker.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(22)))));
            this.label5.Location = new System.Drawing.Point(527, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(22)))));
            this.label6.Location = new System.Drawing.Point(271, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Arbitro";
            // 
            // comboArbitro
            // 
            this.comboArbitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboArbitro.FormattingEnabled = true;
            this.comboArbitro.Location = new System.Drawing.Point(271, 209);
            this.comboArbitro.Name = "comboArbitro";
            this.comboArbitro.Size = new System.Drawing.Size(226, 24);
            this.comboArbitro.TabIndex = 12;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(22)))));
            this.title.Location = new System.Drawing.Point(23, 50);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(165, 26);
            this.title.TabIndex = 13;
            this.title.Text = "Menú Partidos";
            // 
            // insertar_btn
            // 
            this.insertar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(155)))), ((int)(((byte)(72)))));
            this.insertar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertar_btn.Location = new System.Drawing.Point(797, 133);
            this.insertar_btn.Name = "insertar_btn";
            this.insertar_btn.Size = new System.Drawing.Size(171, 30);
            this.insertar_btn.TabIndex = 14;
            this.insertar_btn.Text = "Insertar";
            this.insertar_btn.UseVisualStyleBackColor = false;
            this.insertar_btn.Click += new System.EventHandler(this.insertar_btn_Click);
            // 
            // actualizar_btn
            // 
            this.actualizar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(191)))), ((int)(((byte)(78)))));
            this.actualizar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizar_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.actualizar_btn.Location = new System.Drawing.Point(797, 169);
            this.actualizar_btn.Name = "actualizar_btn";
            this.actualizar_btn.Size = new System.Drawing.Size(171, 30);
            this.actualizar_btn.TabIndex = 15;
            this.actualizar_btn.Text = "Actualizar";
            this.actualizar_btn.UseVisualStyleBackColor = false;
            this.actualizar_btn.Click += new System.EventHandler(this.actualizar_btn_Click);
            // 
            // eliminar_btn
            // 
            this.eliminar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(57)))), ((int)(((byte)(36)))));
            this.eliminar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar_btn.ForeColor = System.Drawing.Color.White;
            this.eliminar_btn.Location = new System.Drawing.Point(797, 205);
            this.eliminar_btn.Name = "eliminar_btn";
            this.eliminar_btn.Size = new System.Drawing.Size(171, 30);
            this.eliminar_btn.TabIndex = 16;
            this.eliminar_btn.Text = "Eliminar";
            this.eliminar_btn.UseVisualStyleBackColor = false;
            this.eliminar_btn.Click += new System.EventHandler(this.eliminar_btn_Click);
            // 
            // ViewPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 550);
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
            this.Controls.Add(this.tablaPartidos);
            this.Name = "ViewPartidos";
            this.Text = "Partidos";
            ((System.ComponentModel.ISupportInitialize)(this.tablaPartidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaPartidos;
        private System.Windows.Forms.ComboBox comboLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboVisitante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboEstadio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboArbitro;
        private Label title;
        private Button insertar_btn;
        private Button actualizar_btn;
        private Button eliminar_btn;
    }
}