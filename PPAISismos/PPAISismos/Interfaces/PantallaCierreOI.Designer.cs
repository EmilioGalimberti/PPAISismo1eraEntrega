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
            this.comboBoxTiposMotivo = new System.Windows.Forms.ComboBox();
            this.labelTipoMotivo = new System.Windows.Forms.Label();
            this.btnSeleccionarTipoMotivo = new System.Windows.Forms.Button();
            this.textBoxComentario = new System.Windows.Forms.TextBox();
            this.labelComentario = new System.Windows.Forms.Label();
            this.btnGuardarComentario = new System.Windows.Forms.Button();
            this.labelConfirmacion = new System.Windows.Forms.Label();
            this.btnConfirmarCierre = new System.Windows.Forms.Button();
            this.btnCancelarCierre = new System.Windows.Forms.Button();
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
            // comboBoxTiposMotivo
            // 
            this.comboBoxTiposMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTiposMotivo.FormattingEnabled = true;
            this.comboBoxTiposMotivo.Location = new System.Drawing.Point(516, 150);
            this.comboBoxTiposMotivo.Name = "comboBoxTiposMotivo";
            this.comboBoxTiposMotivo.Size = new System.Drawing.Size(173, 21);
            this.comboBoxTiposMotivo.TabIndex = 5;
            this.comboBoxTiposMotivo.Visible = false;
            // 
            // labelTipoMotivo
            // 
            this.labelTipoMotivo.AutoSize = true;
            this.labelTipoMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoMotivo.ForeColor = System.Drawing.Color.White;
            this.labelTipoMotivo.Location = new System.Drawing.Point(512, 127);
            this.labelTipoMotivo.Name = "labelTipoMotivo";
            this.labelTipoMotivo.Size = new System.Drawing.Size(51, 20);
            this.labelTipoMotivo.TabIndex = 6;
            this.labelTipoMotivo.Text = "label2";
            this.labelTipoMotivo.Visible = false;
            // 
            // btnSeleccionarTipoMotivo
            // 
            this.btnSeleccionarTipoMotivo.Location = new System.Drawing.Point(516, 177);
            this.btnSeleccionarTipoMotivo.Name = "btnSeleccionarTipoMotivo";
            this.btnSeleccionarTipoMotivo.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarTipoMotivo.TabIndex = 7;
            this.btnSeleccionarTipoMotivo.Text = "Seleccionar";
            this.btnSeleccionarTipoMotivo.UseVisualStyleBackColor = true;
            this.btnSeleccionarTipoMotivo.Visible = false;
            this.btnSeleccionarTipoMotivo.Click += new System.EventHandler(this.btnSeleccionarTipoMotivo_Click);
            // 
            // textBoxComentario
            // 
            this.textBoxComentario.Location = new System.Drawing.Point(516, 220);
            this.textBoxComentario.Multiline = true;
            this.textBoxComentario.Name = "textBoxComentario";
            this.textBoxComentario.Size = new System.Drawing.Size(173, 39);
            this.textBoxComentario.TabIndex = 8;
            this.textBoxComentario.Visible = false;
            // 
            // labelComentario
            // 
            this.labelComentario.AutoSize = true;
            this.labelComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComentario.ForeColor = System.Drawing.Color.White;
            this.labelComentario.Location = new System.Drawing.Point(512, 197);
            this.labelComentario.Name = "labelComentario";
            this.labelComentario.Size = new System.Drawing.Size(51, 20);
            this.labelComentario.TabIndex = 9;
            this.labelComentario.Text = "label2";
            this.labelComentario.Visible = false;
            // 
            // btnGuardarComentario
            // 
            this.btnGuardarComentario.Location = new System.Drawing.Point(516, 265);
            this.btnGuardarComentario.Name = "btnGuardarComentario";
            this.btnGuardarComentario.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarComentario.TabIndex = 10;
            this.btnGuardarComentario.Text = "Guardar";
            this.btnGuardarComentario.UseVisualStyleBackColor = true;
            this.btnGuardarComentario.Visible = false;
            this.btnGuardarComentario.Click += new System.EventHandler(this.btnGuardarComentario_Click);
            // 
            // labelConfirmacion
            // 
            this.labelConfirmacion.AutoSize = true;
            this.labelConfirmacion.Location = new System.Drawing.Point(12, 200);
            this.labelConfirmacion.Name = "labelConfirmacion";
            this.labelConfirmacion.Size = new System.Drawing.Size(0, 13);
            this.labelConfirmacion.TabIndex = 10;
            this.labelConfirmacion.Visible = false;
            // 
            // btnConfirmarCierre
            // 
            this.btnConfirmarCierre.Location = new System.Drawing.Point(12, 230);
            this.btnConfirmarCierre.Name = "btnConfirmarCierre";
            this.btnConfirmarCierre.Size = new System.Drawing.Size(120, 23);
            this.btnConfirmarCierre.TabIndex = 11;
            this.btnConfirmarCierre.Text = "Confirmar Cierre";
            this.btnConfirmarCierre.UseVisualStyleBackColor = true;
            this.btnConfirmarCierre.Visible = false;
            this.btnConfirmarCierre.Click += new System.EventHandler(this.btnConfirmarCierre_Click);
            // 
            // btnCancelarCierre
            // 
            this.btnCancelarCierre.Location = new System.Drawing.Point(150, 230);
            this.btnCancelarCierre.Name = "btnCancelarCierre";
            this.btnCancelarCierre.Size = new System.Drawing.Size(120, 23);
            this.btnCancelarCierre.TabIndex = 12;
            this.btnCancelarCierre.Text = "Cancelar";
            this.btnCancelarCierre.UseVisualStyleBackColor = true;
            this.btnCancelarCierre.Visible = false;
            this.btnCancelarCierre.Click += new System.EventHandler(this.btnCancelarCierre_Click);
            // 
            // PantallaCierreOI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(957, 366);
            this.Controls.Add(this.btnCancelarCierre);
            this.Controls.Add(this.btnConfirmarCierre);
            this.Controls.Add(this.labelConfirmacion);
            this.Controls.Add(this.btnGuardarComentario);
            this.Controls.Add(this.labelComentario);
            this.Controls.Add(this.textBoxComentario);
            this.Controls.Add(this.btnSeleccionarTipoMotivo);
            this.Controls.Add(this.labelTipoMotivo);
            this.Controls.Add(this.comboBoxTiposMotivo);
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
        private System.Windows.Forms.ComboBox comboBoxTiposMotivo;
        private System.Windows.Forms.Label labelTipoMotivo;
        private System.Windows.Forms.Button btnSeleccionarTipoMotivo;
        private System.Windows.Forms.TextBox textBoxComentario;
        private System.Windows.Forms.Label labelComentario;
        private System.Windows.Forms.Button btnGuardarComentario;
        private System.Windows.Forms.Label labelConfirmacion;
        private System.Windows.Forms.Button btnConfirmarCierre;
        private System.Windows.Forms.Button btnCancelarCierre;
    }
}