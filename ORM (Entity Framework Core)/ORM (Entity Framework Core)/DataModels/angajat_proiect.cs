using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ORM__Entity_Framework_Core_.DataModels
{
    public partial class angajat_proiect
    {
        [Key, Column(Order = 0)]
        public int id_angajat { get; set; }
        [Key, Column(Order = 1)]
        public int id_proiect { get; set; }


        public decimal nr_ore_saptamana { get; set; }
        public Nullable<System.DateTime> data_adaugare { get; set; }
        public Nullable<System.DateTime> data_modificare { get; set; }

        public virtual angajat angajat { get; set; }
        public virtual proiect proiect { get; set; }
    }
}
