using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammiererAnlegen.Models
{
    public class ProjektRepository
    {
        public List<Projekt> DieProjekte { get; set; }
        public ProjektRepository()
        {
            DieProjekte = new List<Projekt>
            {
                new Projekt{Id=1, Name = "Web-Anwendung" },
                new Projekt{Id=2,Name="WPF-Anwendung"},
                new Projekt{Id=3,Name="JavaScript lernen"}
            };
        }

    }
}
