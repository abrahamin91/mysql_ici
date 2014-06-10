using MySql.Data.MySqlClient;
using System.Data; 

namespace ProyectoBarajas
{
    class ConnectionMySQL
    {
        private string cadena;
        private MySqlConnection cnn;
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        private DataTable tabla;
        private string error;

        public string Error
        {
            get { return error; }
            set { error = value; }
        }

        public DataTable Tabla
        {
            get { return tabla; }
            set { tabla = value; }
        }

        public ConnectionMySQL() 
        {
            cadena = "Server=localhost; database=control_alumnos; pwd=admin; uid=root";
        }
        private bool abrir() {
            try
            {
                cnn = new MySqlConnection(cadena);
                if (cnn.State == System.Data.ConnectionState.Closed)
                {
                    cnn.Open();
                    return true;
                }
            }
            catch
            {
            }
            return false;
        }
        private bool cerrar() {
            if (cnn.State == System.Data.ConnectionState.Open)
            {
                cnn.Close();
                return true;
            }
            return false;
        }
        public bool leerTabla(string nombreSP)
        {
            try
            {
                abrir();
                cmd = new MySqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = nombreSP;
                cmd.CommandType = CommandType.StoredProcedure;
                da = new MySqlDataAdapter(cmd);
                tabla = new DataTable();
                da.Fill(tabla);
                return true;
            }
            catch(MySqlException ex)
            {
                error = ex.Message;
                return false;
            }
        }
        public bool EjecutarStoredProcedure(string nombreSP, Parametros[] datos)
        {
            try
            {
                abrir();
                cmd = new MySqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = nombreSP;
                cmd.CommandType = CommandType.StoredProcedure;
                for(int i=0; i <datos.Length; i++){
                    cmd.Parameters.AddWithValue(datos[i].Nom, datos[i].Valor);
                }
                da = new MySqlDataAdapter(cmd);
                tabla = new DataTable();
                da.Fill(tabla);
                return true;
            }
            catch (MySqlException ex)
            {
                error = ex.Message;
                return false;
            }
        }
        
      
    }
}
