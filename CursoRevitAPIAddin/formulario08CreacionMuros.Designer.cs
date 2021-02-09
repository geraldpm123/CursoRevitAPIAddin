namespace CursoRevitAPIAddin
{
    partial class formulario08CreacionMuros
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
            this.btnCrearMuro = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTiposMuros = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbNiveles = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCrearMuro, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(354, 274);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCrearMuro
            // 
            this.btnCrearMuro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCrearMuro.Location = new System.Drawing.Point(3, 232);
            this.btnCrearMuro.Name = "btnCrearMuro";
            this.btnCrearMuro.Size = new System.Drawing.Size(348, 39);
            this.btnCrearMuro.TabIndex = 0;
            this.btnCrearMuro.Text = "Crear Muro";
            this.btnCrearMuro.UseVisualStyleBackColor = true;
            this.btnCrearMuro.Click += new System.EventHandler(this.btnCrearMuro_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtY2);
            this.groupBox1.Controls.Add(this.txtX2);
            this.groupBox1.Controls.Add(this.txtY1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtX1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Posicion del Muro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbTiposMuros);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 49);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipos de Muro";
            // 
            // cmbTiposMuros
            // 
            this.cmbTiposMuros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTiposMuros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiposMuros.FormattingEnabled = true;
            this.cmbTiposMuros.Location = new System.Drawing.Point(9, 19);
            this.cmbTiposMuros.Name = "cmbTiposMuros";
            this.cmbTiposMuros.Size = new System.Drawing.Size(330, 21);
            this.cmbTiposMuros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Punto Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "X(m)";
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(81, 51);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(66, 20);
            this.txtX1.TabIndex = 2;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(153, 51);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(66, 20);
            this.txtY1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y(m)";
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(153, 77);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(66, 20);
            this.txtY2.TabIndex = 8;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(81, 77);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(66, 20);
            this.txtX2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Punto Final";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbNiveles);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 49);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nivel";
            // 
            // cmbNiveles
            // 
            this.cmbNiveles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNiveles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNiveles.FormattingEnabled = true;
            this.cmbNiveles.Location = new System.Drawing.Point(9, 19);
            this.cmbNiveles.Name = "cmbNiveles";
            this.cmbNiveles.Size = new System.Drawing.Size(330, 21);
            this.cmbNiveles.TabIndex = 1;
            // 
            // formulario08CreacionMuros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 274);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "formulario08CreacionMuros";
            this.Text = "Creacion de Muro Rectos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbTiposMuros;
        private System.Windows.Forms.Button btnCrearMuro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbNiveles;
    }
}