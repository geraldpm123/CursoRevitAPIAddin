namespace CursoRevitAPIAddin
{
    partial class formulario07FamilyInstance
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCoordenadas = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFila = new System.Windows.Forms.Label();
            this.btnEliminarFila = new System.Windows.Forms.Button();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolImportar = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnImportarCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImportarExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExportar = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnExportarCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportarExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbNiveles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picImagenDeTipo = new System.Windows.Forms.PictureBox();
            this.btnColocarEjemplares = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoordenadas)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenDeTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnColocarEjemplares, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(577, 440);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordenadas de Colocacion";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.Controls.Add(this.dgvCoordenadas, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(565, 220);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // dgvCoordenadas
            // 
            this.dgvCoordenadas.AllowUserToAddRows = false;
            this.dgvCoordenadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoordenadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y,
            this.z});
            this.dgvCoordenadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCoordenadas.Location = new System.Drawing.Point(3, 33);
            this.dgvCoordenadas.Name = "dgvCoordenadas";
            this.dgvCoordenadas.Size = new System.Drawing.Size(459, 184);
            this.dgvCoordenadas.TabIndex = 0;
            this.dgvCoordenadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoordenadas_CellClick);
            // 
            // x
            // 
            this.x.HeaderText = "X (m)";
            this.x.Name = "x";
            this.x.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // y
            // 
            this.y.HeaderText = "Y (m)";
            this.y.Name = "y";
            this.y.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // z
            // 
            this.z.HeaderText = "Z (m)";
            this.z.Name = "z";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblFila);
            this.panel2.Controls.Add(this.btnEliminarFila);
            this.panel2.Controls.Add(this.btnAnadir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(468, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(94, 184);
            this.panel2.TabIndex = 1;
            // 
            // lblFila
            // 
            this.lblFila.AutoSize = true;
            this.lblFila.Location = new System.Drawing.Point(4, 169);
            this.lblFila.Name = "lblFila";
            this.lblFila.Size = new System.Drawing.Size(0, 13);
            this.lblFila.TabIndex = 2;
            // 
            // btnEliminarFila
            // 
            this.btnEliminarFila.Location = new System.Drawing.Point(3, 32);
            this.btnEliminarFila.Name = "btnEliminarFila";
            this.btnEliminarFila.Size = new System.Drawing.Size(88, 23);
            this.btnEliminarFila.TabIndex = 1;
            this.btnEliminarFila.Text = "Eliminar Fila";
            this.btnEliminarFila.UseVisualStyleBackColor = true;
            this.btnEliminarFila.Click += new System.EventHandler(this.btnEliminarFila_Click);
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(3, 3);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(88, 23);
            this.btnAnadir.TabIndex = 0;
            this.btnAnadir.Text = "Añadir Fila";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolImportar,
            this.toolExportar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(465, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolImportar
            // 
            this.toolImportar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImportarCSV,
            this.btnImportarExcel});
            this.toolImportar.Image = global::CursoRevitAPIAddin.Resource1.icons8_import_32;
            this.toolImportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolImportar.Name = "toolImportar";
            this.toolImportar.Size = new System.Drawing.Size(82, 22);
            this.toolImportar.Text = "Importar";
            // 
            // btnImportarCSV
            // 
            this.btnImportarCSV.Image = global::CursoRevitAPIAddin.Resource1.icons8_csv_32;
            this.btnImportarCSV.Name = "btnImportarCSV";
            this.btnImportarCSV.Size = new System.Drawing.Size(180, 22);
            this.btnImportarCSV.Text = "CSV";
            this.btnImportarCSV.Click += new System.EventHandler(this.btnImportarCSV_Click);
            // 
            // btnImportarExcel
            // 
            this.btnImportarExcel.Image = global::CursoRevitAPIAddin.Resource1.icons8_microsoft_excel_32;
            this.btnImportarExcel.Name = "btnImportarExcel";
            this.btnImportarExcel.Size = new System.Drawing.Size(180, 22);
            this.btnImportarExcel.Text = "Excel";
            this.btnImportarExcel.Click += new System.EventHandler(this.btnImportarExcel_Click);
            // 
            // toolExportar
            // 
            this.toolExportar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExportarCSV,
            this.btnExportarExcel});
            this.toolExportar.Image = global::CursoRevitAPIAddin.Resource1.icons8_export_32;
            this.toolExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExportar.Name = "toolExportar";
            this.toolExportar.Size = new System.Drawing.Size(80, 22);
            this.toolExportar.Text = "Exportar";
            // 
            // btnExportarCSV
            // 
            this.btnExportarCSV.Image = global::CursoRevitAPIAddin.Resource1.icons8_csv_32;
            this.btnExportarCSV.Name = "btnExportarCSV";
            this.btnExportarCSV.Size = new System.Drawing.Size(180, 22);
            this.btnExportarCSV.Text = "CSV";
            this.btnExportarCSV.Click += new System.EventHandler(this.btnExportarCSV_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Image = global::CursoRevitAPIAddin.Resource1.icons8_microsoft_excel_32;
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(180, 22);
            this.btnExportarExcel.Text = "Excel";
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccion de Tipo";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.picImagenDeTipo, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(565, 125);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbNiveles);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbTipos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbCategorias);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(143, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 119);
            this.panel1.TabIndex = 0;
            // 
            // cmbNiveles
            // 
            this.cmbNiveles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNiveles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNiveles.FormattingEnabled = true;
            this.cmbNiveles.Location = new System.Drawing.Point(70, 77);
            this.cmbNiveles.Name = "cmbNiveles";
            this.cmbNiveles.Size = new System.Drawing.Size(346, 21);
            this.cmbNiveles.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Niveles:";
            // 
            // cmbTipos
            // 
            this.cmbTipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipos.FormattingEnabled = true;
            this.cmbTipos.Location = new System.Drawing.Point(70, 50);
            this.cmbTipos.Name = "cmbTipos";
            this.cmbTipos.Size = new System.Drawing.Size(346, 21);
            this.cmbTipos.TabIndex = 3;
            this.cmbTipos.SelectedIndexChanged += new System.EventHandler(this.cmbTipos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipos:";
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(70, 23);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(346, 21);
            this.cmbCategorias.TabIndex = 1;
            this.cmbCategorias.SelectedIndexChanged += new System.EventHandler(this.cmbCategorias_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categorias:";
            // 
            // picImagenDeTipo
            // 
            this.picImagenDeTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picImagenDeTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImagenDeTipo.Location = new System.Drawing.Point(3, 3);
            this.picImagenDeTipo.Name = "picImagenDeTipo";
            this.picImagenDeTipo.Size = new System.Drawing.Size(134, 119);
            this.picImagenDeTipo.TabIndex = 1;
            this.picImagenDeTipo.TabStop = false;
            // 
            // btnColocarEjemplares
            // 
            this.btnColocarEjemplares.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnColocarEjemplares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColocarEjemplares.Location = new System.Drawing.Point(3, 398);
            this.btnColocarEjemplares.Name = "btnColocarEjemplares";
            this.btnColocarEjemplares.Size = new System.Drawing.Size(571, 39);
            this.btnColocarEjemplares.TabIndex = 2;
            this.btnColocarEjemplares.Text = "Colocar Ejemplares";
            this.btnColocarEjemplares.UseVisualStyleBackColor = true;
            this.btnColocarEjemplares.Click += new System.EventHandler(this.btnColocarEjemplares_Click);
            // 
            // formulario07FamilyInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 440);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "formulario07FamilyInstance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Colocar Ejemplares";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoordenadas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenDeTipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgvCoordenadas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFila;
        private System.Windows.Forms.Button btnEliminarFila;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbNiveles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picImagenDeTipo;
        private System.Windows.Forms.Button btnColocarEjemplares;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataGridViewTextBoxColumn z;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolImportar;
        private System.Windows.Forms.ToolStripMenuItem btnImportarCSV;
        private System.Windows.Forms.ToolStripMenuItem btnImportarExcel;
        private System.Windows.Forms.ToolStripDropDownButton toolExportar;
        private System.Windows.Forms.ToolStripMenuItem btnExportarCSV;
        private System.Windows.Forms.ToolStripMenuItem btnExportarExcel;
    }
}