using System.Windows.Forms;

namespace WarriosManagement
{
    partial class VistaEntrenador
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.gridUltimasPeleas = new System.Windows.Forms.DataGridView();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbAlumnos = new System.Windows.Forms.ComboBox();
            this.lblCinturon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridUltimasPeleas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(603, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Historial de Enfrentamientos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(16, 187);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 19);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblApellido.ForeColor = System.Drawing.Color.Black;
            this.lblApellido.Location = new System.Drawing.Point(16, 227);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(61, 19);
            this.lblApellido.TabIndex = 11;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNacionalidad.ForeColor = System.Drawing.Color.Black;
            this.lblNacionalidad.Location = new System.Drawing.Point(16, 267);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(90, 19);
            this.lblNacionalidad.TabIndex = 12;
            this.lblNacionalidad.Text = "Nacionalidad:";
            // 
            // gridUltimasPeleas
            // 
            this.gridUltimasPeleas.AllowUserToAddRows = false;
            this.gridUltimasPeleas.AllowUserToDeleteRows = false;
            this.gridUltimasPeleas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUltimasPeleas.BackgroundColor = System.Drawing.Color.White;
            this.gridUltimasPeleas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUltimasPeleas.Location = new System.Drawing.Point(545, 148);
            this.gridUltimasPeleas.MultiSelect = false;
            this.gridUltimasPeleas.Name = "gridUltimasPeleas";
            this.gridUltimasPeleas.ReadOnly = true;
            this.gridUltimasPeleas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUltimasPeleas.Size = new System.Drawing.Size(300, 200);
            this.gridUltimasPeleas.TabIndex = 18;
            // 
            // cbCategoria
            // 
            this.cbCategoria.Location = new System.Drawing.Point(20, 67);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(200, 21);
            this.cbCategoria.TabIndex = 20;
            // 
            // cbAlumnos
            // 
            this.cbAlumnos.Location = new System.Drawing.Point(280, 67);
            this.cbAlumnos.Name = "cbAlumnos";
            this.cbAlumnos.Size = new System.Drawing.Size(200, 21);
            this.cbAlumnos.TabIndex = 21;
            // 
            // lblCinturon
            // 
            this.lblCinturon.AutoSize = true;
            this.lblCinturon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCinturon.ForeColor = System.Drawing.Color.Black;
            this.lblCinturon.Location = new System.Drawing.Point(16, 306);
            this.lblCinturon.Name = "lblCinturon";
            this.lblCinturon.Size = new System.Drawing.Size(66, 19);
            this.lblCinturon.TabIndex = 22;
            this.lblCinturon.Text = "Cinturón:";
            // 
            // VistaEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 554);
            this.Controls.Add(this.lblCinturon);
            this.Controls.Add(this.cbAlumnos);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.gridUltimasPeleas);
            this.Name = "VistaEntrenador";
            this.Sizable = false;
            this.Text = "Vista Entrenador";
            ((System.ComponentModel.ISupportInitialize)(this.gridUltimasPeleas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblNacionalidad;
        private DataGridView gridUltimasPeleas;
        private ComboBox cbCategoria;
        private ComboBox cbAlumnos;
        private Label lblCinturon;
    }
}
