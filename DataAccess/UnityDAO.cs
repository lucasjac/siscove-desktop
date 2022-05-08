using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Models;

namespace DataAccess
{
    public class UnityDAO
    {
        SqlCommand commandSql = new SqlCommand();
        StringBuilder sql;
        DataTable newDataTable = new DataTable();

        public void Save(Unity u)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("INSERT INTO UNITY (name, quantity, state)");
                    sql.Append("VALUES (@NAME, @QUANTITY, @STATE)");

                    commandSql.Parameters.Add(new SqlParameter("@NAME", u.Name));
                    commandSql.Parameters.Add(new SqlParameter("@QUANTITY", u.Quantity));
                    commandSql.Parameters.Add(new SqlParameter("@STATE", u.State));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    commandSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método SAVE. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }

        public void Modify(Unity u)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("UPDATE UNITY");
                    sql.Append(" SET name = @NAME, quantity = @QUANTITY, state = @STATE");
                    sql.Append(" WHERE (ID_UNITY = @ID)");

                    commandSql.Parameters.Add(new SqlParameter("@ID", u.Id));
                    commandSql.Parameters.Add(new SqlParameter("@NAME", u.Name));
                    commandSql.Parameters.Add(new SqlParameter("@QUANTITY", u.Quantity));
                    commandSql.Parameters.Add(new SqlParameter("@STATE", u.State));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    commandSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método MODIFY. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("UPDATE UNITY");
                    sql.Append(" SET state = 'Discarded'");
                    sql.Append(" WHERE (ID_UNITY = @ID)");

                    commandSql.Parameters.Add(new SqlParameter("@ID", id));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    commandSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método DELETE. Si el problema persiste entre en contacto con el Administrador del Sistema."); ;
            }
        }

        public DataTable List(string condition)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("SELECT TOP 200 * FROM UNITY WHERE state = 'In Use' " + condition + " ORDER BY name ASC");

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    newDataTable.Load(commandSql.ExecuteReader());
                    return newDataTable;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método TOLIST. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }
    }
}
