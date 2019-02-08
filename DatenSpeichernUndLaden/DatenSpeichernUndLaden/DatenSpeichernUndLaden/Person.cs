using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DatenSpeichernUndLaden
{
    class Person
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        [MaxLength(255)]
        public string Vorname { get; set; }
        [MaxLength(255)]
        public string Nachname { get; set; }
        public byte Alter { get; set; }
        public decimal Kontostand { get; set; }
    }
}
