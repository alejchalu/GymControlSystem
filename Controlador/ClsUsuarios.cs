using BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ClsUsuarios
    {
        #region Variables
        private int ID;
        private string Usuario;
        private string Contraseña;
        private string Nombre;
        private string Descripcion;
        private int IDRol;
        private bool Activo;
        private Conexiones C = new Conexiones();
        #endregion

        #region Constructores
        public ClsUsuarios()
        {

        }
        #endregion

        #region Gets y Sets
        public int _ID { get => ID; set => ID = value; }
        public string _Usuario { get => Usuario; set => Usuario = value; }
        public string _Contraseña { get => Contraseña; set => Contraseña = value; }
        public string _Nombre { get => Nombre; set => Nombre = value; }
        public int _IDRol { get => IDRol; set => IDRol = value; }
        public bool _Activo { get => Activo; set => Activo = value; }
        public string _Descripcion { get => Descripcion; set => Descripcion = value; }
        #endregion

        #region Metodos
        public DataTable ListarCombo()
        {
            return C.ListarUsuariosCombo();
        }
        public DataTable Listar()
        {
            return C.ListarUsuarios();
        }
        public int Insertar()
        {
           return C.InsertarUsuarios(_Usuario, _Contraseña, _Nombre, _IDRol, _Descripcion);
        }

        public void Actualizar()
        {
            C.ActualizarUsuarios(_ID,_Usuario, _Contraseña, _Nombre, _IDRol, _Descripcion);
        }

        public void Eliminar()
        {
            C.EliminarUsuarios(_ID);
        }

        public void Validar()
        {
            DataTable tabla = new DataTable();
            tabla = C.ValidaUsuarios(_Usuario, _Contraseña);
            if (tabla.Rows.Count>0)
            {
                _ID = int.Parse(tabla.Rows[0][0].ToString());
                _Nombre = tabla.Rows[0][1].ToString();
                _IDRol = int.Parse(tabla.Rows[0][2].ToString());

            }
            
        }
        #endregion
    }
}
