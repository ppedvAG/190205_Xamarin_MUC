using MVVM_Simpel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Simpel.Services
{
    class PersonenService
    {
        public List<Person> GetPersonen()
        {
            return new List<Person>
            {
                new Person{Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=100m},
                new Person{Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=20m},
                new Person{Vorname="Peter",Nachname="Silie",Alter=30,Kontostand=3000m},
                new Person{Vorname="Franz",Nachname="Ose",Alter=40,Kontostand=-4000m},
                new Person{Vorname="Klara",Nachname="Fall",Alter=50,Kontostand=55500m},
                new Person{Vorname="Martha",Nachname="Pfahl",Alter=60,Kontostand=123456m},
                new Person{Vorname="Rainer",Nachname="Zufall",Alter=70,Kontostand=-7721100m},
                new Person{Vorname="Axel",Nachname="Schweiß",Alter=80,Kontostand=1876500m},
                new Person{Vorname="Anna",Nachname="Bolika",Alter=90,Kontostand=987m},
                new Person{Vorname="Max",Nachname="Mustermann",Alter=100,Kontostand=10000000000m},
            };
        }
    }
}
