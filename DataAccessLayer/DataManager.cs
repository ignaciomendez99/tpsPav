using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS_PAV.DataAccessLayer
{
    class DataManager
    {
        private SqlConnection dbConnection;
        private SqlTransaction dbTransaction;


        private static DataManager instance;
        private DataManager()
        {
            dbConnection = new SqlConnection();
            // En los recursos de TPS PAV fue definido el connection string
            var string_conexion = Properties.Resources.ConnectionStringRes;
            dbConnection.ConnectionString = string_conexion;
        }

        public static DataManager GetInstance()
        {
            if (instance == null)
                instance = new DataManager();

            instance.Open();

            return instance;
        }

        public void Open()
        {
            if (dbConnection.State != ConnectionState.Open)
                dbConnection.Open();
        }

        public void Close()
        {
            if (dbConnection.State != ConnectionState.Closed)
                dbConnection.Close();
        }


        public DataTable ConsultaSQL(string strSql, Dictionary<string, object> prs = null)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            try
            {
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;

                if (prs != null)
                {
                    foreach (var item in prs)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }

                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int EjecutarSQL(string strSql, Dictionary<string, object> prs = null)
        {

            SqlCommand cmd = new SqlCommand();

            int rtdo = 0;

            try
            {
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;

                //Agregamos a la colección de parámetros del comando los filtros recibidos
                if (prs != null)
                {
                    foreach (var item in prs)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }

                // Retorna el resultado de ejecutar el comando
                rtdo = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rtdo;
        }


        /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Select”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un valor entero
        /// Excepciones:
        ///      System.Data.SqlClient.SqlException:
        ///          El error de conexión se produce:
        ///              a) durante la apertura de la conexión
        ///              b) durante la ejecución del comando.
        public object ConsultaSQLScalar(string strSql, Dictionary<string, object> prs = null)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;

                if (prs != null)
                {
                    foreach (var item in prs)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }

                return cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
        }

        // Begin transaction
        public void BeginTransaction()
        {
            if (dbConnection.State == ConnectionState.Open)
                dbTransaction = dbConnection.BeginTransaction();
        }

        public void Commit()
        {
            if (dbTransaction != null)
                dbTransaction.Commit();
        }

        public void Rollback()
        {
            if (dbTransaction != null)
                dbTransaction.Rollback();
        }

        public void Dispose()
        {
            this.Close();
        }


    }
}
