using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace BaseDatos
{
    public class Conexiones
    {
        public static SqlConnection StrConectar = new SqlConnection(ConfigurationManager.ConnectionStrings["StrCon"].ConnectionString);
        public static SqlConnection ConBase(bool Estado)
        {

            if (Estado)
            {
                StrConectar.Open();
            }
            else
            {
                StrConectar.Close();
            }

            return StrConectar;
        }


        #region Metodos ClsUsuarios
        public DataTable ListarUsuariosCombo()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Usu_P_ListarUsuariosCombo", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                ConBase(false);
                return table;

            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }
        public DataTable ListarUsuarios()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Usu_P_ListarUsuarios", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                ConBase(false);
                return table;
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }
        public int InsertarUsuarios(string Usuario, string Contraseña, string Nombre,
            int IDRol, string Descripcion)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Usu_P_InsertarUsuarios", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cmd.Parameters.AddWithValue("@Contraseña", Contraseña);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                cmd.Parameters.AddWithValue("@IDRol", IDRol);
                

                var IDtabla = cmd.Parameters.Add("@ID", SqlDbType.Int);
                IDtabla.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                ConBase(false);

                int ID = (int)IDtabla.Value;

                return ID;
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }

        public void ActualizarUsuarios(int ID, string Usuario, string Contraseña, string Nombre,
            int IDRol,string Descripcion)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Usu_P_ActualizarUsuarios", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cmd.Parameters.AddWithValue("@Contraseña", Contraseña);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@IDRol", IDRol);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);

                cmd.ExecuteNonQuery();
                ConBase(false);
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }

        public void EliminarUsuarios(int ID)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Usu_P_EliminarUsuarios", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", ID);

                cmd.ExecuteNonQuery();
                ConBase(false);
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }

        public DataTable ValidaUsuarios(string Usuario, string Contraseña)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Usu_P_ValidaUsuarios", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cmd.Parameters.AddWithValue("@Contraseña", Contraseña);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                ConBase(false);
                return table;

            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }

        }
        #endregion

        #region Metodos ClsRoles
        public DataTable ListarRolesCombo()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Rol_P_ListarRolesCombo", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                ConBase(false);
                return table;

            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }

        public DataTable ListarRoles()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Rol_P_ListarRoles", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                ConBase(false);
                return table;
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }
        public int InsertarRoles(string Nombre, string Descripcion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Rol_P_InsertarRoles", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);

                var IDtabla = cmd.Parameters.Add("@ID", SqlDbType.Int);
                IDtabla.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                ConBase(false);

                int ID = (int)IDtabla.Value;

                return ID;
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }

        public void ActualizarRoles(int ID, string Nombre, string Descripcion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Rol_P_ActualizarRoles", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);

                cmd.ExecuteNonQuery();
                ConBase(false);
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }

        public void EliminarRoles(int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Rol_P_EliminarRoles", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", ID);

                cmd.ExecuteNonQuery();
                ConBase(false);
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }
        #endregion

        #region Metodos ClsPermisos
        public void InsertarPermisos(int IDRol,string NombrePermiso)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Per_P_InsertarPermisos", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IDRol", IDRol);
                cmd.Parameters.AddWithValue("@NombrePermiso", NombrePermiso);

                cmd.ExecuteNonQuery();
                ConBase(false);
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }

        public DataTable ListarPermisos(int IDRol)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Per_P_ListarPermisos", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IDRol", IDRol);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                ConBase(false);
                return table;
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }

        public void EliminarPermisos(int IDRol)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Per_P_EliminarPermisos", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IDRol", IDRol);

                cmd.ExecuteNonQuery();
                ConBase(false);
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }
        #endregion

        #region Metodos ClsClientes
        public DataTable ConsultarEstadoClientes(int ID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Cli_P_ConsultarEstado", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", ID);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                ConBase(false);
                return table;

            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }
        public DataTable ListarClientesCombo()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Cli_P_ListarClientesCombo", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                ConBase(false);
                return table;

            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }
        public DataTable ListarClientes()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Cli_P_ListarClientes", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                ConBase(false);
                return table;
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }
        public int InsertarClientes(string Nombre, string PrimerApellido, string SegundoApellido, string Telefono, string Correo, 
            DateTime FechaIngreso, decimal Peso, decimal Estatura, string Horario, int IDUsuario)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Cli_P_InsertarClientes", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@PrimerApellido", PrimerApellido);
                cmd.Parameters.AddWithValue("@SegundoApellido", SegundoApellido);
                cmd.Parameters.AddWithValue("@Telefono", Telefono);
                cmd.Parameters.AddWithValue("@Correo", Correo);
                cmd.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
                cmd.Parameters.AddWithValue("@Peso", Peso);
                cmd.Parameters.AddWithValue("@Estatura", Estatura);
                cmd.Parameters.AddWithValue("@Horario", Horario);
                cmd.Parameters.AddWithValue("@IDUsuario", IDUsuario);

                var IDtabla = cmd.Parameters.Add("@ID", SqlDbType.Int);
                IDtabla.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                ConBase(false);

                int ID = (int)IDtabla.Value;

                return ID;
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }

        public void ActualizarClientes(int ID, string Nombre, string PrimerApellido, string SegundoApellido, string Telefono, string Correo,
            DateTime FechaIngreso, decimal Peso, decimal Estatura, string Horario)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Cli_P_ActualizarClientes", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@PrimerApellido", PrimerApellido);
                cmd.Parameters.AddWithValue("@SegundoApellido", SegundoApellido);
                cmd.Parameters.AddWithValue("@Telefono", Telefono);
                cmd.Parameters.AddWithValue("@Correo", Correo);
                cmd.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
                cmd.Parameters.AddWithValue("@Peso", Peso);
                cmd.Parameters.AddWithValue("@Estatura", Estatura);
                cmd.Parameters.AddWithValue("@Horario", Horario);

                cmd.ExecuteNonQuery();
                ConBase(false);
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }

        public void EliminarClientes(int ID)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Cli_P_EliminarClientes", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", ID);

                cmd.ExecuteNonQuery();
                ConBase(false);
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }
        #endregion

        #region Metodos ClsRutinas
        public DataTable GenerarReporteRutinas(DateTime FechaDesde, DateTime FechaHasta)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Rut_P_GenerarReporte", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaDesde", FechaDesde);
                cmd.Parameters.AddWithValue("@FechaHasta", FechaHasta);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                ConBase(false);
                return table;
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }
        public DataTable ListarRutinas()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Rut_P_ListarRutinas", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                ConBase(false);
                return table;
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }
        public int InsertarRutinas(DateTime Fecha, string Rutina,
            byte[] Imagen, string CalentaMujeres, string Trabajo1Mujeres, string Trabajo2Mujeres,
                string Trabajo3Mujeres, string CalentaHombres, string Trabajo1Hombres,
                string Trabajo2Hombres, string Trabajo3Hombres, int IDUsuario)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Rut_P_InsertarRutinas", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Fecha", Fecha);
                cmd.Parameters.AddWithValue("@Rutina", Rutina);
                if (Imagen == null)
                {
                    cmd.Parameters.Add("@Imagen",SqlDbType.Image).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Imagen", Imagen);
                }
                cmd.Parameters.AddWithValue("@CalentaMujeres", CalentaMujeres);
                cmd.Parameters.AddWithValue("@Trabajo1Mujeres", Trabajo1Mujeres);
                cmd.Parameters.AddWithValue("@Trabajo2Mujeres", Trabajo2Mujeres);
                cmd.Parameters.AddWithValue("@Trabajo3Mujeres", Trabajo3Mujeres);
                cmd.Parameters.AddWithValue("@CalentaHombres", CalentaHombres);
                cmd.Parameters.AddWithValue("@Trabajo1Hombres", Trabajo1Hombres);
                cmd.Parameters.AddWithValue("@Trabajo2Hombres", Trabajo2Hombres);
                cmd.Parameters.AddWithValue("@Trabajo3Hombres", Trabajo3Hombres);
                cmd.Parameters.AddWithValue("@IDUsuario", IDUsuario);

                var IDtabla = cmd.Parameters.Add("@ID", SqlDbType.Int);
                IDtabla.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                ConBase(false);

                int ID = (int)IDtabla.Value;

                return ID;
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }

        public void ActualizarRutinas(int ID, DateTime Fecha, string Rutina,
            byte[] Imagen, string CalentaMujeres, string Trabajo1Mujeres, string Trabajo2Mujeres,
                string Trabajo3Mujeres, string CalentaHombres, string Trabajo1Hombres,
                string Trabajo2Hombres, string Trabajo3Hombres, int IDUsuario)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Rut_P_ActualizarRutinas", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Fecha", Fecha);
                cmd.Parameters.AddWithValue("@Rutina", Rutina);
                if (Imagen == null)
                {
                    cmd.Parameters.Add("@Imagen", SqlDbType.Image).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Imagen", Imagen);
                }
                cmd.Parameters.AddWithValue("@CalentaMujeres", CalentaMujeres);
                cmd.Parameters.AddWithValue("@Trabajo1Mujeres", Trabajo1Mujeres);
                cmd.Parameters.AddWithValue("@Trabajo2Mujeres", Trabajo2Mujeres);
                cmd.Parameters.AddWithValue("@Trabajo3Mujeres", Trabajo3Mujeres);
                cmd.Parameters.AddWithValue("@CalentaHombres", CalentaHombres);
                cmd.Parameters.AddWithValue("@Trabajo1Hombres", Trabajo1Hombres);
                cmd.Parameters.AddWithValue("@Trabajo2Hombres", Trabajo2Hombres);
                cmd.Parameters.AddWithValue("@Trabajo3Hombres", Trabajo3Hombres);
                cmd.Parameters.AddWithValue("@IDUsuario", IDUsuario);

                cmd.ExecuteNonQuery();
                ConBase(false);
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }

        public void EliminarRutinas(int ID)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Rut_P_EliminarRutinas", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", ID);

                cmd.ExecuteNonQuery();
                ConBase(false);
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }
        #endregion

        #region Metodos ClsMensualidades
        public DataTable GenerarReporteMensualidades(DateTime FechaDesde, DateTime FechaHasta,
            int IDFormaPago, int IDCliente)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Men_P_GenerarReporte", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaDesde", FechaDesde);
                cmd.Parameters.AddWithValue("@FechaHasta", FechaHasta);
                cmd.Parameters.AddWithValue("@IDFormaPago", IDFormaPago);
                cmd.Parameters.AddWithValue("@IDCliente", IDCliente);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                ConBase(false);
                return table;
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }

        public DataTable ListarMensualidades()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Men_P_ListarMensualidades", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                ConBase(false);
                return table;
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }
        public int InsertarMensualidades(int IDCliente, DateTime Fecha,
            DateTime FechaVencimiento,decimal Monto, int IDUsuario, int IDFormaPago)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Men_P_InsertarMensualidades", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IDCliente", IDCliente);
                cmd.Parameters.AddWithValue("@Fecha", Fecha);
                cmd.Parameters.AddWithValue("@FechaVencimiento", FechaVencimiento);
                cmd.Parameters.AddWithValue("@Monto", Monto);
                cmd.Parameters.AddWithValue("@IDUsuario", IDUsuario);
                cmd.Parameters.AddWithValue("@IDFormaPago", IDFormaPago);

                var IDtabla = cmd.Parameters.Add("@ID", SqlDbType.Int);
                IDtabla.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                ConBase(false);

                int ID = (int)IDtabla.Value;

                return ID;
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }

        public void ActualizarMensualidades(int ID, int IDCliente, DateTime Fecha,
            DateTime FechaVencimiento,decimal Monto, int IDUsuario, int IDFormaPago)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Men_P_ActualizarMensualidades", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@IDCliente", IDCliente);
                cmd.Parameters.AddWithValue("@Fecha", Fecha);
                cmd.Parameters.AddWithValue("@FechaVencimiento", FechaVencimiento);
                cmd.Parameters.AddWithValue("@Monto", Monto);
                cmd.Parameters.AddWithValue("@IDUsuario", IDUsuario);
                cmd.Parameters.AddWithValue("@IDFormaPago", IDFormaPago);

                cmd.ExecuteNonQuery();
                ConBase(false);
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }

        public void EliminarMensualidades(int ID)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Men_P_EliminarMensualidades", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", ID);

                cmd.ExecuteNonQuery();
                ConBase(false);
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }
        #endregion

        #region Metodos ClsIngresosGastos
        public DataTable GenerarReporteIngresosGastosDetalle(DateTime FechaDesde, DateTime FechaHasta,
            int IDFormaPago)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("InG_P_GenerarReporteDetalle", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaDesde", FechaDesde);
                cmd.Parameters.AddWithValue("@FechaHasta", FechaHasta);
                cmd.Parameters.AddWithValue("@IDFormaPago", IDFormaPago);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                ConBase(false);
                return table;
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }

        public DataTable GenerarReporteIngresosGastosTotales(DateTime FechaDesde, DateTime FechaHasta,
            int IDFormaPago)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("InG_P_GenerarReporteTotales", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaDesde", FechaDesde);
                cmd.Parameters.AddWithValue("@FechaHasta", FechaHasta);
                cmd.Parameters.AddWithValue("@IDFormaPago", IDFormaPago);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                ConBase(false);
                return table;
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }
        public DataTable ListarIngresosGastos()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("InG_P_ListarIngresosGastos", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                ConBase(false);
                return table;
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }
        public int InsertarIngresosGastos(decimal Monto, string Descripcion,
            DateTime Fecha, bool Tipo, int IDUsuario,int IDFormaPago, int IDMensualidad)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("InG_P_InsertarIngresosGastos", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Monto", Monto);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                cmd.Parameters.AddWithValue("@Fecha", Fecha);
                cmd.Parameters.AddWithValue("@Tipo", Tipo);
                cmd.Parameters.AddWithValue("@IDUsuario", IDUsuario);
                cmd.Parameters.AddWithValue("@IDFormaPago", IDFormaPago);
                cmd.Parameters.AddWithValue("@IDMensualidad", IDMensualidad);

                var IDtabla = cmd.Parameters.Add("@ID", SqlDbType.Int);
                IDtabla.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                ConBase(false);

                int ID = (int)IDtabla.Value;

                return ID;
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }

        public void ActualizarIngresosGastos(int ID, decimal Monto, string Descripcion,
            DateTime Fecha, bool Tipo, int IDUsuario, int IDFormaPago)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("InG_P_ActualizarIngresosGastos", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Monto", Monto);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                cmd.Parameters.AddWithValue("@Fecha", Fecha);
                cmd.Parameters.AddWithValue("@Tipo", Tipo);
                cmd.Parameters.AddWithValue("@IDUsuario", IDUsuario);
                cmd.Parameters.AddWithValue("@IDFormaPago", IDFormaPago);

                cmd.ExecuteNonQuery();
                ConBase(false);
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }

        public void EliminarIngresosGastos(int ID)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("InG_P_EliminarIngresosGastos", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", ID);

                cmd.ExecuteNonQuery();
                ConBase(false);
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }
        #endregion

        #region Metodos ClsBitIngresosSalidas
        public DataTable GenerarReporteBitIngresosSalidas(DateTime FechaDesde, DateTime FechaHasta, int IDUsuario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Bit_P_GenerarReporteBitIngresosSalidas", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaDesde", FechaDesde);
                cmd.Parameters.AddWithValue("@FechaHasta", FechaHasta);
                cmd.Parameters.AddWithValue("@IDUsuario", IDUsuario);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                ConBase(false);
                return table;
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }

        public DataTable ListarBitIngresosSalidas(int Usuario,
            DateTime FechaDesde, DateTime FechaHasta)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Bit_P_ListarBitIngresosSalidas", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cmd.Parameters.AddWithValue("@FechaDesde", FechaDesde);
                cmd.Parameters.AddWithValue("@FechaHasta", FechaHasta);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                ConBase(false);
                return table;
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }
        public void InsertarBitIngresosSalidas(DateTime Fecha, bool Tipo, int IDUsuario)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Bit_P_InsertarBitIngresosSalidas", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Fecha", Fecha);
                cmd.Parameters.AddWithValue("@Tipo", Tipo);
                cmd.Parameters.AddWithValue("@IDUsuario", IDUsuario);

                cmd.ExecuteNonQuery();
                ConBase(false);
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }
        #endregion

        #region Metodos ClsBitMovimientos
        public DataTable GenerarReporteBitMovimientos(DateTime FechaDesde, DateTime FechaHasta, int IDUsuario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Bit_P_GenerarReporteBitMovimientos", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaDesde", FechaDesde);
                cmd.Parameters.AddWithValue("@FechaHasta", FechaHasta);
                cmd.Parameters.AddWithValue("@IDUsuario", IDUsuario);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                ConBase(false);
                return table;
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }

        public DataTable ListarBitMovimientos(int Usuario, int IDMovimiento,
            DateTime FechaDesde, DateTime FechaHasta)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Bit_P_ListarBitMovimientos", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cmd.Parameters.AddWithValue("@IDMovimiento", IDMovimiento);
                cmd.Parameters.AddWithValue("@FechaDesde", FechaDesde);
                cmd.Parameters.AddWithValue("@FechaHasta", FechaHasta);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                ConBase(false);
                return table;
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }
        public void InsertarBitMovimientos(DateTime Fecha, 
            int IDUsuario, int IDMovimiento, string Detalle)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Bit_P_InsertarBitMovimientos", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Fecha", Fecha);        
                cmd.Parameters.AddWithValue("@IDUsuario", IDUsuario);
                cmd.Parameters.AddWithValue("@IDMovimiento", IDMovimiento);
                cmd.Parameters.AddWithValue("@Detalle", Detalle);

                cmd.ExecuteNonQuery();
                ConBase(false);
            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }
        #endregion

        #region Metodos ClsFormaPago
        public DataTable ListarFormaPagoCombo()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("For_P_ListarFormaPagoCombo", ConBase(true));
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                ConBase(false);
                return table;

            }
            catch (Exception)
            {
                ConBase(false);
                throw;
            }
        }
        #endregion

    }
}
