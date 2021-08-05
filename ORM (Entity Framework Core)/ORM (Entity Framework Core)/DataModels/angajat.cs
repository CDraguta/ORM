using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ORM__Entity_Framework_Core_.DataModels
{
    public partial class angajat
    {
        public angajat()
        {
            this.angajat_proiect = new HashSet<angajat_proiect>();
            this.partenerAngajats = new HashSet<partenerAngajat>();
        }


        public int id { get; set; }
        public int id_departament { get; set; }
        public int id_sector { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public string strada { get; set; }
        public int numar { get; set; }
        public string sex { get; set; }
        public Nullable<System.DateTime> data_nastere { get; set; }
        public Nullable<System.DateTime> data_angajare { get; set; }
        public Nullable<int> salariu { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> data_adaugare { get; set; }
        public Nullable<System.DateTime> data_modificare { get; set; }

        public virtual departament departament { get; set; }
        public virtual sector sector { get; set; }
        public virtual ICollection<angajat_proiect> angajat_proiect { get; set; }
        public virtual ICollection<partenerAngajat> partenerAngajats { get; set; }


    }
    }
