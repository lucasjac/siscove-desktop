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
    public class Unity_ProductDAO
    {
        SqlCommand commandSql = new SqlCommand();
        StringBuilder sql;
        DataTable newDataTable = new DataTable();

        public void Save(UnityProduct u)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("INSERT INTO PRODUCT_UNITY (FK_ID_PRODUCT, FK_ID_UNITY)");
                    sql.Append("VALUES (@IDPRODUCT, @IDUNITY)");

                    commandSql.Parameters.Add(new SqlParameter("@IDPRODUCT", u.IdProduct));
                    commandSql.Parameters.Add(new SqlParameter("@IDUNITY", u.IdUnity));

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

        public void Modify(UnityProduct u)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("UPDATE PRODUCT_UNITY");
                    sql.Append(" SET FK_ID_PRODUCT = @IDPRODUCT, FK_ID_UNITY = @IDUNITY");
                    sql.Append(" WHERE (ID_PRODUCT_UNITY = @ID)");

                    commandSql.Parameters.Add(new SqlParameter("@ID", u.Id));
                    commandSql.Parameters.Add(new SqlParameter("@IDPRODUCT", u.IdProduct));
                    commandSql.Parameters.Add(new SqlParameter("@IDUNITY", u.IdUnity));

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
                    sql.Append("DELETE FROM PRODUCT_UNITY");
                    sql.Append(" WHERE (ID_PRODUCT_UNITY = @ID)");

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
                    sql.Append("SELECT TOP 200 up.ID_PRODUCT_UNITY, up.FK_ID_PRODUCT, up.FK_ID_UNITY, " + condition);

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
