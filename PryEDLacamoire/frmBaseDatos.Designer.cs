namespace PryEDLacamoire
{
    partial class frmBaseDatos
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
            this.mrcSELECT = new System.Windows.Forms.GroupBox();
            this.mrcWHERE = new System.Windows.Forms.GroupBox();
            this.mrcOperacionesAlgebraicas = new System.Windows.Forms.GroupBox();
            this.btnProyeccionSimple = new System.Windows.Forms.Button();
            this.btnProyeccionMultiatributo = new System.Windows.Forms.Button();
            this.btnSeleccionSimple = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnSeleccionMultiatributo = new System.Windows.Forms.Button();
            this.btnSeleccionConvulcion = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.mrcSELECT.SuspendLayout();
            this.mrcWHERE.SuspendLayout();
            this.mrcOperacionesAlgebraicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcSELECT
            // 
            this.mrcSELECT.Controls.Add(this.btnJuntar);
            this.mrcSELECT.Controls.Add(this.btnProyeccionMultiatributo);
            this.mrcSELECT.Controls.Add(this.btnProyeccionSimple);
            this.mrcSELECT.Location = new System.Drawing.Point(12, 351);
            this.mrcSELECT.Name = "mrcSELECT";
            this.mrcSELECT.Size = new System.Drawing.Size(209, 152);
            this.mrcSELECT.TabIndex = 0;
            this.mrcSELECT.TabStop = false;
            this.mrcSELECT.Text = "Operaciones de Proyección - SELECT";
            // 
            // mrcWHERE
            // 
            this.mrcWHERE.Controls.Add(this.btnSeleccionConvulcion);
            this.mrcWHERE.Controls.Add(this.btnSeleccionMultiatributo);
            this.mrcWHERE.Controls.Add(this.btnSeleccionSimple);
            this.mrcWHERE.Location = new System.Drawing.Point(239, 351);
            this.mrcWHERE.Name = "mrcWHERE";
            this.mrcWHERE.Size = new System.Drawing.Size(209, 152);
            this.mrcWHERE.TabIndex = 1;
            this.mrcWHERE.TabStop = false;
            this.mrcWHERE.Text = "Operaciones de Selección - WHERE";
            // 
            // mrcOperacionesAlgebraicas
            // 
            this.mrcOperacionesAlgebraicas.Controls.Add(this.btnDiferencia);
            this.mrcOperacionesAlgebraicas.Controls.Add(this.btnInterseccion);
            this.mrcOperacionesAlgebraicas.Controls.Add(this.btnUnion);
            this.mrcOperacionesAlgebraicas.Location = new System.Drawing.Point(464, 351);
            this.mrcOperacionesAlgebraicas.Name = "mrcOperacionesAlgebraicas";
            this.mrcOperacionesAlgebraicas.Size = new System.Drawing.Size(209, 152);
            this.mrcOperacionesAlgebraicas.TabIndex = 2;
            this.mrcOperacionesAlgebraicas.TabStop = false;
            this.mrcOperacionesAlgebraicas.Text = "Operacioines de Algebraicas";
            // 
            // btnProyeccionSimple
            // 
            this.btnProyeccionSimple.Location = new System.Drawing.Point(22, 28);
            this.btnProyeccionSimple.Name = "btnProyeccionSimple";
            this.btnProyeccionSimple.Size = new System.Drawing.Size(161, 23);
            this.btnProyeccionSimple.TabIndex = 0;
            this.btnProyeccionSimple.Text = "Proyección Simple";
            this.btnProyeccionSimple.UseVisualStyleBackColor = true;
            // 
            // btnProyeccionMultiatributo
            // 
            this.btnProyeccionMultiatributo.Location = new System.Drawing.Point(24, 67);
            this.btnProyeccionMultiatributo.Name = "btnProyeccionMultiatributo";
            this.btnProyeccionMultiatributo.Size = new System.Drawing.Size(161, 23);
            this.btnProyeccionMultiatributo.TabIndex = 1;
            this.btnProyeccionMultiatributo.Text = "Proyección Multiatributo";
            this.btnProyeccionMultiatributo.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionSimple
            // 
            this.btnSeleccionSimple.Location = new System.Drawing.Point(25, 28);
            this.btnSeleccionSimple.Name = "btnSeleccionSimple";
            this.btnSeleccionSimple.Size = new System.Drawing.Size(161, 23);
            this.btnSeleccionSimple.TabIndex = 1;
            this.btnSeleccionSimple.Text = "Selección Simple";
            this.btnSeleccionSimple.UseVisualStyleBackColor = true;
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(26, 28);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(161, 23);
            this.btnUnion.TabIndex = 1;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(24, 106);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(161, 23);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionMultiatributo
            // 
            this.btnSeleccionMultiatributo.Location = new System.Drawing.Point(24, 65);
            this.btnSeleccionMultiatributo.Name = "btnSeleccionMultiatributo";
            this.btnSeleccionMultiatributo.Size = new System.Drawing.Size(161, 23);
            this.btnSeleccionMultiatributo.TabIndex = 2;
            this.btnSeleccionMultiatributo.Text = "Selección Multiatributo";
            this.btnSeleccionMultiatributo.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionConvulcion
            // 
            this.btnSeleccionConvulcion.Location = new System.Drawing.Point(24, 106);
            this.btnSeleccionConvulcion.Name = "btnSeleccionConvulcion";
            this.btnSeleccionConvulcion.Size = new System.Drawing.Size(161, 23);
            this.btnSeleccionConvulcion.TabIndex = 3;
            this.btnSeleccionConvulcion.Text = "Selección por Convulción";
            this.btnSeleccionConvulcion.UseVisualStyleBackColor = true;
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(24, 65);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(161, 23);
            this.btnInterseccion.TabIndex = 3;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(26, 106);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(161, 23);
            this.btnDiferencia.TabIndex = 4;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            // 
            // frmBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(676, 515);
            this.Controls.Add(this.mrcOperacionesAlgebraicas);
            this.Controls.Add(this.mrcWHERE);
            this.Controls.Add(this.mrcSELECT);
            this.Name = "frmBaseDatos";
            this.Text = "frmBaseDatos";
            this.mrcSELECT.ResumeLayout(false);
            this.mrcWHERE.ResumeLayout(false);
            this.mrcOperacionesAlgebraicas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcSELECT;
        private System.Windows.Forms.Button btnProyeccionSimple;
        private System.Windows.Forms.GroupBox mrcWHERE;
        private System.Windows.Forms.GroupBox mrcOperacionesAlgebraicas;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProyeccionMultiatributo;
        private System.Windows.Forms.Button btnSeleccionMultiatributo;
        private System.Windows.Forms.Button btnSeleccionSimple;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.Button btnSeleccionConvulcion;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInterseccion;
    }
}