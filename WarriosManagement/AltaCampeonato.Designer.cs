using MaterialSkin.Controls;
using System.Windows.Forms;

namespace WarriosManagement
{
    partial class AltaCampeonato
    {
        private System.ComponentModel.IContainer components = null;

        private MaterialTextBox txtNombre;
        private MaterialComboBox cbCiudad;
        private MaterialTextBox txtCalle;
        private MaterialTextBox txtNumeroCalle;
        private MaterialTextBox txtCodPostal;
        private DateTimePicker datePickerFecha;
        private MaterialButton btnGuardar;
        private MaterialButton btnEliminar;
        private MaterialListView listTorneos;
        private ColumnHeader columnId;
        private ColumnHeader columnNombre;
        private ColumnHeader columnCiudad;
        private ColumnHeader columnCalle;
        private ColumnHeader columnNumero;
        private ColumnHeader columnPostal;
        private ColumnHeader columnFecha;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem entrenadoresToolStripMenuItem;
        private ToolStripMenuItem atletasToolStripMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaCampeonato));
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.cbCiudad = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCalle = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNumeroCalle = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCodPostal = new MaterialSkin.Controls.MaterialTextBox();
            this.datePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.listTorneos = new MaterialSkin.Controls.MaterialListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCiudad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCalle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPostal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.entrenadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atletasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.Hint = "Nombre del Torneo";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(30, 132);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 50);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            // 
            // cbCiudad
            // 
            this.cbCiudad.AutoResize = false;
            this.cbCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbCiudad.Depth = 0;
            this.cbCiudad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbCiudad.DropDownHeight = 174;
            this.cbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCiudad.DropDownWidth = 121;
            this.cbCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbCiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbCiudad.Hint = "Ciudad";
            this.cbCiudad.IntegralHeight = false;
            this.cbCiudad.ItemHeight = 43;
            this.cbCiudad.Items.AddRange(new object[] {
            "Madrid",
            "Barcelona",
            "Valencia",
            "Sevilla",
            "Zaragoza",
            "Málaga",
            "Murcia",
            "Palma",
            "Bilbao",
            "Alicante",
            "Córdoba",
            "Valladolid",
            "Vigo",
            "Gijón",
            "L\'Hospitalet de Llobregat",
            "A Coruña"});
            this.cbCiudad.Location = new System.Drawing.Point(489, 132);
            this.cbCiudad.MaxDropDownItems = 4;
            this.cbCiudad.MouseState = MaterialSkin.MouseState.OUT;
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(250, 49);
            this.cbCiudad.StartIndex = 0;
            this.cbCiudad.TabIndex = 2;
            // 
            // txtCalle
            // 
            this.txtCalle.AnimateReadOnly = false;
            this.txtCalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCalle.Depth = 0;
            this.txtCalle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCalle.Hint = "Calle";
            this.txtCalle.LeadingIcon = null;
            this.txtCalle.Location = new System.Drawing.Point(30, 192);
            this.txtCalle.MaxLength = 50;
            this.txtCalle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCalle.Multiline = false;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(250, 50);
            this.txtCalle.TabIndex = 3;
            this.txtCalle.Text = "";
            this.txtCalle.TrailingIcon = null;
            // 
            // txtNumeroCalle
            // 
            this.txtNumeroCalle.AnimateReadOnly = false;
            this.txtNumeroCalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroCalle.Depth = 0;
            this.txtNumeroCalle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumeroCalle.Hint = "Número";
            this.txtNumeroCalle.LeadingIcon = null;
            this.txtNumeroCalle.Location = new System.Drawing.Point(489, 192);
            this.txtNumeroCalle.MaxLength = 50;
            this.txtNumeroCalle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumeroCalle.Multiline = false;
            this.txtNumeroCalle.Name = "txtNumeroCalle";
            this.txtNumeroCalle.Size = new System.Drawing.Size(250, 50);
            this.txtNumeroCalle.TabIndex = 4;
            this.txtNumeroCalle.Text = "";
            this.txtNumeroCalle.TrailingIcon = null;
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.AnimateReadOnly = false;
            this.txtCodPostal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodPostal.Depth = 0;
            this.txtCodPostal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodPostal.Hint = "Código Postal";
            this.txtCodPostal.LeadingIcon = null;
            this.txtCodPostal.Location = new System.Drawing.Point(30, 252);
            this.txtCodPostal.MaxLength = 50;
            this.txtCodPostal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodPostal.Multiline = false;
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(250, 50);
            this.txtCodPostal.TabIndex = 5;
            this.txtCodPostal.Text = "";
            this.txtCodPostal.TrailingIcon = null;
            // 
            // datePickerFecha
            // 
            this.datePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerFecha.Location = new System.Drawing.Point(489, 267);
            this.datePickerFecha.Name = "datePickerFecha";
            this.datePickerFecha.Size = new System.Drawing.Size(250, 20);
            this.datePickerFecha.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(44, 527);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardar.Size = new System.Drawing.Size(88, 36);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.HighEmphasis = true;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(639, 527);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminar.Size = new System.Drawing.Size(88, 36);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminar.UseAccentColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // listTorneos
            // 
            this.listTorneos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listTorneos.AutoSizeTable = false;
            this.listTorneos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listTorneos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTorneos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnNombre,
            this.columnCiudad,
            this.columnCalle,
            this.columnNumero,
            this.columnPostal,
            this.columnFecha});
            this.listTorneos.Depth = 0;
            this.listTorneos.FullRowSelect = true;
            this.listTorneos.HideSelection = false;
            this.listTorneos.Location = new System.Drawing.Point(30, 320);
            this.listTorneos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listTorneos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listTorneos.MouseState = MaterialSkin.MouseState.OUT;
            this.listTorneos.Name = "listTorneos";
            this.listTorneos.OwnerDraw = true;
            this.listTorneos.Size = new System.Drawing.Size(709, 180);
            this.listTorneos.TabIndex = 9;
            this.listTorneos.UseCompatibleStateImageBehavior = false;
            this.listTorneos.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "ID";
            // 
            // columnNombre
            // 
            this.columnNombre.Text = "Nombre";
            // 
            // columnCiudad
            // 
            this.columnCiudad.Text = "Ciudad";
            // 
            // columnCalle
            // 
            this.columnCalle.Text = "Calle";
            // 
            // columnNumero
            // 
            this.columnNumero.Text = "Número";
            // 
            // columnPostal
            // 
            this.columnPostal.Text = "Cód. Postal";
            // 
            // columnFecha
            // 
            this.columnFecha.Text = "Fecha";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrenadoresToolStripMenuItem,
            this.atletasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // entrenadoresToolStripMenuItem
            // 
            this.entrenadoresToolStripMenuItem.Name = "entrenadoresToolStripMenuItem";
            this.entrenadoresToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.entrenadoresToolStripMenuItem.Text = "Entrenadores";
            this.entrenadoresToolStripMenuItem.Click += new System.EventHandler(this.entrenadoresToolStripMenuItem_Click);
            // 
            // atletasToolStripMenuItem
            // 
            this.atletasToolStripMenuItem.Name = "atletasToolStripMenuItem";
            this.atletasToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.atletasToolStripMenuItem.Text = "Alta Usuarios";
            this.atletasToolStripMenuItem.Click += new System.EventHandler(this.atletasToolStripMenuItem_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.Location = new System.Drawing.Point(224, 64);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(200, 21);
            this.cbCategoria.TabIndex = 15;
            // 
            // AltaCampeonato
            // 
            this.ClientSize = new System.Drawing.Size(779, 600);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtNumeroCalle);
            this.Controls.Add(this.txtCodPostal);
            this.Controls.Add(this.datePickerFecha);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.listTorneos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AltaCampeonato";
            this.Text = "Alta de Campeonato";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ComboBox cbCategoria;
    }
}
