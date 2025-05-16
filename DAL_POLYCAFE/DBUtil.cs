using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;



namespace DAL_POLYCAFE
{
    public class DBUtil
    {
        private static string connString = @"Data Source=PC-202212270109\SQLEXPRESS;Initial Catalog=SOF2052_PolyCafe;Integrated Security=True;Trust Server Certificate=True";

        public static SqlCommand GetCommand(string sql, List<object> args, CommandType cmdType)
        {
            var conn = new SqlConnection(connString);
            var cmd = new SqlCommand(sql, conn)
            {
                CommandType = cmdType
            };

            for (int i = 0; i < args.Count; i++)
            {
                cmd.Parameters.AddWithValue($"@{i}", args[i] ?? DBNull.Value);
            }

            return cmd;
        }

        public static void Update(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                using (var cmd = GetCommand(sql, args, cmdType))
                using (var transaction = conn.BeginTransaction())
                {
                    cmd.Transaction = transaction;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Lỗi: {ex.Message}");
                        throw;
                    }
                }
            }
        }

        public static SqlDataReader Query(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            var conn = new SqlConnection(connString);
            try
            {
                var cmd = GetCommand(sql, args, cmdType);
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine($"Lỗi: {ex.Message}");
                throw;
            }
        }

        public static T Value<T>(string sql, List<object> args, CommandType cmdType = CommandType.Text) where T : new()
        {
            try
            {
                SqlCommand cmd = GetCommand(sql, args, cmdType);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    T result = new T();
                    Type type = typeof(T);

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        string columnName = reader.GetName(i);
                        PropertyInfo propertyInfo = type.GetProperty(columnName);

                        if (propertyInfo != null && propertyInfo.CanWrite)
                        {
                            object value = reader.IsDBNull(i) ? null : reader.GetValue(i);
                            if (value != null)
                                propertyInfo.SetValue(result, Convert.ChangeType(value, propertyInfo.PropertyType));
                        }
                    }

                    return result;
                }

                return default;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
    

}
