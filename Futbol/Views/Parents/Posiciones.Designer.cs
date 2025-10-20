using System.Drawing;
using System.Windows.Forms;

namespace Futbol.Views.Parents
{
    partial class Posiciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.textboxPosicion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericId)).BeginInit();
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
            this.dataGrid.Location = new System.Drawing.Point(27, 255);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowTemplate.Height = 28;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(944, 218);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.SelectionChanged += new System.EventHandler(this.DataGrid_SelectionChanged);
            // 
            // eliminar_btn
            // 
            this.eliminar_btn.BackColor = System.Drawing.Color.IndianRed;
            this.eliminar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar_btn.ForeColor = System.Drawing.Color.White;
            this.eliminar_btn.Location = new System.Drawing.Point(774, 205);
            this.eliminar_btn.Name = "eliminar_btn";
            this.eliminar_btn.Size = new System.Drawing.Size(171, 30);
            this.eliminar_btn.TabIndex = 35;
            this.eliminar_btn.Text = "Eliminar";
            this.eliminar_btn.UseVisualStyleBackColor = false;
            this.eliminar_btn.Click += new System.EventHandler(this.Eliminar_btn_Click);
            // 
            // actualizar_btn
            // 
            this.actualizar_btn.BackColor = System.Drawing.Color.Goldenrod;
            this.actualizar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizar_btn.ForeColor = System.Drawing.Color.White;
            this.actualizar_btn.Location = new System.Drawing.Point(774, 169);
            this.actualizar_btn.Name = "actualizar_btn";
            this.actualizar_btn.Size = new System.Drawing.Size(171, 30);
            this.actualizar_btn.TabIndex = 34;
            this.actualizar_btn.Text = "Actualizar";
            this.actualizar_btn.UseVisualStyleBackColor = false;
            this.actualizar_btn.Click += new System.EventHandler(this.Actualizar_btn_Click);
            // 
            // insertar_btn
            // 
            this.insertar_btn.BackColor = System.Drawing.Color.OliveDrab;
            this.insertar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertar_btn.ForeColor = System.Drawing.Color.White;
            this.insertar_btn.Location = new System.Drawing.Point(774, 133);
            this.insertar_btn.Name = "insertar_btn";
            this.insertar_btn.Size = new System.Drawing.Size(171, 30);
            this.insertar_btn.TabIndex = 33;
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
            this.title.Location = new System.Drawing.Point(36, 44);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(3);
            this.title.Size = new System.Drawing.Size(162, 37);
            this.title.TabIndex = 36;
            this.title.Text = "Posiciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(169, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Posición";
            // 
            // textboxPosicion
            // 
            this.textboxPosicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPosicion.Location = new System.Drawing.Point(173, 188);
            this.textboxPosicion.MaxLength = 30;
            this.textboxPosicion.Name = "textboxPosicion";
            this.textboxPosicion.Size = new System.Drawing.Size(265, 29);
            this.textboxPosicion.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(54, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Id";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numericId
            // 
            this.numericId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericId.Location = new System.Drawing.Point(58, 189);
            this.numericId.Name = "numericId";
            this.numericId.Size = new System.Drawing.Size(80, 29);
            this.numericId.TabIndex = 40;
            this.numericId.ValueChanged += new System.EventHandler(this.numericId_ValueChanged);
            // 
            // Posiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.numericId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxPosicion);
            this.Controls.Add(this.title);
            this.Controls.Add(this.eliminar_btn);
            this.Controls.Add(this.actualizar_btn);
            this.Controls.Add(this.insertar_btn);
            this.Controls.Add(this.dataGrid);
            this.Name = "Posiciones";
            this.Size = new System.Drawing.Size(992, 504);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button eliminar_btn;
        private System.Windows.Forms.Button actualizar_btn;
        private System.Windows.Forms.Button insertar_btn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private TextBox textboxPosicion;
        private Label label2;
        private NumericUpDown numericId;
    }
}
