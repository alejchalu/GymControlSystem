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
    public partial class FrmMensualidades : Form
    {
        public FrmMensualidades()
        {
            InitializeComponent();
            DtFecha.Value = DateTime.Now;
        }
        #region Variables
        private ClsMensualidades M = new ClsMensualidades();
        private ClsClientes C = new ClsClientes();
        private ClsFormaPago FP = new ClsFormaPago();
        private ClsBitMovimientos BM = new ClsBitMovimientos();
        private ClsIngresosGastos IG = new ClsIngresosGastos();
        private DataTable DatosGrid = new DataTable();
        private bool CamposCompletos = true;
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

        private void Limpiar()
        {
            DtFecha.Value = DateTime.Now;
            DtFechaVencimiento.Value = DateTime.Now;
            NuMonto.Value = 0;
            CbCliente.SelectedValue = 0;
            CbFormaPago.SelectedValue = 0;
            TxtID.Clear();
        }
        private void BotonesBorde()
        {
            BtnActualizar.BackColor = Color.LightGray;
            BtnActualizar.FlatStyle = FlatStyle.Flat;
            BtnActualizar.FlatAppearance.BorderColor = Color.Gold;
            BtnActualizar.FlatAppearance.BorderSize = 1;

            BtnAgregar.BackColor = Color.LightGray;
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.FlatAppearance.BorderColor = Color.Gold;
            BtnAgregar.FlatAppearance.BorderSize = 1;

            BtnEliminar.BackColor = Color.LightGray;
            BtnEliminar.FlatStyle = FlatStyle.Flat;
            BtnEliminar.FlatAppearance.BorderColor = Color.Gold;
            BtnEliminar.FlatAppearance.BorderSize = 1;

            BtnSalir.BackColor = Color.LightGray;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.FlatAppearance.BorderColor = Color.Gold;
            BtnSalir.FlatAppearance.BorderSize = 1;

            BtnLimpiar.BackColor = Color.LightGray;
            BtnLimpiar.FlatStyle = FlatStyle.Flat;
            BtnLimpiar.FlatAppearance.BorderColor = Color.Gold;
            BtnLimpiar.FlatAppearance.BorderSize = 1;
        }
        private void Asignar()
        {
            if (!string.IsNullOrEmpty(TxtID.Text))
            {
                M._ID = Convert.ToInt32(TxtID.Text);
            }
            M._Fecha = DtFecha.Value;
            M._FechaVencimiento = DtFechaVencimiento.Value;
            M._Monto = NuMonto.Value;
            M._IDCliente = Convert.ToInt32(CbCliente.SelectedValue);
            M._IDUsuario = ClsGeneral.IDUsuario;
            M._IDFormaPago = Convert.ToInt32(CbFormaPago.SelectedValue);

            IG._Monto = NuMonto.Value;
            IG._Descripcion = "Pago mensualidad del cliente: " + CbCliente.Text;
            IG._Fecha = DtFecha.Value;
            IG._Tipo = true;
            IG._IDUsuario = ClsGeneral.IDUsuario;
            IG._IDFormaPago = Convert.ToInt32(CbFormaPago.SelectedValue);
        }
        private bool ValidarCampos()
        {
            if (DtFecha.Text == "" ||
                DtFechaVencimiento.Text == "" ||
                NuMonto.Value == 0 ||
                CbFormaPago.Text == "" ||
                CbCliente.Text == "")
            {
                CamposCompletos = false;
            }
            else
            {
                CamposCompletos = true;
            }
            return CamposCompletos;
        }
        #endregion

        #region Eventos
        private void DtFecha_ValueChanged(object sender, EventArgs e)
        {
            DtFechaVencimiento.Value = DtFecha.Value.AddDays(30);
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DatosGrid;
            var resultado = (from fila in dt.AsEnumerable()
                             where fila["Cliente"].ToString().ToLower().Contains(TxtBuscar.Text.ToLower())
                             select fila);
            if (resultado != null && resultado.Count() > 0)
            {
                GcMensualidades.DataSource = resultado.CopyToDataTable();
            }
            else
            {
                GcMensualidades.DataSource = DatosGrid;
            }
        }

        private void GcMensualidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GcMensualidades.Rows[0].Cells[0].Value.ToString() != "")
            {
                Limpiar();
                DataGridViewRow row = GcMensualidades.CurrentCell.OwningRow;
                DtFecha.Value = DateTime.Parse(row.Cells["Fecha de pago"].Value.ToString());
                DtFechaVencimiento.Value = DateTime.Parse(row.Cells["Fecha de vencimiento"].Value.ToString());
                NuMonto.Value = decimal.Parse(row.Cells["Monto"].Value.ToString());
                CbCliente.SelectedValue = row.Cells["IDCliente"].Value.ToString();
                CbFormaPago.SelectedValue = row.Cells["IDFormaPago"].Value.ToString();
                TxtID.Text = row.Cells["ID"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No hay datos para mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtID.Text == "")
                {
                    if (ValidarCampos() == false)
                    {
                        MessageBox.Show("Debe ingresar todos los datos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (MessageBox.Show("¿Realmente desea agregar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Asignar();

                        
                        int IDTabla = M.Insertar();

                        IG._IDMensualidad = IDTabla;
                        IG.Insertar();
                        BM._Fecha = DateTime.Now;
                        BM._IDUsuario = ClsGeneral.IDUsuario;
                        BM._IDMovimiento = 1;
                        BM._Detalle = "Insert mensualidad: " + IDTabla.ToString();
                        BM.Insertar();
                        

                        MessageBox.Show("Registro ingresado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();

                        GcMensualidades.DataSource = M.Listar();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor limpie los datos antes de agregar un nuevo registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtID.Text == "")
                {
                    MessageBox.Show("Debe seleccionar un registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ValidarCampos() == false)
                {
                    MessageBox.Show("Debe ingresar todos los datos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MessageBox.Show("¿Realmente desea actualizar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Asignar();

                    BM._Fecha = DateTime.Now;
                    BM._IDUsuario = ClsGeneral.IDUsuario;
                    BM._IDMovimiento = 2;
                    BM._Detalle = "Update mensualidad: " + TxtID.Text;
                    BM.Insertar();
                    M.Actualizar();

                    MessageBox.Show("Registro actualizado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();

                    GcMensualidades.DataSource = M.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtID.Text == "")
                {
                    MessageBox.Show("Debe seleccionar un registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MessageBox.Show("¿Realmente desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    M._ID = Convert.ToInt32(TxtID.Text);

                    BM._Fecha = DateTime.Now;
                    BM._IDUsuario = ClsGeneral.IDUsuario;
                    BM._IDMovimiento = 3;
                    BM._Detalle = "Delete mensualidad: " + TxtID.Text;
                    BM.Insertar();
                    M.Eliminar();

                    MessageBox.Show("Registro eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();

                    GcMensualidades.DataSource = M.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMensualidades_Load(object sender, EventArgs e)
        {
            BotonesBorde();
            try
            {
                DatosGrid = M.Listar();
                GcMensualidades.DataSource = DatosGrid;
                GcMensualidades.Columns[0].Visible = false;
                GcMensualidades.Columns[1].Visible = false;
                GcMensualidades.Columns[6].Visible = false;
                GcMensualidades.Columns[7].Visible = false;

                GcMensualidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                CbCliente.DataSource = C.ListarCombo();
                DataTable Tabla = (DataTable)CbCliente.DataSource;
                CbCliente.ValueMember = "ID";
                CbCliente.DisplayMember = "Nombre";

                CbFormaPago.DataSource = FP.ListarCombo();
                DataTable TablaFP = (DataTable)CbFormaPago.DataSource;
                CbFormaPago.ValueMember = "ID";
                CbFormaPago.DisplayMember = "FormaPago";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion       
    }
}
