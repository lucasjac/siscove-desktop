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
    public class DistributorControl
    {
        PersonDAO newDistributorDAO = new PersonDAO();

        public DataTable List(string condition)
        {
            return newDistributorDAO.List(condition);
        }

        public void Save(Person d)
        {
            newDistributorDAO.Save(d);
        }

        public void Modify(Person d)
        {
            newDistributorDAO.Modify(d);
        }

        public void Delete(int id)
        {
            newDistributorDAO.Delete(id);
        }
    }
}
