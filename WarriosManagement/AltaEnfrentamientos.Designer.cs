using System.Windows.Forms;

namespace WarriosManagement
{
    partial class AltaEnfrentamientos
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtStaff;

        private System.Windows.Forms.ComboBox cbAtletaAka;
        private System.Windows.Forms.ComboBox cbAtletaAo;
        private System.Windows.Forms.ComboBox cbArbitroCentral;
        private System.Windows.Forms.ComboBox cbArbitro1;
        private System.Windows.Forms.ComboBox cbArbitro2;
        private System.Windows.Forms.ComboBox cbArbitro3;
        private System.Windows.Forms.ComboBox cbArbitro4;
        private System.Windows.Forms.ComboBox cbAccion;
        private System.Windows.Forms.ComboBox cbExtremidad;
        private System.Windows.Forms.ComboBox cbLateralidad;
        private System.Windows.Forms.ComboBox cbBanderas;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbAtletaPuntos;

        private System.Windows.Forms.TextBox txtTorneo;
        private System.Windows.Forms.TextBox txtGanador;

        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblAtletas;
        private System.Windows.Forms.Label lblArbitros;
        private System.Windows.Forms.Label lblGanador;

        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton btnTerminar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.cbAtletaAka = new System.Windows.Forms.ComboBox();
            this.cbAtletaAo = new System.Windows.Forms.ComboBox();
            this.cbArbitroCentral = new System.Windows.Forms.ComboBox();
            this.cbArbitro1 = new System.Windows.Forms.ComboBox();
            this.cbArbitro2 = new System.Windows.Forms.ComboBox();
            this.cbArbitro3 = new System.Windows.Forms.ComboBox();
            this.cbArbitro4 = new System.Windows.Forms.ComboBox();
            this.cbAccion = new System.Windows.Forms.ComboBox();
            this.cbExtremidad = new System.Windows.Forms.ComboBox();
            this.cbLateralidad = new System.Windows.Forms.ComboBox();
            this.cbBanderas = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbAtletaPuntos = new System.Windows.Forms.ComboBox();
            this.txtTorneo = new System.Windows.Forms.TextBox();
            this.txtGanador = new System.Windows.Forms.TextBox();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblAtletas = new System.Windows.Forms.Label();
            this.lblArbitros = new System.Windows.Forms.Label();
            this.lblGanador = new System.Windows.Forms.Label();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.btnTerminar = new MaterialSkin.Controls.MaterialButton();
            this.txtMarcador = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(983, 36);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 15);
            this.lblFecha.TabIndex = 0;
            // 
            // txtStaff
            // 
            this.txtStaff.Location = new System.Drawing.Point(831, 33);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.ReadOnly = true;
            this.txtStaff.Size = new System.Drawing.Size(120, 23);
            this.txtStaff.TabIndex = 1;
            // 
            // cbAtletaAka
            // 
            this.cbAtletaAka.Location = new System.Drawing.Point(42, 116);
            this.cbAtletaAka.Name = "cbAtletaAka";
            this.cbAtletaAka.Size = new System.Drawing.Size(200, 23);
            this.cbAtletaAka.TabIndex = 2;
            // 
            // cbAtletaAo
            // 
            this.cbAtletaAo.Location = new System.Drawing.Point(42, 156);
            this.cbAtletaAo.Name = "cbAtletaAo";
            this.cbAtletaAo.Size = new System.Drawing.Size(200, 23);
            this.cbAtletaAo.TabIndex = 3;
            // 
            // cbArbitroCentral
            // 
            this.cbArbitroCentral.Location = new System.Drawing.Point(309, 117);
            this.cbArbitroCentral.Name = "cbArbitroCentral";
            this.cbArbitroCentral.Size = new System.Drawing.Size(200, 23);
            this.cbArbitroCentral.TabIndex = 4;
            // 
            // cbArbitro1
            // 
            this.cbArbitro1.Location = new System.Drawing.Point(309, 157);
            this.cbArbitro1.Name = "cbArbitro1";
            this.cbArbitro1.Size = new System.Drawing.Size(200, 23);
            this.cbArbitro1.TabIndex = 5;
            // 
            // cbArbitro2
            // 
            this.cbArbitro2.Location = new System.Drawing.Point(309, 197);
            this.cbArbitro2.Name = "cbArbitro2";
            this.cbArbitro2.Size = new System.Drawing.Size(200, 23);
            this.cbArbitro2.TabIndex = 6;
            // 
            // cbArbitro3
            // 
            this.cbArbitro3.Location = new System.Drawing.Point(309, 237);
            this.cbArbitro3.Name = "cbArbitro3";
            this.cbArbitro3.Size = new System.Drawing.Size(200, 23);
            this.cbArbitro3.TabIndex = 7;
            // 
            // cbArbitro4
            // 
            this.cbArbitro4.Location = new System.Drawing.Point(309, 277);
            this.cbArbitro4.Name = "cbArbitro4";
            this.cbArbitro4.Size = new System.Drawing.Size(200, 23);
            this.cbArbitro4.TabIndex = 8;
            // 
            // cbAccion
            // 
            this.cbAccion.Location = new System.Drawing.Point(600, 116);
            this.cbAccion.Name = "cbAccion";
            this.cbAccion.Size = new System.Drawing.Size(120, 23);
            this.cbAccion.TabIndex = 9;
            // 
            // cbExtremidad
            // 
            this.cbExtremidad.Location = new System.Drawing.Point(730, 116);
            this.cbExtremidad.Name = "cbExtremidad";
            this.cbExtremidad.Size = new System.Drawing.Size(120, 23);
            this.cbExtremidad.TabIndex = 10;
            // 
            // cbLateralidad
            // 
            this.cbLateralidad.Location = new System.Drawing.Point(600, 156);
            this.cbLateralidad.Name = "cbLateralidad";
            this.cbLateralidad.Size = new System.Drawing.Size(120, 23);
            this.cbLateralidad.TabIndex = 11;
            // 
            // cbBanderas
            // 
            this.cbBanderas.Location = new System.Drawing.Point(730, 156);
            this.cbBanderas.Name = "cbBanderas";
            this.cbBanderas.Size = new System.Drawing.Size(120, 23);
            this.cbBanderas.TabIndex = 12;
            // 
            // cbCategoria
            // 
            this.cbCategoria.Location = new System.Drawing.Point(309, 33);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(200, 23);
            this.cbCategoria.TabIndex = 13;
            // 
            // cbAtletaPuntos
            // 
            this.cbAtletaPuntos.Location = new System.Drawing.Point(635, 224);
            this.cbAtletaPuntos.Name = "cbAtletaPuntos";
            this.cbAtletaPuntos.Size = new System.Drawing.Size(200, 23);
            this.cbAtletaPuntos.TabIndex = 14;
            // 
            // txtTorneo
            // 
            this.txtTorneo.HideSelection = false;
            this.txtTorneo.Location = new System.Drawing.Point(702, 33);
            this.txtTorneo.Name = "txtTorneo";
            this.txtTorneo.ReadOnly = true;
            this.txtTorneo.Size = new System.Drawing.Size(120, 23);
            this.txtTorneo.TabIndex = 15;
            // 
            // txtGanador
            // 
            this.txtGanador.Location = new System.Drawing.Point(1009, 145);
            this.txtGanador.Name = "txtGanador";
            this.txtGanador.ReadOnly = true;
            this.txtGanador.Size = new System.Drawing.Size(120, 23);
            this.txtGanador.TabIndex = 16;
            // 
            // lblPuntos
            // 
            this.lblPuntos.Location = new System.Drawing.Point(699, 83);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(100, 23);
            this.lblPuntos.TabIndex = 17;
            this.lblPuntos.Text = "Puntos";
            // 
            // lblAtletas
            // 
            this.lblAtletas.Location = new System.Drawing.Point(114, 83);
            this.lblAtletas.Name = "lblAtletas";
            this.lblAtletas.Size = new System.Drawing.Size(100, 23);
            this.lblAtletas.TabIndex = 18;
            this.lblAtletas.Text = "Atletas";
            // 
            // lblArbitros
            // 
            this.lblArbitros.Location = new System.Drawing.Point(396, 77);
            this.lblArbitros.Name = "lblArbitros";
            this.lblArbitros.Size = new System.Drawing.Size(100, 23);
            this.lblArbitros.TabIndex = 19;
            this.lblArbitros.Text = "Árbitros";
            // 
            // lblGanador
            // 
            this.lblGanador.Location = new System.Drawing.Point(1018, 83);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(100, 23);
            this.lblGanador.TabIndex = 20;
            this.lblGanador.Text = "Ganador";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(241, 350);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardar.Size = new System.Drawing.Size(221, 36);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar Enfrentamiento";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(644, 350);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(149, 36);
            this.materialButton1.TabIndex = 22;
            this.materialButton1.Text = "Guardar Puntos";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTerminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTerminar.Depth = 0;
            this.btnTerminar.HighEmphasis = true;
            this.btnTerminar.Icon = null;
            this.btnTerminar.Location = new System.Drawing.Point(1149, 341);
            this.btnTerminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTerminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTerminar.Size = new System.Drawing.Size(94, 36);
            this.btnTerminar.TabIndex = 23;
            this.btnTerminar.Text = "terminar";
            this.btnTerminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTerminar.UseAccentColor = false;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // txtMarcador
            // 
            this.txtMarcador.Enabled = false;
            this.txtMarcador.Location = new System.Drawing.Point(886, 116);
            this.txtMarcador.Name = "txtMarcador";
            this.txtMarcador.ReadOnly = true;
            this.txtMarcador.Size = new System.Drawing.Size(357, 23);
            this.txtMarcador.TabIndex = 24;
            // 
            // AltaEnfrentamientos
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1273, 420);
            this.Controls.Add(this.txtMarcador);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtStaff);
            this.Controls.Add(this.cbAtletaAka);
            this.Controls.Add(this.cbAtletaAo);
            this.Controls.Add(this.cbArbitroCentral);
            this.Controls.Add(this.cbArbitro1);
            this.Controls.Add(this.cbArbitro2);
            this.Controls.Add(this.cbArbitro3);
            this.Controls.Add(this.cbArbitro4);
            this.Controls.Add(this.cbAccion);
            this.Controls.Add(this.cbExtremidad);
            this.Controls.Add(this.cbLateralidad);
            this.Controls.Add(this.cbBanderas);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbAtletaPuntos);
            this.Controls.Add(this.txtTorneo);
            this.Controls.Add(this.txtGanador);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.lblAtletas);
            this.Controls.Add(this.lblArbitros);
            this.Controls.Add(this.lblGanador);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.btnTerminar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "AltaEnfrentamientos";
            this.Sizable = false;
            this.Text = "Alta Enfrentamiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox txtMarcador;
    }
}
