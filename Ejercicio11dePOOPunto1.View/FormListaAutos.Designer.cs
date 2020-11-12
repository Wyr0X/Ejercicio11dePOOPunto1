namespace Ejercicio11dePOOPunto1.View
{
    partial class FrmLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLista));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Combustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioDeFabricacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.BotonAgregar = new System.Windows.Forms.ToolStripButton();
            this.BotonEditar = new System.Windows.Forms.ToolStripButton();
            this.BotonEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BotonRecargar = new System.Windows.Forms.ToolStripButton();
            this.BotonOrdenar = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenarPatenteAZ = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenarPatenteZA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenarMarcaAZ = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenarMarcaZA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenarAnioNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenarAnioAntiguo = new System.Windows.Forms.ToolStripMenuItem();
            this.BotonFiltrar = new System.Windows.Forms.ToolStripDropDownButton();
            this.FiltrarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.FiltrarColor = new System.Windows.Forms.ToolStripMenuItem();
            this.FiltrarCombustible = new System.Windows.Forms.ToolStripMenuItem();
            this.combustibleComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.BotonEstadisticas = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Patente,
            this.Marca,
            this.Modelo,
            this.Color,
            this.Combustible,
            this.AnioDeFabricacion});
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(0, 62);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(644, 326);
            this.dataGridView.TabIndex = 0;
            // 
            // Patente
            // 
            this.Patente.HeaderText = "Patente (clave)";
            this.Patente.Name = "Patente";
            this.Patente.ReadOnly = true;
            this.Patente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Combustible
            // 
            this.Combustible.HeaderText = "Combustible";
            this.Combustible.Name = "Combustible";
            this.Combustible.ReadOnly = true;
            this.Combustible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AnioDeFabricacion
            // 
            this.AnioDeFabricacion.HeaderText = "Año de Fabricación";
            this.AnioDeFabricacion.Name = "AnioDeFabricacion";
            this.AnioDeFabricacion.ReadOnly = true;
            this.AnioDeFabricacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BotonAgregar,
            this.BotonEditar,
            this.BotonEliminar,
            this.toolStripSeparator1,
            this.BotonRecargar,
            this.BotonOrdenar,
            this.BotonFiltrar,
            this.BotonEstadisticas});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(644, 59);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.BotonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonAgregar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAgregar.ForeColor = System.Drawing.Color.Black;
            this.BotonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BotonAgregar.Image")));
            this.BotonAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BotonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotonAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.BotonAgregar.Size = new System.Drawing.Size(63, 55);
            this.BotonAgregar.Text = "Agregar";
            this.BotonAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // BotonEditar
            // 
            this.BotonEditar.BackColor = System.Drawing.SystemColors.Control;
            this.BotonEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonEditar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEditar.ForeColor = System.Drawing.Color.Black;
            this.BotonEditar.Image = ((System.Drawing.Image)(resources.GetObject("BotonEditar.Image")));
            this.BotonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BotonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotonEditar.Margin = new System.Windows.Forms.Padding(2);
            this.BotonEditar.Name = "BotonEditar";
            this.BotonEditar.Padding = new System.Windows.Forms.Padding(3);
            this.BotonEditar.Size = new System.Drawing.Size(50, 55);
            this.BotonEditar.Text = "Editar";
            this.BotonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BotonEditar.Click += new System.EventHandler(this.BotonEditar_Click);
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.BotonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonEliminar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEliminar.ForeColor = System.Drawing.Color.Black;
            this.BotonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BotonEliminar.Image")));
            this.BotonEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BotonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotonEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.BotonEliminar.Size = new System.Drawing.Size(60, 55);
            this.BotonEliminar.Text = "Elminar";
            this.BotonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 59);
            // 
            // BotonRecargar
            // 
            this.BotonRecargar.BackColor = System.Drawing.SystemColors.Control;
            this.BotonRecargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonRecargar.Enabled = false;
            this.BotonRecargar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonRecargar.ForeColor = System.Drawing.Color.Black;
            this.BotonRecargar.Image = ((System.Drawing.Image)(resources.GetObject("BotonRecargar.Image")));
            this.BotonRecargar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BotonRecargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotonRecargar.Margin = new System.Windows.Forms.Padding(2);
            this.BotonRecargar.Name = "BotonRecargar";
            this.BotonRecargar.Padding = new System.Windows.Forms.Padding(3);
            this.BotonRecargar.Size = new System.Drawing.Size(70, 55);
            this.BotonRecargar.Text = "Recargar";
            this.BotonRecargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BotonRecargar.Click += new System.EventHandler(this.BotonRecargar_Click);
            // 
            // BotonOrdenar
            // 
            this.BotonOrdenar.BackColor = System.Drawing.SystemColors.Control;
            this.BotonOrdenar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4,
            this.toolStripMenuItem10});
            this.BotonOrdenar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonOrdenar.ForeColor = System.Drawing.Color.Black;
            this.BotonOrdenar.Image = ((System.Drawing.Image)(resources.GetObject("BotonOrdenar.Image")));
            this.BotonOrdenar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BotonOrdenar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotonOrdenar.Margin = new System.Windows.Forms.Padding(2);
            this.BotonOrdenar.Name = "BotonOrdenar";
            this.BotonOrdenar.Padding = new System.Windows.Forms.Padding(3);
            this.BotonOrdenar.Size = new System.Drawing.Size(73, 55);
            this.BotonOrdenar.Text = "Ordenar";
            this.BotonOrdenar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.BotonOrdenar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BotonOrdenar.ToolTipText = "Ordenar";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrdenarPatenteAZ,
            this.OrdenarPatenteZA});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Patente";
            // 
            // OrdenarPatenteAZ
            // 
            this.OrdenarPatenteAZ.Name = "OrdenarPatenteAZ";
            this.OrdenarPatenteAZ.Size = new System.Drawing.Size(180, 22);
            this.OrdenarPatenteAZ.Text = "A - Z";
            this.OrdenarPatenteAZ.Click += new System.EventHandler(this.OrdenarPatenteAZ_Click);
            // 
            // OrdenarPatenteZA
            // 
            this.OrdenarPatenteZA.Name = "OrdenarPatenteZA";
            this.OrdenarPatenteZA.Size = new System.Drawing.Size(180, 22);
            this.OrdenarPatenteZA.Text = "Z - A";
            this.OrdenarPatenteZA.Click += new System.EventHandler(this.OrdenarPatenteZA_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrdenarMarcaAZ,
            this.OrdenarMarcaZA});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "Marca";
            // 
            // OrdenarMarcaAZ
            // 
            this.OrdenarMarcaAZ.Name = "OrdenarMarcaAZ";
            this.OrdenarMarcaAZ.Size = new System.Drawing.Size(99, 22);
            this.OrdenarMarcaAZ.Text = "A - Z";
            this.OrdenarMarcaAZ.Click += new System.EventHandler(this.OrdenarMarcaAZ_Click);
            // 
            // OrdenarMarcaZA
            // 
            this.OrdenarMarcaZA.Name = "OrdenarMarcaZA";
            this.OrdenarMarcaZA.Size = new System.Drawing.Size(99, 22);
            this.OrdenarMarcaZA.Text = "Z - A";
            this.OrdenarMarcaZA.Click += new System.EventHandler(this.OrdenarMarcaZA_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrdenarAnioNuevo,
            this.OrdenarAnioAntiguo});
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem10.Text = "Año de fabricación";
            // 
            // OrdenarAnioNuevo
            // 
            this.OrdenarAnioNuevo.Name = "OrdenarAnioNuevo";
            this.OrdenarAnioNuevo.Size = new System.Drawing.Size(191, 22);
            this.OrdenarAnioNuevo.Text = "Más nuevo primero";
            this.OrdenarAnioNuevo.Click += new System.EventHandler(this.OrdenarAnioNuevo_Click);
            // 
            // OrdenarAnioAntiguo
            // 
            this.OrdenarAnioAntiguo.Name = "OrdenarAnioAntiguo";
            this.OrdenarAnioAntiguo.Size = new System.Drawing.Size(191, 22);
            this.OrdenarAnioAntiguo.Text = "Más antiguo primero";
            this.OrdenarAnioAntiguo.Click += new System.EventHandler(this.OrdenarAnioAntiguo_Click);
            // 
            // BotonFiltrar
            // 
            this.BotonFiltrar.BackColor = System.Drawing.SystemColors.Control;
            this.BotonFiltrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FiltrarMarca,
            this.FiltrarColor,
            this.FiltrarCombustible});
            this.BotonFiltrar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonFiltrar.ForeColor = System.Drawing.Color.Black;
            this.BotonFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("BotonFiltrar.Image")));
            this.BotonFiltrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BotonFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotonFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.BotonFiltrar.Name = "BotonFiltrar";
            this.BotonFiltrar.Padding = new System.Windows.Forms.Padding(3);
            this.BotonFiltrar.Size = new System.Drawing.Size(59, 55);
            this.BotonFiltrar.Text = "Filtrar";
            this.BotonFiltrar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.BotonFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BotonFiltrar.ToolTipText = "Filtrar";
            // 
            // FiltrarMarca
            // 
            this.FiltrarMarca.Name = "FiltrarMarca";
            this.FiltrarMarca.Size = new System.Drawing.Size(145, 22);
            this.FiltrarMarca.Text = "Marca";
            this.FiltrarMarca.Click += new System.EventHandler(this.FiltrarMarca_Click);
            // 
            // FiltrarColor
            // 
            this.FiltrarColor.Name = "FiltrarColor";
            this.FiltrarColor.Size = new System.Drawing.Size(145, 22);
            this.FiltrarColor.Text = "Color";
            this.FiltrarColor.Click += new System.EventHandler(this.FiltrarColor_Click);
            // 
            // FiltrarCombustible
            // 
            this.FiltrarCombustible.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.combustibleComboBox});
            this.FiltrarCombustible.Name = "FiltrarCombustible";
            this.FiltrarCombustible.Size = new System.Drawing.Size(145, 22);
            this.FiltrarCombustible.Text = "Combustible";
            // 
            // combustibleComboBox
            // 
            this.combustibleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combustibleComboBox.Name = "combustibleComboBox";
            this.combustibleComboBox.Size = new System.Drawing.Size(121, 23);
            this.combustibleComboBox.SelectedIndexChanged += new System.EventHandler(this.CombustibleComboBox_SelectedIndexChanged);
            // 
            // BotonEstadisticas
            // 
            this.BotonEstadisticas.BackColor = System.Drawing.SystemColors.Control;
            this.BotonEstadisticas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEstadisticas.ForeColor = System.Drawing.Color.Black;
            this.BotonEstadisticas.Image = ((System.Drawing.Image)(resources.GetObject("BotonEstadisticas.Image")));
            this.BotonEstadisticas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BotonEstadisticas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotonEstadisticas.Margin = new System.Windows.Forms.Padding(2);
            this.BotonEstadisticas.Name = "BotonEstadisticas";
            this.BotonEstadisticas.Padding = new System.Windows.Forms.Padding(3);
            this.BotonEstadisticas.Size = new System.Drawing.Size(87, 55);
            this.BotonEstadisticas.Text = "Estadísticas";
            this.BotonEstadisticas.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.BotonEstadisticas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BotonEstadisticas.ToolTipText = "Estadísticas";
            this.BotonEstadisticas.Click += new System.EventHandler(this.BotonEstadisticas_Click);
            // 
            // FrmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 387);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(660, 426);
            this.Name = "FrmLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de autos";
            this.Load += new System.EventHandler(this.FrmLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton BotonAgregar;
        private System.Windows.Forms.ToolStripButton BotonEditar;
        private System.Windows.Forms.ToolStripButton BotonRecargar;
        private System.Windows.Forms.ToolStripDropDownButton BotonOrdenar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem OrdenarPatenteAZ;
        private System.Windows.Forms.ToolStripMenuItem OrdenarPatenteZA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem OrdenarMarcaAZ;
        private System.Windows.Forms.ToolStripMenuItem OrdenarMarcaZA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem OrdenarAnioNuevo;
        private System.Windows.Forms.ToolStripMenuItem OrdenarAnioAntiguo;
        private System.Windows.Forms.ToolStripDropDownButton BotonFiltrar;
        private System.Windows.Forms.ToolStripMenuItem FiltrarMarca;
        private System.Windows.Forms.ToolStripMenuItem FiltrarCombustible;
        private System.Windows.Forms.ToolStripComboBox combustibleComboBox;
        private System.Windows.Forms.ToolStripMenuItem FiltrarColor;
        private System.Windows.Forms.ToolStripButton BotonEstadisticas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Combustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioDeFabricacion;
        private System.Windows.Forms.ToolStripButton BotonEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

