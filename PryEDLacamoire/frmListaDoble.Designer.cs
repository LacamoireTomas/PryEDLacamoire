namespace PryEDLacamoire
{
    partial class frmListaDoble
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
            this.mrcCola = new System.Windows.Forms.GroupBox();
            this.dgvListaSimple = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstListaSimple = new System.Windows.Forms.ListBox();
            this.mrcElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.lblCodigoEliminado = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.mrcNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtTramiteNuevo = new System.Windows.Forms.TextBox();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.txtCodigoNuevo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramiteNuevo = new System.Windows.Forms.Label();
            this.lblNombreNuevo = new System.Windows.Forms.Label();
            this.lblCodigoNuevo = new System.Windows.Forms.Label();
            this.picboxRepGraficaListaDoble = new System.Windows.Forms.PictureBox();
            this.mrcCola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSimple)).BeginInit();
            this.mrcElementoEliminado.SuspendLayout();
            this.mrcNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRepGraficaListaDoble)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcCola
            // 
            this.mrcCola.Controls.Add(this.dgvListaSimple);
            this.mrcCola.Controls.Add(this.lstListaSimple);
            this.mrcCola.Location = new System.Drawing.Point(6, 240);
            this.mrcCola.Name = "mrcCola";
            this.mrcCola.Size = new System.Drawing.Size(665, 270);
            this.mrcCola.TabIndex = 11;
            this.mrcCola.TabStop = false;
            this.mrcCola.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvListaSimple
            // 
            this.dgvListaSimple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaSimple.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvListaSimple.Location = new System.Drawing.Point(227, 19);
            this.dgvListaSimple.Name = "dgvListaSimple";
            this.dgvListaSimple.Size = new System.Drawing.Size(432, 240);
            this.dgvListaSimple.TabIndex = 1;
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
            // lstListaSimple
            // 
            this.lstListaSimple.FormattingEnabled = true;
            this.lstListaSimple.Location = new System.Drawing.Point(11, 21);
            this.lstListaSimple.Name = "lstListaSimple";
            this.lstListaSimple.Size = new System.Drawing.Size(194, 238);
            this.lstListaSimple.TabIndex = 0;
            // 
            // mrcElementoEliminado
            // 
            this.mrcElementoEliminado.Controls.Add(this.cmbCodigo);
            this.mrcElementoEliminado.Controls.Add(this.lblCodigoEliminado);
            this.mrcElementoEliminado.Controls.Add(this.btnEliminar);
            this.mrcElementoEliminado.Location = new System.Drawing.Point(442, 15);
            this.mrcElementoEliminado.Name = "mrcElementoEliminado";
            this.mrcElementoEliminado.Size = new System.Drawing.Size(229, 219);
            this.mrcElementoEliminado.TabIndex = 10;
            this.mrcElementoEliminado.TabStop = false;
            this.mrcElementoEliminado.Text = "Elemento Eliminado";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(83, 79);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(121, 21);
            this.cmbCodigo.TabIndex = 8;
            // 
            // lblCodigoEliminado
            // 
            this.lblCodigoEliminado.AutoSize = true;
            this.lblCodigoEliminado.Location = new System.Drawing.Point(23, 79);
            this.lblCodigoEliminado.Name = "lblCodigoEliminado";
            this.lblCodigoEliminado.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoEliminado.TabIndex = 7;
            this.lblCodigoEliminado.Text = "Código:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(26, 143);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(178, 55);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
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
            this.mrcNuevoElemento.Location = new System.Drawing.Point(207, 15);
            this.mrcNuevoElemento.Name = "mrcNuevoElemento";
            this.mrcNuevoElemento.Size = new System.Drawing.Size(229, 219);
            this.mrcNuevoElemento.TabIndex = 9;
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
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Enabled = false;
            this.txtNombreNuevo.Location = new System.Drawing.Point(70, 72);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(134, 20);
            this.txtNombreNuevo.TabIndex = 5;
            // 
            // txtCodigoNuevo
            // 
            this.txtCodigoNuevo.Location = new System.Drawing.Point(104, 39);
            this.txtCodigoNuevo.Name = "txtCodigoNuevo";
            this.txtCodigoNuevo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoNuevo.TabIndex = 4;
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
            // picboxRepGraficaListaDoble
            // 
            this.picboxRepGraficaListaDoble.BackgroundImage = global::PryEDLacamoire.Properties.Resources.ListaDoblementeEnlazada;
            this.picboxRepGraficaListaDoble.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxRepGraficaListaDoble.Location = new System.Drawing.Point(6, 4);
            this.picboxRepGraficaListaDoble.Name = "picboxRepGraficaListaDoble";
            this.picboxRepGraficaListaDoble.Size = new System.Drawing.Size(195, 230);
            this.picboxRepGraficaListaDoble.TabIndex = 8;
            this.picboxRepGraficaListaDoble.TabStop = false;
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 515);
            this.Controls.Add(this.mrcCola);
            this.Controls.Add(this.mrcElementoEliminado);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Controls.Add(this.picboxRepGraficaListaDoble);
            this.Name = "frmListaDoble";
            this.Text = "frmListaDoble";
            this.mrcCola.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSimple)).EndInit();
            this.mrcElementoEliminado.ResumeLayout(false);
            this.mrcElementoEliminado.PerformLayout();
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRepGraficaListaDoble)).EndInit();
            this.ResumeLayout(false);

            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstListaSimple = new System.Windows.Forms.ListBox();
            this.mrcElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.lblCodigoEliminado = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.mrcNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtTramiteNuevo = new System.Windows.Forms.TextBox();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.txtCodigoNuevo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramiteNuevo = new System.Windows.Forms.Label();
            this.lblNombreNuevo = new System.Windows.Forms.Label();
            this.lblCodigoNuevo = new System.Windows.Forms.Label();
            this.picboxRepGraficaListaDoble = new System.Windows.Forms.PictureBox();
            this.mrcCola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSimple)).BeginInit();
            this.mrcElementoEliminado.SuspendLayout();
            this.mrcNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRepGraficaListaDoble)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcCola
            // 
            this.mrcCola.Controls.Add(this.dgvListaSimple);
            this.mrcCola.Controls.Add(this.lstListaSimple);
            this.mrcCola.Location = new System.Drawing.Point(6, 240);
            this.mrcCola.Name = "mrcCola";
            this.mrcCola.Size = new System.Drawing.Size(665, 270);
            this.mrcCola.TabIndex = 11;
            this.mrcCola.TabStop = false;
            this.mrcCola.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvListaSimple
            // 
            this.dgvListaSimple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaSimple.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvListaSimple.Location = new System.Drawing.Point(227, 19);
            this.dgvListaSimple.Name = "dgvListaSimple";
            this.dgvListaSimple.Size = new System.Drawing.Size(432, 240);
            this.dgvListaSimple.TabIndex = 1;
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
            // lstListaSimple
            // 
            this.lstListaSimple.FormattingEnabled = true;
            this.lstListaSimple.Location = new System.Drawing.Point(11, 21);
            this.lstListaSimple.Name = "lstListaSimple";
            this.lstListaSimple.Size = new System.Drawing.Size(194, 238);
            this.lstListaSimple.TabIndex = 0;
            // 
            // mrcElementoEliminado
            // 
            this.mrcElementoEliminado.Controls.Add(this.cmbCodigo);
            this.mrcElementoEliminado.Controls.Add(this.lblCodigoEliminado);
            this.mrcElementoEliminado.Controls.Add(this.btnEliminar);
            this.mrcElementoEliminado.Location = new System.Drawing.Point(442, 15);
            this.mrcElementoEliminado.Name = "mrcElementoEliminado";
            this.mrcElementoEliminado.Size = new System.Drawing.Size(229, 219);
            this.mrcElementoEliminado.TabIndex = 10;
            this.mrcElementoEliminado.TabStop = false;
            this.mrcElementoEliminado.Text = "Elemento Eliminado";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(83, 79);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(121, 21);
            this.cmbCodigo.TabIndex = 8;
            // 
            // lblCodigoEliminado
            // 
            this.lblCodigoEliminado.AutoSize = true;
            this.lblCodigoEliminado.Location = new System.Drawing.Point(23, 79);
            this.lblCodigoEliminado.Name = "lblCodigoEliminado";
            this.lblCodigoEliminado.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoEliminado.TabIndex = 7;
            this.lblCodigoEliminado.Text = "Código:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(26, 143);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(178, 55);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
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
            this.mrcNuevoElemento.Location = new System.Drawing.Point(207, 15);
            this.mrcNuevoElemento.Name = "mrcNuevoElemento";
            this.mrcNuevoElemento.Size = new System.Drawing.Size(229, 219);
            this.mrcNuevoElemento.TabIndex = 9;
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
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Enabled = false;
            this.txtNombreNuevo.Location = new System.Drawing.Point(70, 72);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(134, 20);
            this.txtNombreNuevo.TabIndex = 5;
            // 
            // txtCodigoNuevo
            // 
            this.txtCodigoNuevo.Location = new System.Drawing.Point(104, 39);
            this.txtCodigoNuevo.Name = "txtCodigoNuevo";
            this.txtCodigoNuevo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoNuevo.TabIndex = 4;
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
            // picboxRepGraficaListaDoble
            // 
            this.picboxRepGraficaListaDoble.BackgroundImage = global::PryEDLacamoire.Properties.Resources._01_ListasSimplementeEnlazadas;
            this.picboxRepGraficaListaDoble.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxRepGraficaListaDoble.Location = new System.Drawing.Point(6, 4);
            this.picboxRepGraficaListaDoble.Name = "picboxRepGraficaListaDoble";
            this.picboxRepGraficaListaDoble.Size = new System.Drawing.Size(195, 230);
            this.picboxRepGraficaListaDoble.TabIndex = 8;
            this.picboxRepGraficaListaDoble.TabStop = false;
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 515);
            this.Controls.Add(this.mrcCola);
            this.Controls.Add(this.mrcElementoEliminado);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Controls.Add(this.picboxRepGraficaListaDoble);
            this.Name = "frmListaDoble";
            this.Text = "frmListaDoble";
            this.mrcCola.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSimple)).EndInit();
            this.mrcElementoEliminado.ResumeLayout(false);
            this.mrcElementoEliminado.PerformLayout();
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRepGraficaListaDoble)).EndInit();
            this.ResumeLayout(false);

            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstListaSimple = new System.Windows.Forms.ListBox();
            this.mrcElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.lblCodigoEliminado = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.mrcNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtTramiteNuevo = new System.Windows.Forms.TextBox();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.txtCodigoNuevo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramiteNuevo = new System.Windows.Forms.Label();
            this.lblNombreNuevo = new System.Windows.Forms.Label();
            this.lblCodigoNuevo = new System.Windows.Forms.Label();
            this.picboxRepGraficaListaSimple = new System.Windows.Forms.PictureBox();
            this.mrcCola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSimple)).BeginInit();
            this.mrcElementoEliminado.SuspendLayout();
            this.mrcNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRepGraficaListaSimple)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcCola
            // 
            this.mrcCola.Controls.Add(this.dgvListaSimple);
            this.mrcCola.Controls.Add(this.lstListaSimple);
            this.mrcCola.Location = new System.Drawing.Point(6, 240);
            this.mrcCola.Name = "mrcCola";
            this.mrcCola.Size = new System.Drawing.Size(665, 270);
            this.mrcCola.TabIndex = 11;
            this.mrcCola.TabStop = false;
            this.mrcCola.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvListaSimple
            // 
            this.dgvListaSimple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaSimple.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvListaSimple.Location = new System.Drawing.Point(227, 19);
            this.dgvListaSimple.Name = "dgvListaSimple";
            this.dgvListaSimple.Size = new System.Drawing.Size(432, 240);
            this.dgvListaSimple.TabIndex = 1;
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
            // lstListaSimple
            // 
            this.lstListaSimple.FormattingEnabled = true;
            this.lstListaSimple.Location = new System.Drawing.Point(11, 21);
            this.lstListaSimple.Name = "lstListaSimple";
            this.lstListaSimple.Size = new System.Drawing.Size(194, 238);
            this.lstListaSimple.TabIndex = 0;
            // 
            // mrcElementoEliminado
            // 
            this.mrcElementoEliminado.Controls.Add(this.cmbCodigo);
            this.mrcElementoEliminado.Controls.Add(this.lblCodigoEliminado);
            this.mrcElementoEliminado.Controls.Add(this.btnEliminar);
            this.mrcElementoEliminado.Location = new System.Drawing.Point(442, 15);
            this.mrcElementoEliminado.Name = "mrcElementoEliminado";
            this.mrcElementoEliminado.Size = new System.Drawing.Size(229, 219);
            this.mrcElementoEliminado.TabIndex = 10;
            this.mrcElementoEliminado.TabStop = false;
            this.mrcElementoEliminado.Text = "Elemento Eliminado";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(83, 79);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(121, 21);
            this.cmbCodigo.TabIndex = 8;
            // 
            // lblCodigoEliminado
            // 
            this.lblCodigoEliminado.AutoSize = true;
            this.lblCodigoEliminado.Location = new System.Drawing.Point(23, 79);
            this.lblCodigoEliminado.Name = "lblCodigoEliminado";
            this.lblCodigoEliminado.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoEliminado.TabIndex = 7;
            this.lblCodigoEliminado.Text = "Código:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(26, 143);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(178, 55);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
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
            this.mrcNuevoElemento.Location = new System.Drawing.Point(207, 15);
            this.mrcNuevoElemento.Name = "mrcNuevoElemento";
            this.mrcNuevoElemento.Size = new System.Drawing.Size(229, 219);
            this.mrcNuevoElemento.TabIndex = 9;
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
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Enabled = false;
            this.txtNombreNuevo.Location = new System.Drawing.Point(70, 72);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(134, 20);
            this.txtNombreNuevo.TabIndex = 5;
            // 
            // txtCodigoNuevo
            // 
            this.txtCodigoNuevo.Location = new System.Drawing.Point(104, 39);
            this.txtCodigoNuevo.Name = "txtCodigoNuevo";
            this.txtCodigoNuevo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoNuevo.TabIndex = 4;
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
            // picboxRepGraficaListaSimple
            // 
            this.picboxRepGraficaListaSimple.BackgroundImage = global::PryEDLacamoire.Properties.Resources._01_ListasSimplementeEnlazadas;
            this.picboxRepGraficaListaSimple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxRepGraficaListaSimple.Location = new System.Drawing.Point(6, 4);
            this.picboxRepGraficaListaSimple.Name = "picboxRepGraficaListaSimple";
            this.picboxRepGraficaListaSimple.Size = new System.Drawing.Size(195, 230);
            this.picboxRepGraficaListaSimple.TabIndex = 8;
            this.picboxRepGraficaListaSimple.TabStop = false;
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 515);
            this.Controls.Add(this.mrcCola);
            this.Controls.Add(this.mrcElementoEliminado);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Controls.Add(this.picboxRepGraficaListaSimple);
            this.Name = "frmListaDoble";
            this.Text = "frmListaDoble";
            this.mrcCola.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSimple)).EndInit();
            this.mrcElementoEliminado.ResumeLayout(false);
            this.mrcElementoEliminado.PerformLayout();
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxRepGraficaListaSimple)).EndInit();
            this.ResumeLayout(false);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 515);
            this.Name = "frmListaDoble";
            this.Text = "frmListaDoble";
            this.ResumeLayout(false);

        }

        #endregion
    }
}