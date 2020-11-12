namespace Ejercicio11dePOOPunto1.View
{
    partial class FormFiltro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFiltro));
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.BotonFiltrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(13, 13);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(169, 20);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFiltro_KeyDown);
            // 
            // BotonFiltrar
            // 
            this.BotonFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("BotonFiltrar.Image")));
            this.BotonFiltrar.Location = new System.Drawing.Point(55, 49);
            this.BotonFiltrar.Name = "BotonFiltrar";
            this.BotonFiltrar.Size = new System.Drawing.Size(83, 50);
            this.BotonFiltrar.TabIndex = 1;
            this.BotonFiltrar.Text = "Filtrar";
            this.BotonFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BotonFiltrar.UseVisualStyleBackColor = true;
            this.BotonFiltrar.Click += new System.EventHandler(this.BotonFiltrar_Click);
            // 
            // FormFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 111);
            this.Controls.Add(this.BotonFiltrar);
            this.Controls.Add(this.txtFiltro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFiltro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button BotonFiltrar;
    }
}