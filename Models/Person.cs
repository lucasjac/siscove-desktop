using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Person
    {
        private int id;
        private String name;
        private String document;
        private String type;
        private String state;

        public Person(int id, String name, String document, String type, String state)
        {
            this.id = id;
            this.name = name;
            this.document = document;
            this.type = type;
            this.state = state;
        }

        public Person(String name, String document, String type, String state)
        {
            this.name = name;
            this.document = document;
            this.type = type;
            this.state = state;
        }

        public Person(int id)
        {
            this.id = id;
        }

        public Person()
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

        public string Document
        {
            get { return document; }
            set { document = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
