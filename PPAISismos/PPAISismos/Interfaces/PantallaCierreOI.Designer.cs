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
            this.checkedListBoxMotivos = new System.Windows.Forms.CheckedListBox();
            this.labelMotivosFueraServicio = new System.Windows.Forms.Label();
            this.buttonConfirmarMotivos = new System.Windows.Forms.Button();
            this.labelComentario = new System.Windows.Forms.Label();
            this.textBoxComentario = new System.Windows.Forms.TextBox();
            this.btnGuardarComentario = new System.Windows.Forms.Button();
            this.btnConfirmarCierreOI = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
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
            this.dataGridOrdenes.Location = new System.Drawing.Point(28, 61);
            this.dataGridOrdenes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridOrdenes.MultiSelect = false;
            this.dataGridOrdenes.Name = "dataGridOrdenes";
            this.dataGridOrdenes.ReadOnly = true;
            this.dataGridOrdenes.RowHeadersWidth = 51;
            this.dataGridOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOrdenes.Size = new System.Drawing.Size(550, 300);
            this.dataGridOrdenes.TabIndex = 0;
            this.dataGridOrdenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrdenes_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tus Órdenes de Inspección Completamente Realizadas:";
            // 
            // textBoxObservaciones
            // 
            this.textBoxObservaciones.Location = new System.Drawing.Point(687, 61);
            this.textBoxObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxObservaciones.Multiline = true;
            this.textBoxObservaciones.Name = "textBoxObservaciones";
            this.textBoxObservaciones.Size = new System.Drawing.Size(550, 150);
            this.textBoxObservaciones.TabIndex = 2;
            this.textBoxObservaciones.Tag = "";
            this.textBoxObservaciones.Visible = false;
            // 
            // labelObservacion
            // 
            this.labelObservacion.AutoSize = true;
            this.labelObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObservacion.ForeColor = System.Drawing.Color.White;
            this.labelObservacion.Location = new System.Drawing.Point(683, 23);
            this.labelObservacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelObservacion.Name = "labelObservacion";
            this.labelObservacion.Size = new System.Drawing.Size(64, 25);
            this.labelObservacion.TabIndex = 3;
            this.labelObservacion.Text = "label2";
            this.labelObservacion.Visible = false;
            // 
            // btnGuardarObservacion
            // 
            this.btnGuardarObservacion.Location = new System.Drawing.Point(686, 219);
            this.btnGuardarObservacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarObservacion.Name = "btnGuardarObservacion";
            this.btnGuardarObservacion.Size = new System.Drawing.Size(100, 30);
            this.btnGuardarObservacion.TabIndex = 4;
            this.btnGuardarObservacion.Text = "Guardar";
            this.btnGuardarObservacion.UseVisualStyleBackColor = true;
            this.btnGuardarObservacion.Visible = false;
            this.btnGuardarObservacion.Click += new System.EventHandler(this.btnGuardarObservacion_Click);
            // 
            // checkedListBoxMotivos
            // 
            this.checkedListBoxMotivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(79)))));
            this.checkedListBoxMotivos.ForeColor = System.Drawing.SystemColors.Window;
            this.checkedListBoxMotivos.FormattingEnabled = true;
            this.checkedListBoxMotivos.Location = new System.Drawing.Point(687, 321);
            this.checkedListBoxMotivos.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBoxMotivos.Name = "checkedListBoxMotivos";
            this.checkedListBoxMotivos.Size = new System.Drawing.Size(550, 191);
            this.checkedListBoxMotivos.TabIndex = 5;
            this.checkedListBoxMotivos.Visible = false;
            // 
            // labelMotivosFueraServicio
            // 
            this.labelMotivosFueraServicio.AutoSize = true;
            this.labelMotivosFueraServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotivosFueraServicio.ForeColor = System.Drawing.Color.White;
            this.labelMotivosFueraServicio.Location = new System.Drawing.Point(684, 287);
            this.labelMotivosFueraServicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMotivosFueraServicio.Name = "labelMotivosFueraServicio";
            this.labelMotivosFueraServicio.Size = new System.Drawing.Size(510, 20);
            this.labelMotivosFueraServicio.TabIndex = 7;
            this.labelMotivosFueraServicio.Text = "Seleccione los motivos para poner Fuera de Servicio al Sismógrafo";
            this.labelMotivosFueraServicio.Visible = false;
            // 
            // buttonConfirmarMotivos
            // 
            this.buttonConfirmarMotivos.Location = new System.Drawing.Point(686, 520);
            this.buttonConfirmarMotivos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfirmarMotivos.Name = "buttonConfirmarMotivos";
            this.buttonConfirmarMotivos.Size = new System.Drawing.Size(150, 30);
            this.buttonConfirmarMotivos.TabIndex = 8;
            this.buttonConfirmarMotivos.Text = "Confirmar motivos";
            this.buttonConfirmarMotivos.UseVisualStyleBackColor = true;
            this.buttonConfirmarMotivos.Visible = false;
            this.buttonConfirmarMotivos.Click += new System.EventHandler(this.buttonConfirmarMotivos_Click);
            // 
            // labelComentario
            // 
            this.labelComentario.AutoSize = true;
            this.labelComentario.ForeColor = System.Drawing.Color.Snow;
            this.labelComentario.Location = new System.Drawing.Point(684, 592);
            this.labelComentario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComentario.Name = "labelComentario";
            this.labelComentario.Size = new System.Drawing.Size(106, 16);
            this.labelComentario.TabIndex = 9;
            this.labelComentario.Text = "labelComentario";
            this.labelComentario.Visible = false;
            // 
            // textBoxComentario
            // 
            this.textBoxComentario.Location = new System.Drawing.Point(686, 623);
            this.textBoxComentario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxComentario.Name = "textBoxComentario";
            this.textBoxComentario.Size = new System.Drawing.Size(550, 22);
            this.textBoxComentario.TabIndex = 10;
            this.textBoxComentario.Visible = false;
            this.textBoxComentario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnGuardarComentario
            // 
            this.btnGuardarComentario.Location = new System.Drawing.Point(686, 653);
            this.btnGuardarComentario.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarComentario.Name = "btnGuardarComentario";
            this.btnGuardarComentario.Size = new System.Drawing.Size(150, 30);
            this.btnGuardarComentario.TabIndex = 11;
            this.btnGuardarComentario.Text = "Guardar comentario";
            this.btnGuardarComentario.UseVisualStyleBackColor = true;
            this.btnGuardarComentario.Visible = false;
            this.btnGuardarComentario.Click += new System.EventHandler(this.btnGuardarComentario_Click);
            // 
            // btnConfirmarCierreOI
            // 
            this.btnConfirmarCierreOI.BackColor = System.Drawing.Color.Green;
            this.btnConfirmarCierreOI.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarCierreOI.Location = new System.Drawing.Point(942, 739);
            this.btnConfirmarCierreOI.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmarCierreOI.Name = "btnConfirmarCierreOI";
            this.btnConfirmarCierreOI.Size = new System.Drawing.Size(150, 30);
            this.btnConfirmarCierreOI.TabIndex = 12;
            this.btnConfirmarCierreOI.Text = "Confirmar cierre";
            this.btnConfirmarCierreOI.UseVisualStyleBackColor = false;
            this.btnConfirmarCierreOI.Visible = false;
            this.btnConfirmarCierreOI.Click += new System.EventHandler(this.btnConfirmarCierreOI_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(1136, 739);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // PantallaCierreOI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1300, 1000);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmarCierreOI);
            this.Controls.Add(this.btnGuardarComentario);
            this.Controls.Add(this.textBoxComentario);
            this.Controls.Add(this.labelComentario);
            this.Controls.Add(this.buttonConfirmarMotivos);
            this.Controls.Add(this.labelMotivosFueraServicio);
            this.Controls.Add(this.checkedListBoxMotivos);
            this.Controls.Add(this.btnGuardarObservacion);
            this.Controls.Add(this.labelObservacion);
            this.Controls.Add(this.textBoxObservaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridOrdenes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PantallaCierreOI";
            this.Text = "Dar Cierre a Orden de Inspección de Estación Sismológica";
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
        private System.Windows.Forms.CheckedListBox checkedListBoxMotivos;
        private System.Windows.Forms.Label labelMotivosFueraServicio;
        private System.Windows.Forms.Button buttonConfirmarMotivos;
        private System.Windows.Forms.Label labelComentario;
        private System.Windows.Forms.TextBox textBoxComentario;
        private System.Windows.Forms.Button btnGuardarComentario;
        private System.Windows.Forms.Button btnConfirmarCierreOI;
        private System.Windows.Forms.Button btnCancelar;
    }
}