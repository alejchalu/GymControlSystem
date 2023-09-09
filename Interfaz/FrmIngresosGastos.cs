using Controlador;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Interfaz
{
    public partial class FrmIngresosGastos : Form
    {
        public FrmIngresosGastos()
        {
            InitializeComponent();

            DtFecha.Value = DateTime.Now;
            DtBuscar.Value = DateTime.Now;
        }
        #region Variables
        private ClsIngresosGastos IG = new ClsIngresosGastos();
        private ClsBitMovimientos M = new ClsBitMovimientos();
        private ClsFormaPago FP = new ClsFormaPago();
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
            NuMonto.Value = 0;
            RtxtDescripcion.Clear();
            RbIngreso.Checked = true;
            CbFormaPago.SelectedValue = 0;
            TxtID.Clear();
            BtnActualizar.Enabled = true;
            BtnEliminar.Enabled = true;
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
                IG._ID = Convert.ToInt32(TxtID.Text);
            }
            IG._Fecha = DtFecha.Value;
            IG._Monto = NuMonto.Value;
            IG._Descripcion = RtxtDescripcion.Text;
            IG._IDUsuario = ClsGeneral.IDUsuario;
            IG._IDFormaPago = Convert.ToInt32(CbFormaPago.SelectedValue);
            if (RbIngreso.Checked)
            {
                IG._Tipo = true;
            }
            else
            {
                IG._Tipo = false;
            }
        }
        private bool ValidarCampos()
        {
            if (DtFecha.Text == "" ||
                NuMonto.Value == 0 ||
                CbFormaPago.Text == "" ||
                RtxtDescripcion.Text == "")
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
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void DtBuscar_ValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DatosGrid;
            var resultado = (from fila in dt.AsEnumerable()
                             where fila["Fecha"].ToString().ToLower().Contains(DtBuscar.Text.ToLower())
                             select fila);
            if (resultado != null && resultado.Count() > 0)
            {
                GcIngresosGastos.DataSource = resultado.CopyToDataTable();
            }
            else
            {
                GcIngresosGastos.DataSource = DatosGrid;
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

                        int IDTabla = IG.Insertar();
                        M._Fecha = DateTime.Now;
                        M._IDUsuario = ClsGeneral.IDUsuario;
                        M._IDMovimiento = 1;
                        M._Detalle = "Insert IngresoGasto: " + IDTabla.ToString();
                        M.Insertar();
                        

                        MessageBox.Show("Registro ingresado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();

                        GcIngresosGastos.DataSource = IG.Listar();
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

                    M._Fecha = DateTime.Now;
                    M._IDUsuario = ClsGeneral.IDUsuario;
                    M._IDMovimiento = 2;
                    M._Detalle = "Update IngresoGasto: " + TxtID.Text;
                    M.Insertar();
                    IG.Actualizar();

                    MessageBox.Show("Registro actualizado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();

                    GcIngresosGastos.DataSource = IG.Listar();
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
                    IG._ID = Convert.ToInt32(TxtID.Text);

                    M._Fecha = DateTime.Now;
                    M._IDUsuario = ClsGeneral.IDUsuario;
                    M._IDMovimiento = 3;
                    M._Detalle = "Delete IngresoGasto: " + TxtID.Text;
                    M.Insertar();
                    IG.Eliminar();

                    MessageBox.Show("Registro eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();

                    GcIngresosGastos.DataSource = IG.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIngresosGastos_Load(object sender, EventArgs e)
        {
            BotonesBorde();
            try
            {
                DatosGrid = IG.Listar();
                GcIngresosGastos.DataSource = DatosGrid;
                GcIngresosGastos.Columns[0].Visible = false;
                GcIngresosGastos.Columns[5].Visible = false;
                GcIngresosGastos.Columns[6].Visible = false;
                GcIngresosGastos.Columns[7].Visible = false;

                GcIngresosGastos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                RbIngreso.Checked = true;

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

        private void GcIngresosGastos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GcIngresosGastos.Rows[0].Cells[0].Value.ToString() != "")
            {
                
                Limpiar();
                DataGridViewRow row = GcIngresosGastos.CurrentCell.OwningRow;
                DtFecha.Value = DateTime.Parse(row.Cells["Fecha"].Value.ToString());
                NuMonto.Value = decimal.Parse(row.Cells["Monto"].Value.ToString());
                RtxtDescripcion.Text = row.Cells["Descripción"].Value.ToString();
                TxtID.Text = row.Cells["ID"].Value.ToString();
                CbFormaPago.SelectedValue = row.Cells["IDFormaPago"].Value.ToString();
                if (row.Cells["Tipo"].Value.ToString() == "Ingreso")
                {
                    RbIngreso.Checked = true;
                }
                else
                {
                    RbGasto.Checked = true;
                }
                if (RtxtDescripcion.Text.Contains("mensualidad"))
                {
                    BtnActualizar.Enabled = false;
                    BtnEliminar.Enabled = false;
                }
                else
                {
                    BtnActualizar.Enabled = true;
                    BtnEliminar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("No hay datos para mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void RbIngreso_CheckedChanged(object sender, EventArgs e)
        {
            if (RbIngreso.Checked)
            {
                RbGasto.Checked = false;
            }
        }

        private void RbGasto_CheckedChanged(object sender, EventArgs e)
        {
            if (RbGasto.Checked)
            {
                RbIngreso.Checked = false;
            }
        }
        #endregion       
    }
}
