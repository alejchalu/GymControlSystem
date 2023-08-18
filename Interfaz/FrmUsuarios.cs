using Controlador;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1;


namespace Interfaz
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        #region Variables
        private ClsBitMovimientos M = new ClsBitMovimientos();  
        private ClsUsuarios U = new ClsUsuarios();
        private ClsRoles R = new ClsRoles();
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

                if ((WindowState == FormWindowState.Maximized) && (coordenadasPuntero.X >= 0 && coordenadasPuntero.X <= (Width - 116)))
                {
                    return;
                }

            }

            base.WndProc(ref m);
        }

        private void Limpiar()
        {
            TxtNombre.Clear();
            TxtContraseña.Clear();
            TxtUsuario.Clear();
            CbRol.SelectedValue = 0;
            TxtID.Clear();
            RtxtDescripcion.Clear();
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
                U._ID = Convert.ToInt32(TxtID.Text);
            }
            U._Nombre = TxtNombre.Text;
            U._Usuario = TxtUsuario.Text;
            if (!ClsGeneral.IsTextEncrypted(TxtContraseña.Text))
            {
                U._Contraseña = ClsGeneral.Encriptar(TxtContraseña.Text);
            }
            else
            {
                U._Contraseña = TxtContraseña.Text;
            }           
            U._IDRol = Convert.ToInt32(CbRol.SelectedValue);
            U._Descripcion = RtxtDescripcion.Text;
        }
        private bool ValidarCampos()
        {
            if (TxtNombre.Text == "" ||
                TxtUsuario.Text == "" ||
                TxtContraseña.Text == "" ||
                CbRol.Text == "")
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
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            BotonesBorde();
            try
            {
                DatosGrid = U.Listar();
                GcUsuarios.DataSource = DatosGrid;
                GcUsuarios.Columns[0].Visible = false;
                GcUsuarios.Columns[5].Visible = false;

                CbRol.DataSource = R.ListarCombo();
                DataTable Tabla = (DataTable)CbRol.DataSource;
                CbRol.ValueMember = "ID";
                CbRol.DisplayMember = "Nombre";

                GcUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtID.Text == "")
                {
                    if (ValidarCampos() ==false)
                    {
                        MessageBox.Show("Debe ingresar todos los datos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (MessageBox.Show("¿Realmente desea agregar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Asignar();

                        int IDTabla = U.Insertar();
                        M._Fecha = DateTime.Now;
                        M._IDUsuario = ClsGeneral.IDUsuario;
                        M._IDMovimiento = 1;
                        M._Detalle = "Insert usuario: " + IDTabla.ToString();
                        M.Insertar();
                        

                        MessageBox.Show("Registro ingresado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();

                        GcUsuarios.DataSource = U.Listar();
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
                    DataGridViewRow row = GcUsuarios.CurrentCell.OwningRow;
                    string Usuario_antiguo = row.Cells["Usuario"].Value.ToString();

                    if (Usuario_antiguo == ClsGeneral.Usuario)
                    {
                        ClsGeneral.Usuario = TxtUsuario.Text;
                    }                   
                                       
                    Asignar();

                    M._Fecha = DateTime.Now;
                    M._IDUsuario = ClsGeneral.IDUsuario;
                    M._IDMovimiento = 2;
                    M._Detalle = "Update usuario: " + TxtID.Text;
                    M.Insertar();
                    U.Actualizar();

                    MessageBox.Show("Registro actualizado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();

                    GcUsuarios.DataSource = U.Listar();
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
                    U._ID = Convert.ToInt32(TxtID.Text);

                    M._Fecha = DateTime.Now;
                    M._IDUsuario = ClsGeneral.IDUsuario;
                    M._IDMovimiento = 3;
                    M._Detalle = "Delete usuario: " + TxtID.Text;
                    M.Insertar();
                    U.Eliminar();

                    MessageBox.Show("Registro eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();

                    GcUsuarios.DataSource = U.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GcUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GcUsuarios.Rows[0].Cells[0].Value.ToString() != "")
            {
                Limpiar();
                DataGridViewRow row = GcUsuarios.CurrentCell.OwningRow;
                TxtUsuario.Text = row.Cells["Usuario"].Value.ToString();
                TxtContraseña.Text = row.Cells["Contraseña"].Value.ToString();
                TxtNombre.Text = row.Cells["Nombre"].Value.ToString();
                RtxtDescripcion.Text = row.Cells["Descripción"].Value.ToString();
                CbRol.SelectedValue = row.Cells["IDRol"].Value.ToString();
                TxtID.Text = row.Cells["ID"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No hay datos para mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DatosGrid;
            var resultado = (from fila in dt.AsEnumerable()
                             where fila["Nombre"].ToString().ToLower().Contains(TxtBuscar.Text.ToLower())
                             select fila);
            if (resultado != null && resultado.Count() > 0)
            {
                GcUsuarios.DataSource = resultado.CopyToDataTable();
            }
            else
            {
                GcUsuarios.DataSource = DatosGrid;
            }
        }
        #endregion

    }
}
