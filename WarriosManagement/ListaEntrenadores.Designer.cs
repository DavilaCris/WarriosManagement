namespace WarriosManagement
{
    partial class ListaEntrenadores
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvEntrenadores;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvEntrenadores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEntrenadores
            // 
            this.dgvEntrenadores.AllowUserToAddRows = false;
            this.dgvEntrenadores.AllowUserToDeleteRows = false;
            this.dgvEntrenadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrenadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEntrenadores.Location = new System.Drawing.Point(0, 0);
            this.dgvEntrenadores.Name = "dgvEntrenadores";
            this.dgvEntrenadores.ReadOnly = true;
            this.dgvEntrenadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntrenadores.Size = new System.Drawing.Size(800, 450);
            this.dgvEntrenadores.TabIndex = 0;
            this.dgvEntrenadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntrenadores_CellContentClick);
            // 
            // ListaEntrenadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEntrenadores);
            this.Name = "ListaEntrenadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Entrenadores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenadores)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
