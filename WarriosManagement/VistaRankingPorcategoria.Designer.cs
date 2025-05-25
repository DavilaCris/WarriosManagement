namespace WarriosManagement
{
    partial class VistaRankingPorCategoria
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvRanking;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvRanking = new System.Windows.Forms.DataGridView();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRanking
            // 
            this.dgvRanking.AllowUserToAddRows = false;
            this.dgvRanking.AllowUserToDeleteRows = false;
            this.dgvRanking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRanking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRanking.Location = new System.Drawing.Point(3, 64);
            this.dgvRanking.MultiSelect = false;
            this.dgvRanking.Name = "dgvRanking";
            this.dgvRanking.ReadOnly = true;
            this.dgvRanking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRanking.Size = new System.Drawing.Size(1056, 357);
            this.dgvRanking.TabIndex = 0;
            // 
            // cbCategoria
            // 
            this.cbCategoria.Location = new System.Drawing.Point(840, 37);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(200, 21);
            this.cbCategoria.TabIndex = 21;
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(362, 37);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(183, 20);
            this.txtBuscarNombre.TabIndex = 22;
            this.txtBuscarNombre.Text = "Buscar atleta...";
            // 
            // VistaRankingPorCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 424);
            this.Controls.Add(this.txtBuscarNombre);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.dgvRanking);
            this.Name = "VistaRankingPorCategoria";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranking por Categoría";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cerrar);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRanking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txtBuscarNombre;
    }
}
