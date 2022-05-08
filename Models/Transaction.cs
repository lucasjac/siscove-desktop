using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Transaction
    {
        private int id;
        private int idInfo;
        private int idProduct;
        private decimal price;
        private int quantity;
        private byte invoice;

        public Transaction(int id, int idInfo, int idProduct, decimal price, int quantity, byte invoice)
        {
            this.id = id;
            this.idInfo = idInfo;
            this.idProduct = idProduct;
            this.price = price;
            this.quantity = quantity;
            this.invoice = invoice;
        }

        public Transaction(int idInfo, int idProduct, decimal price, int quantity, byte invoice)
        {
            this.idInfo = idInfo;
            this.idProduct = idProduct;
            this.price = price;
            this.quantity = quantity;
            this.invoice = invoice;
        }

        public Transaction(int id)
        {
            this.id = id;
        }

        public Transaction()
        {

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int IdInfo
        {
            get { return idInfo; }
            set { idInfo = value; }
        }

        public int IdProduct
        {
            get { return idProduct; }
            set { idProduct = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public byte Invoice
        {
            get { return invoice; }
            set { invoice = value; }
        }
    }
}
