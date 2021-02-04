namespace CursoRevitAPIAddin
{
    partial class formulario06ModificacionesBasicas
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
            this.btnMover = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnRotar = new System.Windows.Forms.Button();
            this.btnReflejar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMover
            // 
            this.btnMover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMover.Location = new System.Drawing.Point(92, 29);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(124, 45);
            this.btnMover.TabIndex = 0;
            this.btnMover.Text = "MOVER";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiar.Location = new System.Drawing.Point(92, 80);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(124, 45);
            this.btnCopiar.TabIndex = 1;
            this.btnCopiar.Text = "COPIAR";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // btnRotar
            // 
            this.btnRotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotar.Location = new System.Drawing.Point(92, 131);
            this.btnRotar.Name = "btnRotar";
            this.btnRotar.Size = new System.Drawing.Size(124, 45);
            this.btnRotar.TabIndex = 2;
            this.btnRotar.Text = "ROTAR";
            this.btnRotar.UseVisualStyleBackColor = true;
            this.btnRotar.Click += new System.EventHandler(this.btnRotar_Click);
            // 
            // btnReflejar
            // 
            this.btnReflejar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReflejar.Location = new System.Drawing.Point(92, 182);
            this.btnReflejar.Name = "btnReflejar";
            this.btnReflejar.Size = new System.Drawing.Size(124, 45);
            this.btnReflejar.TabIndex = 3;
            this.btnReflejar.Text = "REFLEJAR";
            this.btnReflejar.UseVisualStyleBackColor = true;
            this.btnReflejar.Click += new System.EventHandler(this.btnReflejar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(92, 233);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(124, 45);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // formulario06ModificacionesBasicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 317);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnReflejar);
            this.Controls.Add(this.btnRotar);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnMover);
            this.Name = "formulario06ModificacionesBasicas";
            this.Text = "formulario06ModificacionesBasicas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Button btnRotar;
        private System.Windows.Forms.Button btnReflejar;
        private System.Windows.Forms.Button btnEliminar;
    }
}