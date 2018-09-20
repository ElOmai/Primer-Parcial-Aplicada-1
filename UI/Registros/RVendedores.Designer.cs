namespace Primer_Parcial.UI.NewFolder1
{
    partial class RVendedor
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
            this.components = new System.ComponentModel.Container();
            this.Buscar_Button = new System.Windows.Forms.Button();
            this.Nuevo_Button = new System.Windows.Forms.Button();
            this.Guardar_Button = new System.Windows.Forms.Button();
            this.Eliminar_Button = new System.Windows.Forms.Button();
            this.VendedorIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.VendedorIdLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.SueldoLabel = new System.Windows.Forms.Label();
            this.PorcentajeLabel = new System.Windows.Forms.Label();
            this.RetencionLabel = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.SueldoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PorcentajeRetencionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RetencionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.VendedorErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.VendedorIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SueldoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PorcentajeRetencionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetencionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendedorErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscar_Button
            // 
            this.Buscar_Button.Location = new System.Drawing.Point(243, 19);
            this.Buscar_Button.Name = "Buscar_Button";
            this.Buscar_Button.Size = new System.Drawing.Size(75, 53);
            this.Buscar_Button.TabIndex = 0;
            this.Buscar_Button.Text = "Buscar";
            this.Buscar_Button.UseVisualStyleBackColor = true;
            this.Buscar_Button.Click += new System.EventHandler(this.Buscar_Button_Click);
            // 
            // Nuevo_Button
            // 
            this.Nuevo_Button.Location = new System.Drawing.Point(22, 297);
            this.Nuevo_Button.Name = "Nuevo_Button";
            this.Nuevo_Button.Size = new System.Drawing.Size(75, 48);
            this.Nuevo_Button.TabIndex = 1;
            this.Nuevo_Button.Text = "Nuevo";
            this.Nuevo_Button.UseVisualStyleBackColor = true;
            this.Nuevo_Button.Click += new System.EventHandler(this.Nuevo_Button_Click);
            // 
            // Guardar_Button
            // 
            this.Guardar_Button.Location = new System.Drawing.Point(137, 297);
            this.Guardar_Button.Name = "Guardar_Button";
            this.Guardar_Button.Size = new System.Drawing.Size(75, 48);
            this.Guardar_Button.TabIndex = 2;
            this.Guardar_Button.Text = "Guardar";
            this.Guardar_Button.UseVisualStyleBackColor = true;
            this.Guardar_Button.Click += new System.EventHandler(this.Guardar_Button_Click);
            // 
            // Eliminar_Button
            // 
            this.Eliminar_Button.Location = new System.Drawing.Point(243, 297);
            this.Eliminar_Button.Name = "Eliminar_Button";
            this.Eliminar_Button.Size = new System.Drawing.Size(75, 48);
            this.Eliminar_Button.TabIndex = 3;
            this.Eliminar_Button.Text = "Eliminar";
            this.Eliminar_Button.UseVisualStyleBackColor = true;
            this.Eliminar_Button.Click += new System.EventHandler(this.Eliminar_Button_Click);
            // 
            // VendedorIdNumericUpDown
            // 
            this.VendedorIdNumericUpDown.Location = new System.Drawing.Point(133, 19);
            this.VendedorIdNumericUpDown.Name = "VendedorIdNumericUpDown";
            this.VendedorIdNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.VendedorIdNumericUpDown.TabIndex = 4;
            // 
            // VendedorIdLabel
            // 
            this.VendedorIdLabel.AutoSize = true;
            this.VendedorIdLabel.Location = new System.Drawing.Point(19, 19);
            this.VendedorIdLabel.Name = "VendedorIdLabel";
            this.VendedorIdLabel.Size = new System.Drawing.Size(62, 13);
            this.VendedorIdLabel.TabIndex = 5;
            this.VendedorIdLabel.Text = "VendedorId";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(19, 68);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(44, 13);
            this.NombreLabel.TabIndex = 6;
            this.NombreLabel.Text = "Nombre";
            // 
            // SueldoLabel
            // 
            this.SueldoLabel.AutoSize = true;
            this.SueldoLabel.Location = new System.Drawing.Point(19, 127);
            this.SueldoLabel.Name = "SueldoLabel";
            this.SueldoLabel.Size = new System.Drawing.Size(40, 13);
            this.SueldoLabel.TabIndex = 7;
            this.SueldoLabel.Text = "Sueldo";
            // 
            // PorcentajeLabel
            // 
            this.PorcentajeLabel.AutoSize = true;
            this.PorcentajeLabel.Location = new System.Drawing.Point(19, 186);
            this.PorcentajeLabel.Name = "PorcentajeLabel";
            this.PorcentajeLabel.Size = new System.Drawing.Size(64, 13);
            this.PorcentajeLabel.TabIndex = 8;
            this.PorcentajeLabel.Text = "%Retencion";
            // 
            // RetencionLabel
            // 
            this.RetencionLabel.AutoSize = true;
            this.RetencionLabel.Location = new System.Drawing.Point(19, 251);
            this.RetencionLabel.Name = "RetencionLabel";
            this.RetencionLabel.Size = new System.Drawing.Size(56, 13);
            this.RetencionLabel.TabIndex = 9;
            this.RetencionLabel.Text = "Retencion";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(89, 61);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(119, 20);
            this.NombreTextBox.TabIndex = 13;
            // 
            // SueldoNumericUpDown
            // 
            this.SueldoNumericUpDown.DecimalPlaces = 2;
            this.SueldoNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SueldoNumericUpDown.Location = new System.Drawing.Point(89, 120);
            this.SueldoNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.SueldoNumericUpDown.Name = "SueldoNumericUpDown";
            this.SueldoNumericUpDown.Size = new System.Drawing.Size(119, 20);
            this.SueldoNumericUpDown.TabIndex = 14;
            // 
            // PorcentajeRetencionNumericUpDown
            // 
            this.PorcentajeRetencionNumericUpDown.DecimalPlaces = 2;
            this.PorcentajeRetencionNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PorcentajeRetencionNumericUpDown.Location = new System.Drawing.Point(89, 179);
            this.PorcentajeRetencionNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.PorcentajeRetencionNumericUpDown.Name = "PorcentajeRetencionNumericUpDown";
            this.PorcentajeRetencionNumericUpDown.Size = new System.Drawing.Size(119, 20);
            this.PorcentajeRetencionNumericUpDown.TabIndex = 15;
            // 
            // RetencionNumericUpDown
            // 
            this.RetencionNumericUpDown.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.RetencionNumericUpDown.DecimalPlaces = 2;
            this.RetencionNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.RetencionNumericUpDown.Location = new System.Drawing.Point(89, 244);
            this.RetencionNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.RetencionNumericUpDown.Name = "RetencionNumericUpDown";
            this.RetencionNumericUpDown.Size = new System.Drawing.Size(119, 20);
            this.RetencionNumericUpDown.TabIndex = 16;
            this.RetencionNumericUpDown.ValueChanged += new System.EventHandler(this.RetencionNumericUpDown_ValueChanged);
            // 
            // VendedorErrorProvider
            // 
            this.VendedorErrorProvider.ContainerControl = this;
            // 
            // RVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 357);
            this.Controls.Add(this.RetencionNumericUpDown);
            this.Controls.Add(this.PorcentajeRetencionNumericUpDown);
            this.Controls.Add(this.SueldoNumericUpDown);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.RetencionLabel);
            this.Controls.Add(this.PorcentajeLabel);
            this.Controls.Add(this.SueldoLabel);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.VendedorIdLabel);
            this.Controls.Add(this.VendedorIdNumericUpDown);
            this.Controls.Add(this.Eliminar_Button);
            this.Controls.Add(this.Guardar_Button);
            this.Controls.Add(this.Nuevo_Button);
            this.Controls.Add(this.Buscar_Button);
            this.Name = "RVendedor";
            this.Text = "RVendedor";
            ((System.ComponentModel.ISupportInitialize)(this.VendedorIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SueldoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PorcentajeRetencionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetencionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendedorErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscar_Button;
        private System.Windows.Forms.Button Nuevo_Button;
        private System.Windows.Forms.Button Guardar_Button;
        private System.Windows.Forms.Button Eliminar_Button;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label RetencionLabel;
        private System.Windows.Forms.Label PorcentajeLabel;
        private System.Windows.Forms.Label SueldoLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label VendedorIdLabel;
        private System.Windows.Forms.NumericUpDown VendedorIdNumericUpDown;
        private System.Windows.Forms.NumericUpDown RetencionNumericUpDown;
        private System.Windows.Forms.NumericUpDown PorcentajeRetencionNumericUpDown;
        private System.Windows.Forms.NumericUpDown SueldoNumericUpDown;
        private System.Windows.Forms.ErrorProvider VendedorErrorProvider;
    }
}