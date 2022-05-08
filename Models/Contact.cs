using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Contact
    {
        private int id;
        private int idPerson;
        private String description;

        public Contact(int id, int idPerson, String description)
        {
            this.id = id;
            this.idPerson = idPerson;
            this.description = description;
        }

        public Contact(int idPerson, String description)
        {
            this.idPerson = idPerson;
            this.description = description;
        }

        public Contact(int id)
        {
            this.id = id;
        }

        public Contact()
        {

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int IdPerson
        {
            get { return idPerson; }
            set { idPerson = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
