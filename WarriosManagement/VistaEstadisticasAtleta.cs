using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AccesoDatosWM;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using MaterialSkin;
using Modelos;

namespace WarriosManagement
{
    public partial class VistaEstadisticasAtleta : Form
    {
        private int idAtleta;

        public VistaEstadisticasAtleta(int id)
        {
            idAtleta = id;
            InitializeComponent();
            CargarDatos();


        }

        private void CargarDatos()
        {
            var atleta = AtletaRepositorio.ObtenerAtletaPorId(idAtleta);
            this.Text = "" + atleta.NombreCompleto + "    " + atleta.NombreCategoria;
            lblTitulo.Text = this.Text;
            var enf = EnfrentamientoRepositorio.ObtenerResumen(idAtleta);
            int totalPuntos = EstadisticasRepositorio.ObtenerTotalPuntos(idAtleta);
            int totalLesiones = EstadisticasRepositorio.ObtenerTotalLesiones(idAtleta);
            var puntosPorTipo = EstadisticasRepositorio.ObtenerPuntosPorTipo(idAtleta);
            var faltasPorTipo = EstadisticasRepositorio.ObtenerFaltasPorTipo(idAtleta);
            var puntosPorZona = EstadisticasRepositorio.ObtenerPuntosPorExtremidadYLateralidad(idAtleta);

            // Enfrentamientos
            lblTotalEnfrentamientos.Text = $"Total de enfrentamientos: {enf.Totales}";
            lblGanados.Text = $"Ganados: {enf.Ganados}";
            lblPerdidos.Text = $"Perdidos: {enf.Perdidos}";

            // Puntos por tipo
            lblIPPON.Text = $"IPPON: {ValorSeguro(puntosPorTipo, "IPPON")}";
            lblWAZAARI.Text = $"WAZAARI: {ValorSeguro(puntosPorTipo, "WAZAARI")}";
            lblYUKO.Text = $"YUKO: {ValorSeguro(puntosPorTipo, "YUKO")}";

            // Puntos por extremidad
            lblTotalPuntos.Text = $"Total de puntos: {totalPuntos}";
            lblManoDer.Text = $"Mano derecha: {ValorSeguro(puntosPorZona, "MANO_DERECHA")}";
            lblManoIzq.Text = $"Mano izquierda: {ValorSeguro(puntosPorZona, "MANO_IZQUIERDA")}";
            lblPieDer.Text = $"Pie derecho: {ValorSeguro(puntosPorZona, "PIE_DERECHA")}";
            lblPieIzq.Text = $"Pie izquierdo: {ValorSeguro(puntosPorZona, "PIE_IZQUIERDA")}";

            // Faltas
            lblTotalFaltas.Text = $"Total de faltas: {faltasPorTipo.Values.Sum()}";
            lblFalta1.Text = $"CHUKOKU: {ValorSeguro(faltasPorTipo, "CHUKOKU")}";
            lblFalta2.Text = $"KEYOKU: {ValorSeguro(faltasPorTipo, "KEYOKU")}";
            lblFalta3.Text = $"HANSOKU_CHUI: {ValorSeguro(faltasPorTipo, "HANSOKU_CHUI")}";
            lblFalta4.Text = $"HANSOKU: {ValorSeguro(faltasPorTipo, "HANSOKU")}";

            // Gráfico: Enfrentamientos
            pieEnfrentamientos.Series = new SeriesCollection
            {
                new PieSeries { Title = "Ganados", Values = new ChartValues<int> { enf.Ganados }, DataLabels = true },
                new PieSeries { Title = "Perdidos", Values = new ChartValues<int> { enf.Perdidos }, DataLabels = true }
            };

            // Gráfico: Puntos por tipo
            pieTipoPuntos.Series = new SeriesCollection
            {
                new PieSeries { Title = "IPPON", Values = new ChartValues<int> { ValorSeguro(puntosPorTipo, "IPPON") }, DataLabels = true },
                new PieSeries { Title = "WAZAARI", Values = new ChartValues<int> { ValorSeguro(puntosPorTipo, "WAZAARI") }, DataLabels = true },
                new PieSeries { Title = "YUKO", Values = new ChartValues<int> { ValorSeguro(puntosPorTipo, "YUKO") }, DataLabels = true }
            };

            // Gráfico: Puntos por zona
            var zonas = new[] { "MANO_DERECHA", "MANO_IZQUIERDA", "PIE_DERECHA", "PIE_IZQUIERDA" };
            cartesianPuntosZona.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Puntos",
                    Values = new ChartValues<int>(zonas.Select(z => ValorSeguro(puntosPorZona, z)))
                }
            };
            cartesianPuntosZona.AxisX.Clear();
            cartesianPuntosZona.AxisY.Clear();
            cartesianPuntosZona.AxisX.Add(new Axis { Labels = zonas });
            cartesianPuntosZona.AxisY.Add(new Axis { Title = "Cantidad" });

            // Gráfico: Faltas por tipo
            var faltas = faltasPorTipo.Keys.ToArray();
            cartesianFaltas.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Faltas",
                    Values = new ChartValues<int>(faltas.Select(f => ValorSeguro(faltasPorTipo, f)))
                }
            };
            cartesianFaltas.AxisX.Clear();
            cartesianFaltas.AxisY.Clear();
            cartesianFaltas.AxisX.Add(new Axis { Labels = faltas });
            cartesianFaltas.AxisY.Add(new Axis { Title = "Cantidad" });
        }

        private int ValorSeguro(Dictionary<string, int> diccionario, string clave)
        {
            return diccionario != null && diccionario.ContainsKey(clave) ? diccionario[clave] : 0;
        }
    }
}
