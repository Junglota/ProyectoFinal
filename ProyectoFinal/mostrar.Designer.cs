namespace ProyectoFinal
{
    partial class Mostrar
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
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSeleccionar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.Location = new System.Drawing.Point(63, 35);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(684, 349);
            this.dgvMostrar.TabIndex = 0;
            this.dgvMostrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_CellContentClick);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(147, 390);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(211, 48);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Agenda";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSeleccionar2
            // 
            this.btnSeleccionar2.Location = new System.Drawing.Point(453, 390);
            this.btnSeleccionar2.Name = "btnSeleccionar2";
            this.btnSeleccionar2.Size = new System.Drawing.Size(211, 48);
            this.btnSeleccionar2.TabIndex = 2;
            this.btnSeleccionar2.Text = "Seleccionar";
            this.btnSeleccionar2.UseVisualStyleBackColor = true;
            this.btnSeleccionar2.Click += new System.EventHandler(this.btnSeleccionar2_Click);
            // 
            // Mostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSeleccionar2);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgvMostrar);
            this.Name = "Mostrar";
            this.Text = "Mostrar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSeleccionar2;
    }
}