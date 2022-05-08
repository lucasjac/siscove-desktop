using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Product
    {
        private int id;
        private String barcode;
        private String description;
        private int quantity;
        private String state;

        public Product(int id, String description, String barcode, int quantity, String state)
        {
            this.id = id;
            this.barcode = barcode;
            this.description = description;
            this.quantity = quantity;
            this.state = state;
        }

        public Product(String description, String barcode, int quantity, String state)
        {
            this.barcode = barcode;
            this.description = description;
            this.quantity = quantity;
            this.state = state;
        }

        public Product(int id)
        {
            this.id = id;
        }

        public Product()
        {

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public String State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
