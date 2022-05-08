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
    public class Price_SaleDAO
    {
        SqlCommand commandSql = new SqlCommand();
        StringBuilder sql;
        DataTable newDataTable = new DataTable();

        public void Save(Price p)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("INSERT INTO PRICE (FK_ID_PRODUCT, price, quantity)");
                    sql.Append("VALUES (@IDPRODUCT, @PRICE, @QUANTITY)");

                    commandSql.Parameters.Add(new SqlParameter("@IDPRODUCT", p.IdProduct));
                    commandSql.Parameters.Add(new SqlParameter("@PRICE", p.PriceValue));
                    commandSql.Parameters.Add(new SqlParameter("@QUANTITY", p.Quantity));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    commandSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método Save. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }

        public void Modify(Price p)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("UPDATE PRICE");
                    sql.Append(" SET FK_ID_PRODUCT = @IDPRODUCT, price = @PRICE, quantity = @QUANTITY");
                    sql.Append(" WHERE (ID_PRICE = @ID)");

                    commandSql.Parameters.Add(new SqlParameter("@ID", p.Id));
                    commandSql.Parameters.Add(new SqlParameter("@IDPRODUCT", p.IdProduct));
                    commandSql.Parameters.Add(new SqlParameter("@PRICE", p.PriceValue));
                    commandSql.Parameters.Add(new SqlParameter("@QUANTITY", p.Quantity));

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
                    sql.Append("DELETE FROM PRICE");
                    sql.Append(" WHERE (ID_PRICE = @ID)");

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
                    sql.Append("SELECT TOP 200 * FROM PRICE " + condition + " ORDER BY price ASC");

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    newDataTable.Load(commandSql.ExecuteReader());
                    return newDataTable;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método List. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }

        public String SearchId(string condition)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("SELECT MAX(ID_PRICE) FROM PRICE " + condition);

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    newDataTable.Load(commandSql.ExecuteReader());
                    DataRow row = newDataTable.Rows[0];
                    return row[0].ToString();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método SearchId. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }
    }
}
