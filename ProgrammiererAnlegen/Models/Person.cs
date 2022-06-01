using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammiererAnlegen.Models
{
    public class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string EMail { get; set; }

        public string  Geschlecht { get; set; }

        public AufgabenClass Aufgabe { get; set; }
        public Projekt [] Projekt { get; set; }

    }
}
