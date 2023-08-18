using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Interfaz
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        #region Variables
        private ClsPermisos P = new ClsPermisos();
        private ClsBitMovimientos M = new ClsBitMovimientos();
        private ClsBitIngresosSalidas IS = new ClsBitIngresosSalidas();
        
        #endregion

        #region Metodos
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        #endregion

        #region Eventos
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Gold, ButtonBorderStyle.Solid);
        }
        private void BtnClientes_Click(object sender, EventArgs e)
        {
            bool FormularioAbierto = false;
            foreach (Form form in PnlOpciones.Controls)
            {
                if (form is FrmClientes)
                {
                    FormularioAbierto = true;
                    form.WindowState = FormWindowState.Maximized;                   
                    form.BringToFront();
                    break;
                }
            }

            if (!FormularioAbierto)
            {
                FrmClientes Clientes = new FrmClientes();
                Clientes.TopLevel = false;

                PnlOpciones.Controls.Add(Clientes);
                Clientes.Show();
                Clientes.BringToFront();
            }
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {

            bool FormularioAbierto = false;
            foreach (Form form in PnlOpciones.Controls)
            {
                if (form is FrmUsuarios)
                {
                    FormularioAbierto = true;
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    break;
                }
            }

            if (!FormularioAbierto)
            {
                FrmUsuarios Usuarios = new FrmUsuarios();
                Usuarios.TopLevel = false;

                PnlOpciones.Controls.Add(Usuarios);
                Usuarios.Show();
                Usuarios.BringToFront();
            }
        }

        private void BtnRoles_Click(object sender, EventArgs e)
        {

            bool FormularioAbierto = false;
            foreach (Form form in PnlOpciones.Controls)
            {
                if (form is FrmRoles)
                {
                    FormularioAbierto = true;
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    break;
                }
            }

            if (!FormularioAbierto)
            {
                FrmRoles Roles = new FrmRoles();
                Roles.TopLevel = false;

                PnlOpciones.Controls.Add(Roles);
                Roles.Show();
                Roles.BringToFront();
            }
        }

        private void BtnPermisos_Click(object sender, EventArgs e)
        {

            bool FormularioAbierto = false;
            foreach (Form form in PnlOpciones.Controls)
            {
                if (form is FrmPermisos)
                {
                    FormularioAbierto = true;
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    break;
                }
            }

            if (!FormularioAbierto)
            {
                FrmPermisos Permisos = new FrmPermisos();
                Permisos.TopLevel = false;

                PnlOpciones.Controls.Add(Permisos);
                Permisos.Show();
                Permisos.BringToFront();
            }
        }

        private void BtnRutinas_Click(object sender, EventArgs e)
        {

            bool FormularioAbierto = false;
            foreach (Form form in PnlOpciones.Controls)
            {
                if (form is FrmRutinas)
                {
                    FormularioAbierto = true;
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    break;
                }
            }

            if (!FormularioAbierto)
            {
                FrmRutinas Rutinas = new FrmRutinas();
                Rutinas.TopLevel = false;

                PnlOpciones.Controls.Add(Rutinas);
                Rutinas.Show();
                Rutinas.BringToFront();
            }
        }

        private void BtnMensualidades_Click(object sender, EventArgs e)
        {
            bool FormularioAbierto = false;
            foreach (Form form in PnlOpciones.Controls)
            {
                if (form is FrmMensualidades)
                {
                    FormularioAbierto = true;
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    break;
                }
            }

            if (!FormularioAbierto)
            {
                FrmMensualidades Mensualidades = new FrmMensualidades();
                Mensualidades.TopLevel = false;

                PnlOpciones.Controls.Add(Mensualidades);
                Mensualidades.Show();
                Mensualidades.BringToFront();
            }
        }

        private void BtnIngresosGastos_Click(object sender, EventArgs e)
        {

            bool FormularioAbierto = false;
            foreach (Form form in PnlOpciones.Controls)
            {
                if (form is FrmIngresosGastos)
                {
                    FormularioAbierto = true;
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    break;
                }
            }

            if (!FormularioAbierto)
            {
                FrmIngresosGastos IngresosGastos = new FrmIngresosGastos();
                IngresosGastos.TopLevel = false;

                PnlOpciones.Controls.Add(IngresosGastos);
                IngresosGastos.Show();
                IngresosGastos.BringToFront();
            }
        }

        private void BtnAcercaDe_Click(object sender, EventArgs e)
        {
            bool FormularioAbierto = false;
            foreach (Form form in PnlOpciones.Controls)
            {
                if (form is FrmAcercaDe)
                {
                    FormularioAbierto = true;
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    break;
                }
            }
            if (!FormularioAbierto)
            {
                FrmAcercaDe AcercaDe = new FrmAcercaDe();
                AcercaDe.TopLevel = false;

                PnlOpciones.Controls.Add(AcercaDe);
                AcercaDe.Show();
                AcercaDe.BringToFront();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                IS._Fecha = DateTime.Now;
                IS._Tipo = false;
                IS._IDUsuario = ClsGeneral.IDUsuario;
                IS.Insertar();
                FrmLogin Login = new FrmLogin();
                Login.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            try
            {
                P._IDRol = ClsGeneral.IDRol;
                DataTable dt = P.Listar();

                foreach (ToolStripMenuItem menuItem in this.MnPrincipal.Items)
                {
                    if (menuItem.Text != "Salir" && menuItem.Text != "Mantenimientos" && menuItem.Text != "Reportes")
                        menuItem.Enabled = false;

                    if (menuItem.DropDownItems.Count > 0)
                    {
                        foreach (ToolStripMenuItem subitem in menuItem.DropDownItems)
                        {
                            subitem.Enabled = false;
                            foreach (DataRow row in dt.Rows)
                            {
                                if (subitem.Text.Trim() == row[1].ToString().Trim())
                                {
                                    subitem.Enabled = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            if (menuItem.Text.Trim() == row[1].ToString().Trim())
                                menuItem.Enabled = true;
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            try
            {
                M._Fecha = DateTime.Now;
                M._IDUsuario = ClsGeneral.IDUsuario;
                M._IDMovimiento = 6;
                M._Detalle = "Ingresó a Ayuda ";
                M.Insertar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRepRutinas_Click(object sender, EventArgs e)
        {

            bool FormularioAbierto = false;
            foreach (Form form in PnlOpciones.Controls)
            {
                if (form is FrmRepRutinas)
                {
                    FormularioAbierto = true;
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    break;
                }
            }
            if (!FormularioAbierto)
            {
                FrmRepRutinas RepRutinas = new FrmRepRutinas();
                RepRutinas.TopLevel = false;

                PnlOpciones.Controls.Add(RepRutinas);
                RepRutinas.Show();
                RepRutinas.BringToFront();
            }
        }
        private void BtnRepMensualidades_Click(object sender, EventArgs e)
        {

            bool FormularioAbierto = false;
            foreach (Form form in PnlOpciones.Controls)
            {
                if (form is FrmRepMensualidades)
                {
                    FormularioAbierto = true;
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    break;
                }
            }
            if (!FormularioAbierto)
            {
                FrmRepMensualidades RepMensualidades = new FrmRepMensualidades();
                RepMensualidades.TopLevel = false;

                PnlOpciones.Controls.Add(RepMensualidades);
                RepMensualidades.Show();
                RepMensualidades.BringToFront();
            }
        }

        private void BtnRepIngresosGastos_Click(object sender, EventArgs e)
        {
            bool FormularioAbierto = false;
            foreach (Form form in PnlOpciones.Controls)
            {
                if (form is FrmRepIngresosGastos)
                {
                    FormularioAbierto = true;
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    break;
                }
            }
            if (!FormularioAbierto)
            {
                FrmRepIngresosGastos RepIngresosGastos = new FrmRepIngresosGastos();
                RepIngresosGastos.TopLevel = false;

                PnlOpciones.Controls.Add(RepIngresosGastos);
                RepIngresosGastos.Show();
                RepIngresosGastos.BringToFront();
            }
        }
        private void BtnRepBitIngresosSalidas_Click(object sender, EventArgs e)
        {

            bool FormularioAbierto = false;
            foreach (Form form in PnlOpciones.Controls)
            {
                if (form is FrmRepBitIngresosSalidas)
                {
                    FormularioAbierto = true;
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    break;
                }
            }
            if (!FormularioAbierto)
            {
                FrmRepBitIngresosSalidas RepBitIngresosSalidas = new FrmRepBitIngresosSalidas();
                RepBitIngresosSalidas.TopLevel = false;

                PnlOpciones.Controls.Add(RepBitIngresosSalidas);
                RepBitIngresosSalidas.Show();
                RepBitIngresosSalidas.BringToFront();
            }
        }

        private void BtnRepBitMovimientos_Click(object sender, EventArgs e)
        {

            bool FormularioAbierto = false;
            foreach (Form form in PnlOpciones.Controls)
            {
                if (form is FrmRepBitMovimientos)
                {
                    FormularioAbierto = true;
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    break;
                }
            }
            if (!FormularioAbierto)
            {
                FrmRepBitMovimientos RepBitMovimientos = new FrmRepBitMovimientos();
                RepBitMovimientos.TopLevel = false;

                PnlOpciones.Controls.Add(RepBitMovimientos);
                RepBitMovimientos.Show();
                RepBitMovimientos.BringToFront();
            }
        }
        #endregion     
    }
}
