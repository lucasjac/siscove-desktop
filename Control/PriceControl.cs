using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Models;

namespace Control
{
    public class PriceControl
    {
        Price_SaleDAO newPrice_SaleDAO = new Price_SaleDAO();

        public DataTable List(string condition)
        {
            return newPrice_SaleDAO.List(condition);
        }

        public void Save(Price p)
        {
            newPrice_SaleDAO.Save(p);
        }

        public void Modify(Price p)
        {
            newPrice_SaleDAO.Modify(p);
        }

        public void Delete(int id)
        {
            newPrice_SaleDAO.Delete(id);
        }

        public String SearchId(string condition)
        {
            return newPrice_SaleDAO.SearchId(condition);
        }
    }
}
