using System;
using System.Collections.Generic;
using System.Text;

namespace ORM__Entity_Framework_Core_.DataModels
{
    public partial class partenerAngajat
    {
        public int id { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public string sex { get; set; }
        public Nullable<int> id_angajat { get; set; }
        public Nullable<System.DateTime> data_adaugare { get; set; }
        public Nullable<System.DateTime> data_modificare { get; set; }

        public virtual angajat angajat { get; set; }
    }
}
