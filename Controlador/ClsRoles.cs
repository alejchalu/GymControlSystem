using BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ClsRoles
    {
        #region Variables
        private int ID;
        private string Nombre;
        private string Descripcion;
        private bool Activo;
        private int IDUsuario;
        private Conexiones C = new Conexiones();
        #endregion

        #region Constructores
        public ClsRoles()
        {

        }
        #endregion

        #region Gets y Sets
        public int _ID { get => ID; set => ID = value; }
        public string _Nombre { get => Nombre; set => Nombre = value; }
        public string _Descripcion { get => Descripcion; set => Descripcion = value; }
        public int _IDUsuario { get => IDUsuario; set => IDUsuario = value; }
        public bool _Activo { get => Activo; set => Activo = value; }
        #endregion

        #region Metodos
        public DataTable Listar()
        {
            return C.ListarRoles();
        }

        public DataTable ListarCombo()
        {
            return C.ListarRolesCombo();
        }
        public int Insertar()
        {
            return C.InsertarRoles(_Nombre, _Descripcion);
        }

        public void Actualizar()
        {
            C.ActualizarRoles(_ID, _Nombre,_Descripcion);
        }

        public void Eliminar()
        {
            C.EliminarRoles(_ID);
        }
        #endregion
    }
}
