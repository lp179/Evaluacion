namespace Evaluacion
{
    partial class Opciones
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
            this.lblProducto = new System.Windows.Forms.Label();
            this.dgvOpciones = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtNuevaOpcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(66, 27);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(85, 25);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Ninguno";
            // 
            // dgvOpciones
            // 
            this.dgvOpciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpciones.Location = new System.Drawing.Point(91, 118);
            this.dgvOpciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOpciones.Name = "dgvOpciones";
            this.dgvOpciones.RowHeadersWidth = 51;
            this.dgvOpciones.RowTemplate.Height = 24;
            this.dgvOpciones.Size = new System.Drawing.Size(245, 261);
            this.dgvOpciones.TabIndex = 1;
            this.dgvOpciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOpciones_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAgregar.Location = new System.Drawing.Point(431, 58);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 45);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificar.Location = new System.Drawing.Point(431, 139);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(109, 45);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtNuevaOpcion
            // 
            this.txtNuevaOpcion.Location = new System.Drawing.Point(273, 65);
            this.txtNuevaOpcion.Name = "txtNuevaOpcion";
            this.txtNuevaOpcion.Size = new System.Drawing.Size(100, 30);
            this.txtNuevaOpcion.TabIndex = 4;
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.txtNuevaOpcion);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvOpciones);
            this.Controls.Add(this.lblProducto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Opciones";
            this.Text = "Opciones";
            this.Load += new System.EventHandler(this.Opciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DataGridView dgvOpciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtNuevaOpcion;
    }
}