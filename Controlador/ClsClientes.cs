using BaseDatos;
using System;
using System.Data;

namespace Controlador
{
    public class ClsClientes
    {
        #region Variables
        private int ID;
        private string Nombre;
        private string PrimerApellido;
        private string SegundoApellido;
        private string Telefono;
        private string Correo;
        private DateTime FechaIngreso;
        private decimal Peso;
        private decimal Estatura;
        private string Horario;
        private int IDUsuario;
        private Conexiones C = new Conexiones();
       #endregion

        #region Constructores
        public ClsClientes()
        {

        }
        #endregion

        #region Gets y Sets
        public int _ID { get => ID; set => ID = value; }
        public string _Nombre { get => Nombre; set => Nombre = value; }
        public string _PrimerApellido { get => PrimerApellido; set => PrimerApellido = value; }
        public string _SegundoApellido { get => SegundoApellido; set => SegundoApellido = value; }
        public string _Telefono { get => Telefono; set => Telefono = value; }
        public string _Correo { get => Correo; set => Correo = value; }
        public DateTime _FechaIngreso { get => FechaIngreso; set => FechaIngreso = value; }
        public decimal _Peso { get => Peso; set => Peso = value; }
        public decimal _Estatura { get => Estatura; set => Estatura = value; }
        public string _Horario { get => Horario; set => Horario = value; }
        public int _IDUsuario { get => IDUsuario; set => IDUsuario = value; }

        #endregion

        #region Metodos
        public DataTable Listar()
        {
            return C.ListarClientes();
        }
        public int Insertar()
        {
            return C.InsertarClientes(_Nombre,_PrimerApellido,_SegundoApellido,_Telefono,_Correo,_FechaIngreso,_Peso,_Estatura,_Horario,_IDUsuario);
        }

        public void Actualizar()
        {
            C.ActualizarClientes(_ID, _Nombre, _PrimerApellido, _SegundoApellido, _Telefono, _Correo, _FechaIngreso, _Peso, _Estatura, _Horario);
        }

        public void Eliminar()
        {
            C.EliminarClientes(_ID);
        }
        public DataTable ListarCombo()
        {
            return C.ListarClientesCombo();
        }

        public DataTable ConsultarEstado()
        {
            return C.ConsultarEstadoClientes(_ID);
        }
        #endregion
    }
}
