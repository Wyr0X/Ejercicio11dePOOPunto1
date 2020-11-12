namespace Ejercicio11dePOOPunto1.View
{
    partial class FormAgregarEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarEditar));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combustibleComboBox = new System.Windows.Forms.ComboBox();
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericAnio = new System.Windows.Forms.NumericUpDown();
            this.BotonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patente (clave)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPatente
            // 
            this.txtPatente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPatente.Location = new System.Drawing.Point(107, 17);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(121, 20);
            this.txtPatente.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(107, 43);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(121, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(107, 69);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(121, 20);
            this.txtModelo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modelo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(107, 95);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(121, 20);
            this.txtColor.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Color";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Combustible";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // combustibleComboBox
            // 
            this.combustibleComboBox.FormattingEnabled = true;
            this.combustibleComboBox.Location = new System.Drawing.Point(107, 121);
            this.combustibleComboBox.Name = "combustibleComboBox";
            this.combustibleComboBox.Size = new System.Drawing.Size(121, 21);
            this.combustibleComboBox.TabIndex = 9;
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BotonAceptar.Image = ((System.Drawing.Image)(resources.GetObject("BotonAceptar.Image")));
            this.BotonAceptar.Location = new System.Drawing.Point(35, 204);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(76, 36);
            this.BotonAceptar.TabIndex = 10;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonAceptar.UseVisualStyleBackColor = false;
            this.BotonAceptar.Click += new System.EventHandler(this.BotonAceptar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Año de fabricación";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericAnio
            // 
            this.numericAnio.Location = new System.Drawing.Point(107, 149);
            this.numericAnio.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericAnio.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericAnio.Name = "numericAnio";
            this.numericAnio.Size = new System.Drawing.Size(120, 20);
            this.numericAnio.TabIndex = 12;
            this.numericAnio.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BotonCancelar.Image")));
            this.BotonCancelar.Location = new System.Drawing.Point(133, 204);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(81, 36);
            this.BotonCancelar.TabIndex = 13;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BotonCancelar.UseVisualStyleBackColor = false;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // FormAgregarEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 247);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.numericAnio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BotonAceptar);
            this.Controls.Add(this.combustibleComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAgregarEditar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormAgregarEditar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combustibleComboBox;
        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericAnio;
        private System.Windows.Forms.Button BotonCancelar;
    }
}