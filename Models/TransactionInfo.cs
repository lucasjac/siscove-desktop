using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TransactionInfo
    {
        private int id;
        private int idPerson;
        private string date;

        public TransactionInfo(int id, int idPerson, String date)
        {
            this.id = id;
            this.idPerson = idPerson;
            this.date = date;
        }

        public TransactionInfo(int id)
        {
            this.id = id;
        }

        public TransactionInfo()
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

        public String Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
