using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UnityProduct
    {
        private int id;
        private int idProduct;
        private int idUnity;

        public UnityProduct(int id, int idProduct, int idUnity)
        {
            this.id = id;
            this.idProduct = idProduct;
            this.idUnity = idUnity;
        }

        public UnityProduct(int id_product, int id_unity)
        {
            this.idProduct = id_product;
            this.idUnity = id_unity;
        }

        public UnityProduct(int id)
        {
            this.id = id;
        }

        public UnityProduct()
        {

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int IdProduct
        {
            get { return idProduct; }
            set { idProduct = value; }
        }

        public int IdUnity
        {
            get { return idUnity; }
            set { idUnity = value; }
        }
    }
}
