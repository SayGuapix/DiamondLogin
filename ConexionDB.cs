using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;

namespace DIAMOND
{
    public class ConexionDB
    {
        public static SQLiteConnection ObtenerConexion()
        {
            string rutaBaseDeDatos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DB_usuarios.db");
            SQLiteConnection conexion = new SQLiteConnection($"Data Source={rutaBaseDeDatos}; Version=3;");

            conexion.Open();
            return conexion;
        }

        public static bool RegistrarUsuario(string usuario, string correo, string curso, string contraseña)
        {
            try
            {
                using (var conexion = ObtenerConexion())
                {
                    string query = "INSERT INTO tbl_user (Usuario, Correo, Curso, Contraseña) VALUES (@Usuario, @Correo, @Curso, @Contraseña)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Curso", curso);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                if (ex.ResultCode == SQLiteErrorCode.Constraint)
                {
                    MessageBox.Show("El usuario ya está registrado.");
                }
                else
                {
                    MessageBox.Show("Error al registrar el usuario: " + ex.Message);
                }
                return false;
            }
        }

        private static int intentosFallidos = 0;
        private const int maxIntentos = 3;
        private const int tiempoEspera = 30; 
        private static DateTime tiempoBloqueo;

        public static bool IniciarSesion(string usuario, string contraseña)
        {
            if (intentosFallidos >= maxIntentos)
            {
                if ((DateTime.Now - tiempoBloqueo).TotalSeconds < tiempoEspera)
                {
                    MessageBox.Show("Estás bloqueado. Espera " + ((int)(tiempoEspera - (DateTime.Now - tiempoBloqueo).TotalSeconds)) + " segundos.");
                    return false;
                }
                else
                {
                    intentosFallidos = 0;
                }
            }

            try
            {
                using (var conexion = ObtenerConexion())
                {
                    string query = "SELECT Contraseña FROM tbl_user WHERE Usuario = @Usuario";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    var resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        string contraseñaAlmacenada = resultado.ToString();

                        if (contraseña == contraseñaAlmacenada)
                        {
                            intentosFallidos = 0; 
                            return true;
                        }
                        else
                        {
                            intentosFallidos++;
                            if (intentosFallidos >= maxIntentos)
                            {
                                tiempoBloqueo = DateTime.Now; 
                                MessageBox.Show("Has alcanzado el máximo de intentos permitidos.");
                            }
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
                return false;
            }
        }
        public static (string Usuario, string Correo, string Curso) ObtenerDatosUsuario(string usuario)
        {
            try
            {
                using (var conexion = ObtenerConexion())
                {
                    string query = "SELECT Correo, Curso FROM tbl_user WHERE Usuario = @Usuario";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@Usuario", usuario);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string correo = reader["Correo"].ToString();
                            string curso = reader["Curso"].ToString();
                            return (usuario, correo, curso);
                        }
                        else
                        {
                            return (null, null, null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos del usuario: " + ex.Message);
                return (null, null, null);
            }
        }
    }
}
