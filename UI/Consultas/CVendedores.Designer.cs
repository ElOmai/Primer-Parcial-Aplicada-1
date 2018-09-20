using System;

namespace Primer_Parcial.UI.Consultas
{
    partial class CVendedor
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

       
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FechacheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConsultardataGridView = new System.Windows.Forms.DataGridView();
            this.criteriotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GeneralerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.Buscar_Button = new System.Windows.Forms.Button();
            this.MinDate = new System.Windows.Forms.DateTimePicker();
            this.MaxDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.primerParcialDBDataSet = new Primer_Parcial.PrimerParcialDBDataSet();
            this.vendedorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendedorsTableAdapter = new Primer_Parcial.PrimerParcialDBDataSetTableAdapters.VendedorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultardataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primerParcialDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FechacheckBox
            // 
            this.FechacheckBox.AutoSize = true;
            this.FechacheckBox.Checked = true;
            this.FechacheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FechacheckBox.Location = new System.Drawing.Point(44, 30);
            this.FechacheckBox.Name = "FechacheckBox";
            this.FechacheckBox.Size = new System.Drawing.Size(56, 17);
            this.FechacheckBox.TabIndex = 23;
            this.FechacheckBox.Text = "Fecha";
            this.FechacheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Desde:";
            // 
            // ConsultardataGridView
            // 
            this.ConsultardataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultardataGridView.Location = new System.Drawing.Point(7, 87);
            this.ConsultardataGridView.Name = "ConsultardataGridView";
            this.ConsultardataGridView.Size = new System.Drawing.Size(631, 310);
            this.ConsultardataGridView.TabIndex = 17;
            // 
            // criteriotextBox
            // 
            this.criteriotextBox.Location = new System.Drawing.Point(243, 9);
            this.criteriotextBox.Name = "criteriotextBox";
            this.criteriotextBox.Size = new System.Drawing.Size(138, 20);
            this.criteriotextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Criterio";
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "Vendedor ID",
            "Nombre",
            "Sueldo",
            "Retencion",
            "%rRetencion"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(44, 9);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrocomboBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Filtro";
            // 
            // GeneralerrorProvider
            // 
            this.GeneralerrorProvider.ContainerControl = this;
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.FlatAppearance.BorderSize = 0;
            this.Imprimirbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Imprimirbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Imprimirbutton.Location = new System.Drawing.Point(7, 403);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(75, 47);
            this.Imprimirbutton.TabIndex = 18;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            // 
            // Buscar_Button
            // 
            this.Buscar_Button.Location = new System.Drawing.Point(441, 9);
            this.Buscar_Button.Name = "Buscar_Button";
            this.Buscar_Button.Size = new System.Drawing.Size(75, 36);
            this.Buscar_Button.TabIndex = 24;
            this.Buscar_Button.Text = "Buscar";
            this.Buscar_Button.UseVisualStyleBackColor = true;
            // 
            // MinDate
            // 
            this.MinDate.Location = new System.Drawing.Point(55, 55);
            this.MinDate.Name = "MinDate";
            this.MinDate.Size = new System.Drawing.Size(200, 20);
            this.MinDate.TabIndex = 25;
            // 
            // MaxDate
            // 
            this.MaxDate.Location = new System.Drawing.Point(316, 55);
            this.MaxDate.Name = "MaxDate";
            this.MaxDate.Size = new System.Drawing.Size(200, 20);
            this.MaxDate.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Hasta";
            // 
            // primerParcialDBDataSet
            // 
            this.primerParcialDBDataSet.DataSetName = "PrimerParcialDBDataSet";
            this.primerParcialDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendedorsBindingSource
            // 
            this.vendedorsBindingSource.DataMember = "Vendedors";
            this.vendedorsBindingSource.DataSource = this.primerParcialDBDataSet;
            // 
            // vendedorsTableAdapter
            // 
            this.vendedorsTableAdapter.ClearBeforeFill = true;
            // 
            // CVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaxDate);
            this.Controls.Add(this.MinDate);
            this.Controls.Add(this.Buscar_Button);
            this.Controls.Add(this.FechacheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.ConsultardataGridView);
            this.Controls.Add(this.criteriotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.label1);
            this.Name = "CVendedor";
            this.Text = "Consulta de Vendedores";
            this.Load += new System.EventHandler(this.CVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultardataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primerParcialDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.CheckBox FechacheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.DataGridView ConsultardataGridView;
        private System.Windows.Forms.TextBox criteriotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider GeneralerrorProvider;
        private System.Windows.Forms.Button Buscar_Button;
        private System.Windows.Forms.DateTimePicker MaxDate;
        private System.Windows.Forms.DateTimePicker MinDate;
        private System.Windows.Forms.Label label4;
        private PrimerParcialDBDataSet primerParcialDBDataSet;
        private System.Windows.Forms.BindingSource vendedorsBindingSource;
        private PrimerParcialDBDataSetTableAdapters.VendedorsTableAdapter vendedorsTableAdapter;
    }
}
