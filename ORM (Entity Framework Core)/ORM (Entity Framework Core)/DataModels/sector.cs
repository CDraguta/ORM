using System;
using System.Collections.Generic;
using System.Text;

namespace ORM__Entity_Framework_Core_.DataModels
{
    public partial class sector
    {
        public sector()
        {
            this.angajats = new HashSet<angajat>();
        }

        public int id { get; set; }
        public string denumire { get; set; }
        public Nullable<int> cod_postal { get; set; }
        public Nullable<System.DateTime> data_adaugare { get; set; }
        public Nullable<System.DateTime> data_modificare { get; set; }
        public virtual ICollection<angajat> angajats { get; set; }
    }
}
