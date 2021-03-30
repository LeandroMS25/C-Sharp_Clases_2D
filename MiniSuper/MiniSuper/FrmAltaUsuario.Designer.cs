
namespace MiniSuper
{
    partial class FrmAltaUsuario
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.numDni = new System.Windows.Forms.NumericUpDown();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.chkEfectivo = new System.Windows.Forms.CheckBox();
            this.chkTarjeta = new System.Windows.Forms.CheckBox();
            this.chkMercadoPago = new System.Windows.Forms.CheckBox();
            this.panelFormasPago = new System.Windows.Forms.Panel();
            this.groupBoxMediosPago = new System.Windows.Forms.GroupBox();
            this.radioButtonEfectivo = new System.Windows.Forms.RadioButton();
            this.radioButtonTarjeta = new System.Windows.Forms.RadioButton();
            this.radioButtonMP = new System.Windows.Forms.RadioButton();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDni)).BeginInit();
            this.panelFormasPago.SuspendLayout();
            this.groupBoxMediosPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(55, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(55, 39);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(55, 126);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(151, 36);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(153, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(151, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // numDni
            // 
            this.numDni.Location = new System.Drawing.Point(151, 124);
            this.numDni.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numDni.Name = "numDni";
            this.numDni.Size = new System.Drawing.Size(153, 20);
            this.numDni.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(578, 354);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(55, 168);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(79, 13);
            this.lblFormaPago.TabIndex = 8;
            this.lblFormaPago.Text = "Forma de Pago";
            // 
            // chkEfectivo
            // 
            this.chkEfectivo.AutoSize = true;
            this.chkEfectivo.Location = new System.Drawing.Point(17, 11);
            this.chkEfectivo.Name = "chkEfectivo";
            this.chkEfectivo.Size = new System.Drawing.Size(65, 17);
            this.chkEfectivo.TabIndex = 9;
            this.chkEfectivo.Text = "Efectivo";
            this.chkEfectivo.UseVisualStyleBackColor = true;
            // 
            // chkTarjeta
            // 
            this.chkTarjeta.AutoSize = true;
            this.chkTarjeta.Location = new System.Drawing.Point(88, 11);
            this.chkTarjeta.Name = "chkTarjeta";
            this.chkTarjeta.Size = new System.Drawing.Size(59, 17);
            this.chkTarjeta.TabIndex = 10;
            this.chkTarjeta.Text = "Tarjeta";
            this.chkTarjeta.UseVisualStyleBackColor = true;
            // 
            // chkMercadoPago
            // 
            this.chkMercadoPago.AutoSize = true;
            this.chkMercadoPago.Location = new System.Drawing.Point(153, 11);
            this.chkMercadoPago.Name = "chkMercadoPago";
            this.chkMercadoPago.Size = new System.Drawing.Size(96, 17);
            this.chkMercadoPago.TabIndex = 11;
            this.chkMercadoPago.Text = "Mercado Pago";
            this.chkMercadoPago.UseVisualStyleBackColor = true;
            // 
            // panelFormasPago
            // 
            this.panelFormasPago.Controls.Add(this.chkMercadoPago);
            this.panelFormasPago.Controls.Add(this.chkTarjeta);
            this.panelFormasPago.Controls.Add(this.chkEfectivo);
            this.panelFormasPago.Location = new System.Drawing.Point(58, 184);
            this.panelFormasPago.Name = "panelFormasPago";
            this.panelFormasPago.Size = new System.Drawing.Size(262, 39);
            this.panelFormasPago.TabIndex = 12;
            // 
            // groupBoxMediosPago
            // 
            this.groupBoxMediosPago.Controls.Add(this.radioButtonMP);
            this.groupBoxMediosPago.Controls.Add(this.radioButtonTarjeta);
            this.groupBoxMediosPago.Controls.Add(this.radioButtonEfectivo);
            this.groupBoxMediosPago.Location = new System.Drawing.Point(58, 242);
            this.groupBoxMediosPago.Name = "groupBoxMediosPago";
            this.groupBoxMediosPago.Size = new System.Drawing.Size(262, 58);
            this.groupBoxMediosPago.TabIndex = 13;
            this.groupBoxMediosPago.TabStop = false;
            this.groupBoxMediosPago.Text = "Medio de Pago";
            // 
            // radioButtonEfectivo
            // 
            this.radioButtonEfectivo.AutoSize = true;
            this.radioButtonEfectivo.Location = new System.Drawing.Point(17, 29);
            this.radioButtonEfectivo.Name = "radioButtonEfectivo";
            this.radioButtonEfectivo.Size = new System.Drawing.Size(64, 17);
            this.radioButtonEfectivo.TabIndex = 0;
            this.radioButtonEfectivo.TabStop = true;
            this.radioButtonEfectivo.Text = "Efectivo";
            this.radioButtonEfectivo.UseVisualStyleBackColor = true;
            // 
            // radioButtonTarjeta
            // 
            this.radioButtonTarjeta.AutoSize = true;
            this.radioButtonTarjeta.Location = new System.Drawing.Point(93, 29);
            this.radioButtonTarjeta.Name = "radioButtonTarjeta";
            this.radioButtonTarjeta.Size = new System.Drawing.Size(58, 17);
            this.radioButtonTarjeta.TabIndex = 1;
            this.radioButtonTarjeta.TabStop = true;
            this.radioButtonTarjeta.Text = "Tarjeta";
            this.radioButtonTarjeta.UseVisualStyleBackColor = true;
            // 
            // radioButtonMP
            // 
            this.radioButtonMP.AutoSize = true;
            this.radioButtonMP.Location = new System.Drawing.Point(161, 29);
            this.radioButtonMP.Name = "radioButtonMP";
            this.radioButtonMP.Size = new System.Drawing.Size(95, 17);
            this.radioButtonMP.TabIndex = 2;
            this.radioButtonMP.TabStop = true;
            this.radioButtonMP.Text = "Mercado Pago";
            this.radioButtonMP.UseVisualStyleBackColor = true;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(58, 319);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(51, 13);
            this.lblProvincia.TabIndex = 14;
            this.lblProvincia.Text = "Provincia";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Items.AddRange(new object[] {
            "CABA",
            "Buenos Aires",
            "La Pampa",
            "Santa Fe",
            "Cordoba",
            "Mendoza",
            "Entre Ríos"});
            this.cmbProvincia.Location = new System.Drawing.Point(125, 316);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(121, 21);
            this.cmbProvincia.TabIndex = 15;
            // 
            // FrmAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 389);
            this.Controls.Add(this.cmbProvincia);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.groupBoxMediosPago);
            this.Controls.Add(this.panelFormasPago);
            this.Controls.Add(this.lblFormaPago);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.numDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmAltaUsuario";
            this.Text = "FrmAltaUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.numDni)).EndInit();
            this.panelFormasPago.ResumeLayout(false);
            this.panelFormasPago.PerformLayout();
            this.groupBoxMediosPago.ResumeLayout(false);
            this.groupBoxMediosPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown numDni;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.CheckBox chkEfectivo;
        private System.Windows.Forms.CheckBox chkTarjeta;
        private System.Windows.Forms.CheckBox chkMercadoPago;
        private System.Windows.Forms.Panel panelFormasPago;
        private System.Windows.Forms.GroupBox groupBoxMediosPago;
        private System.Windows.Forms.RadioButton radioButtonEfectivo;
        private System.Windows.Forms.RadioButton radioButtonMP;
        private System.Windows.Forms.RadioButton radioButtonTarjeta;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox cmbProvincia;
    }
}