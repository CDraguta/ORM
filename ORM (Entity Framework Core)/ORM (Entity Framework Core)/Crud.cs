using System;
using System.Collections.Generic;
using System.Linq;
using ORM__Entity_Framework_Core_.DataModels;

namespace ORM__Entity_Framework_Core_
{
    public class Crud
    {
        //afisare tabele
        public  List<angajat> GetAllAngajat(Context myContext)
        {
           return myContext
                .Angajat
                .ToList();
 
        }
        public List<angajat_proiect> GetAllAngajatProiect(Context myContext)
        {
            return myContext
                  .AngajatProiect
                  .ToList();
        }
        public List<departament> GetAllDepartament (Context myContext)
        {
            return myContext
                .Departament
                .ToList();
        }
        public List<partenerAngajat> GetAllPartenerAngajat (Context myContext)
        {
            return myContext
                .PartenerAngajat
                .ToList();
        }
        public List<proiect> GetAllProiect (Context myContext)
        {
            return myContext
                .Proiect
                .ToList();
        }
        public List<sector> GetAllSector (Context myContext)
        {
            return myContext
                .Sector
                .ToList();
        }

        //inserare
        public void AddAngajat(Context myContext, int id_dep, int id_sec, string num ,string pren , string str ,int nr, string s ,DateTime d_ang,
                                      int sal , string em , DateTime d_adaug , DateTime d_mod)
        {
            myContext.Angajat.Add(new angajat()
            {
                id_departament = id_dep,
                id_sector = id_sec,
                nume = num,
                prenume = pren,
                strada = str,
                numar = nr,
                sex = s,
                data_angajare = d_ang,
                salariu = sal,
                email = em,
                data_adaugare = d_adaug,
                data_modificare = d_mod
            });

            myContext.SaveChanges();
        }

        public void AddAngajatProiect (Context myContext ,int ida , int idp, decimal nr ,DateTime adaugare , DateTime modificare)
        {
            myContext.AngajatProiect.Add(new angajat_proiect()
            {
                id_angajat = ida,
                id_proiect = idp,
                nr_ore_saptamana = nr,
                data_adaugare = adaugare,
                data_modificare = modificare

            });
            myContext.SaveChanges();
        }

        public void AddDepartament(Context myContext , string den, string c , DateTime da , DateTime dm)
        {
            myContext.Departament.Add(new departament()
            {
                denumire =den,
                cod=c,
                data_adaugare =da,
                data_modificare=dm

            });
            myContext.SaveChanges();
        }
        public void AddPartenerAngajat(Context myContext , string num , string pren , string s , int id , DateTime da , DateTime dm)
        {
            myContext.PartenerAngajat.Add(new partenerAngajat()
            {
                nume =num,
                prenume = pren,
                sex = s,
                id_angajat = id,
                data_adaugare = da,
                data_modificare = dm
            });
            myContext.SaveChanges();
        }

        public void AddProiect(Context myContext , int idd , string num, string c , DateTime di , int b , DateTime tl ,DateTime da, DateTime dm)
        {
            myContext.Proiect.Add(new proiect()
            {
                id_departament = idd,
                nume = num,
                cod =c,
                data_incepere = di,
                buget = b,
                termen_limita = tl,
                data_adaugare =da,
                data_modificare = dm
            });
            myContext.SaveChanges();
        }

        public void AddSector(Context myContext, string den , int cod , DateTime da , DateTime dm)
        {
            myContext.Sector.Add(new sector()
            {
                denumire = den,
                cod_postal = cod,
                data_adaugare = da,
                data_modificare = dm
            });
            myContext.SaveChanges();
        }

        //update 
        public void UpdateAngajat(Context myContext ,int id_utilizator , string nume_utilizator)
        {
            var myAngajat = myContext
                .Angajat
                .Where(a => a.id == id_utilizator)
                .ToList();
            foreach (var ang in myAngajat)
            {
                ang.prenume = nume_utilizator;
            }
            myContext.SaveChanges();
        }

        public void UpdateAngajatProiect(Context myContext , int id_utilizator , decimal nr_ore)
        {
            var myAngajatProiect = myContext
                .AngajatProiect
                .Where(ap => ap.id_angajat == id_utilizator)
                .ToList();

            foreach(var angpro in myAngajatProiect)
            {
                angpro.nr_ore_saptamana = nr_ore;
            }

            myContext.SaveChanges();
        }

        public void UpdateDepartament(Context myContext , int id_utilizator , string codD)
        {
            var myDepartament = myContext
                .Departament
                .Where(d => d.id == id_utilizator)
                .ToList();

            foreach (var dep in myDepartament)
            {
                dep.cod = codD;
            }
            myContext.SaveChanges(); 
        }

        public void UpdatePartenerAngajat (Context myContext , int id_utilizator,string nume_utilizator)
        {
            var myPartenerAngajat = myContext
                .PartenerAngajat
                .Where(d => d.id == id_utilizator)
                .ToList();
            foreach (var part in myPartenerAngajat)
            {
                part.nume = nume_utilizator;
            }
            myContext.SaveChanges();
        }

        public void UpdateProiect (Context myContext , int id_utilizator , int buget_utili)
        {
            var myProiect = myContext
                .Proiect
                .Where(p => p.id == id_utilizator)
                .ToList();
            foreach(var pro in myProiect)
            {
                pro.buget = buget_utili;
            }
            myContext.SaveChanges();
        }
        public void UpdateSector(Context myContext, int id_util , int cod)
        {
            var mySector = myContext
                .Sector
                .Where(s => s.id == id_util)
                .ToList();

            foreach(var sect in mySector)
            {
                sect.cod_postal = cod;
            }

            myContext.SaveChanges();
        }

        //stergere
        public  void DeleteAngajat(Context myContext ,int id_utilizator)
        {
            var myAngajat = myContext
               .Angajat
               .Where(a => a.id == id_utilizator)
               .ToList();

            myContext.RemoveRange(myAngajat);
            myContext.SaveChanges();

        }

       public void DeleteAngajatProiect(Context myContext, int id_utilizator)
        {
            var myAngajatProiect = myContext
               .AngajatProiect
               .Where(a => a.id_angajat == id_utilizator)
               .ToList();

            myContext.RemoveRange(myAngajatProiect);
            myContext.SaveChanges();

        }

        public void DeleteDepartament(Context myContext, int id_utilizator)
        {
            var myDepartament = myContext
               .Departament
               .Where(a => a.id == id_utilizator)
               .ToList();

            myContext.RemoveRange(myDepartament);
            myContext.SaveChanges();

        }
        public void DeletePartenerAngajat(Context myContext, int id_utilizator)
        {
            var myPartenerAngajat = myContext
               .PartenerAngajat
               .Where(a => a.id == id_utilizator)
               .ToList();

            myContext.RemoveRange(myPartenerAngajat);
            myContext.SaveChanges();

        }

        public void DeleteProiect(Context myContext, int id_utilizator)
        {
            var myProiect = myContext
               .Proiect
               .Where(a => a.id == id_utilizator)
               .ToList();

            myContext.RemoveRange(myProiect);
            myContext.SaveChanges();

        }
        public void DeleteSector(Context myContext, int id_utilizator)
        {
            var mySector = myContext
               .Sector
               .Where(a => a.id == id_utilizator)
               .ToList();

            myContext.RemoveRange(mySector);
            myContext.SaveChanges();

        }
    }
}
