using System;
using System.Collections.Generic;

namespace ORM__Entity_Framework_Core_.DataModels
{
    public partial class departament
    {
       
        public departament()
        {
            this.angajats = new HashSet<angajat>();
            this.proiects = new HashSet<proiect>();
        }

        public int id { get; set; }
        public string denumire { get; set; }
        public string cod { get; set; }
        public Nullable<System.DateTime> data_adaugare { get; set; }
        public Nullable<System.DateTime> data_modificare { get; set; }

        public virtual ICollection<angajat> angajats { get; set; }
        public virtual ICollection<proiect> proiects { get; set; }
    }
}

