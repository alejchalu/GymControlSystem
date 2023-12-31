﻿using Controlador;
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
    public partial class FrmRepBitMovimientos : Form
    {
        public FrmRepBitMovimientos()
        {
            InitializeComponent();

            DtFechaDesde.Value = DateTime.Now.AddDays(-1);
            DtFechaHasta.Value = DateTime.Now;
        }
        #region Variables
        private ClsUsuarios U = new ClsUsuarios();
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
            int IDUsuario = Convert.ToInt32(CbUsuario.SelectedValue);
            FrmGenerarReportes RR = new FrmGenerarReportes(ClsGeneral.RptBitMovimientos, DtFechaDesde.Value, DtFechaHasta.Value, IDUsuario);
            RR.ShowDialog();
        }
        private void FrmRepBitMovimientos_Load(object sender, EventArgs e)
        {
            BtnGenerar.BackColor = Color.LightGray;
            BtnGenerar.FlatStyle = FlatStyle.Flat;
            BtnGenerar.FlatAppearance.BorderColor = Color.Gold;
            BtnGenerar.FlatAppearance.BorderSize = 1;

            BtnSalir.BackColor = Color.LightGray;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.FlatAppearance.BorderColor = Color.Gold;
            BtnSalir.FlatAppearance.BorderSize = 1;

            CbUsuario.DataSource = U.ListarCombo();
            DataTable Tabla = (DataTable)CbUsuario.DataSource;
            DataRow newRow = Tabla.NewRow();
            newRow["ID"] = 0;
            newRow["Nombre"] = "Todos";
            Tabla.Rows.InsertAt(newRow, 0);

            CbUsuario.ValueMember = "ID";
            CbUsuario.DisplayMember = "Nombre";

            CbUsuario.SelectedIndex = 0;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
           Dispose();
        }
        #endregion
    }
}
