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
    public class ProductControl
    {
        ProductDAO newProductDAO = new ProductDAO();

        public DataTable List(string condition)
        {
            return newProductDAO.List(condition);
        }

        public String SearchQuantity(string condition)
        {
            return newProductDAO.SearchQuantity(condition);
        }

        public void Save(Product p)
        {
            newProductDAO.Save(p);
        }

        public void Modify(Product p)
        {
            newProductDAO.Modify(p);
        }

        public void ModifyQuantity(int Id, string condition)
        {
            newProductDAO.ModifyQuantity(Id, condition);
        }

        public void Delete(int id)
        {
            newProductDAO.Delete(id);
        }
    }
}
