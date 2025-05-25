namespace PPAISismos.Interfaces.menu
{
    partial class MenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.titulo1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cerrarOrdenDeInspeccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ordenesDeInspeccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarOrdenDeInspeccionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo1
            // 
            this.titulo1.AutoSize = true;
            this.titulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titulo1.Location = new System.Drawing.Point(257, 124);
            this.titulo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulo1.Name = "titulo1";
            this.titulo1.Size = new System.Drawing.Size(456, 29);
            this.titulo1.TabIndex = 0;
            this.titulo1.Text = "Observatorio Nacional: Red Sísmica   ";
            this.titulo1.Click += new System.EventHandler(this.titulo1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarOrdenDeInspeccionToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(261, 28);
            // 
            // cerrarOrdenDeInspeccionToolStripMenuItem
            // 
            this.cerrarOrdenDeInspeccionToolStripMenuItem.Name = "cerrarOrdenDeInspeccionToolStripMenuItem";
            this.cerrarOrdenDeInspeccionToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.cerrarOrdenDeInspeccionToolStripMenuItem.Text = "Cerrar Orden De Inspeccion";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenesDeInspeccionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ordenesDeInspeccionToolStripMenuItem
            // 
            this.ordenesDeInspeccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarOrdenDeInspeccionToolStripMenuItem1});
            this.ordenesDeInspeccionToolStripMenuItem.Name = "ordenesDeInspeccionToolStripMenuItem";
            this.ordenesDeInspeccionToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.ordenesDeInspeccionToolStripMenuItem.Text = "Ordenes de inspeccion";
            // 
            // cerrarOrdenDeInspeccionToolStripMenuItem1
            // 
            this.cerrarOrdenDeInspeccionToolStripMenuItem1.Name = "cerrarOrdenDeInspeccionToolStripMenuItem1";
            this.cerrarOrdenDeInspeccionToolStripMenuItem1.Size = new System.Drawing.Size(270, 26);
            this.cerrarOrdenDeInspeccionToolStripMenuItem1.Text = "Cerrar orden de inspeccion";
            this.cerrarOrdenDeInspeccionToolStripMenuItem1.Click += new System.EventHandler(this.cerrarOrdenDeInspeccionToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PPAISismos.Properties.Resources.Screenshot_2025_05_25_145349;
            this.pictureBox1.Location = new System.Drawing.Point(263, 158);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.titulo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPrincipal";
            this.Text = "Observatorio Nacional";
            this.Load += new System.EventHandler(this.menuPrincipal_Load);
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cerrarOrdenDeInspeccionToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeInspeccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarOrdenDeInspeccionToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}