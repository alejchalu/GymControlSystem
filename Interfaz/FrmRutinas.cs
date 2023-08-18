using Controlador;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web.Security;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Interfaz
{
    public partial class FrmRutinas : Form
    {
        public FrmRutinas()
        {
            InitializeComponent();
        }

        #region Variables
        private ClsRutinas R = new ClsRutinas();
        private ClsBitMovimientos M = new ClsBitMovimientos();
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
            RtxtRutina.Clear();
            PbImagen.Image = null;
            TxtID.Clear();
            RtxtCalentaMujeres.Clear();
            RtxtTrabajo1Mujeres.Clear();
            RtxtTrabajo2Mujeres.Clear();
            RtxtTrabajo3Mujeres.Clear();
            RtxtCalentaHombres.Clear();
            RtxtTrabajo1Hombres.Clear();
            RtxtTrabajo2Hombres.Clear();
            RtxtTrabajo3Hombres.Clear();
        }
        public byte[] ImageToByteArray(Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
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
                R._ID = Convert.ToInt32(TxtID.Text);
            }
            R._Fecha = DtFecha.Value;
            R._Rutina = RtxtRutina.Text;
            if (PbImagen.Image == null)
            {
                R._Imagen = null;
            }
            else
            {
                R._Imagen = ImageToByteArray(PbImagen.Image);
            }
            R._CalentaMujeres = RtxtCalentaMujeres.Text;
            R._Trabajo1Mujeres = RtxtTrabajo1Mujeres.Text;
            R._Trabajo2Mujeres = RtxtTrabajo2Mujeres.Text;
            R._Trabajo3Mujeres = RtxtTrabajo3Mujeres.Text;
            R._CalentaHombres = RtxtCalentaHombres.Text;
            R._Trabajo1Hombres = RtxtTrabajo1Hombres.Text;
            R._Trabajo2Hombres = RtxtTrabajo2Hombres.Text;
            R._Trabajo3Hombres = RtxtTrabajo3Hombres.Text;
            R._IDUsuario = ClsGeneral.IDUsuario;
        }
        private bool ValidarCampos()
        {
            CamposCompletos = false;

            if ((RtxtCalentaMujeres.Text == "" &&
                RtxtCalentaHombres.Text == "" &&
                RtxtTrabajo1Mujeres.Text == "" &&
                RtxtTrabajo2Mujeres.Text == "" &&
                RtxtTrabajo3Mujeres.Text == "" &&
                 RtxtTrabajo1Hombres.Text == "" &&
                 RtxtTrabajo2Hombres.Text == "" &&
                 RtxtTrabajo3Hombres.Text == "")
                 && (RtxtRutina.Text != "" || PbImagen.Image != null)
                 )
            {
                CamposCompletos = true;
            }
            else if (RtxtCalentaMujeres.Text != "" &&
                RtxtCalentaHombres.Text != "" &&
                RtxtTrabajo1Mujeres.Text != "" &&
                RtxtTrabajo2Mujeres.Text != "" &&
                RtxtTrabajo3Mujeres.Text != "" &&
                 RtxtTrabajo1Hombres.Text != "" &&
                 RtxtTrabajo2Hombres.Text != "" &&
                 RtxtTrabajo3Hombres.Text != "")
            {
                CamposCompletos = true;
            }

            return CamposCompletos;
        }
        #endregion

        #region Eventos
        private void BtnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    PbImagen.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
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

                        int IDTabla = R.Insertar();
                        M._Fecha = DateTime.Now;
                        M._IDUsuario = ClsGeneral.IDUsuario;
                        M._IDMovimiento = 1;
                        M._Detalle = "Insert rutina: " + IDTabla.ToString();
                        M.Insertar();


                        MessageBox.Show("Registro ingresado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();

                        GcRutinas.DataSource = R.Listar();
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
                    M._Detalle = "Update rutina: " + TxtID.Text;
                    M.Insertar();
                    R.Actualizar();

                    MessageBox.Show("Registro actualizado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();

                    GcRutinas.DataSource = R.Listar();
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
                    R._ID = Convert.ToInt32(TxtID.Text);

                    M._Fecha = DateTime.Now;
                    M._IDUsuario = ClsGeneral.IDUsuario;
                    M._IDMovimiento = 3;
                    M._Detalle = "Delete rutina: " + TxtID.Text;
                    M.Insertar();
                    R.Eliminar();

                    MessageBox.Show("Registro eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();

                    GcRutinas.DataSource = R.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                GcRutinas.DataSource = resultado.CopyToDataTable();
            }
            else
            {
                GcRutinas.DataSource = DatosGrid;
            }
        }

        private void GcRutinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GcRutinas.Rows[0].Cells[0].Value.ToString() != "")
            {
                Limpiar();
                DataGridViewRow row = GcRutinas.CurrentCell.OwningRow;
                RtxtRutina.Text = row.Cells["Rutina"].Value.ToString();
                DtFecha.Value = DateTime.Parse(row.Cells["Fecha"].Value.ToString());
                TxtID.Text = row.Cells["ID"].Value.ToString();
                RtxtCalentaMujeres.Text = row.Cells["Calentamiento Mujeres"].Value.ToString();
                RtxtTrabajo1Mujeres.Text = row.Cells["Trabajo #1 Mujeres"].Value.ToString();
                RtxtTrabajo2Mujeres.Text = row.Cells["Trabajo #2 Mujeres"].Value.ToString();
                RtxtTrabajo3Mujeres.Text = row.Cells["Trabajo #3 Mujeres"].Value.ToString();
                RtxtCalentaHombres.Text = row.Cells["Calentamiento Hombres"].Value.ToString();
                RtxtTrabajo1Hombres.Text = row.Cells["Trabajo #1 Hombres"].Value.ToString();
                RtxtTrabajo2Hombres.Text = row.Cells["Trabajo #2 Hombres"].Value.ToString();
                RtxtTrabajo3Hombres.Text = row.Cells["Trabajo #3 Hombres"].Value.ToString();

                if (row.Cells["Imagen"].Value.ToString() != "")
                {
                    byte[] bytes = (byte[])row.Cells["Imagen"].Value;
                    MemoryStream ms = new MemoryStream(bytes);
                    Image img = Image.FromStream(ms);
                    PbImagen.Image = img;
                }
            }
            else
            {
                MessageBox.Show("No hay datos para mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void FrmRutinas_Load(object sender, EventArgs e)
        {
            BotonesBorde();
            try
            {
                DatosGrid = R.Listar();
                GcRutinas.DataSource = DatosGrid;
                GcRutinas.Columns[0].Visible = false;
                GcRutinas.Columns[12].Visible = false;
                GcRutinas.Columns[13].Visible = false;

                GcRutinas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnQuitarImagen_Click(object sender, EventArgs e)
        {
            if (PbImagen.Image == null)
            {
                MessageBox.Show("No hay imagen para remover", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PbImagen.Image = null;
            }
        }
        #endregion
    }
}
