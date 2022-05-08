using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Models;

namespace Control
{
    public class SaleControl
    {
        SaleDAO newSaleDAO = new SaleDAO();

        public DataTable ListInfo(string condition)
        {
            return newSaleDAO.ListInfo(condition);
        }

        public DataTable List(string condition)
        {
            return newSaleDAO.List(condition);
        }

        public void SaveInfo(TransactionInfo si)
        {
            newSaleDAO.SaveInfo(si);
        }

        public void Save(Transaction s)
        {
            newSaleDAO.Save(s);
        }

        public void ModifyInfo(TransactionInfo si)
        {
            newSaleDAO.ModifyInfo(si);
        }

        public void Modify(Transaction s)
        {
            newSaleDAO.Modify(s);
        }

        public void DeleteInfo(int id)
        {
            newSaleDAO.DeleteInfo(id);
        }

        public void Delete(int id)
        {
            newSaleDAO.Delete(id);
        }

        public int GetLastId()
        {
            return newSaleDAO.GetLastId();
        }
    }
}
