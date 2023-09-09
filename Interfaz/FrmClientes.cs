using Controlador;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Interfaz
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();

            DtFechaIngreso.Value = DateTime.Now;
        }
        #region Variables
        private ClsClientes C = new ClsClientes();
        private ClsBitMovimientos M = new ClsBitMovimientos();
        DataTable DatosGrid = new DataTable();
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

                if ((WindowState == FormWindowState.Maximized) && (coordenadasPuntero.X >= 0 && coordenadasPuntero.X <= (Width-116)))
                {
                    return;
                }

            }

            base.WndProc(ref m);
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
        private void Limpiar()
        {
            TxtNombre.Clear();
            TxtTelefono.Clear();
            TxtCorreo.Clear();
            DtFechaIngreso.Value = DateTime.Now;
            TxtID.Clear();
            NuEstatura.Value = 0;
            NuPeso.Value = 0;
            CbHorario.SelectedIndex =0;
            TxtApellido1.Clear();
            TxtApellido2.Clear();
            TxtEstado.Clear();
        }

        private void Asignar()
        {
            if (!string.IsNullOrEmpty(TxtID.Text))
            {
                C._ID = Convert.ToInt32(TxtID.Text);
            }
            C._Nombre = TxtNombre.Text;
            C._PrimerApellido = TxtApellido1.Text;
            C._SegundoApellido = TxtApellido2.Text;
            C._Telefono = TxtTelefono.Text;
            C._Correo = TxtCorreo.Text;
            C._FechaIngreso = DtFechaIngreso.Value;
            C._Peso = (decimal)NuPeso.Value;
            C._Estatura = (decimal)NuEstatura.Value;
            C._Horario = CbHorario.SelectedItem.ToString();
            C._IDUsuario = ClsGeneral.IDUsuario;
            
        }

        private bool ValidarCampos()
        {
            if (TxtNombre.Text == "" ||
                DtFechaIngreso.Value.ToString() == "" ||
                (decimal)NuPeso.Value ==0 ||
                (decimal)NuEstatura.Value == 0 || (TxtCorreo.Text !="" &&
                !ClsGeneral.EsCorreoElectronicoValido(TxtCorreo.Text.Trim())))
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
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtID.Text == "")
                {
                    if (ValidarCampos() == false)
                    {
                        MessageBox.Show("Debe ingresar todos los datos solicitados y de forma correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (MessageBox.Show("¿Realmente desea agregar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Asignar();

                        int IDTabla = C.Insertar();
                        M._Fecha = DateTime.Now;
                        M._IDUsuario = ClsGeneral.IDUsuario;
                        M._IDMovimiento = 1;
                        M._Detalle = "Insert cliente: " + IDTabla.ToString();
                        M.Insertar();
                        

                        MessageBox.Show("Registro ingresado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();

                        GcClientes.DataSource = C.Listar();
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
                    MessageBox.Show("Debe ingresar todos los datos solicitados y de forma correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MessageBox.Show("¿Realmente desea actualizar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Asignar();

                    M._Fecha = DateTime.Now;
                    M._IDUsuario = ClsGeneral.IDUsuario;
                    M._IDMovimiento = 2;
                    M._Detalle = "Update cliente: " + TxtID.Text;
                    M.Insertar();
                    C.Actualizar();

                    MessageBox.Show("Registro actualizado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();

                    GcClientes.DataSource = C.Listar();
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
                    C._ID = Convert.ToInt32(TxtID.Text);

                    M._Fecha = DateTime.Now;
                    M._IDUsuario = ClsGeneral.IDUsuario;
                    M._IDMovimiento = 3;
                    M._Detalle = "Delete cliente: " + TxtID.Text;
                    M.Insertar();
                    C.Eliminar();

                    MessageBox.Show("Registro eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();

                    GcClientes.DataSource = C.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            BotonesBorde();
            try
            {
                DatosGrid = C.Listar();
                GcClientes.DataSource = DatosGrid;
                GcClientes.Columns[0].Visible = false;
                GcClientes.Columns[10].Visible = false;
                GcClientes.Columns[11].Visible = false;

                GcClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GcClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GcClientes.Rows[0].Cells[0].Value.ToString() != "")
            {
                Limpiar();
                DataGridViewRow row = GcClientes.CurrentCell.OwningRow;
                TxtNombre.Text = row.Cells["Nombre"].Value.ToString();
                TxtApellido1.Text = row.Cells["Primer apellido"].Value.ToString();
                TxtApellido2.Text = row.Cells["Segundo apellido"].Value.ToString();
                TxtTelefono.Text = row.Cells["Teléfono"].Value.ToString();
                TxtCorreo.Text = row.Cells["Correo"].Value.ToString();
                DtFechaIngreso.Value = DateTime.Parse(row.Cells["Fecha de ingreso"].Value.ToString());
                NuPeso.Value = decimal.Parse(row.Cells["Peso"].Value.ToString());
                NuEstatura.Value = decimal.Parse(row.Cells["Estatura"].Value.ToString());

                for (int i = 0; i < CbHorario.Items.Count; i++)
                {
                    if (row.Cells["Horario"].Value.ToString() == CbHorario.Items[i].ToString())
                    {
                        CbHorario.SelectedIndex = i; break;
                    }
                }

                TxtID.Text = row.Cells["ID"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No hay datos para mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DatosGrid;
            var resultado = (from fila in dt.AsEnumerable()
                             where fila["Nombre"].ToString().ToLower().Contains(TxtBuscar.Text.ToLower())
                             select fila);
            if (resultado != null && resultado.Count() > 0)
            {
                GcClientes.DataSource = resultado.CopyToDataTable();
            }
            else
            {
                GcClientes.DataSource = DatosGrid;
            }
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BtnVerEstado_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtID.Text))
            {
                C._ID = Convert.ToInt32(TxtID.Text);
                DataTable Estado = new DataTable();
                Estado = C.ConsultarEstado();
                if (Estado.Rows.Count>0)
                {
                    TxtEstado.Text = "ESTADO: " + Estado.Rows[0]["ESTADO"].ToString() + "\n";
                    TxtEstado.Text = "\n" + TxtEstado.Text + "Numero de días: " + Estado.Rows[0]["NumeroDias"].ToString() + "\n";
                    TxtEstado.Text = "\n" + TxtEstado.Text + "Vencimiento: " + Estado.Rows[0]["FechaVencimiento"].ToString();
                }
                else
                {
                    MessageBox.Show("No hay mensualidades registradas para el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        #endregion
    }
}
