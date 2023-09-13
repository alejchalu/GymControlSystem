using BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ClsBitIngresosSalidas
    {
        #region Variables
        private int ID;
        private DateTime Fecha;
        private bool Tipo;
        private int IDUsuario;
        private Conexiones C = new Conexiones();
        #endregion

        #region Constructores
        public ClsBitIngresosSalidas()
        {

        }
        #endregion

        #region Gets y Sets
        public int _ID { get => ID; set => ID = value; }
        public DateTime _Fecha { get => Fecha; set => Fecha = value; }
        public bool _Tipo { get => Tipo; set => Tipo = value; }
        public int _IDUsuario { get => IDUsuario; set => IDUsuario = value; }
        #endregion

        #region Metodos
        public DataTable Reporte(DateTime FechaDesde, DateTime FechaHasta, int IDUsuario)
        {
            return C.GenerarReporteBitIngresosSalidas(FechaDesde, FechaHasta, IDUsuario);
        }
        public DataTable Listar(int Usuario,DateTime FechaDesde, DateTime FechaHasta)
        {
            return C.ListarBitIngresosSalidas(Usuario, FechaDesde, FechaHasta);
        }
        public void Insertar()
        {
            C.InsertarBitIngresosSalidas(_Fecha, _Tipo, _IDUsuario);
        }

        #endregion

    }
}
