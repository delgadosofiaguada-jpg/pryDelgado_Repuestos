namespace pryDelgado_GestionRepuestos
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbc1 = new TabControl();
            tbRegistrar = new TabPage();
            txtDescripcion = new TextBox();
            mtbPrecio = new MaskedTextBox();
            lstOrigen = new ComboBox();
            mtbNumero = new MaskedTextBox();
            lstMarca = new ComboBox();
            cmdCancelar = new Button();
            cmdRegistrar = new Button();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            lblMarca = new Label();
            lblOrigen = new Label();
            lblNumero = new Label();
            lblTitulo = new Label();
            tbConsultar = new TabPage();
            ltbResultados = new ListBox();
            cmdConsultar = new Button();
            rbImportado = new RadioButton();
            rbNacional = new RadioButton();
            lstMarca2 = new ComboBox();
            lblMarca2 = new Label();
            lblOrigen2 = new Label();
            lblTitulo2 = new Label();
            tbc1.SuspendLayout();
            tbRegistrar.SuspendLayout();
            tbConsultar.SuspendLayout();
            SuspendLayout();
            // 
            // tbc1
            // 
            tbc1.Controls.Add(tbRegistrar);
            tbc1.Controls.Add(tbConsultar);
            tbc1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbc1.Location = new Point(10, 17);
            tbc1.Margin = new Padding(3, 2, 3, 2);
            tbc1.Name = "tbc1";
            tbc1.SelectedIndex = 0;
            tbc1.Size = new Size(574, 372);
            tbc1.TabIndex = 0;
            // 
            // tbRegistrar
            // 
            tbRegistrar.Controls.Add(txtDescripcion);
            tbRegistrar.Controls.Add(mtbPrecio);
            tbRegistrar.Controls.Add(lstOrigen);
            tbRegistrar.Controls.Add(mtbNumero);
            tbRegistrar.Controls.Add(lstMarca);
            tbRegistrar.Controls.Add(cmdCancelar);
            tbRegistrar.Controls.Add(cmdRegistrar);
            tbRegistrar.Controls.Add(lblDescripcion);
            tbRegistrar.Controls.Add(lblPrecio);
            tbRegistrar.Controls.Add(lblMarca);
            tbRegistrar.Controls.Add(lblOrigen);
            tbRegistrar.Controls.Add(lblNumero);
            tbRegistrar.Controls.Add(lblTitulo);
            tbRegistrar.Location = new Point(4, 28);
            tbRegistrar.Margin = new Padding(3, 2, 3, 2);
            tbRegistrar.Name = "tbRegistrar";
            tbRegistrar.Padding = new Padding(3, 2, 3, 2);
            tbRegistrar.Size = new Size(566, 340);
            tbRegistrar.TabIndex = 0;
            tbRegistrar.Text = "Registrar";
            tbRegistrar.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(418, 97);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(133, 26);
            txtDescripcion.TabIndex = 8;
            // 
            // mtbPrecio
            // 
            mtbPrecio.Location = new Point(389, 48);
            mtbPrecio.Margin = new Padding(3, 2, 3, 2);
            mtbPrecio.Mask = "99999";
            mtbPrecio.Name = "mtbPrecio";
            mtbPrecio.Size = new Size(89, 26);
            mtbPrecio.TabIndex = 3;
            // 
            // lstOrigen
            // 
            lstOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            lstOrigen.FormattingEnabled = true;
            lstOrigen.Items.AddRange(new object[] { "Nacional", "Importado" });
            lstOrigen.Location = new Point(101, 93);
            lstOrigen.Margin = new Padding(3, 2, 3, 2);
            lstOrigen.Name = "lstOrigen";
            lstOrigen.Size = new Size(133, 27);
            lstOrigen.TabIndex = 4;
            // 
            // mtbNumero
            // 
            mtbNumero.Location = new Point(161, 138);
            mtbNumero.Margin = new Padding(3, 2, 3, 2);
            mtbNumero.Mask = "999999";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(133, 26);
            mtbNumero.TabIndex = 1;
            // 
            // lstMarca
            // 
            lstMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            lstMarca.FormattingEnabled = true;
            lstMarca.Items.AddRange(new object[] { "Peugeot (P)", "Fiat (F)", "Renault (R)" });
            lstMarca.Location = new Point(101, 48);
            lstMarca.Margin = new Padding(3, 2, 3, 2);
            lstMarca.Name = "lstMarca";
            lstMarca.Size = new Size(133, 27);
            lstMarca.TabIndex = 0;
            // 
            // cmdCancelar
            // 
            cmdCancelar.Location = new Point(150, 205);
            cmdCancelar.Margin = new Padding(3, 2, 3, 2);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(82, 26);
            cmdCancelar.TabIndex = 7;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // cmdRegistrar
            // 
            cmdRegistrar.Location = new Point(24, 205);
            cmdRegistrar.Margin = new Padding(3, 2, 3, 2);
            cmdRegistrar.Name = "cmdRegistrar";
            cmdRegistrar.Size = new Size(82, 26);
            cmdRegistrar.TabIndex = 6;
            cmdRegistrar.Text = "Registrar";
            cmdRegistrar.UseVisualStyleBackColor = true;
            cmdRegistrar.Click += cmdRegistrar_Click_1;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(317, 99);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(79, 19);
            lblDescripcion.TabIndex = 5;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(317, 54);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(46, 19);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(28, 54);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(47, 19);
            lblMarca.TabIndex = 3;
            lblMarca.Text = "Marca";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(28, 99);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(51, 19);
            lblOrigen.TabIndex = 2;
            lblOrigen.Text = "Origen";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(28, 143);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(108, 19);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Nº de repuestos";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(10, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(139, 19);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de Repuesto";
            // 
            // tbConsultar
            // 
            tbConsultar.Controls.Add(ltbResultados);
            tbConsultar.Controls.Add(cmdConsultar);
            tbConsultar.Controls.Add(rbImportado);
            tbConsultar.Controls.Add(rbNacional);
            tbConsultar.Controls.Add(lstMarca2);
            tbConsultar.Controls.Add(lblMarca2);
            tbConsultar.Controls.Add(lblOrigen2);
            tbConsultar.Controls.Add(lblTitulo2);
            tbConsultar.Location = new Point(4, 28);
            tbConsultar.Margin = new Padding(3, 2, 3, 2);
            tbConsultar.Name = "tbConsultar";
            tbConsultar.Padding = new Padding(3, 2, 3, 2);
            tbConsultar.Size = new Size(566, 340);
            tbConsultar.TabIndex = 1;
            tbConsultar.Text = "Consultar";
            tbConsultar.UseVisualStyleBackColor = true;
            // 
            // ltbResultados
            // 
            ltbResultados.FormattingEnabled = true;
            ltbResultados.ItemHeight = 19;
            ltbResultados.Location = new Point(14, 155);
            ltbResultados.Margin = new Padding(3, 2, 3, 2);
            ltbResultados.Name = "ltbResultados";
            ltbResultados.Size = new Size(420, 80);
            ltbResultados.TabIndex = 7;
            // 
            // cmdConsultar
            // 
            cmdConsultar.Location = new Point(17, 94);
            cmdConsultar.Margin = new Padding(3, 2, 3, 2);
            cmdConsultar.Name = "cmdConsultar";
            cmdConsultar.Size = new Size(82, 28);
            cmdConsultar.TabIndex = 6;
            cmdConsultar.Text = "Consultar";
            cmdConsultar.UseVisualStyleBackColor = true;
            cmdConsultar.Click += cmdConsultar_Click;
            // 
            // rbImportado
            // 
            rbImportado.AutoSize = true;
            rbImportado.Location = new Point(347, 68);
            rbImportado.Margin = new Padding(3, 2, 3, 2);
            rbImportado.Name = "rbImportado";
            rbImportado.Size = new Size(92, 23);
            rbImportado.TabIndex = 5;
            rbImportado.TabStop = true;
            rbImportado.Text = "Importado";
            rbImportado.UseVisualStyleBackColor = true;
            // 
            // rbNacional
            // 
            rbNacional.AutoSize = true;
            rbNacional.Location = new Point(347, 43);
            rbNacional.Margin = new Padding(3, 2, 3, 2);
            rbNacional.Name = "rbNacional";
            rbNacional.Size = new Size(79, 23);
            rbNacional.TabIndex = 4;
            rbNacional.TabStop = true;
            rbNacional.Text = "Nacional";
            rbNacional.UseVisualStyleBackColor = true;
            // 
            // lstMarca2
            // 
            lstMarca2.DropDownStyle = ComboBoxStyle.DropDownList;
            lstMarca2.FormattingEnabled = true;
            lstMarca2.Items.AddRange(new object[] { "Peugeot (P)", "Fiat (F)", "Renault (R)" });
            lstMarca2.Location = new Point(85, 37);
            lstMarca2.Margin = new Padding(3, 2, 3, 2);
            lstMarca2.Name = "lstMarca2";
            lstMarca2.Size = new Size(133, 27);
            lstMarca2.TabIndex = 3;
            // 
            // lblMarca2
            // 
            lblMarca2.AutoSize = true;
            lblMarca2.Location = new Point(17, 43);
            lblMarca2.Name = "lblMarca2";
            lblMarca2.Size = new Size(47, 19);
            lblMarca2.TabIndex = 2;
            lblMarca2.Text = "Marca";
            // 
            // lblOrigen2
            // 
            lblOrigen2.AutoSize = true;
            lblOrigen2.Location = new Point(271, 43);
            lblOrigen2.Name = "lblOrigen2";
            lblOrigen2.Size = new Size(51, 19);
            lblOrigen2.TabIndex = 1;
            lblOrigen2.Text = "Origen";
            // 
            // lblTitulo2
            // 
            lblTitulo2.AutoSize = true;
            lblTitulo2.Location = new Point(0, 10);
            lblTitulo2.Name = "lblTitulo2";
            lblTitulo2.Size = new Size(129, 19);
            lblTitulo2.TabIndex = 0;
            lblTitulo2.Text = "Consultar Repuesto";
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 400);
            Controls.Add(tbc1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmInicio";
            Text = "Inicio";
            tbc1.ResumeLayout(false);
            tbRegistrar.ResumeLayout(false);
            tbRegistrar.PerformLayout();
            tbConsultar.ResumeLayout(false);
            tbConsultar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbc1;
        private TabPage tbRegistrar;
        private TabPage tbConsultar;
        private Label lblMarca;
        private Label lblOrigen;
        private Label lblNumero;
        private Label lblTitulo;
        private Button cmdRegistrar;
        private Label lblDescripcion;
        private Label lblPrecio;
        private ComboBox lstOrigen;
        private MaskedTextBox mtbNumero;
        private ComboBox lstMarca;
        private Button cmdCancelar;
        private TextBox txtDescripcion;
        private MaskedTextBox mtbPrecio;
        private Label lblMarca2;
        private Label lblOrigen2;
        private Label lblTitulo2;
        private ComboBox lstMarca2;
        private ListBox ltbResultados;
        private Button cmdConsultar;
        private RadioButton rbImportado;
        private RadioButton rbNacional;
    }
}
