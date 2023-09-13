using BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ClsBitMovimientos
    {
        #region Variables
        private int ID;
        private DateTime Fecha;
        private int IDMovimiento;
        private string Detalle;
        private int IDUsuario;
        private Conexiones C = new Conexiones();
        #endregion

        #region Constructores
        public ClsBitMovimientos()
        {

        }
        #endregion

        #region Gets y Sets
        public int _ID { get => ID; set => ID = value; }
        public DateTime _Fecha { get => Fecha; set => Fecha = value; }
        public int _IDMovimiento { get => IDMovimiento; set => IDMovimiento = value; }
        public string _Detalle { get => Detalle; set => Detalle = value; }
        public int _IDUsuario { get => IDUsuario; set => IDUsuario = value; }
        #endregion

        #region Metodos
        public DataTable Reporte(DateTime FechaDesde, DateTime FechaHasta,int IDUsuario)
        {
            return C.GenerarReporteBitMovimientos(FechaDesde, FechaHasta, IDUsuario);
        }
        public DataTable Listar(int Usuario,int TipoMovimiento, DateTime FechaDesde, DateTime FechaHasta)
        {
            return C.ListarBitMovimientos(Usuario, TipoMovimiento, FechaDesde, FechaHasta);
        }
        public void Insertar()
        {
            C.InsertarBitMovimientos(_Fecha, _IDUsuario, _IDMovimiento, _Detalle);
        }

        #endregion
    }
}
