
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace WarriosManagement
{
    partial class SolicitudAlta
    {
        private MaterialTextBox txtNombre;
        private MaterialTextBox txtApellido;
        private MaterialTextBox txtNacionalidad;
        private MaterialTextBox txtCorreo;
        private MaterialTextBox txtContra1;
        private MaterialTextBox txtContra2;
        private MaterialTextBox txtPeso;
        private MaterialTextBox txtAltura;
        private MaterialTextBox txtDNI;
        private MaterialComboBox cbCinturon;
        private MaterialComboBox cbCategoria;
        private MaterialComboBox cbEntrenador;
        private MaterialComboBox cbTipoUsuario;
        private MaterialComboBox cbLateralidad;
        private DateTimePicker txtFechNac;
        private MaterialButton btnAlta;
        private PictureBox pictureBoxFoto;
        private MaterialLabel lblFoto;

        private void InitializeComponent()
        {
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtApellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNacionalidad = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCorreo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtContra1 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtContra2 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPeso = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAltura = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDNI = new MaterialSkin.Controls.MaterialTextBox();
            this.cbCinturon = new MaterialSkin.Controls.MaterialComboBox();
            this.cbCategoria = new MaterialSkin.Controls.MaterialComboBox();
            this.cbEntrenador = new MaterialSkin.Controls.MaterialComboBox();
            this.cbTipoUsuario = new MaterialSkin.Controls.MaterialComboBox();
            this.cbLateralidad = new MaterialSkin.Controls.MaterialComboBox();
            this.txtFechNac = new System.Windows.Forms.DateTimePicker();
            this.btnAlta = new MaterialSkin.Controls.MaterialButton();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.lblFoto = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
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
            this.txtNombre.Location = new System.Drawing.Point(30, 80);
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
            this.txtApellido.Location = new System.Drawing.Point(300, 80);
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
            this.txtNacionalidad.Location = new System.Drawing.Point(30, 150);
            this.txtNacionalidad.MaxLength = 50;
            this.txtNacionalidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNacionalidad.Multiline = false;
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(200, 50);
            this.txtNacionalidad.TabIndex = 2;
            this.txtNacionalidad.Text = "";
            this.txtNacionalidad.TrailingIcon = null;
            // 
            // txtCorreo
            // 
            this.txtCorreo.AnimateReadOnly = false;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCorreo.Hint = "Correo electrónico";
            this.txtCorreo.LeadingIcon = null;
            this.txtCorreo.Location = new System.Drawing.Point(30, 290);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(300, 50);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.Text = "";
            this.txtCorreo.TrailingIcon = null;
            // 
            // txtContra1
            // 
            this.txtContra1.AnimateReadOnly = false;
            this.txtContra1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContra1.Depth = 0;
            this.txtContra1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContra1.Hint = "Contraseña";
            this.txtContra1.LeadingIcon = null;
            this.txtContra1.Location = new System.Drawing.Point(350, 290);
            this.txtContra1.MaxLength = 50;
            this.txtContra1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContra1.Multiline = false;
            this.txtContra1.Name = "txtContra1";
            this.txtContra1.Password = true;
            this.txtContra1.Size = new System.Drawing.Size(200, 50);
            this.txtContra1.TabIndex = 4;
            this.txtContra1.Text = "";
            this.txtContra1.TrailingIcon = null;
            // 
            // txtContra2
            // 
            this.txtContra2.AnimateReadOnly = false;
            this.txtContra2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContra2.Depth = 0;
            this.txtContra2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContra2.Hint = "Repetir contraseña";
            this.txtContra2.LeadingIcon = null;
            this.txtContra2.Location = new System.Drawing.Point(570, 290);
            this.txtContra2.MaxLength = 50;
            this.txtContra2.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContra2.Multiline = false;
            this.txtContra2.Name = "txtContra2";
            this.txtContra2.Password = true;
            this.txtContra2.Size = new System.Drawing.Size(200, 50);
            this.txtContra2.TabIndex = 5;
            this.txtContra2.Text = "";
            this.txtContra2.TrailingIcon = null;
            // 
            // txtPeso
            // 
            this.txtPeso.AnimateReadOnly = false;
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeso.Depth = 0;
            this.txtPeso.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPeso.Hint = "Peso (kg)";
            this.txtPeso.LeadingIcon = null;
            this.txtPeso.Location = new System.Drawing.Point(470, 220);
            this.txtPeso.MaxLength = 50;
            this.txtPeso.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPeso.Multiline = false;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 50);
            this.txtPeso.TabIndex = 6;
            this.txtPeso.Text = "";
            this.txtPeso.TrailingIcon = null;
            // 
            // txtAltura
            // 
            this.txtAltura.AnimateReadOnly = false;
            this.txtAltura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAltura.Depth = 0;
            this.txtAltura.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAltura.Hint = "Altura (cm)";
            this.txtAltura.LeadingIcon = null;
            this.txtAltura.Location = new System.Drawing.Point(580, 220);
            this.txtAltura.MaxLength = 50;
            this.txtAltura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAltura.Multiline = false;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 50);
            this.txtAltura.TabIndex = 7;
            this.txtAltura.Text = "";
            this.txtAltura.TrailingIcon = null;
            // 
            // txtDNI
            // 
            this.txtDNI.AnimateReadOnly = false;
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDNI.Depth = 0;
            this.txtDNI.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDNI.Hint = "DNI";
            this.txtDNI.LeadingIcon = null;
            this.txtDNI.Location = new System.Drawing.Point(570, 80);
            this.txtDNI.MaxLength = 50;
            this.txtDNI.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDNI.Multiline = false;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(150, 50);
            this.txtDNI.TabIndex = 8;
            this.txtDNI.Text = "";
            this.txtDNI.TrailingIcon = null;
            // 
            // cbCinturon
            // 
            this.cbCinturon.AutoResize = false;
            this.cbCinturon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbCinturon.Depth = 0;
            this.cbCinturon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbCinturon.DropDownHeight = 174;
            this.cbCinturon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCinturon.DropDownWidth = 121;
            this.cbCinturon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbCinturon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbCinturon.IntegralHeight = false;
            this.cbCinturon.ItemHeight = 43;
            this.cbCinturon.Items.AddRange(new object[] {
            "Elige un cinturón",
            "Blanco",
            "Naranja",
            "Verde",
            "Azul",
            "Morado",
            "Amarillo",
            "Marrón ",
            "Negro"});
            this.cbCinturon.Location = new System.Drawing.Point(250, 160);
            this.cbCinturon.MaxDropDownItems = 4;
            this.cbCinturon.MouseState = MaterialSkin.MouseState.OUT;
            this.cbCinturon.Name = "cbCinturon";
            this.cbCinturon.Size = new System.Drawing.Size(200, 49);
            this.cbCinturon.StartIndex = 0;
            this.cbCinturon.TabIndex = 9;
            // 
            // cbCategoria
            // 
            this.cbCategoria.AutoResize = false;
            this.cbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbCategoria.Depth = 0;
            this.cbCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbCategoria.DropDownHeight = 174;
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.DropDownWidth = 121;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbCategoria.IntegralHeight = false;
            this.cbCategoria.ItemHeight = 43;
            this.cbCategoria.Location = new System.Drawing.Point(470, 160);
            this.cbCategoria.MaxDropDownItems = 4;
            this.cbCategoria.MouseState = MaterialSkin.MouseState.OUT;
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(200, 49);
            this.cbCategoria.StartIndex = 0;
            this.cbCategoria.TabIndex = 10;
            // 
            // cbEntrenador
            // 
            this.cbEntrenador.AutoResize = false;
            this.cbEntrenador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbEntrenador.Depth = 0;
            this.cbEntrenador.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbEntrenador.DropDownHeight = 174;
            this.cbEntrenador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEntrenador.DropDownWidth = 121;
            this.cbEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbEntrenador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbEntrenador.IntegralHeight = false;
            this.cbEntrenador.ItemHeight = 43;
            this.cbEntrenador.Location = new System.Drawing.Point(690, 160);
            this.cbEntrenador.MaxDropDownItems = 4;
            this.cbEntrenador.MouseState = MaterialSkin.MouseState.OUT;
            this.cbEntrenador.Name = "cbEntrenador";
            this.cbEntrenador.Size = new System.Drawing.Size(200, 49);
            this.cbEntrenador.StartIndex = 0;
            this.cbEntrenador.TabIndex = 11;
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.AutoResize = false;
            this.cbTipoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbTipoUsuario.Depth = 0;
            this.cbTipoUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTipoUsuario.DropDownHeight = 174;
            this.cbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoUsuario.DropDownWidth = 121;
            this.cbTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbTipoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTipoUsuario.IntegralHeight = false;
            this.cbTipoUsuario.ItemHeight = 43;
            this.cbTipoUsuario.Items.AddRange(new object[] {
            "ATLETA",
            "STAFF",
            "ENTRENADOR",
            "ARBITRO",
            "ADMINISTRADOR"});
            this.cbTipoUsuario.Location = new System.Drawing.Point(30, 220);
            this.cbTipoUsuario.MaxDropDownItems = 4;
            this.cbTipoUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(200, 49);
            this.cbTipoUsuario.StartIndex = 0;
            this.cbTipoUsuario.TabIndex = 12;
            // 
            // cbLateralidad
            // 
            this.cbLateralidad.AutoResize = false;
            this.cbLateralidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbLateralidad.Depth = 0;
            this.cbLateralidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbLateralidad.DropDownHeight = 174;
            this.cbLateralidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLateralidad.DropDownWidth = 121;
            this.cbLateralidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbLateralidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbLateralidad.IntegralHeight = false;
            this.cbLateralidad.ItemHeight = 43;
            this.cbLateralidad.Items.AddRange(new object[] {
            "Lateralidad",
                "DIESTRO",
            "IZQUIERDO"});
            this.cbLateralidad.Location = new System.Drawing.Point(250, 220);
            this.cbLateralidad.MaxDropDownItems = 4;
            this.cbLateralidad.MouseState = MaterialSkin.MouseState.OUT;
            this.cbLateralidad.Name = "cbLateralidad";
            this.cbLateralidad.Size = new System.Drawing.Size(200, 49);
            this.cbLateralidad.StartIndex = 0;
            this.cbLateralidad.TabIndex = 13;
            // 
            // txtFechNac
            // 
            this.txtFechNac.Location = new System.Drawing.Point(750, 92);
            this.txtFechNac.Name = "txtFechNac";
            this.txtFechNac.Size = new System.Drawing.Size(200, 20);
            this.txtFechNac.TabIndex = 14;
            // 
            // btnAlta
            // 
            this.btnAlta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAlta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAlta.Depth = 0;
            this.btnAlta.HighEmphasis = true;
            this.btnAlta.Icon = null;
            this.btnAlta.Location = new System.Drawing.Point(400, 370);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAlta.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAlta.Size = new System.Drawing.Size(134, 36);
            this.btnAlta.TabIndex = 15;
            this.btnAlta.Text = "Solicitar Alta";
            this.btnAlta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAlta.UseAccentColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_click);
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxFoto.Location = new System.Drawing.Point(800, 260);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(150, 100);
            this.pictureBoxFoto.TabIndex = 16;
            this.pictureBoxFoto.TabStop = false;
            this.pictureBoxFoto.Click += new System.EventHandler(this.pictureBoxFoto_Click);
            // 
            // lblFoto
            // 
            this.lblFoto.Depth = 0;
            this.lblFoto.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFoto.Location = new System.Drawing.Point(800, 360);
            this.lblFoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(200, 20);
            this.lblFoto.TabIndex = 17;
            this.lblFoto.Text = "Haz clic para cargar foto";
            // 
            // SolicitudAlta
            // 
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtContra1);
            this.Controls.Add(this.txtContra2);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.cbCinturon);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbEntrenador);
            this.Controls.Add(this.cbTipoUsuario);
            this.Controls.Add(this.cbLateralidad);
            this.Controls.Add(this.txtFechNac);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.lblFoto);
            this.Name = "SolicitudAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud de Alta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
