using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataAccess
{
    public class PurchaseDAO
    {
        SqlCommand commandSql = new SqlCommand();
        StringBuilder sql;
        DataTable newDataTable = new DataTable();

        public void SaveInfo(TransactionInfo si)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("INSERT INTO SALE_INFO (FK_ID_PERSON, date) ");
                    sql.Append("VALUES (@IDPERSON, @DATE)");

                    commandSql.Parameters.Add(new SqlParameter("@IDPERSON", si.IdPerson));
                    commandSql.Parameters.Add(new SqlParameter("@DATE", si.Date));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    commandSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método SaveInfo. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }

        public void Save(Transaction s)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("INSERT INTO SALE (FK_ID_SALE_INFO, FK_ID_PRODUCT, price, quantity, invoice) ");
                    sql.Append("VALUES (@IDSALEINFO, @IDPRODUCT, @PRICE, @QUANTITY, @INVOICE)");

                    commandSql.Parameters.Add(new SqlParameter("@IDSALEINFO", s.IdInfo));
                    commandSql.Parameters.Add(new SqlParameter("@IDPRODUCT", s.IdProduct));
                    commandSql.Parameters.Add(new SqlParameter("@PRICE", s.Price));
                    commandSql.Parameters.Add(new SqlParameter("@QUANTITY", s.Quantity));
                    commandSql.Parameters.Add(new SqlParameter("@INVOICE", s.Invoice));

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

        public void ModifyInfo(TransactionInfo si)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("UPDATE SALE_INFO");
                    sql.Append(" SET FK_ID_PERSON = @IDPERSON, date = @DATE");
                    sql.Append(" WHERE (ID_SALE_INFO = @ID)");

                    commandSql.Parameters.Add(new SqlParameter("@ID", si.Id));
                    commandSql.Parameters.Add(new SqlParameter("@IDPERSON", si.IdPerson));
                    commandSql.Parameters.Add(new SqlParameter("@DATE", si.Date));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    commandSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método ModifyInfo. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }

        public void Modify(Transaction s)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("UPDATE SALE");
                    sql.Append(" SET FK_ID_SALE_INFO = @IDSALEINFO, FK_ID_PRODUCT = @IDPRODUCT, price = @PRICE, quantity = @QUANTITY, invoice = @INVOICE");
                    sql.Append(" WHERE (ID_SALE = @ID)");

                    commandSql.Parameters.Add(new SqlParameter("@ID", s.Id));
                    commandSql.Parameters.Add(new SqlParameter("@IDSALEINFO", s.IdInfo));
                    commandSql.Parameters.Add(new SqlParameter("@IDPRODUCT", s.IdProduct));
                    commandSql.Parameters.Add(new SqlParameter("@PRICE", s.Price));
                    commandSql.Parameters.Add(new SqlParameter("@QUANTITY", s.Quantity));
                    commandSql.Parameters.Add(new SqlParameter("@INVOICE", s.Invoice));

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

        public void DeleteInfo(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("DELETE FROM SALE_INFO");
                    sql.Append(" WHERE (ID_SALE_INFO = @ID)");

                    commandSql.Parameters.Add(new SqlParameter("@ID", id));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    commandSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método DeleteInfo. Si el problema persiste entre en contacto con el Administrador del Sistema."); ;
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
                    sql.Append("DELETE FROM SALE");
                    sql.Append(" WHERE (ID_SALE = @ID)");

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

        public DataTable ListInfo(string condition)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("SELECT TOP 1000 si.ID_SALE_INFO, si.FK_ID_PERSON, pe.name, si.date FROM SALE_INFO si " + condition);

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    newDataTable.Load(commandSql.ExecuteReader());
                    return newDataTable;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método ListInfo. Si el problema persiste entre en contacto con el Administrador del Sistema."); ;
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
                    sql.Append("SELECT TOP 1000 s.ID_SALE, s.FK_ID_SALE_INFO, s.FK_ID_PRODUCT, pro.description, s.price, s.quantity, s.invoice FROM SALE s " + condition);

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

        public int GetLastId()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("SELECT MAX(ID_SALE_INFO) FROM SALE_INFO");

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    newDataTable.Load(commandSql.ExecuteReader());
                    DataRow row = newDataTable.Rows[0];
                    return Convert.ToInt32(row[0]);
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método GetLastId. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }

        public int GetPrice(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    sql = new StringBuilder();
                    sql.Append("SELECT MAX(PRICE) FROM PURCHASE WHERE FK_ID_PRODUCT = @ID");

                    commandSql.Parameters.Add(new SqlParameter("@ID", id));

                    commandSql.CommandText = sql.ToString();
                    commandSql.Connection = connection;
                    newDataTable.Load(commandSql.ExecuteReader());
                    DataRow row = newDataTable.Rows[0];
                    int result = 0;
                    if (row[0].ToString() != "")
                    {
                        result = Convert.ToInt32(row[0]);
                    }
                    return result;
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrió un error en el método GetPrice. Si el problema persiste entre en contacto con el Administrador del Sistema.");
            }
        }
    }
}
