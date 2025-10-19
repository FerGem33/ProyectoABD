namespace Futbol.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.mainContainer = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ligasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbitrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posicionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.mainContainer);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(992, 504);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(992, 528);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.Color.Linen;
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(992, 504);
            this.mainContainer.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Linen;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.jugadoresToolStripMenuItem,
            this.partidosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ligasToolStripMenuItem,
            this.entrenadoresToolStripMenuItem,
            this.arbitrosToolStripMenuItem,
            this.estadiosToolStripMenuItem,
            this.posicionesToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(72, 20);
            this.toolStripMenuItem1.Text = "Catálogos";
            // 
            // ligasToolStripMenuItem
            // 
            this.ligasToolStripMenuItem.Name = "ligasToolStripMenuItem";
            this.ligasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ligasToolStripMenuItem.Text = "Ligas";
            // 
            // entrenadoresToolStripMenuItem
            // 
            this.entrenadoresToolStripMenuItem.Name = "entrenadoresToolStripMenuItem";
            this.entrenadoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.entrenadoresToolStripMenuItem.Text = "Entrenadores";
            // 
            // arbitrosToolStripMenuItem
            // 
            this.arbitrosToolStripMenuItem.Name = "arbitrosToolStripMenuItem";
            this.arbitrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arbitrosToolStripMenuItem.Text = "Arbitros";
            // 
            // estadiosToolStripMenuItem
            // 
            this.estadiosToolStripMenuItem.Name = "estadiosToolStripMenuItem";
            this.estadiosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estadiosToolStripMenuItem.Text = "Estadios";
            // 
            // posicionesToolStripMenuItem
            // 
            this.posicionesToolStripMenuItem.Name = "posicionesToolStripMenuItem";
            this.posicionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.posicionesToolStripMenuItem.Text = "Posiciones";
            this.posicionesToolStripMenuItem.Click += new System.EventHandler(this.posicionesToolStripMenuItem_Click);
            // 
            // jugadoresToolStripMenuItem
            // 
            this.jugadoresToolStripMenuItem.Name = "jugadoresToolStripMenuItem";
            this.jugadoresToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.jugadoresToolStripMenuItem.Text = "Jugadores";
            // 
            // partidosToolStripMenuItem
            // 
            this.partidosToolStripMenuItem.Name = "partidosToolStripMenuItem";
            this.partidosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.partidosToolStripMenuItem.Text = "Partidos";
            this.partidosToolStripMenuItem.Click += new System.EventHandler(this.partidosToolStripMenuItem_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 528);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.Text = "Gestión de Partidos de Fútbol";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ligasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrenadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbitrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posicionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jugadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partidosToolStripMenuItem;
        private System.Windows.Forms.Panel mainContainer;
    }
}