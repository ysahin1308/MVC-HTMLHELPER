using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammiererAnlegen.Models
{
    public class AufgabenRepository
    {
        public List<AufgabenClass> Aufgaben { get; set; }

        public AufgabenRepository()
        {
            Aufgaben = new List<AufgabenClass>
            {
                new AufgabenClass { Id = 1, Name = "Programmierer" },
                new AufgabenClass { Id = 2, Name = "Systemintegrator" },
                new AufgabenClass { Id = 3, Name = "CyberSecurity" }
            };
        }
    }
}
