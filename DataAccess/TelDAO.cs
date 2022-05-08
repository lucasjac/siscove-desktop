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
    public class TelDAO
    {
        SqlCommand commandSql = new SqlCommand();
        StringBuilder sql = new StringBuilder();
        DataTable newDataTable = new DataTable();

        public void Save(Contact t)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("INSERT INTO PERSON_INFO (FK_ID_PERSON, info)");
                    sql.Append("VALUES (@IDPERSON, @INFO)");

                    commandSql.Parameters.Add(new SqlParameter("@IDPERSON", t.IdPerson));
                    commandSql.Parameters.Add(new SqlParameter("@INFO", t.Description));

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

        public void Modify(Contact t)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("UPDATE PERSON_INFO");
                    sql.Append(" SET FK_ID_PERSON = @IDPERSON, info = @INFO");
                    sql.Append(" WHERE (ID_PERSON_INFO = @ID)");

                    commandSql.Parameters.Add(new SqlParameter("@ID", t.Id));
                    commandSql.Parameters.Add(new SqlParameter("@IDPERSON", t.IdPerson));
                    commandSql.Parameters.Add(new SqlParameter("@INFO", t.Description));

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
                    sql.Append("DELETE FROM PERSON_INFO");
                    sql.Append(" WHERE (ID_PERSON_INFO = @ID)");

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

        public DataTable List(String condition)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("SELECT TOP 100 * FROM PERSON_INFO " + condition + " ORDER BY ID_PERSON_INFO ASC");

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
