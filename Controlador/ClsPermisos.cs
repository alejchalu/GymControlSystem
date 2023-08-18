using BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ClsPermisos
    {
        #region Variables
        private int ID;
        private string Nombre;
        private int IDRol;
        private Conexiones C = new Conexiones();
        #endregion

        #region Constructores
        public ClsPermisos()
        {

        }
        #endregion

        #region Gets y Sets
        public int _ID { get => ID; set => ID = value; }
        public string _Nombre { get => Nombre; set => Nombre = value; }
        public int _IDRol { get => IDRol; set => IDRol = value; }
        #endregion

        #region Metodos
        public void Insertar()
        {
            C.InsertarPermisos(_IDRol,_Nombre);
        }
        public void Eliminar()
        {
            C.EliminarPermisos(_IDRol);
        }

        public DataTable Listar()
        {
           return C.ListarPermisos(_IDRol);
        }
        #endregion
    }
}
