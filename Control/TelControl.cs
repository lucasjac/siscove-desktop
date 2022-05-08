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
    public class TelControl
    {
        TelDAO newTelDAO = new TelDAO();

        public DataTable List(string condition)
        {
            return newTelDAO.List(condition);
        }

        public void Save(Contact t)
        {
            newTelDAO.Save(t);
        }

        public void Modify(Contact t)
        {
            newTelDAO.Modify(t);
        }

        public void Delete(int id)
        {
            newTelDAO.Delete(id);
        }
    }
}
