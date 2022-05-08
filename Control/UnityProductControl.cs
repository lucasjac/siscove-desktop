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
    public class UnityProductControl
    {
        Unity_ProductDAO newUnityProductDAO = new Unity_ProductDAO();

        public DataTable List(string condition)
        {
            return newUnityProductDAO.List(condition);
        }

        public void Save(UnityProduct u)
        {
            newUnityProductDAO.Save(u);
        }

        public void Modify(UnityProduct u)
        {
            newUnityProductDAO.Modify(u);
        }

        public void Delete(int id)
        {
            newUnityProductDAO.Delete(id);
        }
    }
}
