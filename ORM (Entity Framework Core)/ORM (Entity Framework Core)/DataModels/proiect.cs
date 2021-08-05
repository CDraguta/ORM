using System;
using System.Collections.Generic;
using System.Text;

namespace ORM__Entity_Framework_Core_.DataModels
{
    public partial class proiect
    {
        public proiect()
        {
            this.angajat_proiect = new HashSet<angajat_proiect>();
        }

        public int id { get; set; }
        public int id_departament { get; set; }
        public string nume { get; set; }
        public string cod { get; set; }
        public Nullable<System.DateTime> data_incepere { get; set; }
        public Nullable<int> buget { get; set; }
        public Nullable<System.DateTime> termen_limita { get; set; }
        public Nullable<System.DateTime> data_adaugare { get; set; }
        public Nullable<System.DateTime> data_modificare { get; set; }

        public virtual ICollection<angajat_proiect> angajat_proiect { get; set; }
        public virtual departament departament { get; set; }
    }
}
