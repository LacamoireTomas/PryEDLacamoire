namespace PryEDLacamoire
{
    partial class frmConsultaBaseDatos
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
            this.lblConsultaSql = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConsultaSql
            // 
            this.lblConsultaSql.AutoSize = true;
            this.lblConsultaSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaSql.Location = new System.Drawing.Point(13, 13);
            this.lblConsultaSql.Name = "lblConsultaSql";
            this.lblConsultaSql.Size = new System.Drawing.Size(150, 20);
            this.lblConsultaSql.TabIndex = 0;
            this.lblConsultaSql.Text = "Consulta en SQL:";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(586, 222);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // frmConsultaBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(676, 515);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblConsultaSql);
            this.Name = "frmConsultaBaseDatos";
            this.Text = "frmConsultaBaseDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultaSql;
        private System.Windows.Forms.Button btnListar;
    }
}