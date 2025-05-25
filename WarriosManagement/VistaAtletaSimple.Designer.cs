using System.Windows.Forms;

namespace WarriosManagement
{
    partial class VistaAtletaSimple
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
            this.lblPosicionRank = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblLateralidad = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.gridUltimasPeleas = new System.Windows.Forms.DataGridView();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUltimasPeleas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(78, 280);
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
            this.lblNombre.Location = new System.Drawing.Point(285, 85);
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
            this.lblApellido.Location = new System.Drawing.Point(285, 125);
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
            this.lblNacionalidad.Location = new System.Drawing.Point(285, 167);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(90, 19);
            this.lblNacionalidad.TabIndex = 12;
            this.lblNacionalidad.Text = "Nacionalidad:";
            // 
            // lblPosicionRank
            // 
            this.lblPosicionRank.AutoSize = true;
            this.lblPosicionRank.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPosicionRank.ForeColor = System.Drawing.Color.Black;
            this.lblPosicionRank.Location = new System.Drawing.Point(682, 33);
            this.lblPosicionRank.Name = "lblPosicionRank";
            this.lblPosicionRank.Size = new System.Drawing.Size(114, 19);
            this.lblPosicionRank.TabIndex = 13;
            this.lblPosicionRank.Text = "Posición Ranking:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPeso.ForeColor = System.Drawing.Color.Black;
            this.lblPeso.Location = new System.Drawing.Point(480, 85);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(40, 19);
            this.lblPeso.TabIndex = 14;
            this.lblPeso.Text = "Peso:";
            // 
            // lblLateralidad
            // 
            this.lblLateralidad.AutoSize = true;
            this.lblLateralidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLateralidad.ForeColor = System.Drawing.Color.Black;
            this.lblLateralidad.Location = new System.Drawing.Point(480, 125);
            this.lblLateralidad.Name = "lblLateralidad";
            this.lblLateralidad.Size = new System.Drawing.Size(79, 19);
            this.lblLateralidad.TabIndex = 15;
            this.lblLateralidad.Text = "Lateralidad:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAltura.ForeColor = System.Drawing.Color.Black;
            this.lblAltura.Location = new System.Drawing.Point(480, 176);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(49, 19);
            this.lblAltura.TabIndex = 16;
            this.lblAltura.Text = "Altura:";
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFoto.Location = new System.Drawing.Point(676, 85);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 17;
            this.pictureBoxFoto.TabStop = false;
            // 
            // gridUltimasPeleas
            // 
            this.gridUltimasPeleas.AllowUserToAddRows = false;
            this.gridUltimasPeleas.AllowUserToDeleteRows = false;
            this.gridUltimasPeleas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUltimasPeleas.BackgroundColor = System.Drawing.Color.White;
            this.gridUltimasPeleas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUltimasPeleas.Location = new System.Drawing.Point(20, 313);
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
            this.cbCategoria.TabIndex = 21;
            // 
            // VistaAtletaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 554);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblPosicionRank);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblLateralidad);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.gridUltimasPeleas);
            this.Name = "VistaAtletaSimple";
            this.Sizable = false;
            this.Text = "Atleta ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUltimasPeleas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblNacionalidad;
        private Label lblPosicionRank;
        private Label lblPeso;
        private Label lblLateralidad;
        private Label lblAltura;
        private PictureBox pictureBoxFoto;
        private DataGridView gridUltimasPeleas;
        private ComboBox cbCategoria;
    }
}