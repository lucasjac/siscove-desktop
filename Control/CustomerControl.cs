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
    public class CustomerControl
    {
        PersonDAO newCustomerDAO = new PersonDAO();

        public DataTable List(string condition)
        {
            return newCustomerDAO.List(condition);
        }

        public void Save(Person c)
        {
            newCustomerDAO.Save(c);
        }

        public void Modify(Person c)
        {
            newCustomerDAO.Modify(c);
        }

        public void Delete(int id)
        {
            newCustomerDAO.Delete(id);
        }
    }
}
