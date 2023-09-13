using Controlador;
using Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmRepMensualidades : Form
    {
        public FrmRepMensualidades()
        {
            InitializeComponent();

            DtFechaDesde.Value = DateTime.Now.AddDays(-1);
            DtFechaHasta.Value = DateTime.Now;
        }

        #region Variables
        private ClsClientes C = new ClsClientes();
        private ClsFormaPago FP = new ClsFormaPago();
        private const int CP_NOCLOSE_BUTTON = 0x200;
        #endregion

        #region Metodos 
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDBLCLK = 0x00A3;
            const int WM_NCHITTEST = 0x0084;

            // Deshabilitar el minimizado del tamaño del formulario mediante doble clic en la barra de título
            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                return;
            }

            //Deshabilitar el cambio de tamaño al arrastrar la barra de título
            if (m.Msg == WM_NCHITTEST)
            {

                Point coordenadasPuntero = PointToClient(Cursor.Position);

                if ((WindowState == FormWindowState.Maximized) && (coordenadasPuntero.X >= 0 && coordenadasPuntero.X <= (Width - 116)))
                {
                    return;
                }

            }

            base.WndProc(ref m);
        }
        #endregion

        #region Eventos
        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            FrmGenerarReportes RR = new FrmGenerarReportes(ClsGeneral.RptMensualidades,
                DtFechaDesde.Value, DtFechaHasta.Value,
                IDFormaPagoP: Convert.ToInt32(CbFormaPago.SelectedValue),
                IDClienteP: Convert.ToInt32(CbCliente.SelectedValue));
            RR.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmRepMensualidades_Load(object sender, EventArgs e)
        {
            BtnGenerar.BackColor = Color.LightGray;
            BtnGenerar.FlatStyle = FlatStyle.Flat;
            BtnGenerar.FlatAppearance.BorderColor = Color.Gold;
            BtnGenerar.FlatAppearance.BorderSize = 1;

            BtnSalir.BackColor = Color.LightGray;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.FlatAppearance.BorderColor = Color.Gold;
            BtnSalir.FlatAppearance.BorderSize = 1;

            CbCliente.DataSource = C.ListarCombo();
            DataTable Tabla = (DataTable)CbCliente.DataSource;
            DataRow newRow = Tabla.NewRow();
            newRow["ID"] = 0;
            newRow["Nombre"] = "Todos";
            Tabla.Rows.InsertAt(newRow, 0);

            CbCliente.ValueMember = "ID";
            CbCliente.DisplayMember = "Nombre";

            CbCliente.SelectedIndex = 0;

            CbFormaPago.DataSource = FP.ListarCombo();
            DataTable TablaFP = (DataTable)CbFormaPago.DataSource;
            DataRow newRowFP = TablaFP.NewRow();
            newRowFP["ID"] = 0;
            newRowFP["FormaPago"] = "Todas";
            TablaFP.Rows.InsertAt(newRowFP, 0);

            CbFormaPago.ValueMember = "ID";
            CbFormaPago.DisplayMember = "FormaPago";

            CbFormaPago.SelectedIndex = 0;
        }
        #endregion
    }
}
