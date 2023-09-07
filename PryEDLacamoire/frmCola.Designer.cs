namespace PryEDLacamoire
{
    partial class frmCola
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
            this.mrcNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtTramiteNuevo = new System.Windows.Forms.TextBox();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.txtCodigoNuevo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramiteNuevo = new System.Windows.Forms.Label();
            this.lblNombreNuevo = new System.Windows.Forms.Label();
            this.lblCodigoNuevo = new System.Windows.Forms.Label();
            this.mrcElementoEliminado = new System.Windows.Forms.GroupBox();
            this.lblMuestraTramite = new System.Windows.Forms.Label();
            this.lblMuestraNombre = new System.Windows.Forms.Label();
            this.lblMuestraCodigo = new System.Windows.Forms.Label();
            this.lblCodigoEliminado = new System.Windows.Forms.Label();
            this.lblNombreEliminado = new System.Windows.Forms.Label();
            this.lblTramiteEliminado = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.mrcCola = new System.Windows.Forms.GroupBox();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.picboxRepGraficaCola = new System.Windows.Forms.PictureBox();
            this.mrcNuevoElemento.SuspendLayout();
            this.mrcElementoEliminado.SuspendLayout();
            this.mrcCola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRepGraficaCola)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcNuevoElemento
            // 
            this.mrcNuevoElemento.Controls.Add(this.txtTramiteNuevo);
            this.mrcNuevoElemento.Controls.Add(this.txtNombreNuevo);
            this.mrcNuevoElemento.Controls.Add(this.txtCodigoNuevo);
            this.mrcNuevoElemento.Controls.Add(this.btnAgregar);
            this.mrcNuevoElemento.Controls.Add(this.lblTramiteNuevo);
            this.mrcNuevoElemento.Controls.Add(this.lblNombreNuevo);
            this.mrcNuevoElemento.Controls.Add(this.lblCodigoNuevo);
            this.mrcNuevoElemento.Location = new System.Drawing.Point(203, 8);
            this.mrcNuevoElemento.Name = "mrcNuevoElemento";
            this.mrcNuevoElemento.Size = new System.Drawing.Size(229, 219);
            this.mrcNuevoElemento.TabIndex = 1;
            this.mrcNuevoElemento.TabStop = false;
            this.mrcNuevoElemento.Text = "Nuevo Elemento";
            // 
            // txtTramiteNuevo
            // 
            this.txtTramiteNuevo.Enabled = false;
            this.txtTramiteNuevo.Location = new System.Drawing.Point(70, 105);
            this.txtTramiteNuevo.Name = "txtTramiteNuevo";
            this.txtTramiteNuevo.Size = new System.Drawing.Size(134, 20);
            this.txtTramiteNuevo.TabIndex = 6;
            this.txtTramiteNuevo.TextChanged += new System.EventHandler(this.txtTramiteNuevo_TextChanged);
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Enabled = false;
            this.txtNombreNuevo.Location = new System.Drawing.Point(70, 72);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(134, 20);
            this.txtNombreNuevo.TabIndex = 5;
            this.txtNombreNuevo.TextChanged += new System.EventHandler(this.txtNombreNuevo_TextChanged);
            // 
            // txtCodigoNuevo
            // 
            this.txtCodigoNuevo.Location = new System.Drawing.Point(104, 39);
            this.txtCodigoNuevo.Name = "txtCodigoNuevo";
            this.txtCodigoNuevo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoNuevo.TabIndex = 4;
            this.txtCodigoNuevo.TextChanged += new System.EventHandler(this.txtCodigoNuevo_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(26, 143);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(178, 55);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTramiteNuevo
            // 
            this.lblTramiteNuevo.AutoSize = true;
            this.lblTramiteNuevo.Location = new System.Drawing.Point(6, 108);
            this.lblTramiteNuevo.Name = "lblTramiteNuevo";
            this.lblTramiteNuevo.Size = new System.Drawing.Size(45, 13);
            this.lblTramiteNuevo.TabIndex = 2;
            this.lblTramiteNuevo.Text = "Trámite:";
            // 
            // lblNombreNuevo
            // 
            this.lblNombreNuevo.AutoSize = true;
            this.lblNombreNuevo.Location = new System.Drawing.Point(6, 75);
            this.lblNombreNuevo.Name = "lblNombreNuevo";
            this.lblNombreNuevo.Size = new System.Drawing.Size(47, 13);
            this.lblNombreNuevo.TabIndex = 1;
            this.lblNombreNuevo.Text = "Nombre:";
            // 
            // lblCodigoNuevo
            // 
            this.lblCodigoNuevo.AutoSize = true;
            this.lblCodigoNuevo.Location = new System.Drawing.Point(6, 39);
            this.lblCodigoNuevo.Name = "lblCodigoNuevo";
            this.lblCodigoNuevo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoNuevo.TabIndex = 0;
            this.lblCodigoNuevo.Text = "Código:";
            // 
            // mrcElementoEliminado
            // 
            this.mrcElementoEliminado.Controls.Add(this.lblMuestraTramite);
            this.mrcElementoEliminado.Controls.Add(this.lblMuestraNombre);
            this.mrcElementoEliminado.Controls.Add(this.lblMuestraCodigo);
            this.mrcElementoEliminado.Controls.Add(this.lblCodigoEliminado);
            this.mrcElementoEliminado.Controls.Add(this.lblNombreEliminado);
            this.mrcElementoEliminado.Controls.Add(this.lblTramiteEliminado);
            this.mrcElementoEliminado.Controls.Add(this.btnEliminar);
            this.mrcElementoEliminado.Location = new System.Drawing.Point(438, 8);
            this.mrcElementoEliminado.Name = "mrcElementoEliminado";
            this.mrcElementoEliminado.Size = new System.Drawing.Size(229, 219);
            this.mrcElementoEliminado.TabIndex = 2;
            this.mrcElementoEliminado.TabStop = false;
            this.mrcElementoEliminado.Text = "Elemento Eliminado";
            // 
            // lblMuestraTramite
            // 
            this.lblMuestraTramite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMuestraTramite.Location = new System.Drawing.Point(57, 105);
            this.lblMuestraTramite.Name = "lblMuestraTramite";
            this.lblMuestraTramite.Size = new System.Drawing.Size(157, 20);
            this.lblMuestraTramite.TabIndex = 10;
            // 
            // lblMuestraNombre
            // 
            this.lblMuestraNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMuestraNombre.Location = new System.Drawing.Point(59, 72);
            this.lblMuestraNombre.Name = "lblMuestraNombre";
            this.lblMuestraNombre.Size = new System.Drawing.Size(155, 20);
            this.lblMuestraNombre.TabIndex = 9;
            // 
            // lblMuestraCodigo
            // 
            this.lblMuestraCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMuestraCodigo.Location = new System.Drawing.Point(114, 39);
            this.lblMuestraCodigo.Name = "lblMuestraCodigo";
            this.lblMuestraCodigo.Size = new System.Drawing.Size(100, 23);
            this.lblMuestraCodigo.TabIndex = 8;
            // 
            // lblCodigoEliminado
            // 
            this.lblCodigoEliminado.AutoSize = true;
            this.lblCodigoEliminado.Location = new System.Drawing.Point(6, 39);
            this.lblCodigoEliminado.Name = "lblCodigoEliminado";
            this.lblCodigoEliminado.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoEliminado.TabIndex = 7;
            this.lblCodigoEliminado.Text = "Código:";
            // 
            // lblNombreEliminado
            // 
            this.lblNombreEliminado.AutoSize = true;
            this.lblNombreEliminado.Location = new System.Drawing.Point(6, 75);
            this.lblNombreEliminado.Name = "lblNombreEliminado";
            this.lblNombreEliminado.Size = new System.Drawing.Size(47, 13);
            this.lblNombreEliminado.TabIndex = 6;
            this.lblNombreEliminado.Text = "Nombre:";
            // 
            // lblTramiteEliminado
            // 
            this.lblTramiteEliminado.AutoSize = true;
            this.lblTramiteEliminado.Location = new System.Drawing.Point(6, 108);
            this.lblTramiteEliminado.Name = "lblTramiteEliminado";
            this.lblTramiteEliminado.Size = new System.Drawing.Size(45, 13);
            this.lblTramiteEliminado.TabIndex = 5;
            this.lblTramiteEliminado.Text = "Trámite:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(26, 143);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(178, 55);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // mrcCola
            // 
            this.mrcCola.Controls.Add(this.dgvCola);
            this.mrcCola.Controls.Add(this.lstCola);
            this.mrcCola.Location = new System.Drawing.Point(2, 233);
            this.mrcCola.Name = "mrcCola";
            this.mrcCola.Size = new System.Drawing.Size(665, 270);
            this.mrcCola.TabIndex = 3;
            this.mrcCola.TabStop = false;
            this.mrcCola.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvCola
            // 
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvCola.Location = new System.Drawing.Point(227, 19);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.Size = new System.Drawing.Size(432, 240);
            this.dgvCola.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.FillWeight = 200F;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Tramite";
            this.Tramite.Name = "Tramite";
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(11, 21);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(194, 238);
            this.lstCola.TabIndex = 0;
            // 
            // picboxRepGraficaCola
            // 
            this.picboxRepGraficaCola.BackgroundImage = global::PryEDLacamoire.Properties.Resources.RepGraficaCola;
            this.picboxRepGraficaCola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxRepGraficaCola.Location = new System.Drawing.Point(2, -3);
            this.picboxRepGraficaCola.Name = "picboxRepGraficaCola";
            this.picboxRepGraficaCola.Size = new System.Drawing.Size(195, 230);
            this.picboxRepGraficaCola.TabIndex = 0;
            this.picboxRepGraficaCola.TabStop = false;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(676, 515);
            this.Controls.Add(this.mrcCola);
            this.Controls.Add(this.mrcElementoEliminado);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Controls.Add(this.picboxRepGraficaCola);
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Dinámica no Lineal - Cola";
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            this.mrcElementoEliminado.ResumeLayout(false);
            this.mrcElementoEliminado.PerformLayout();
            this.mrcCola.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRepGraficaCola)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxRepGraficaCola;
        private System.Windows.Forms.GroupBox mrcNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramiteNuevo;
        private System.Windows.Forms.Label lblNombreNuevo;
        private System.Windows.Forms.Label lblCodigoNuevo;
        private System.Windows.Forms.GroupBox mrcElementoEliminado;
        private System.Windows.Forms.Label lblCodigoEliminado;
        private System.Windows.Forms.Label lblNombreEliminado;
        private System.Windows.Forms.Label lblTramiteEliminado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox mrcCola;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.TextBox txtCodigoNuevo;
        private System.Windows.Forms.TextBox txtTramiteNuevo;
        private System.Windows.Forms.Label lblMuestraTramite;
        private System.Windows.Forms.Label lblMuestraNombre;
        private System.Windows.Forms.Label lblMuestraCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
    }
}