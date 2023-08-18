using BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ClsFormaPago
    {
        #region Variables
        private int ID;
        private string FormaPago;
        private Conexiones C = new Conexiones();
        #endregion

        #region Constructores
        public ClsFormaPago()
        {

        }
        #endregion

        #region Gets y Sets
        public int _ID { get => ID; set => ID = value; }
        public string _FormaPago { get => FormaPago; set => FormaPago = value; }
        #endregion

        #region Metodos
        public DataTable ListarCombo()
        {
            return C.ListarFormaPagoCombo();
        }
        #endregion
    }
}
