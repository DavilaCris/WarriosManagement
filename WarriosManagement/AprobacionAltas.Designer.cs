using System.Windows.Forms;

namespace WarriosManagement
{
    partial class AprobacionAltas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView gridSolicitudes;
        private MaterialSkin.Controls.MaterialButton btnAprobar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.gridSolicitudes = new System.Windows.Forms.DataGridView();
            this.btnAprobar = new MaterialSkin.Controls.MaterialButton();
            this.campeonatosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarCampeonatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSolicitudes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridSolicitudes
            // 
            this.gridSolicitudes.AllowUserToAddRows = false;
            this.gridSolicitudes.AllowUserToDeleteRows = false;
            this.gridSolicitudes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSolicitudes.Location = new System.Drawing.Point(20, 114);
            this.gridSolicitudes.Name = "gridSolicitudes";
            this.gridSolicitudes.ReadOnly = true;
            this.gridSolicitudes.Size = new System.Drawing.Size(1356, 276);
            this.gridSolicitudes.TabIndex = 2;
            // 
            // btnAprobar
            // 
            this.btnAprobar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAprobar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAprobar.Depth = 0;
            this.btnAprobar.HighEmphasis = true;
            this.btnAprobar.Icon = null;
            this.btnAprobar.Location = new System.Drawing.Point(20, 399);
            this.btnAprobar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAprobar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAprobar.Size = new System.Drawing.Size(88, 36);
            this.btnAprobar.TabIndex = 3;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAprobar.UseAccentColor = false;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // campeonatosMenuItem
            // 
            this.campeonatosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarCampeonatosToolStripMenuItem});
            this.campeonatosMenuItem.Name = "campeonatosMenuItem";
            this.campeonatosMenuItem.Size = new System.Drawing.Size(93, 20);
            this.campeonatosMenuItem.Text = "Campeonatos";
            this.campeonatosMenuItem.Click += new System.EventHandler(this.campeonatosMenuItem_Click);
            // 
            // administrarCampeonatosToolStripMenuItem
            // 
            this.administrarCampeonatosToolStripMenuItem.Name = "administrarCampeonatosToolStripMenuItem";
            this.administrarCampeonatosToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.administrarCampeonatosToolStripMenuItem.Text = "Administrar campeonatos";
            this.administrarCampeonatosToolStripMenuItem.Click += new System.EventHandler(this.administrarCampeonatosToolStripMenuItem_Click);
            // 
            // entrenadoresToolStripMenuItem
            // 
            this.entrenadoresToolStripMenuItem.Name = "entrenadoresToolStripMenuItem";
            this.entrenadoresToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.entrenadoresToolStripMenuItem.Text = "Entrenadores";
            this.entrenadoresToolStripMenuItem.Click += new System.EventHandler(this.entrenadoresToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.campeonatosMenuItem,
            this.entrenadoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1399, 24);
            this.menuStrip1.TabIndex = 1;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(1289, 399);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(87, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "Denegar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.Location = new System.Drawing.Point(241, 67);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(200, 21);
            this.cbCategoria.TabIndex = 14;
            // 
            // AprobacionAltas
            // 
            this.ClientSize = new System.Drawing.Size(1405, 500);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gridSolicitudes);
            this.Controls.Add(this.btnAprobar);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AprobacionAltas";
            this.Sizable = false;
            this.Text = "Aprobación de altas";
            ((System.ComponentModel.ISupportInitialize)(this.gridSolicitudes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ToolStripMenuItem campeonatosMenuItem;
        private ToolStripMenuItem administrarCampeonatosToolStripMenuItem;
        private ToolStripMenuItem entrenadoresToolStripMenuItem;
        private MenuStrip menuStrip1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private ComboBox cbCategoria;
    }
}
