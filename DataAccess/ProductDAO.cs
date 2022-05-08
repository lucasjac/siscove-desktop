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
    public class ProductDAO
    {
        SqlCommand commandSql = new SqlCommand();
        StringBuilder sql;
        DataTable newDataTable = new DataTable();

        public void Save(Product p)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("INSERT INTO PRODUCT (barcode, description, quantity, state)");
                    sql.Append("VALUES (@BARCODE, @DESCRIPTION, @QUANTITY, @STATE)");

                    commandSql.Parameters.Add(new SqlParameter("@BARCODE", p.Barcode));
                    commandSql.Parameters.Add(new SqlParameter("@DESCRIPTION", p.Description));
                    commandSql.Parameters.Add(new SqlParameter("@QUANTITY", p.Quantity));
                    commandSql.Parameters.Add(new SqlParameter("@STATE", p.State));

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

        public void Modify(Product p)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("UPDATE PRODUCT");
                    sql.Append(" SET barcode = @BARCODE, description = @DESCRIPTION, quantity = @QUANTITY, state = @STATE");
                    sql.Append(" WHERE (ID_PRODUCT = @ID)");

                    commandSql.Parameters.Add(new SqlParameter("@ID", p.Id));
                    commandSql.Parameters.Add(new SqlParameter("@BARCODE", p.Barcode));
                    commandSql.Parameters.Add(new SqlParameter("@DESCRIPTION", p.Description));
                    commandSql.Parameters.Add(new SqlParameter("@QUANTITY", p.Quantity));
                    commandSql.Parameters.Add(new SqlParameter("@STATE", p.State));

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

        public void ModifyQuantity(int Id, string condition)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("UPDATE PRODUCT");
                    sql.Append(" SET quantity = quantity " + condition + " WHERE (ID_PRODUCT = @ID)");

                    commandSql.Parameters.Add(new SqlParameter("@ID", Id));
                    
                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    commandSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método MODIFY QUANTITY. Si el problema persiste entre en contacto con el Administrador del Sistema.");
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
                    sql.Append("UPDATE PRODUCT");
                    sql.Append(" SET state = 'Discarded'");
                    sql.Append(" WHERE (ID_PRODUCT = @ID)");

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
                    sql.Append("SELECT * FROM PRODUCT WHERE state = 'In Use' " + condition + " ORDER BY description ASC");

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

        public String SearchQuantity(string condition)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("SELECT quantity FROM PRODUCT " + condition);

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    newDataTable.Load(commandSql.ExecuteReader());
                    DataRow row = newDataTable.Rows[0];
                    return row[0].ToString();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método SearchQuantity. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }
    }
}
