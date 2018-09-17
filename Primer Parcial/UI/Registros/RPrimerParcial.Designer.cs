namespace Primer_Parcial.UI.Registros
{
    partial class RPrimerParcial
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
            this.Buscar_Button = new System.Windows.Forms.Button();
            this.Nuevo_Button = new System.Windows.Forms.Button();
            this.Guardar_Button = new System.Windows.Forms.Button();
            this.Eliminar_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Buscar_Button
            // 
            this.Buscar_Button.Location = new System.Drawing.Point(271, 12);
            this.Buscar_Button.Name = "Buscar_Button";
            this.Buscar_Button.Size = new System.Drawing.Size(75, 23);
            this.Buscar_Button.TabIndex = 0;
            this.Buscar_Button.Text = "Buscar";
            this.Buscar_Button.UseVisualStyleBackColor = true;
            // 
            // Nuevo_Button
            // 
            this.Nuevo_Button.Location = new System.Drawing.Point(12, 273);
            this.Nuevo_Button.Name = "Nuevo_Button";
            this.Nuevo_Button.Size = new System.Drawing.Size(75, 23);
            this.Nuevo_Button.TabIndex = 1;
            this.Nuevo_Button.Text = "Nuevo";
            this.Nuevo_Button.UseVisualStyleBackColor = true;
            // 
            // Guardar_Button
            // 
            this.Guardar_Button.Location = new System.Drawing.Point(271, 273);
            this.Guardar_Button.Name = "Guardar_Button";
            this.Guardar_Button.Size = new System.Drawing.Size(75, 23);
            this.Guardar_Button.TabIndex = 2;
            this.Guardar_Button.Text = "Guardar";
            this.Guardar_Button.UseVisualStyleBackColor = true;
            // 
            // Eliminar_Button
            // 
            this.Eliminar_Button.Location = new System.Drawing.Point(497, 273);
            this.Eliminar_Button.Name = "Eliminar_Button";
            this.Eliminar_Button.Size = new System.Drawing.Size(75, 23);
            this.Eliminar_Button.TabIndex = 3;
            this.Eliminar_Button.Text = "Eliminar";
            this.Eliminar_Button.UseVisualStyleBackColor = true;
            // 
            // RPrimerParcial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 308);
            this.Controls.Add(this.Eliminar_Button);
            this.Controls.Add(this.Guardar_Button);
            this.Controls.Add(this.Nuevo_Button);
            this.Controls.Add(this.Buscar_Button);
            this.Name = "RPrimerParcial";
            this.Text = "RPrimerParcial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Buscar_Button;
        private System.Windows.Forms.Button Nuevo_Button;
        private System.Windows.Forms.Button Guardar_Button;
        private System.Windows.Forms.Button Eliminar_Button;
    }
}