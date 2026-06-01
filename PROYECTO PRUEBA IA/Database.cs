using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PROYECTO_PRUEBA_IA
{
    public static class Database
    {
        public static string ConnectionString
        {
            get
            {
                try
                {
                    // Try environment variable first
                    var csEnv = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
                    if (!string.IsNullOrEmpty(csEnv)) return csEnv;
                    // Fallback: no connection string configured in code. Return empty.
                    return string.Empty;
                }
                catch
                {
                    return string.Empty;
                }
            }
        }

        public static int ExecuteScalarInt(string sql, params SqlParameter[] parameters)
        {
            try
            {
                using (var cn = new SqlConnection(ConnectionString))
                using (var cmd = new SqlCommand(sql, cn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    cn.Open();
                    var val = cmd.ExecuteScalar();
                    if (val == null || val == DBNull.Value) return 0;
                    return Convert.ToInt32(val);
                }
            }
            catch
            {
                return 0;
            }
        }

        public static DataTable ExecuteDataTable(string sql, params SqlParameter[] parameters)
        {
            var dt = new DataTable();
            try
            {
                using (var cn = new SqlConnection(ConnectionString))
                using (var cmd = new SqlCommand(sql, cn))
                using (var da = new SqlDataAdapter(cmd))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    da.Fill(dt);
                }
            }
            catch
            {
            }
            return dt;
        }
    }
}
