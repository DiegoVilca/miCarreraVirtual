namespace claseTresFormUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.cmbCorrerCarrera = new System.Windows.Forms.ComboBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCorrerCarrera = new System.Windows.Forms.Button();
            this.gpbListaAutos = new System.Windows.Forms.GroupBox();
            this.lsbListaAutos = new System.Windows.Forms.ListBox();
            this.gpbAutos = new System.Windows.Forms.GroupBox();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.txtNombrePiloto = new System.Windows.Forms.TextBox();
            this.lblNombrePiloto = new System.Windows.Forms.Label();
            this.gpbCarrera = new System.Windows.Forms.GroupBox();
            this.btnCrearCarrera = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gpbOrdenar = new System.Windows.Forms.GroupBox();
            this.rbDescendente = new System.Windows.Forms.RadioButton();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.cmbOrdenar = new System.Windows.Forms.ComboBox();
            this.rbAscendente = new System.Windows.Forms.RadioButton();
            this.gpbResultado.SuspendLayout();
            this.gpbListaAutos.SuspendLayout();
            this.gpbAutos.SuspendLayout();
            this.gpbCarrera.SuspendLayout();
            this.gpbOrdenar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.cmbCorrerCarrera);
            this.gpbResultado.Controls.Add(this.txtResultado);
            this.gpbResultado.Controls.Add(this.btnCorrerCarrera);
            this.gpbResultado.Location = new System.Drawing.Point(29, 377);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Size = new System.Drawing.Size(276, 253);
            this.gpbResultado.TabIndex = 8;
            this.gpbResultado.TabStop = false;
            this.gpbResultado.Text = "Resultado";
            // 
            // cmbCorrerCarrera
            // 
            this.cmbCorrerCarrera.FormattingEnabled = true;
            this.cmbCorrerCarrera.Location = new System.Drawing.Point(11, 197);
            this.cmbCorrerCarrera.Name = "cmbCorrerCarrera";
            this.cmbCorrerCarrera.Size = new System.Drawing.Size(145, 21);
            this.cmbCorrerCarrera.TabIndex = 3;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(11, 14);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(259, 170);
            this.txtResultado.TabIndex = 2;
            // 
            // btnCorrerCarrera
            // 
            this.btnCorrerCarrera.Location = new System.Drawing.Point(177, 197);
            this.btnCorrerCarrera.Name = "btnCorrerCarrera";
            this.btnCorrerCarrera.Size = new System.Drawing.Size(99, 23);
            this.btnCorrerCarrera.TabIndex = 1;
            this.btnCorrerCarrera.Text = "Correr";
            this.btnCorrerCarrera.UseVisualStyleBackColor = true;
            this.btnCorrerCarrera.Click += new System.EventHandler(this.btnCorrerCarrera_Click);
            // 
            // gpbListaAutos
            // 
            this.gpbListaAutos.Controls.Add(this.lsbListaAutos);
            this.gpbListaAutos.Location = new System.Drawing.Point(317, 152);
            this.gpbListaAutos.Name = "gpbListaAutos";
            this.gpbListaAutos.Size = new System.Drawing.Size(294, 347);
            this.gpbListaAutos.TabIndex = 9;
            this.gpbListaAutos.TabStop = false;
            this.gpbListaAutos.Text = "Lista de autos";
            // 
            // lsbListaAutos
            // 
            this.lsbListaAutos.FormattingEnabled = true;
            this.lsbListaAutos.Location = new System.Drawing.Point(19, 23);
            this.lsbListaAutos.Name = "lsbListaAutos";
            this.lsbListaAutos.Size = new System.Drawing.Size(255, 303);
            this.lsbListaAutos.TabIndex = 0;
            // 
            // gpbAutos
            // 
            this.gpbAutos.Controls.Add(this.cmbFabricante);
            this.gpbAutos.Controls.Add(this.btnAgregarAuto);
            this.gpbAutos.Controls.Add(this.lblFabricante);
            this.gpbAutos.Controls.Add(this.txtNombrePiloto);
            this.gpbAutos.Controls.Add(this.lblNombrePiloto);
            this.gpbAutos.Enabled = false;
            this.gpbAutos.Location = new System.Drawing.Point(31, 152);
            this.gpbAutos.Name = "gpbAutos";
            this.gpbAutos.Size = new System.Drawing.Size(209, 219);
            this.gpbAutos.TabIndex = 10;
            this.gpbAutos.TabStop = false;
            this.gpbAutos.Text = "Autos";
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(20, 105);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(159, 21);
            this.cmbFabricante.TabIndex = 3;
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.Location = new System.Drawing.Point(20, 145);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(159, 23);
            this.btnAgregarAuto.TabIndex = 2;
            this.btnAgregarAuto.Text = "Agregar auto";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(17, 89);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(57, 13);
            this.lblFabricante.TabIndex = 1;
            this.lblFabricante.Text = "Fabricante";
            // 
            // txtNombrePiloto
            // 
            this.txtNombrePiloto.Location = new System.Drawing.Point(20, 39);
            this.txtNombrePiloto.Name = "txtNombrePiloto";
            this.txtNombrePiloto.Size = new System.Drawing.Size(159, 20);
            this.txtNombrePiloto.TabIndex = 0;
            // 
            // lblNombrePiloto
            // 
            this.lblNombrePiloto.AutoSize = true;
            this.lblNombrePiloto.Location = new System.Drawing.Point(17, 23);
            this.lblNombrePiloto.Name = "lblNombrePiloto";
            this.lblNombrePiloto.Size = new System.Drawing.Size(73, 13);
            this.lblNombrePiloto.TabIndex = 1;
            this.lblNombrePiloto.Text = "Nombre Piloto";
            // 
            // gpbCarrera
            // 
            this.gpbCarrera.Controls.Add(this.btnCrearCarrera);
            this.gpbCarrera.Controls.Add(this.label3);
            this.gpbCarrera.Controls.Add(this.txtLugar);
            this.gpbCarrera.Controls.Add(this.label2);
            this.gpbCarrera.Controls.Add(this.txtFecha);
            this.gpbCarrera.Controls.Add(this.label1);
            this.gpbCarrera.Controls.Add(this.txtNombre);
            this.gpbCarrera.Location = new System.Drawing.Point(31, 31);
            this.gpbCarrera.Name = "gpbCarrera";
            this.gpbCarrera.Size = new System.Drawing.Size(583, 115);
            this.gpbCarrera.TabIndex = 11;
            this.gpbCarrera.TabStop = false;
            this.gpbCarrera.Text = "Carrera";
            // 
            // btnCrearCarrera
            // 
            this.btnCrearCarrera.Location = new System.Drawing.Point(23, 62);
            this.btnCrearCarrera.Name = "btnCrearCarrera";
            this.btnCrearCarrera.Size = new System.Drawing.Size(156, 23);
            this.btnCrearCarrera.TabIndex = 2;
            this.btnCrearCarrera.Text = "Crear Carrera";
            this.btnCrearCarrera.UseVisualStyleBackColor = true;
            this.btnCrearCarrera.Click += new System.EventHandler(this.btnCrearCarrera_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lugar";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(198, 35);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(150, 20);
            this.txtLugar.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(369, 35);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(145, 20);
            this.txtFecha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(20, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // gpbOrdenar
            // 
            this.gpbOrdenar.Controls.Add(this.rbDescendente);
            this.gpbOrdenar.Controls.Add(this.btnOrdenar);
            this.gpbOrdenar.Controls.Add(this.cmbOrdenar);
            this.gpbOrdenar.Controls.Add(this.rbAscendente);
            this.gpbOrdenar.Location = new System.Drawing.Point(317, 505);
            this.gpbOrdenar.Name = "gpbOrdenar";
            this.gpbOrdenar.Size = new System.Drawing.Size(274, 125);
            this.gpbOrdenar.TabIndex = 12;
            this.gpbOrdenar.TabStop = false;
            this.gpbOrdenar.Text = "Ordenar";
            // 
            // rbDescendente
            // 
            this.rbDescendente.AutoSize = true;
            this.rbDescendente.Location = new System.Drawing.Point(90, 81);
            this.rbDescendente.Name = "rbDescendente";
            this.rbDescendente.Size = new System.Drawing.Size(50, 17);
            this.rbDescendente.TabIndex = 6;
            this.rbDescendente.TabStop = true;
            this.rbDescendente.Text = "Desc";
            this.rbDescendente.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(165, 35);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(91, 29);
            this.btnOrdenar.TabIndex = 4;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // cmbOrdenar
            // 
            this.cmbOrdenar.FormattingEnabled = true;
            this.cmbOrdenar.Location = new System.Drawing.Point(19, 35);
            this.cmbOrdenar.Name = "cmbOrdenar";
            this.cmbOrdenar.Size = new System.Drawing.Size(121, 21);
            this.cmbOrdenar.TabIndex = 4;
            // 
            // rbAscendente
            // 
            this.rbAscendente.AutoSize = true;
            this.rbAscendente.Location = new System.Drawing.Point(19, 81);
            this.rbAscendente.Name = "rbAscendente";
            this.rbAscendente.Size = new System.Drawing.Size(43, 17);
            this.rbAscendente.TabIndex = 5;
            this.rbAscendente.TabStop = true;
            this.rbAscendente.Text = "Asc";
            this.rbAscendente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 676);
            this.Controls.Add(this.gpbResultado);
            this.Controls.Add(this.gpbListaAutos);
            this.Controls.Add(this.gpbAutos);
            this.Controls.Add(this.gpbCarrera);
            this.Controls.Add(this.gpbOrdenar);
            this.Name = "Form1";
            this.Text = "Carrera Virtual";
            this.gpbResultado.ResumeLayout(false);
            this.gpbResultado.PerformLayout();
            this.gpbListaAutos.ResumeLayout(false);
            this.gpbAutos.ResumeLayout(false);
            this.gpbAutos.PerformLayout();
            this.gpbCarrera.ResumeLayout(false);
            this.gpbCarrera.PerformLayout();
            this.gpbOrdenar.ResumeLayout(false);
            this.gpbOrdenar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.ComboBox cmbCorrerCarrera;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCorrerCarrera;
        private System.Windows.Forms.GroupBox gpbListaAutos;
        private System.Windows.Forms.ListBox lsbListaAutos;
        private System.Windows.Forms.GroupBox gpbAutos;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.TextBox txtNombrePiloto;
        private System.Windows.Forms.Label lblNombrePiloto;
        private System.Windows.Forms.GroupBox gpbCarrera;
        private System.Windows.Forms.Button btnCrearCarrera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gpbOrdenar;
        private System.Windows.Forms.RadioButton rbDescendente;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.ComboBox cmbOrdenar;
        private System.Windows.Forms.RadioButton rbAscendente;
    }
}

