using Controlador;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Interfaz
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        #region Variables
        private ClsUsuarios U = new ClsUsuarios();
        private ClsBitIngresosSalidas IS = new ClsBitIngresosSalidas();
        #endregion

        #region Deshabilitar "X"
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
        private void FrmLogin_Load(object sender, EventArgs e)
        {           
            BtnIngresar.BackColor = Color.LightGray;
            BtnIngresar.FlatStyle = FlatStyle.Flat;
            BtnIngresar.FlatAppearance.BorderColor = Color.Gold;
            BtnIngresar.FlatAppearance.BorderSize = 1;

            BtnSalir.BackColor = Color.LightGray;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.FlatAppearance.BorderColor = Color.Gold;
            BtnSalir.FlatAppearance.BorderSize = 1;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            try
            {              
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                U._Usuario = TxtUsuario.Text;
                U._Contraseña = ClsGeneral.Encriptar(TxtContraseña.Text);
                ClsGeneral.Usuario = TxtUsuario.Text;

                if (TxtUsuario.Text == "" || TxtContraseña.Text == "")
                {
                    MessageBox.Show("Debe ingresar todos los datos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    TxtUsuario.Clear();
                    TxtContraseña.Clear();
                    TxtUsuario.Focus();
                }
                else
                {
                    U.Validar();

                    if (U._Nombre == "" || U._Nombre == null)
                    {
                        MessageBox.Show("El usuario o la contraseña son incorrectos o no existen en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        TxtUsuario.Clear();
                        TxtContraseña.Clear();
                        TxtUsuario.Focus();
                    }
                    else if (U._Nombre != "")
                    {
                        IS._Fecha = DateTime.Now;
                        IS._Tipo = true;
                        IS._IDUsuario = U._ID;
                        IS.Insertar();
                        FrmMenu Menu = new FrmMenu();
                        ClsGeneral.Nombre = U._Nombre;
                        Menu.LblUsuario.Text = Menu.LblUsuario.Text + U._Nombre;
                        ClsGeneral.IDUsuario = U._ID;
                        ClsGeneral.IDRol = U._IDRol;
                        this.Hide();
                        Menu.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Error relacionado con la red"))
                {
                    MessageBox.Show("Error al iniciar el sistema, por favor valide que el servidor esta encendido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        #endregion
    }
}