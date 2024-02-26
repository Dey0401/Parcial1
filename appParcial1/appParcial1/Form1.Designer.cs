namespace appParcial1
{
    partial class frmParcial1
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
            this.cmbDato = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grMostar = new System.Windows.Forms.GroupBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.grMostar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDato
            // 
            this.cmbDato.FormattingEnabled = true;
            this.cmbDato.Location = new System.Drawing.Point(171, 43);
            this.cmbDato.Name = "cmbDato";
            this.cmbDato.Size = new System.Drawing.Size(121, 21);
            this.cmbDato.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Día : ";
            // 
            // grMostar
            // 
            this.grMostar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grMostar.Controls.Add(this.lbl);
            this.grMostar.Controls.Add(this.label2);
            this.grMostar.Location = new System.Drawing.Point(25, 208);
            this.grMostar.Name = "grMostar";
            this.grMostar.Size = new System.Drawing.Size(319, 204);
            this.grMostar.TabIndex = 2;
            this.grMostar.TabStop = false;
            this.grMostar.Text = "Mostrar";
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(163, 33);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(138, 16);
            this.lbl.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "               Sub Total:";
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTerminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.Location = new System.Drawing.Point(228, 438);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(116, 23);
            this.btnTerminar.TabIndex = 14;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(47, 179);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(117, 23);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(210, 179);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(116, 23);
            this.btnFacturar.TabIndex = 16;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            // 
            // frmParcial1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 473);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.grMostar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDato);
            this.Name = "frmParcial1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmParcial1_Load);
            this.grMostar.ResumeLayout(false);
            this.grMostar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grMostar;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnFacturar;
    }
}

