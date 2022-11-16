namespace pryEjercicioxResolverSP3
{
    partial class frmRepuestos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepuestos));
            this.mrcConsulta = new System.Windows.Forms.GroupBox();
            this.lblOri = new System.Windows.Forms.Label();
            this.lblMarca2 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lstConsulta = new System.Windows.Forms.ListBox();
            this.cmbMarca2 = new System.Windows.Forms.ComboBox();
            this.optNacional = new System.Windows.Forms.RadioButton();
            this.optImportado = new System.Windows.Forms.RadioButton();
            this.mrcRegistro = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblNumRep = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDescpRep = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.txtNumeroRepuesto = new System.Windows.Forms.TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.mrcConsulta.SuspendLayout();
            this.mrcRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcConsulta
            // 
            this.mrcConsulta.BackColor = System.Drawing.Color.Transparent;
            this.mrcConsulta.Controls.Add(this.lblOri);
            this.mrcConsulta.Controls.Add(this.lblMarca2);
            this.mrcConsulta.Controls.Add(this.btnConsultar);
            this.mrcConsulta.Controls.Add(this.lstConsulta);
            this.mrcConsulta.Controls.Add(this.cmbMarca2);
            this.mrcConsulta.Controls.Add(this.optNacional);
            this.mrcConsulta.Controls.Add(this.optImportado);
            this.mrcConsulta.Location = new System.Drawing.Point(420, 12);
            this.mrcConsulta.Name = "mrcConsulta";
            this.mrcConsulta.Size = new System.Drawing.Size(281, 312);
            this.mrcConsulta.TabIndex = 20;
            this.mrcConsulta.TabStop = false;
            this.mrcConsulta.Text = "Consulta de los repuestos:";
            // 
            // lblOri
            // 
            this.lblOri.AutoSize = true;
            this.lblOri.Location = new System.Drawing.Point(23, 83);
            this.lblOri.Name = "lblOri";
            this.lblOri.Size = new System.Drawing.Size(38, 13);
            this.lblOri.TabIndex = 19;
            this.lblOri.Text = "Origen";
            // 
            // lblMarca2
            // 
            this.lblMarca2.AutoSize = true;
            this.lblMarca2.Location = new System.Drawing.Point(23, 28);
            this.lblMarca2.Name = "lblMarca2";
            this.lblMarca2.Size = new System.Drawing.Size(37, 13);
            this.lblMarca2.TabIndex = 18;
            this.lblMarca2.Text = "Marca";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(90, 276);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(92, 23);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lstConsulta
            // 
            this.lstConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstConsulta.FormattingEnabled = true;
            this.lstConsulta.Location = new System.Drawing.Point(26, 126);
            this.lstConsulta.Name = "lstConsulta";
            this.lstConsulta.Size = new System.Drawing.Size(224, 130);
            this.lstConsulta.TabIndex = 14;
            // 
            // cmbMarca2
            // 
            this.cmbMarca2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca2.FormattingEnabled = true;
            this.cmbMarca2.Location = new System.Drawing.Point(38, 44);
            this.cmbMarca2.Name = "cmbMarca2";
            this.cmbMarca2.Size = new System.Drawing.Size(121, 21);
            this.cmbMarca2.TabIndex = 17;
            this.cmbMarca2.SelectedIndexChanged += new System.EventHandler(this.cmbMarca2_SelectedIndexChanged);
            // 
            // optNacional
            // 
            this.optNacional.AutoSize = true;
            this.optNacional.Location = new System.Drawing.Point(38, 103);
            this.optNacional.Name = "optNacional";
            this.optNacional.Size = new System.Drawing.Size(67, 17);
            this.optNacional.TabIndex = 15;
            this.optNacional.TabStop = true;
            this.optNacional.Text = "Nacional";
            this.optNacional.UseVisualStyleBackColor = true;
            // 
            // optImportado
            // 
            this.optImportado.AutoSize = true;
            this.optImportado.Location = new System.Drawing.Point(138, 103);
            this.optImportado.Name = "optImportado";
            this.optImportado.Size = new System.Drawing.Size(72, 17);
            this.optImportado.TabIndex = 16;
            this.optImportado.TabStop = true;
            this.optImportado.Text = "Importado";
            this.optImportado.UseVisualStyleBackColor = true;
            // 
            // mrcRegistro
            // 
            this.mrcRegistro.BackColor = System.Drawing.Color.Transparent;
            this.mrcRegistro.Controls.Add(this.label1);
            this.mrcRegistro.Controls.Add(this.lblMarca);
            this.mrcRegistro.Controls.Add(this.lblOrigen);
            this.mrcRegistro.Controls.Add(this.btnRegistrar);
            this.mrcRegistro.Controls.Add(this.lblNumRep);
            this.mrcRegistro.Controls.Add(this.btnCancelar);
            this.mrcRegistro.Controls.Add(this.lblDescpRep);
            this.mrcRegistro.Controls.Add(this.txtPrecio);
            this.mrcRegistro.Controls.Add(this.lblPrecio);
            this.mrcRegistro.Controls.Add(this.txtDescripcion);
            this.mrcRegistro.Controls.Add(this.cmbOrigen);
            this.mrcRegistro.Controls.Add(this.txtNumeroRepuesto);
            this.mrcRegistro.Controls.Add(this.cmbMarca);
            this.mrcRegistro.Location = new System.Drawing.Point(21, 12);
            this.mrcRegistro.Name = "mrcRegistro";
            this.mrcRegistro.Size = new System.Drawing.Size(393, 312);
            this.mrcRegistro.TabIndex = 21;
            this.mrcRegistro.TabStop = false;
            this.mrcRegistro.Text = "Datos del repuesto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "$";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(33, 28);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(33, 68);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(38, 13);
            this.lblOrigen.TabIndex = 1;
            this.lblOrigen.Text = "Origen";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(174, 276);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(92, 23);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "&Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblNumRep
            // 
            this.lblNumRep.AutoSize = true;
            this.lblNumRep.Location = new System.Drawing.Point(33, 107);
            this.lblNumRep.Name = "lblNumRep";
            this.lblNumRep.Size = new System.Drawing.Size(105, 13);
            this.lblNumRep.TabIndex = 2;
            this.lblNumRep.Text = "Número del repuesto";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(281, 276);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblDescpRep
            // 
            this.lblDescpRep.AutoSize = true;
            this.lblDescpRep.Location = new System.Drawing.Point(33, 146);
            this.lblDescpRep.Name = "lblDescpRep";
            this.lblDescpRep.Size = new System.Drawing.Size(63, 13);
            this.lblDescpRep.TabIndex = 3;
            this.lblDescpRep.Text = "Descripción";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(57, 224);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 9;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(33, 208);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(57, 162);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(308, 43);
            this.txtDescripcion.TabIndex = 8;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(57, 83);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigen.TabIndex = 5;
            // 
            // txtNumeroRepuesto
            // 
            this.txtNumeroRepuesto.Location = new System.Drawing.Point(57, 123);
            this.txtNumeroRepuesto.MaxLength = 6;
            this.txtNumeroRepuesto.Name = "txtNumeroRepuesto";
            this.txtNumeroRepuesto.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroRepuesto.TabIndex = 7;
            this.txtNumeroRepuesto.TextChanged += new System.EventHandler(this.txtNumeroRepuesto_TextChanged);
            this.txtNumeroRepuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroRepuesto_KeyPress);
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(57, 44);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 21);
            this.cmbMarca.TabIndex = 6;
            // 
            // frmRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(725, 353);
            this.Controls.Add(this.mrcConsulta);
            this.Controls.Add(this.mrcRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRepuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de repuestos";
            this.Load += new System.EventHandler(this.frmRepuestos_Load);
            this.mrcConsulta.ResumeLayout(false);
            this.mrcConsulta.PerformLayout();
            this.mrcRegistro.ResumeLayout(false);
            this.mrcRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcConsulta;
        private System.Windows.Forms.Label lblOri;
        private System.Windows.Forms.Label lblMarca2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ListBox lstConsulta;
        private System.Windows.Forms.ComboBox cmbMarca2;
        private System.Windows.Forms.RadioButton optNacional;
        private System.Windows.Forms.RadioButton optImportado;
        private System.Windows.Forms.GroupBox mrcRegistro;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblNumRep;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDescpRep;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.TextBox txtNumeroRepuesto;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label1;
    }
}

