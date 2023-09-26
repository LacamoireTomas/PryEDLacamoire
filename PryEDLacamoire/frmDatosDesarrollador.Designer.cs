namespace PryEDLacamoire
{
    partial class frmDatosDesarrollador
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
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.picboxFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(214, 35);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(80, 13);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI: 43559514";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(214, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(134, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre: Tomas Lacamoire";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(214, 118);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(147, 13);
            this.lblMateria.TabIndex = 4;
            this.lblMateria.Text = "Materia: Estructuras de Datos";
            // 
            // picboxFoto
            // 
            this.picboxFoto.BackgroundImage = global::PryEDLacamoire.Properties.Resources.Captura_de_pantalla_2022_08_27_1518131;
            this.picboxFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxFoto.Location = new System.Drawing.Point(30, 25);
            this.picboxFoto.Name = "picboxFoto";
            this.picboxFoto.Size = new System.Drawing.Size(124, 116);
            this.picboxFoto.TabIndex = 0;
            this.picboxFoto.TabStop = false;
            // 
            // frmDatosDesarrollador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 172);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.picboxFoto);
            this.Name = "frmDatosDesarrollador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatosDesarrollador";
            ((System.ComponentModel.ISupportInitialize)(this.picboxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxFoto;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMateria;
    }
}