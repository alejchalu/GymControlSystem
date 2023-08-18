using Controlador;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Interfaz
{
    public partial class FrmPermisos : Form
    {
        public FrmPermisos()
        {
            InitializeComponent();
        }

        #region Variables
        private ClsRoles R = new ClsRoles();
        private ClsPermisos P = new ClsPermisos();
        private ClsBitMovimientos M = new ClsBitMovimientos();
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
        #endregion

        #region Eventos
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmPermisos_Load(object sender, EventArgs e)
        {
            BtnSalir.BackColor = Color.LightGray;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.FlatAppearance.BorderColor = Color.Gold;
            BtnSalir.FlatAppearance.BorderSize = 1;

            BtnGuardar.BackColor = Color.LightGray;
            BtnGuardar.FlatStyle = FlatStyle.Flat;
            BtnGuardar.FlatAppearance.BorderColor = Color.Gold;
            BtnGuardar.FlatAppearance.BorderSize = 1;

            CbRol.SelectedIndexChanged -= CbRol_SelectedIndexChanged;
            CbRol.DataSource = R.ListarCombo();
            DataTable Tabla = (DataTable)CbRol.DataSource;
            CbRol.ValueMember = "ID";
            CbRol.DisplayMember = "Nombre";
            CbRol.SelectedIndex = -1;
            CbRol.SelectedIndexChanged += new EventHandler(CbRol_SelectedIndexChanged);

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChlOpciones.CheckedItems.Count != 0 && CbRol.SelectedIndex >=0)
                {
                    P.Eliminar();
                    for (int x = 0; x < ChlOpciones.CheckedItems.Count; x++)
                    {
                        P._IDRol = Convert.ToInt32(CbRol.SelectedValue);
                        P._Nombre = ChlOpciones.CheckedItems[x].ToString();
                        P.Insertar();
                    }
                    M._Fecha = DateTime.Now;
                    M._IDUsuario = ClsGeneral.IDUsuario;
                    M._IDMovimiento = 1;
                    M._Detalle = "Insert/update permisos rol: " + CbRol.SelectedValue.ToString();
                    M.Insertar();
                    MessageBox.Show("Permisos guardados correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un rol y luego algún permiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                P._IDRol = Convert.ToInt32(CbRol.SelectedValue);
                DataTable dt = P.Listar();

                for (int i = 0; i < ChlOpciones.Items.Count; i++)
                {
                    ChlOpciones.SetItemChecked(i, false);
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row[1].ToString() == ChlOpciones.Items[i].ToString())
                        {
                            ChlOpciones.SetItemChecked(i, true);
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
