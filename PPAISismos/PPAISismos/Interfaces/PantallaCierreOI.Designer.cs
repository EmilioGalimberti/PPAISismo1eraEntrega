namespace PPAISismos.Interfaces
{
    partial class PantallaCierreOI
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
            this.dataGridOrdenes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxObservaciones = new System.Windows.Forms.TextBox();
            this.labelObservacion = new System.Windows.Forms.Label();
            this.btnGuardarObservacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOrdenes
            // 
            this.dataGridOrdenes.AllowUserToAddRows = false;
            this.dataGridOrdenes.AllowUserToDeleteRows = false;
            this.dataGridOrdenes.AllowUserToResizeColumns = false;
            this.dataGridOrdenes.AllowUserToResizeRows = false;
            this.dataGridOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrdenes.Location = new System.Drawing.Point(12, 38);
            this.dataGridOrdenes.MultiSelect = false;
            this.dataGridOrdenes.Name = "dataGridOrdenes";
            this.dataGridOrdenes.ReadOnly = true;
            this.dataGridOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOrdenes.Size = new System.Drawing.Size(349, 64);
            this.dataGridOrdenes.TabIndex = 0;
            this.dataGridOrdenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrdenes_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ordenes De Inspeccion Realizadas de:";
            // 
            // textBoxObservaciones
            // 
            this.textBoxObservaciones.Location = new System.Drawing.Point(516, 38);
            this.textBoxObservaciones.Multiline = true;
            this.textBoxObservaciones.Name = "textBoxObservaciones";
            this.textBoxObservaciones.Size = new System.Drawing.Size(173, 39);
            this.textBoxObservaciones.TabIndex = 2;
            this.textBoxObservaciones.Tag = "";
            this.textBoxObservaciones.Visible = false;
            // 
            // labelObservacion
            // 
            this.labelObservacion.AutoSize = true;
            this.labelObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObservacion.ForeColor = System.Drawing.Color.White;
            this.labelObservacion.Location = new System.Drawing.Point(512, 15);
            this.labelObservacion.Name = "labelObservacion";
            this.labelObservacion.Size = new System.Drawing.Size(51, 20);
            this.labelObservacion.TabIndex = 3;
            this.labelObservacion.Text = "label2";
            this.labelObservacion.Visible = false;
            // 
            // btnGuardarObservacion
            // 
            this.btnGuardarObservacion.Location = new System.Drawing.Point(516, 83);
            this.btnGuardarObservacion.Name = "btnGuardarObservacion";
            this.btnGuardarObservacion.Size = new System.Drawing.Size(60, 23);
            this.btnGuardarObservacion.TabIndex = 4;
            this.btnGuardarObservacion.Text = "Guardar";
            this.btnGuardarObservacion.UseVisualStyleBackColor = true;
            this.btnGuardarObservacion.Visible = false;
            this.btnGuardarObservacion.Click += new System.EventHandler(this.btnGuardarObservacion_Click);
            // 
            // PantallaCierreOI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(957, 366);
            this.Controls.Add(this.btnGuardarObservacion);
            this.Controls.Add(this.labelObservacion);
            this.Controls.Add(this.textBoxObservaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridOrdenes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PantallaCierreOI";
            this.Text = "PantallaCierreOI";
            this.Load += new System.EventHandler(this.PantallaCierreOI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOrdenes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxObservaciones;
        private System.Windows.Forms.Label labelObservacion;
        private System.Windows.Forms.Button btnGuardarObservacion;
    }
}