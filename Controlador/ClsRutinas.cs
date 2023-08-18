using BaseDatos;
using System;
using System.Data;

namespace Controlador
{
    public class ClsRutinas
    {
        #region Variables
        private int ID;
        private DateTime Fecha;
        private string Rutina;
        private byte[] Imagen;
        private string CalentaMujeres;
        private string Trabajo1Mujeres;
        private string Trabajo2Mujeres;
        private string Trabajo3Mujeres;
        private string CalentaHombres;
        private string Trabajo1Hombres;
        private string Trabajo2Hombres;
        private string Trabajo3Hombres;
        private int IDUsuario;
        private bool Activo;
        private Conexiones C = new Conexiones();
        #endregion

        #region Constructores
        public ClsRutinas()
        {

        }
        #endregion

        #region Gets y Sets
        public int _ID { get => ID; set => ID = value; }
        public DateTime _Fecha { get => Fecha; set => Fecha = value; }
        public string _Rutina { get => Rutina; set => Rutina = value; }
        public byte[] _Imagen { get => Imagen; set => Imagen = value; }
        public int _IDUsuario { get => IDUsuario; set => IDUsuario = value; }
        public bool _Activo { get => Activo; set => Activo = value; }
        public string _CalentaMujeres { get => CalentaMujeres; set => CalentaMujeres = value; }
        public string _Trabajo1Mujeres { get => Trabajo1Mujeres; set => Trabajo1Mujeres = value; }
        public string _Trabajo2Mujeres { get => Trabajo2Mujeres; set => Trabajo2Mujeres = value; }
        public string _Trabajo3Mujeres { get => Trabajo3Mujeres; set => Trabajo3Mujeres = value; }
        public string _CalentaHombres { get => CalentaHombres; set => CalentaHombres = value; }
        public string _Trabajo1Hombres { get => Trabajo1Hombres; set => Trabajo1Hombres = value; }
        public string _Trabajo2Hombres { get => Trabajo2Hombres; set => Trabajo2Hombres = value; }
        public string _Trabajo3Hombres { get => Trabajo3Hombres; set => Trabajo3Hombres = value; }

        #endregion

        #region Metodos
        public DataTable Listar()
        {
            return C.ListarRutinas();
        }
        public int Insertar()
        {
            return C.InsertarRutinas(_Fecha, _Rutina,
                _Imagen,_CalentaMujeres,_Trabajo1Mujeres,_Trabajo2Mujeres,
                _Trabajo3Mujeres,_CalentaHombres,_Trabajo1Hombres,
                _Trabajo2Hombres,_Trabajo3Hombres, _IDUsuario);
        }

        public void Actualizar()
        {
            C.ActualizarRutinas(_ID,_Fecha, _Rutina, _Imagen, _CalentaMujeres, _Trabajo1Mujeres, _Trabajo2Mujeres,
                _Trabajo3Mujeres, _CalentaHombres, _Trabajo1Hombres,
                _Trabajo2Hombres, _Trabajo3Hombres, _IDUsuario);
        }

        public void Eliminar()
        {
            C.EliminarRutinas(_ID);
        }

        public DataTable Reporte(DateTime FechaDesde, DateTime FechaHasta)
        {
            return C.GenerarReporteRutinas(FechaDesde, FechaHasta);
        }
        #endregion
    }
}
