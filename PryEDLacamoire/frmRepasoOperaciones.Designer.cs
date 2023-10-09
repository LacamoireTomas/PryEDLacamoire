namespace PryEDLacamoire
{
    partial class frmRepasoOperaciones
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
            this.lblOperacion = new System.Windows.Forms.Label();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblRepasoOperaciones = new System.Windows.Forms.Label();
            this.dgvRepasoOperaciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepasoOperaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Location = new System.Drawing.Point(12, 9);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(200, 13);
            this.lblOperacion.TabIndex = 0;
            this.lblOperacion.Text = "Operación a realizar en la base de datos:";
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Location = new System.Drawing.Point(218, 6);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(362, 21);
            this.cmbOperacion.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(586, 4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblRepasoOperaciones
            // 
            this.lblRepasoOperaciones.AutoSize = true;
            this.lblRepasoOperaciones.Location = new System.Drawing.Point(15, 35);
            this.lblRepasoOperaciones.Name = "lblRepasoOperaciones";
            this.lblRepasoOperaciones.Size = new System.Drawing.Size(35, 13);
            this.lblRepasoOperaciones.TabIndex = 3;
            this.lblRepasoOperaciones.Text = "label1";
            // 
            // dgvRepasoOperaciones
            // 
            this.dgvRepasoOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepasoOperaciones.Location = new System.Drawing.Point(15, 172);
            this.dgvRepasoOperaciones.Name = "dgvRepasoOperaciones";
            this.dgvRepasoOperaciones.Size = new System.Drawing.Size(649, 322);
            this.dgvRepasoOperaciones.TabIndex = 4;
            // 
            // frmRepasoOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 515);
            this.Controls.Add(this.dgvRepasoOperaciones);
            this.Controls.Add(this.lblRepasoOperaciones);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.lblOperacion);
            this.Name = "frmRepasoOperaciones";
            this.Text = "frmRepasoOperaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepasoOperaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblRepasoOperaciones;
        private System.Windows.Forms.DataGridView dgvRepasoOperaciones;
    }
}