using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Price
    {
        private int id;
        private int idProduct;
        private decimal price;
        private int quantity;

        public Price(int id, int idProduct, decimal price, int quantity)
        {
            this.id = id;
            this.idProduct = idProduct;
            this.price = price;
            this.quantity = quantity;
        }

        public Price(int idProduct, decimal price, int quantity)
        {
            this.idProduct = idProduct;
            this.price = price;
            this.quantity = quantity;
        }

        public Price(int id)
        {
            this.id = id;
        }

        public Price()
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

        public decimal PriceValue
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
