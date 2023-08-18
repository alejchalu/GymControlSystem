using System;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    internal static class ClsGeneral
    {
        #region Variables
        public static string Usuario = "";
        public static string Nombre = "";
        public static int IDUsuario = 0;
        public static int IDRol = 0;
        public const string RptRutinas = "WindowsFormsApp1.RptRutinas.rdlc";
        public const string RptMensualidades = "WindowsFormsApp1.RptMensualidades.rdlc";
        public const string RptIngresosGastos = "WindowsFormsApp1.RptIngresosGastos.rdlc";
        public const string RptBitMovimientos = "WindowsFormsApp1.RptBitMovimientos.rdlc";
        public const string RptBitIngresosSalidas = "WindowsFormsApp1.RptBitIngresosSalidas.rdlc";
        #endregion

        #region Metodos
        public static string Encriptar(string Contraseña)
        {
            byte[] bytes = System.Text.Encoding.Unicode.GetBytes(Contraseña);
            string encryptedString = Convert.ToBase64String(bytes);
            return encryptedString;
        }

        public static string DesEncriptar(string ContraseñaEncriptada)
        {
            byte[] bytes = Convert.FromBase64String(ContraseñaEncriptada);
            string decryptedString = System.Text.Encoding.Unicode.GetString(bytes);
            return decryptedString;
        }

        public static bool IsTextEncrypted(string text)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(text);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public static bool EsCorreoElectronicoValido(string correo)
        {
            // Patrón de expresión regular para validar el formato de correo electrónico
            string patronCorreoElectronico = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Validar el formato del correo electrónico usando la expresión regular
            if (Regex.IsMatch(correo, patronCorreoElectronico))
            {
                try
                {
                    // Intentar crear una nueva instancia de la clase MailAddress para validar aún más el correo electrónico
                    var direccionCorreo = new System.Net.Mail.MailAddress(correo);
                    return true;
                }
                catch (FormatException)
                {
                    // La dirección de correo electrónico no tiene un formato válido
                    return false;
                }
            }
            else
            {
                // El correo electrónico no coincide con el patrón de expresión regular
                return false;
            }
        }
        #endregion

    }
}
