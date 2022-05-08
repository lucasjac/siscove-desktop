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
    public class PersonDAO
    {
        SqlCommand commandSql = new SqlCommand();
        StringBuilder sql;
        DataTable newDataTable = new DataTable();

        public void Save(Person c)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("INSERT INTO PERSON (name, document, type, state) ");
                    sql.Append("VALUES (@NAME, @DOCUMENT, @TYPE, @STATE)");

                    commandSql.Parameters.Add(new SqlParameter("@NAME", c.Name));
                    commandSql.Parameters.Add(new SqlParameter("@DOCUMENT", c.Document));
                    commandSql.Parameters.Add(new SqlParameter("@TYPE", c.Type));
                    commandSql.Parameters.Add(new SqlParameter("@STATE", c.State));
                    
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

        public void Modify(Person c)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("UPDATE PERSON");
                    sql.Append(" SET name = @NAME, document = @DOCUMENT, type = @TYPE, state = @STATE");
                    sql.Append(" WHERE (ID_PERSON = @ID)");

                    commandSql.Parameters.Add(new SqlParameter("@ID", c.Id));
                    commandSql.Parameters.Add(new SqlParameter("@NAME", c.Name));
                    commandSql.Parameters.Add(new SqlParameter("@DOCUMENT", c.Document));
                    commandSql.Parameters.Add(new SqlParameter("@TYPE", c.Type));
                    commandSql.Parameters.Add(new SqlParameter("@STATE", c.State));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    commandSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método Modify. Si el problema persiste entre en contacto con el Administrador del Sistema.");
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
                    sql.Append("UPDATE PERSON");
                    sql.Append(" SET state = 'Discarded'");
                    sql.Append(" WHERE (ID_PERSON = @ID)");

                    commandSql.Parameters.Add(new SqlParameter("@ID", id));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    commandSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método Delete. Si el problema persiste entre en contacto con el Administrador del Sistema."); ;
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
                    sql.Append("SELECT TOP 200 * FROM PERSON WHERE state = 'In Use' " + condition + " ORDER BY name ASC");

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    newDataTable.Load(commandSql.ExecuteReader());
                    return newDataTable;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método List. Si el problema persiste entre en contacto con el Administrador del Sistema."); ;
            }
        }
    }
}
