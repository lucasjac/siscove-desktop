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
    public class PurchaseControl
    {
        PurchaseDAO newPurchaseDAO = new PurchaseDAO();

        public DataTable ListInfo(string condition)
        {
            return newPurchaseDAO.ListInfo(condition);
        }

        public DataTable List(string condition)
        {
            return newPurchaseDAO.List(condition);
        }

        public void SaveInfo(TransactionInfo si)
        {
            newPurchaseDAO.SaveInfo(si);
        }

        public void Save(Transaction s)
        {
            newPurchaseDAO.Save(s);
        }

        public void ModifyInfo(TransactionInfo si)
        {
            newPurchaseDAO.ModifyInfo(si);
        }

        public void Modify(Transaction s)
        {
            newPurchaseDAO.Modify(s);
        }

        public void DeleteInfo(int id)
        {
            newPurchaseDAO.DeleteInfo(id);
        }

        public void Delete(int id)
        {
            newPurchaseDAO.Delete(id);
        }

        public int GetLastId()
        {
            return newPurchaseDAO.GetLastId();
        }

        public int GetPrice(int id)
        {
            return newPurchaseDAO.GetPrice(id);
        }
    }
}
