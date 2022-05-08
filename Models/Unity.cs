using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Unity
    {
        private int id;
        private String name;
        private int quantity;
        private String state;

        public Unity(int id, String name, int quantity, string state)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.state = state;
        }

        public Unity(String name, int quantity, string state)
        {
            this.name = name;
            this.quantity = quantity;
            this.state = state;
        }

        public Unity(int id)
        {
            this.id = id;
        }

        public Unity()
        {

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
