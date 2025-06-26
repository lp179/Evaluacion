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
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(76, 55);
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
            this.dgvOpciones.Size = new System.Drawing.Size(284, 211);
            this.dgvOpciones.TabIndex = 1;
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(677, 450);
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
    }
}