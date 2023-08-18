using BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ClsIngresosGastos
    {
        #region Variables
        private int ID;
        private DateTime Fecha;
        private decimal Monto;
        private string Descripcion;
        private bool Tipo;
        private int IDUsuario;
        private int IDFormaPago;
        private int IDMensualidad;
        private bool Activo;
        private Conexiones C = new Conexiones();
        #endregion

        #region Constructores
        public ClsIngresosGastos()
        {

        }
        #endregion

        #region Gets y Sets
        public int _ID { get => ID; set => ID = value; }
        public DateTime _Fecha { get => Fecha; set => Fecha = value; }
        public decimal _Monto { get => Monto; set => Monto = value; }
        public string _Descripcion { get => Descripcion; set => Descripcion = value; }
        public bool _Tipo { get => Tipo; set => Tipo = value; }
        public int _IDUsuario { get => IDUsuario; set => IDUsuario = value; }
        public int _IDFormaPago { get => IDFormaPago; set => IDFormaPago = value; }
        public int _IDMensualidad { get => IDMensualidad; set => IDMensualidad = value; }
        public bool _Activo { get => Activo; set => Activo = value; }
        #endregion

        #region Metodos
        public DataTable ReporteDetalle(DateTime FechaDesde, DateTime FechaHasta,
            int IDFormaPago)
        {
            return C.GenerarReporteIngresosGastosDetalle(FechaDesde, FechaHasta, IDFormaPago);
        }
        public DataTable ReporteTotales(DateTime FechaDesde, DateTime FechaHasta,
            int IDFormaPago)
        {
            return C.GenerarReporteIngresosGastosTotales(FechaDesde, FechaHasta, IDFormaPago);
        }
        public DataTable Listar()
        {
            return C.ListarIngresosGastos();
        }
        public int Insertar()
        {
            return C.InsertarIngresosGastos(_Monto,_Descripcion,_Fecha,_Tipo,_IDUsuario,_IDFormaPago,_IDMensualidad);
        }

        public void Actualizar()
        {
            C.ActualizarIngresosGastos(_ID, _Monto, _Descripcion, _Fecha, _Tipo, _IDUsuario, _IDFormaPago);
        }

        public void Eliminar()
        {
            C.EliminarIngresosGastos(_ID);
        }
        #endregion
    }
}
