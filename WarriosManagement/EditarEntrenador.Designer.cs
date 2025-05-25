using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace WarriosManagement
{
    partial class EditarEntrenador
    {
        private System.ComponentModel.IContainer components = null;

        private MaterialTextBox txtNombre;
        private MaterialTextBox txtApellido;
        private MaterialTextBox txtNacionalidad;
        private MaterialTextBox txtCinturon;
        private MaterialTextBox txtCiudad;
        private MaterialTextBox txtCalle;
        private MaterialTextBox txtPostal;
        private MaterialTextBox txtEscuela;
        private DateTimePicker dtpFechaNacimiento;
        private MaterialButton btnGuardar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtApellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNacionalidad = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCinturon = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCiudad = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCalle = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPostal = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEscuela = new MaterialSkin.Controls.MaterialTextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(32, 67);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 50);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            // 
            // txtApellido
            // 
            this.txtApellido.AnimateReadOnly = false;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Depth = 0;
            this.txtApellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellido.Hint = "Apellido";
            this.txtApellido.LeadingIcon = null;
            this.txtApellido.Location = new System.Drawing.Point(302, 67);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(250, 50);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.Text = "";
            this.txtApellido.TrailingIcon = null;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.AnimateReadOnly = false;
            this.txtNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNacionalidad.Depth = 0;
            this.txtNacionalidad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNacionalidad.Hint = "Nacionalidad";
            this.txtNacionalidad.LeadingIcon = null;
            this.txtNacionalidad.Location = new System.Drawing.Point(32, 127);
            this.txtNacionalidad.MaxLength = 50;
            this.txtNacionalidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNacionalidad.Multiline = false;
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(250, 50);
            this.txtNacionalidad.TabIndex = 2;
            this.txtNacionalidad.Text = "";
            this.txtNacionalidad.TrailingIcon = null;
            // 
            // txtCinturon
            // 
            this.txtCinturon.AnimateReadOnly = false;
            this.txtCinturon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCinturon.Depth = 0;
            this.txtCinturon.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCinturon.Hint = "Cinturón";
            this.txtCinturon.LeadingIcon = null;
            this.txtCinturon.Location = new System.Drawing.Point(302, 127);
            this.txtCinturon.MaxLength = 50;
            this.txtCinturon.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCinturon.Multiline = false;
            this.txtCinturon.Name = "txtCinturon";
            this.txtCinturon.Size = new System.Drawing.Size(250, 50);
            this.txtCinturon.TabIndex = 3;
            this.txtCinturon.Text = "";
            this.txtCinturon.TrailingIcon = null;
            // 
            // txtCiudad
            // 
            this.txtCiudad.AnimateReadOnly = false;
            this.txtCiudad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCiudad.Depth = 0;
            this.txtCiudad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCiudad.Hint = "Ciudad";
            this.txtCiudad.LeadingIcon = null;
            this.txtCiudad.Location = new System.Drawing.Point(32, 187);
            this.txtCiudad.MaxLength = 50;
            this.txtCiudad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCiudad.Multiline = false;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(250, 50);
            this.txtCiudad.TabIndex = 4;
            this.txtCiudad.Text = "";
            this.txtCiudad.TrailingIcon = null;
            // 
            // txtCalle
            // 
            this.txtCalle.AnimateReadOnly = false;
            this.txtCalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCalle.Depth = 0;
            this.txtCalle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCalle.Hint = "Número de Calle";
            this.txtCalle.LeadingIcon = null;
            this.txtCalle.Location = new System.Drawing.Point(302, 187);
            this.txtCalle.MaxLength = 50;
            this.txtCalle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCalle.Multiline = false;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(250, 50);
            this.txtCalle.TabIndex = 5;
            this.txtCalle.Text = "";
            this.txtCalle.TrailingIcon = null;
            // 
            // txtPostal
            // 
            this.txtPostal.AnimateReadOnly = false;
            this.txtPostal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPostal.Depth = 0;
            this.txtPostal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPostal.Hint = "Código Postal";
            this.txtPostal.LeadingIcon = null;
            this.txtPostal.Location = new System.Drawing.Point(32, 247);
            this.txtPostal.MaxLength = 50;
            this.txtPostal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPostal.Multiline = false;
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(250, 50);
            this.txtPostal.TabIndex = 6;
            this.txtPostal.Text = "";
            this.txtPostal.TrailingIcon = null;
            // 
            // txtEscuela
            // 
            this.txtEscuela.AnimateReadOnly = false;
            this.txtEscuela.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEscuela.Depth = 0;
            this.txtEscuela.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEscuela.Hint = "Escuela";
            this.txtEscuela.LeadingIcon = null;
            this.txtEscuela.Location = new System.Drawing.Point(302, 247);
            this.txtEscuela.MaxLength = 50;
            this.txtEscuela.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEscuela.Multiline = false;
            this.txtEscuela.Name = "txtEscuela";
            this.txtEscuela.Size = new System.Drawing.Size(250, 50);
            this.txtEscuela.TabIndex = 7;
            this.txtEscuela.Text = "";
            this.txtEscuela.TrailingIcon = null;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(32, 307);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(250, 20);
            this.dtpFechaNacimiento.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(222, 357);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardar.Size = new System.Drawing.Size(88, 36);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // EditarEntrenador
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtCinturon);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtPostal);
            this.Controls.Add(this.txtEscuela);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.btnGuardar);
            this.Name = "EditarEntrenador";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Entrenador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
