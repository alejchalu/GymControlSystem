using BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ClsMensualidades
    {
        #region Variables
        private int ID;
        private DateTime Fecha;
        private DateTime FechaVencimiento;
        private decimal Monto;
        private int IDCliente;
        private int IDFormaPago;
        private int IDUsuario;
        private bool Activo;
        private Conexiones C = new Conexiones();
        #endregion

        #region Constructores
        public ClsMensualidades()
        {

        }
        #endregion

        #region Gets y Sets
        public int _ID { get => ID; set => ID = value; }
        public DateTime _Fecha { get => Fecha; set => Fecha = value; }
        public DateTime _FechaVencimiento { get => FechaVencimiento; set => FechaVencimiento = value; }
        public decimal _Monto { get => Monto; set => Monto = value; }
        public int _IDCliente { get => IDCliente; set => IDCliente = value; }
        public int _IDFormaPago { get => IDFormaPago; set => IDFormaPago = value; }
        public int _IDUsuario { get => IDUsuario; set => IDUsuario = value; }
        public bool _Activo { get => Activo; set => Activo = value; }
        #endregion

        #region Metodos
        public DataTable Reporte(DateTime FechaDesde, DateTime FechaHasta,
            int IDFormaPago,int IDCliente)
        {
            return C.GenerarReporteMensualidades(FechaDesde, FechaHasta,IDFormaPago,IDCliente);
        }
        public DataTable Listar()
        {
            return C.ListarMensualidades();
        }
        public int Insertar()
        {
            return C.InsertarMensualidades(_IDCliente,_Fecha, _FechaVencimiento,_Monto, _IDUsuario,_IDFormaPago);
        }

        public void Actualizar()
        {
            C.ActualizarMensualidades(_ID, _IDCliente, _Fecha, _FechaVencimiento, _Monto, _IDUsuario, _IDFormaPago);
        }

        public void Eliminar()
        {
            C.EliminarMensualidades(_ID);
        }
        #endregion
    }
}
