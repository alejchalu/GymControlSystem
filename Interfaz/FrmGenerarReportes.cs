using Controlador;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmGenerarReportes : Form
    {
        private DateTime FechaDesde;
        private DateTime FechaHasta;
        private int IDUsuario;
        private int IDFormaPago;
        private int IDCliente;
        private string NombreReporte;
        public FrmGenerarReportes(string NombreReporteP,
            DateTime FechaDesdeP, DateTime FechaHastaP,
            [Optional] int IDUsuarioP,
            [Optional] int IDFormaPagoP,
            [Optional] int IDClienteP)
        {
            FechaDesde = FechaDesdeP;
            FechaHasta = FechaHastaP;
            NombreReporte = NombreReporteP;
            IDUsuario = IDUsuarioP;
            IDFormaPago = IDFormaPagoP;
            IDCliente = IDClienteP;
            InitializeComponent();
        }

        private ClsRutinas R = new ClsRutinas();
        private ClsBitIngresosSalidas BIS = new ClsBitIngresosSalidas();
        private ClsBitMovimientos BM = new ClsBitMovimientos();
        private ClsIngresosGastos IG = new ClsIngresosGastos();
        private ClsMensualidades M = new ClsMensualidades();

        private void GenerarReportes_Load(object sender, EventArgs e)
        {
            DataTable Datos = new DataTable();
            DataTable Datos1 = new DataTable();
            switch (NombreReporte)
            {
                case ClsGeneral.RptRutinas:
                    Datos = R.Reporte(FechaDesde, FechaHasta);
                    break;
                case ClsGeneral.RptMensualidades:
                    Datos = M.Reporte(FechaDesde, FechaHasta, IDFormaPago, IDCliente);
                    break;
                case ClsGeneral.RptIngresosGastos:               
                    Datos = IG.ReporteDetalle(FechaDesde, FechaHasta, IDFormaPago);
                    Datos1 = IG.ReporteTotales(FechaDesde, FechaHasta, IDFormaPago);
                    break;
                case ClsGeneral.RptBitMovimientos:
                    Datos = BM.Reporte(FechaDesde, FechaHasta);
                    break;
                case ClsGeneral.RptBitIngresosSalidas:
                    Datos = BIS.Reporte(FechaDesde, FechaHasta);
                    break;
                default:
                    break;
            }          

            ReportDataSource RDS = new ReportDataSource("DataSet", Datos);          
            RvVerReportes.LocalReport.DataSources.Clear();
            RvVerReportes.LocalReport.DataSources.Add(RDS);
            RvVerReportes.LocalReport.ReportEmbeddedResource = NombreReporte;           

            if (NombreReporte == ClsGeneral.RptIngresosGastos)
            {
                ReportDataSource RDS1 = new ReportDataSource("DataSet1", Datos1);
                RvVerReportes.LocalReport.DataSources.Add(RDS1);
            }

            RvVerReportes.LocalReport.Refresh();
            RvVerReportes.Refresh();
            RvVerReportes.RefreshReport();
        }
    }
}
