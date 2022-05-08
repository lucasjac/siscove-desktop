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
    public class UnityControl
    {
        UnityDAO newUnityDAO = new UnityDAO();
        Unity newUnity = new Unity();

        public DataTable List(string condition)
        {
            return newUnityDAO.List(condition);
        }

        public void Save(Unity u)
        {
            newUnityDAO.Save(u);
        }

        public void Modify(Unity u)
        {
            newUnityDAO.Modify(u);
        }

        public void Delete(int id)
        {
            newUnityDAO.Delete(id);
        }
    }
}
