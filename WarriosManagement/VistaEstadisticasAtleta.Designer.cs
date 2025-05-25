namespace WarriosManagement
{
    partial class VistaEstadisticasAtleta
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTotalEnfrentamientos;
        private System.Windows.Forms.Label lblGanados;
        private System.Windows.Forms.Label lblPerdidos;
        private System.Windows.Forms.Label lblIPPON;
        private System.Windows.Forms.Label lblWAZAARI;
        private System.Windows.Forms.Label lblYUKO;
        private System.Windows.Forms.Label lblTotalPuntos;
        private System.Windows.Forms.Label lblManoDer;
        private System.Windows.Forms.Label lblManoIzq;
        private System.Windows.Forms.Label lblPieDer;
        private System.Windows.Forms.Label lblPieIzq;
        private System.Windows.Forms.Label lblTotalFaltas;
        private System.Windows.Forms.Label lblFalta1;
        private System.Windows.Forms.Label lblFalta2;
        private System.Windows.Forms.Label lblFalta3;
        private System.Windows.Forms.Label lblFalta4;

        private LiveCharts.WinForms.PieChart pieEnfrentamientos;
        private LiveCharts.WinForms.PieChart pieTipoPuntos;
        private LiveCharts.WinForms.CartesianChart cartesianPuntosZona;
        private LiveCharts.WinForms.CartesianChart cartesianFaltas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaEstadisticasAtleta));
            this.lblTotalEnfrentamientos = new System.Windows.Forms.Label();
            this.lblGanados = new System.Windows.Forms.Label();
            this.lblPerdidos = new System.Windows.Forms.Label();
            this.lblIPPON = new System.Windows.Forms.Label();
            this.lblWAZAARI = new System.Windows.Forms.Label();
            this.lblYUKO = new System.Windows.Forms.Label();
            this.lblTotalPuntos = new System.Windows.Forms.Label();
            this.lblManoDer = new System.Windows.Forms.Label();
            this.lblManoIzq = new System.Windows.Forms.Label();
            this.lblPieDer = new System.Windows.Forms.Label();
            this.lblPieIzq = new System.Windows.Forms.Label();
            this.lblTotalFaltas = new System.Windows.Forms.Label();
            this.lblFalta1 = new System.Windows.Forms.Label();
            this.lblFalta2 = new System.Windows.Forms.Label();
            this.lblFalta3 = new System.Windows.Forms.Label();
            this.lblFalta4 = new System.Windows.Forms.Label();
            this.pieEnfrentamientos = new LiveCharts.WinForms.PieChart();
            this.pieTipoPuntos = new LiveCharts.WinForms.PieChart();
            this.cartesianPuntosZona = new LiveCharts.WinForms.CartesianChart();
            this.cartesianFaltas = new LiveCharts.WinForms.CartesianChart();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotalEnfrentamientos
            // 
            this.lblTotalEnfrentamientos.AutoSize = true;
            this.lblTotalEnfrentamientos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalEnfrentamientos.ForeColor = System.Drawing.Color.Cyan;
            this.lblTotalEnfrentamientos.Location = new System.Drawing.Point(74, 241);
            this.lblTotalEnfrentamientos.Name = "lblTotalEnfrentamientos";
            this.lblTotalEnfrentamientos.Size = new System.Drawing.Size(21, 19);
            this.lblTotalEnfrentamientos.TabIndex = 0;
            this.lblTotalEnfrentamientos.Text = "...";
            // 
            // lblGanados
            // 
            this.lblGanados.AutoSize = true;
            this.lblGanados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGanados.ForeColor = System.Drawing.Color.Cyan;
            this.lblGanados.Location = new System.Drawing.Point(74, 271);
            this.lblGanados.Name = "lblGanados";
            this.lblGanados.Size = new System.Drawing.Size(21, 19);
            this.lblGanados.TabIndex = 1;
            this.lblGanados.Text = "...";
            // 
            // lblPerdidos
            // 
            this.lblPerdidos.AutoSize = true;
            this.lblPerdidos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPerdidos.ForeColor = System.Drawing.Color.Cyan;
            this.lblPerdidos.Location = new System.Drawing.Point(74, 296);
            this.lblPerdidos.Name = "lblPerdidos";
            this.lblPerdidos.Size = new System.Drawing.Size(21, 19);
            this.lblPerdidos.TabIndex = 2;
            this.lblPerdidos.Text = "...";
            // 
            // lblIPPON
            // 
            this.lblIPPON.AutoSize = true;
            this.lblIPPON.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblIPPON.ForeColor = System.Drawing.Color.Cyan;
            this.lblIPPON.Location = new System.Drawing.Point(547, 533);
            this.lblIPPON.Name = "lblIPPON";
            this.lblIPPON.Size = new System.Drawing.Size(21, 19);
            this.lblIPPON.TabIndex = 3;
            this.lblIPPON.Text = "...";
            // 
            // lblWAZAARI
            // 
            this.lblWAZAARI.AutoSize = true;
            this.lblWAZAARI.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblWAZAARI.ForeColor = System.Drawing.Color.Cyan;
            this.lblWAZAARI.Location = new System.Drawing.Point(547, 553);
            this.lblWAZAARI.Name = "lblWAZAARI";
            this.lblWAZAARI.Size = new System.Drawing.Size(21, 19);
            this.lblWAZAARI.TabIndex = 4;
            this.lblWAZAARI.Text = "...";
            // 
            // lblYUKO
            // 
            this.lblYUKO.AutoSize = true;
            this.lblYUKO.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblYUKO.ForeColor = System.Drawing.Color.Cyan;
            this.lblYUKO.Location = new System.Drawing.Point(547, 573);
            this.lblYUKO.Name = "lblYUKO";
            this.lblYUKO.Size = new System.Drawing.Size(21, 19);
            this.lblYUKO.TabIndex = 5;
            this.lblYUKO.Text = "...";
            // 
            // lblTotalPuntos
            // 
            this.lblTotalPuntos.AutoSize = true;
            this.lblTotalPuntos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalPuntos.ForeColor = System.Drawing.Color.Cyan;
            this.lblTotalPuntos.Location = new System.Drawing.Point(779, 141);
            this.lblTotalPuntos.Name = "lblTotalPuntos";
            this.lblTotalPuntos.Size = new System.Drawing.Size(21, 19);
            this.lblTotalPuntos.TabIndex = 6;
            this.lblTotalPuntos.Text = "...";
            // 
            // lblManoDer
            // 
            this.lblManoDer.AutoSize = true;
            this.lblManoDer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblManoDer.ForeColor = System.Drawing.Color.Cyan;
            this.lblManoDer.Location = new System.Drawing.Point(547, 259);
            this.lblManoDer.Name = "lblManoDer";
            this.lblManoDer.Size = new System.Drawing.Size(21, 19);
            this.lblManoDer.TabIndex = 7;
            this.lblManoDer.Text = "...";
            // 
            // lblManoIzq
            // 
            this.lblManoIzq.AutoSize = true;
            this.lblManoIzq.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblManoIzq.ForeColor = System.Drawing.Color.Cyan;
            this.lblManoIzq.Location = new System.Drawing.Point(547, 279);
            this.lblManoIzq.Name = "lblManoIzq";
            this.lblManoIzq.Size = new System.Drawing.Size(21, 19);
            this.lblManoIzq.TabIndex = 8;
            this.lblManoIzq.Text = "...";
            // 
            // lblPieDer
            // 
            this.lblPieDer.AutoSize = true;
            this.lblPieDer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPieDer.ForeColor = System.Drawing.Color.Cyan;
            this.lblPieDer.Location = new System.Drawing.Point(547, 299);
            this.lblPieDer.Name = "lblPieDer";
            this.lblPieDer.Size = new System.Drawing.Size(21, 19);
            this.lblPieDer.TabIndex = 9;
            this.lblPieDer.Text = "...";
            // 
            // lblPieIzq
            // 
            this.lblPieIzq.AutoSize = true;
            this.lblPieIzq.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPieIzq.ForeColor = System.Drawing.Color.Cyan;
            this.lblPieIzq.Location = new System.Drawing.Point(547, 319);
            this.lblPieIzq.Name = "lblPieIzq";
            this.lblPieIzq.Size = new System.Drawing.Size(21, 19);
            this.lblPieIzq.TabIndex = 10;
            this.lblPieIzq.Text = "...";
            // 
            // lblTotalFaltas
            // 
            this.lblTotalFaltas.AutoSize = true;
            this.lblTotalFaltas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalFaltas.ForeColor = System.Drawing.Color.Cyan;
            this.lblTotalFaltas.Location = new System.Drawing.Point(65, 540);
            this.lblTotalFaltas.Name = "lblTotalFaltas";
            this.lblTotalFaltas.Size = new System.Drawing.Size(21, 19);
            this.lblTotalFaltas.TabIndex = 11;
            this.lblTotalFaltas.Text = "...";
            // 
            // lblFalta1
            // 
            this.lblFalta1.AutoSize = true;
            this.lblFalta1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFalta1.ForeColor = System.Drawing.Color.Cyan;
            this.lblFalta1.Location = new System.Drawing.Point(65, 560);
            this.lblFalta1.Name = "lblFalta1";
            this.lblFalta1.Size = new System.Drawing.Size(21, 19);
            this.lblFalta1.TabIndex = 12;
            this.lblFalta1.Text = "...";
            // 
            // lblFalta2
            // 
            this.lblFalta2.AutoSize = true;
            this.lblFalta2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFalta2.ForeColor = System.Drawing.Color.Cyan;
            this.lblFalta2.Location = new System.Drawing.Point(65, 580);
            this.lblFalta2.Name = "lblFalta2";
            this.lblFalta2.Size = new System.Drawing.Size(21, 19);
            this.lblFalta2.TabIndex = 13;
            this.lblFalta2.Text = "...";
            // 
            // lblFalta3
            // 
            this.lblFalta3.AutoSize = true;
            this.lblFalta3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFalta3.ForeColor = System.Drawing.Color.Cyan;
            this.lblFalta3.Location = new System.Drawing.Point(65, 600);
            this.lblFalta3.Name = "lblFalta3";
            this.lblFalta3.Size = new System.Drawing.Size(21, 19);
            this.lblFalta3.TabIndex = 14;
            this.lblFalta3.Text = "...";
            // 
            // lblFalta4
            // 
            this.lblFalta4.AutoSize = true;
            this.lblFalta4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFalta4.ForeColor = System.Drawing.Color.Cyan;
            this.lblFalta4.Location = new System.Drawing.Point(65, 620);
            this.lblFalta4.Name = "lblFalta4";
            this.lblFalta4.Size = new System.Drawing.Size(21, 19);
            this.lblFalta4.TabIndex = 15;
            this.lblFalta4.Text = "...";
            // 
            // pieEnfrentamientos
            // 
            this.pieEnfrentamientos.BackColor = System.Drawing.Color.Transparent;
            this.pieEnfrentamientos.Location = new System.Drawing.Point(234, 194);
            this.pieEnfrentamientos.Name = "pieEnfrentamientos";
            this.pieEnfrentamientos.Size = new System.Drawing.Size(250, 200);
            this.pieEnfrentamientos.TabIndex = 16;
            // 
            // pieTipoPuntos
            // 
            this.pieTipoPuntos.BackColor = System.Drawing.Color.Transparent;
            this.pieTipoPuntos.Location = new System.Drawing.Point(736, 453);
            this.pieTipoPuntos.Name = "pieTipoPuntos";
            this.pieTipoPuntos.Size = new System.Drawing.Size(250, 200);
            this.pieTipoPuntos.TabIndex = 17;
            // 
            // cartesianPuntosZona
            // 
            this.cartesianPuntosZona.BackColor = System.Drawing.Color.Transparent;
            this.cartesianPuntosZona.Location = new System.Drawing.Point(697, 185);
            this.cartesianPuntosZona.Name = "cartesianPuntosZona";
            this.cartesianPuntosZona.Size = new System.Drawing.Size(300, 200);
            this.cartesianPuntosZona.TabIndex = 18;
            // 
            // cartesianFaltas
            // 
            this.cartesianFaltas.BackColor = System.Drawing.Color.Transparent;
            this.cartesianFaltas.Location = new System.Drawing.Point(184, 488);
            this.cartesianFaltas.Name = "cartesianFaltas";
            this.cartesianFaltas.Size = new System.Drawing.Size(300, 200);
            this.cartesianFaltas.TabIndex = 19;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Cyan;
            this.lblTitulo.Location = new System.Drawing.Point(29, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 37);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "...";
            // 
            // VistaEstadisticasAtleta
            // 
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1180, 750);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblTotalEnfrentamientos);
            this.Controls.Add(this.lblGanados);
            this.Controls.Add(this.lblPerdidos);
            this.Controls.Add(this.lblIPPON);
            this.Controls.Add(this.lblWAZAARI);
            this.Controls.Add(this.lblYUKO);
            this.Controls.Add(this.lblTotalPuntos);
            this.Controls.Add(this.lblManoDer);
            this.Controls.Add(this.lblManoIzq);
            this.Controls.Add(this.lblPieDer);
            this.Controls.Add(this.lblPieIzq);
            this.Controls.Add(this.lblTotalFaltas);
            this.Controls.Add(this.lblFalta1);
            this.Controls.Add(this.lblFalta2);
            this.Controls.Add(this.lblFalta3);
            this.Controls.Add(this.lblFalta4);
            this.Controls.Add(this.pieEnfrentamientos);
            this.Controls.Add(this.pieTipoPuntos);
            this.Controls.Add(this.cartesianPuntosZona);
            this.Controls.Add(this.cartesianFaltas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaEstadisticasAtleta";
            this.Text = "Estadísticas del Atleta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitulo;
    }
}
