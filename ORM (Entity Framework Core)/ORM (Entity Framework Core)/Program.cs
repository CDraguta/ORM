using System;
using ORM__Entity_Framework_Core_.DataModels;
using System.Linq;
using System.Collections.Generic;

namespace ORM__Entity_Framework_Core_
{
    class Program
    {
        static void Main(string[] args)
        {
            using Context myContext = new Context();
            Crud crud = new Crud();

            Console.WriteLine("Bine ati venit la baza de date Companie");
        initial:
            Console.Write("Alegeti tabela pe care doriti sa efectuati operatii CRUD: 1-Angajat , 2-AngajatProiect , 3-Departament , 4-PartenerAngajat " +
                ", 5-Proiect , 6-Sector , 7 -Iesire din aplicatie");
            Console.WriteLine(" ");
            string numarString = Console.ReadLine();
            int numar;

            if (int.TryParse(numarString, out numar))
            {

                switch (numar)
                {
                    case 1:
                        Console.WriteLine("Ati ales sa efectuati operatii pe tabela Angajat. Continuati : da/nu");
                        string continuare1 = Console.ReadLine();
                        if (continuare1.ToLower() == "da")
                        {
                        op1:
                            Console.WriteLine("Afisare tabela: ");
                            var angajati = crud.GetAllAngajat(myContext);
                            Console.WriteLine("id , id_departament , id_sector ,nume , prenume, strada, numar, sex , data_nastere," +
                                              "              data_angajare, salariu , email , data_adaugare, data_modificare");
                            foreach (angajat ang in angajati)
                            {
                                Console.WriteLine(ang.id + "       " + ang.id_departament + "              " + ang.id_sector + "         " + ang.nume + " " + ang.prenume + " " +
                                     " " + ang.strada + " " + ang.numar + "      " + ang.sex + " " + ang.data_nastere + "      " + ang.data_angajare + "      "
                                    + ang.salariu + " " + ang.email + " " + ang.data_adaugare + " " + ang.data_modificare + " ");

                            }
                        operatie1:
                            Console.WriteLine("Alegeti operatia pe care doriti sa o efectuati: 1-Inserare element, 2-Update element , 3-Stergere element , 4-Revenire Meniu initial ");
                            string nr1 = Console.ReadLine();
                            int numarOperatie1;
                            if (int.TryParse(nr1, out numarOperatie1))
                            {
                                switch (numarOperatie1)
                                {
                                    case 1:

                                        Console.WriteLine("Introduceti pe rand detalii legate de noul angajat.");
                                    insa1:
                                        Console.WriteLine("id_departament = ");
                                        string idd = Console.ReadLine();
                                        int iddp;
                                        if (int.TryParse(idd, out iddp))
                                        {
                                        insa2:
                                            Console.WriteLine("id_sector = ");
                                            string ids = Console.ReadLine();
                                            int idsp;
                                            if (int.TryParse(ids, out idsp))
                                            {
                                                Console.WriteLine(" nume = ");
                                                string nume = Console.ReadLine();
                                                Console.WriteLine("prenume = ");
                                                string prenume = Console.ReadLine();
                                                Console.WriteLine("strada = ");
                                                string strada = Console.ReadLine();
                                            insa3:
                                                Console.WriteLine("numar = ");
                                                string nr = Console.ReadLine();
                                                int nra;
                                                if (int.TryParse(nr, out nra))
                                                {
                                                    Console.WriteLine("sex = ");
                                                    string sex = Console.ReadLine();
                                                insa4:
                                                    Console.WriteLine("data_angajare = ");
                                                    string da = Console.ReadLine();
                                                    DateTime dat_ang;
                                                    if (DateTime.TryParse(da, out dat_ang))
                                                    {
                                                    insa5:
                                                        Console.WriteLine("salariu = ");
                                                        string sal = Console.ReadLine();
                                                        int salariu;
                                                        if (int.TryParse(sal, out salariu))
                                                        {
                                                            Console.WriteLine("email = ");
                                                            string email = Console.ReadLine();
                                                        insa6:
                                                            Console.WriteLine("data_adaugare =");
                                                            string dat = Console.ReadLine();
                                                            DateTime dat_add;
                                                            if (DateTime.TryParse(dat, out dat_add))
                                                            {
                                                            insa7:
                                                                Console.WriteLine("data_modificare = ");
                                                                string datm = Console.ReadLine();
                                                                DateTime dat_mod;
                                                                if (DateTime.TryParse(datm, out dat_mod))
                                                                {
                                                                    crud.AddAngajat(myContext, iddp, idsp, nume, prenume, strada, nra, sex, dat_ang, salariu, email, dat_add, dat_mod);
                                                                    goto op1;
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Nu ati introdus o data");
                                                                    goto insa7;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Nu ati introdus o data");
                                                                goto insa6;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Nu ati introdus un numar");
                                                            goto insa5;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Nu ati introdus o data");
                                                        goto insa4;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Nu ati introdus un numar");
                                                    goto insa3;
                                                }


                                            }
                                            else
                                            {
                                                Console.WriteLine("id-ul introdus nu este un numar");
                                                goto insa2;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("ID-ul introdus nu este un numar ");
                                            goto insa1;
                                        }
                                    case 2:
                                        upa1:
                                        Console.WriteLine("Introduceti id-ul angajajatului caruia doriti sa ii modificati numele");
                                        string id_ang = Console.ReadLine();
                                        int id_util;
                                        if (int.TryParse(id_ang,out id_util))
                                        {
                                            Console.WriteLine("Introduceti noul nume al angajatului");
                                            string nume = Console.ReadLine();
                                            crud.UpdateAngajat(myContext, id_util, nume);
                                            goto op1;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Nu ati introdus un numar");
                                            goto upa1;
                                        }
                                    case 3:
                                        Console.WriteLine("Introduceti id-ul angajatului pe care doriti sa il stergeti");
                                        string nrr1 = Console.ReadLine();
                                        int nrParse1;
                                        bool parse1 = int.TryParse(nrr1, out nrParse1);
                                        if (parse1)
                                        {
                                            crud.DeleteAngajat(myContext, nrParse1);
                                            goto op1;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Id-ul introdus nu este un numar");
                                            goto operatie1;
                                        }
                                    case 4:
                                        goto initial;
                                    default:
                                        goto operatie1;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nu ati introdus un numar");
                                goto operatie1;
                            }
                        }
                        else if (continuare1.ToLower() == "nu")
                        {
                            Console.WriteLine("La revedere!");
                        }
                        else
                        {
                            Console.WriteLine("Nu ati selectat da sau nu.");
                            goto initial;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ati ales sa efectuati operatii pe tabela AngajatProiect.Continuati : da/nu");
                        string continuare2 = Console.ReadLine();
                        if (continuare2.ToLower() == "da")
                        {
                        op2:
                            Console.WriteLine("Afisare tabela: ");
                            var angajati_proiect = crud.GetAllAngajatProiect(myContext);
                            Console.WriteLine(" id_angajat , id_proiect , nr_ore_saptamana, data_adaugare ,           data_modificare");
                            foreach (angajat_proiect angp in angajati_proiect)
                            {
                                Console.WriteLine(angp.id_angajat + "     " + angp.id_proiect + "    " + angp.nr_ore_saptamana + "   " + angp.data_adaugare + "   " + angp.data_modificare);
                            }

                        operatie2:
                            Console.WriteLine("Alegeti operatia pe care doriti sa o efectuati: 1-Inserare element, 2-Update element , 3-Stergere element , 4 -Revenire Meniu Initial ");
                            string nr2 = Console.ReadLine();
                            int numarOperatie2;
                            if (int.TryParse(nr2, out numarOperatie2))
                            {
                                switch (numarOperatie2)
                                {
                                    case 1:
                                        Console.WriteLine("Introduceti pe rand detalii legate de noua inregistrare din tabela angajat_proiect");
                                    insap1:
                                        Console.WriteLine("id_angajat = ");
                                        string idap = Console.ReadLine();
                                        int idapp;
                                        if (int.TryParse(idap, out idapp))
                                        {
                                        insap2:
                                            Console.WriteLine("id_proiect = ");
                                            string idp = Console.ReadLine();
                                            int iddp;
                                            if (int.TryParse(idp, out iddp))
                                            {
                                            insap3:
                                                Console.WriteLine("nr_ore_saptamana");
                                                string nr = Console.ReadLine();
                                                decimal nr_ore;
                                                if (decimal.TryParse(nr, out nr_ore))
                                                {
                                                insap4:
                                                    Console.WriteLine("data_adaugare = ");
                                                    string dat_ad = Console.ReadLine();
                                                    DateTime datpa;
                                                    if (DateTime.TryParse(dat_ad, out datpa))
                                                    {
                                                    insap5:
                                                        Console.WriteLine("data_modificare = ");
                                                        string dat_mod = Console.ReadLine();
                                                        DateTime datpm;
                                                        if (DateTime.TryParse(dat_mod, out datpm))
                                                        {
                                                            crud.AddAngajatProiect(myContext, idapp, iddp, nr_ore, datpa, datpm);
                                                            Console.WriteLine(" ");
                                                            goto op2;

                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Nu ati introdus o data");
                                                            goto insap5;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Nu ati introdus o data.");
                                                        goto insap4;
                                                    }

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Nu ati introdus o valoare decimal");
                                                    goto insap3;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Nu ati introdus un numar");
                                                goto insap2;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Nu ati introdus un numar");
                                            goto insap1;
                                        }
                                    case 2:
                                        upap1:
                                        Console.WriteLine("Introduceti id-ul angajatului caruia doriti sa ii schimbati numarul de ore");
                                        string id_ang = Console.ReadLine();
                                        int idd;
                                        if(int.TryParse(id_ang , out idd))
                                        {
                                            upap2:
                                            Console.WriteLine("Introduceti noul numar de ore");
                                            string nr_ore = Console.ReadLine();
                                            decimal numar_o;
                                            if (decimal.TryParse(nr_ore , out numar_o))
                                            {
                                                crud.UpdateAngajatProiect(myContext, idd, numar_o);
                                                goto op2;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Nu ati introdus un numar");
                                                goto upap2;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Nu ati introdus un numar");
                                            goto upap1;
                                        }
                                    case 3:
                                        Console.WriteLine("Introduceti id-ul angajatului pe care doriti sa il stergeti");
                                        string nrr1 = Console.ReadLine();
                                        int nrParse1;
                                        bool parse1 = int.TryParse(nrr1, out nrParse1);
                                        if (parse1)
                                        {
                                            crud.DeleteAngajatProiect(myContext, nrParse1);
                                            goto op2;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Id-ul introdus nu este un numar");
                                            goto operatie2;
                                        }
                                    case 4:
                                        goto initial;
                                    default:
                                        goto operatie2;
                                }

                            }
                            else
                            {
                                Console.WriteLine("Nu ati introdus un numar");
                                goto operatie2;
                            }
                        }
                        else if (continuare2.ToLower() == "nu")
                        {
                            Console.WriteLine("La revedere!");
                        }
                        else
                        {
                            Console.WriteLine("Nu ati selectat da sau nu.");
                            goto initial;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ati ales sa efectuati operatii pe tabela Departament. Continuati : da/nu");
                        string continuare3 = Console.ReadLine();
                        if (continuare3.ToLower() == "da")
                        {
                        op3:
                            Console.WriteLine("Afisare tabela: ");
                            var departamente = crud.GetAllDepartament(myContext);
                            Console.WriteLine("id   denumire    cod    data_adaugare   data_modificare");
                            foreach (departament dep in departamente)
                            {
                                Console.WriteLine(dep.id + "  " + dep.denumire + "  " + dep.cod + "  " + dep.data_adaugare + "  " + dep.data_modificare);
                            }
                        operatie3:
                            Console.WriteLine("Alegeti operatia pe care doriti sa o efectuati: 1-Inserare element, 2-Update element , 3-Stergere element 4-Revenire Meniu initial");
                            string nr3 = Console.ReadLine();
                            int numarOperatie3;
                            if (int.TryParse(nr3, out numarOperatie3))
                            {
                                switch (numarOperatie3)
                                {
                                    case 1:
                                        Console.WriteLine("Introduceti pe rand detalii legate de noul departament:");
                                        Console.WriteLine("denumire = ");
                                        string denumire = Console.ReadLine();
                                        Console.WriteLine("cod = ");
                                        string cod = Console.ReadLine();

                                    insd1:
                                        Console.WriteLine("data_adaugare = ");
                                        string datd = Console.ReadLine();
                                        DateTime ddata;
                                        if (DateTime.TryParse(datd , out ddata))
                                        {
                                        insd2:
                                            Console.WriteLine("data_modificare = ");
                                            string datmd = Console.ReadLine();
                                            DateTime datmdd;
                                            if(DateTime.TryParse(datmd , out datmdd))
                                            {
                                                crud.AddDepartament(myContext, denumire, cod, ddata, datmdd);
                                                goto op3;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Nu ati introdus o data");
                                                goto insd2;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Nu ati introdus o data");
                                            goto insd1;
                                        }
                                    case 2:
                                        upd1:
                                        Console.WriteLine("Introduceti id-ul departamentului pentru care doriti sa schimbati codul");
                                        string id = Console.ReadLine();
                                        int idd;
                                        if (int.TryParse(id, out idd))
                                        {
                                            Console.WriteLine("Introduceti noul cod");
                                            string codNou = Console.ReadLine();
                                            crud.UpdateDepartament(myContext, idd, codNou);
                                            goto op3;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Nu ati introdus un numar");
                                            goto upd1;
                                        }
                                    case 3:
                                        Console.WriteLine("Introduceti id-ul departamentului pe care doriti sa il stergeti");
                                        string nrr1 = Console.ReadLine();
                                        int nrParse1;
                                        bool parse1 = int.TryParse(nrr1, out nrParse1);
                                        if (parse1)
                                        {
                                            crud.DeleteDepartament(myContext, nrParse1);
                                            goto op3;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Id-ul introdus nu este un numar");
                                            goto operatie3;
                                        }
                                    case 4:
                                        goto initial;
                                    default:
                                        goto operatie3;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nu ati introdus un numar");
                                goto operatie3;
                            }
                        }
                        else if (continuare3.ToLower() == "nu")
                        {
                            Console.WriteLine("La revedere!");
                        }
                        else
                        {
                            Console.WriteLine("Nu ati selectat da sau nu.");
                            goto initial;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Ati ales sa efectuati operatii pe tabela PartenerAngajat.Continuati : da/nu");
                        string continuare4 = Console.ReadLine();
                        if (continuare4.ToLower() == "da")
                        {
                        op4:
                            Console.WriteLine("Afisare tabela: ");
                            var partAngajat = crud.GetAllPartenerAngajat(myContext);
                            Console.WriteLine("id   nume    prenume    sex  id_angajat   data_adaugare   data_modificare");
                            foreach (partenerAngajat part in partAngajat)
                            {
                                Console.WriteLine(part.id + "  " + part.nume + "  " + part.prenume + "  " + part.sex + " " + part.id_angajat + "  " +
                                    part.data_adaugare + "  " + part.data_modificare);
                            }
                        operatie4:
                            Console.WriteLine("Alegeti operatia pe care doriti sa o efectuati: 1-Inserare element, 2-Update element , 3-Stergere element ,4-Revenire Meniu initial  ");
                            string nr4 = Console.ReadLine();
                            int numarOperatie4;
                            if (int.TryParse(nr4, out numarOperatie4))
                            {

                                switch (numarOperatie4)
                                {
                                    case 1:
                                        Console.WriteLine("Introduceti detalii legate de noul partener al unui angajatului");
                                        Console.WriteLine("nume= ");
                                        string nume = Console.ReadLine();
                                        Console.WriteLine("prenume = ");
                                        string prenume = Console.ReadLine();
                                        Console.WriteLine("sex = ");
                                        string sex = Console.ReadLine();
                                    insd1:
                                        Console.WriteLine("id_angajat =");
                                        string id_an = Console.ReadLine();
                                        int id_ang;
                                        if(int.TryParse(id_an, out id_ang))
                                        {
                                        insd2:
                                            Console.WriteLine("data_adaugare");
                                            string dat_apar = Console.ReadLine();
                                            DateTime data_par;
                                            if(DateTime.TryParse(dat_apar, out data_par))
                                            {
                                            insd3:
                                                Console.WriteLine("data_modificare = ");
                                                string dat_mpar = Console.ReadLine();
                                                DateTime datm_par;
                                                if (DateTime.TryParse(dat_mpar ,out datm_par))
                                                {
                                                    crud.AddPartenerAngajat(myContext, nume, prenume, sex, id_ang, data_par, datm_par);
                                                    goto op4;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Nu ati introdus o data");
                                                    goto insd3;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Nu ati introdus o data");
                                                goto insd2;
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Nu ati introdus un numar");
                                            goto insd1;
                                        }
                                    case 2:
                                        uppa1:
                                        Console.WriteLine("Introduceti id-ul partenerului pentru care doriti sa schimbati numele");
                                        string id_pa = Console.ReadLine();
                                        int id_par;
                                        if (int.TryParse(id_pa, out id_par))
                                        {
                                            Console.WriteLine("Introduceti noul nume");
                                            string nume_pa = Console.ReadLine();
                                            crud.UpdatePartenerAngajat(myContext, id_par, nume_pa);
                                            goto op4;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Nu ati introdus un numar ");
                                            goto uppa1;
                                        }
                                    case 3:
                                        Console.WriteLine("Introduceti id-ul partenerAngajat pe care doriti sa il stergeti");
                                        string nrr1 = Console.ReadLine();
                                        int nrParse1;
                                        bool parse1 = int.TryParse(nrr1, out nrParse1);
                                        if (parse1)
                                        {
                                            crud.DeletePartenerAngajat(myContext, nrParse1);
                                            goto op4;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Id-ul introdus nu este un numar");
                                            goto operatie4;
                                        }
                                    case 4:
                                        goto initial;
                                    default:
                                        goto operatie4;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nu ati introdus un numar");
                                goto operatie4;
                            }

                        }
                        else if (continuare4.ToLower() == "nu")
                        {
                            Console.WriteLine("La revedere!");
                        }
                        else
                        {
                            Console.WriteLine("Nu ati selectat da sau nu.");
                            goto initial;
                        }
                        break;
                    case 5:
                        Console.WriteLine("Ati ales sa efectuati operatii pe tabela Proiect. Continuati : da/nu");
                        string continuare5 = Console.ReadLine();
                        if (continuare5.ToLower() == "da")
                        {
                        op5:
                            Console.WriteLine("Afisare tabela: ");
                            var proiecte = crud.GetAllProiect(myContext);
                            Console.WriteLine("id   id_departament nume  cod  data_incepere  buget   termen_limita   data_adaugare   data_modificare");
                            foreach (proiect prt in proiecte)
                            {
                                Console.WriteLine(prt.id + "  " + prt.id_departament + "  " + prt.nume + "  " + prt.cod + "  " + prt.data_incepere + "  "
                                    + prt.buget + "   " + prt.termen_limita + "   " + prt.data_incepere + "   " + prt.data_modificare);

                            }
                        operatie5:
                            Console.WriteLine("Alegeti operatia pe care doriti sa o efectuati: 1-Inserare element, 2-Update element , 3-Stergere element , 4-Revenire Meniu initial");
                            string nr5 = Console.ReadLine();
                            int numarOperatie5;
                            if (int.TryParse(nr5, out numarOperatie5))
                            {
                                switch (numarOperatie5)
                                {
                                    case 1:
                                        Console.WriteLine("Introduceti pe rand detalii legate de noul proiect");
                                    insp1:
                                        Console.WriteLine("id_departament = ");
                                        string id_dd = Console.ReadLine();
                                        int id_dep;
                                        if(int.TryParse(id_dd , out id_dep))
                                        {
                                            Console.WriteLine("nume = ");
                                            string nume = Console.ReadLine();
                                            Console.WriteLine("cod = ");
                                            string cod = Console.ReadLine();

                                        insp2:
                                            Console.WriteLine("data_incepere = ");
                                            string dat = Console.ReadLine();
                                            DateTime dat_in;
                                            if(DateTime.TryParse(dat, out dat_in))
                                            {
                                            insp3:
                                                Console.WriteLine("buget = ");
                                                string bug = Console.ReadLine();
                                                int buget;
                                                if(int.TryParse(bug,out buget))
                                                {
                                                insp4:
                                                    Console.WriteLine("termen_limita = ");
                                                    string t = Console.ReadLine();
                                                    DateTime termen;
                                                    if (DateTime.TryParse(t, out termen))
                                                    {
                                                    insp5:
                                                        Console.WriteLine("data_adaugare = ");
                                                        string data = Console.ReadLine();
                                                        DateTime dat_ad;
                                                        if(DateTime.TryParse(data,out  dat_ad))
                                                        {
                                                        insp6:
                                                            Console.WriteLine("data_modificare =");
                                                            string datam = Console.ReadLine();
                                                            DateTime dat_mod;
                                                            if(DateTime.TryParse(datam, out dat_mod))
                                                            {
                                                                crud.AddProiect(myContext, id_dep, nume, cod, dat_in, buget, termen, dat_ad, dat_mod);
                                                                goto op5;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Nu ati introdus o data");
                                                                goto insp6;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Nu ati introdus o data");
                                                            goto insp5;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Nu ati introdus o data ");
                                                        goto insp4;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Nu ati introdus un numar");
                                                    goto insp3;
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Nu ati introdus o data");
                                                goto insp2;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Nu ati introdus un numar");
                                            goto insp1;
                                        }
                                    case 2:
                                        upp1:
                                        Console.WriteLine("Introduceti id-ul proiectului pentru care doriti sa schimbati bugetul");
                                        string idp = Console.ReadLine();
                                        int id_p;
                                        if (int.TryParse(idp, out id_p))
                                        {
                                            upp2:
                                            Console.WriteLine("Introduceti noul buget");
                                            string bug = Console.ReadLine();
                                            int buget;
                                            if(int.TryParse(bug, out buget))
                                            {
                                                crud.UpdateProiect(myContext, id_p, buget);
                                                goto op5;

                                            }
                                            else
                                            {
                                                Console.WriteLine("Nu ati introdus un numar");
                                                goto upp2;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Nu ati introdus un numar");
                                            goto upp1;
                                        }
                                    case 3:
                                        Console.WriteLine("Introduceti id-ul proiectului pe care doriti sa il stergeti");
                                        string nrr1 = Console.ReadLine();
                                        int nrParse1;
                                        bool parse1 = int.TryParse(nrr1, out nrParse1);
                                        if (parse1)
                                        {
                                            crud.DeleteProiect(myContext, nrParse1);
                                            goto op5;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Id-ul introdus nu este un numar");
                                            goto operatie5;
                                        }
                                    case 4:
                                        goto initial;
                                    default:
                                        goto operatie5;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nu ati introdus un numar");
                                goto operatie5;
                            }
                        }
                        else if (continuare5.ToLower() == "nu")
                        {
                            Console.WriteLine("La revedere!");
                        }
                        else
                        {
                            Console.WriteLine("Nu ati selectat da sau nu.");
                            goto initial;
                        }
                        break;
                    case 6:
                        Console.WriteLine("Ati ales sa efectuati operatii pe tabela Sector. Continuati : da/nu");
                        string continuare6 = Console.ReadLine();
                        if (continuare6.ToLower() == "da")
                        {
                        op6:
                            Console.WriteLine("Afisare tabela: ");
                            var sectoare = crud.GetAllSector(myContext);
                            Console.WriteLine("id   denumire    cod_postal   data_adaugare   data_modificare");
                            foreach (sector sct in sectoare)
                            {
                                Console.WriteLine(sct.id + "  " + sct.denumire + "  " + sct.cod_postal + " " + sct.data_adaugare + " " + sct.data_modificare);
                            }
                        operatie6:
                            Console.WriteLine("Alegeti operatia pe care doriti sa o efectuati: 1-Inserare element, 2-Update element , 3-Stergere element, 4-Revenire Meniu initial ");
                            string nr6 = Console.ReadLine();
                            int numarOperatie6;
                            if (int.TryParse(nr6, out numarOperatie6))
                            {
                                switch (numarOperatie6)
                                {
                                    case 1:
                                        Console.WriteLine("Introduceti pe rand detalii legate de noul sector");
                                        Console.WriteLine("denumire = ");
                                        string denumire = Console.ReadLine();
                                    inss1:
                                        Console.WriteLine("cod_postal =");
                                        string cod = Console.ReadLine();
                                        int cod_postal;
                                        if(int.TryParse(cod, out cod_postal))
                                        {
                                        inss2:
                                            Console.WriteLine("data_adaugare = ");
                                            string data = Console.ReadLine();
                                            DateTime dat_a;
                                            if(DateTime.TryParse(data, out dat_a))
                                            {
                                            inss3:
                                                Console.WriteLine("data_modificare = ");
                                                string dat = Console.ReadLine();
                                                DateTime dat_m;
                                                if(DateTime.TryParse(dat, out dat_m))
                                                {
                                                    crud.AddSector(myContext, denumire, cod_postal, dat_a, dat_m);
                                                        goto op6;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Nu ati introdus o data");
                                                    goto inss3;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Nu ati introdus o data");
                                                goto inss2;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Nu ati introdus un numar");
                                            goto inss1;
                                        }
                                    case 2:
                                        ups1:
                                        Console.WriteLine("Introduceti id-ul sectorului pentru care doriti sa modificati codul postal");
                                        string ids = Console.ReadLine();
                                        int id_sect;
                                        if(int.TryParse(ids , out id_sect))
                                        {
                                            ups2:
                                            Console.WriteLine("Introduceti noul cod postal");
                                            string codPostal = Console.ReadLine();
                                            int cod_po;
                                            if(int.TryParse(codPostal, out cod_po))
                                            {
                                                crud.UpdateSector(myContext, id_sect, cod_po);
                                                goto op6;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Nu ati introdus un numar");
                                                goto ups2; 
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Nu ati introdus un numar");
                                            goto ups1;
                                        }
                                     
                                    case 3:
                                        Console.WriteLine("Introduceti id-ul sectorului pe care doriti sa il stergeti");
                                        string nrr1 = Console.ReadLine();
                                        int nrParse1;
                                        bool parse1 = int.TryParse(nrr1, out nrParse1);
                                        if (parse1)
                                        {
                                            crud.DeleteSector(myContext, nrParse1);
                                            goto op6;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Id-ul introdus nu este un numar");
                                            goto operatie6;
                                        }
                                    case 4:
                                        goto initial;
                                    default:
                                        goto operatie6;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nu ati introdus un numar");
                                goto operatie6;
                            }
                        }
                        else if (continuare6.ToLower() == "nu")
                        {
                            Console.WriteLine("La revedere!");
                        }
                        else
                        {
                            Console.WriteLine("  ");
                            Console.WriteLine("Nu ati selectat da sau nu.");
                            goto initial;
                        }
                        break;
                    case 7:
                        Console.WriteLine("La revedere!");
                        break;
                    default:
                        Console.WriteLine(" ");
                        Console.WriteLine("Nu ati selectat nicio tabela");
                        goto initial;

                }

            }
            else
            {
                Console.WriteLine("Nu ati introdus un numar");
                Console.WriteLine(" ");
                goto initial;
            }

        }

    }
}
