using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebookning
{
    public class Boernegruppe
    {
        public string ID { get; set; }
        public string Navn { get; set; }
        public string Aldersgruppe { get; set; }
        public int AntalDeltagere { get; set; }

        public Boernegruppe (string id, string navn, string aldersgruppe, int antalDeltagere)
        {
            ID = id;
            Navn = navn;
            Aldersgruppe = aldersgruppe;
            AntalDeltagere = antalDeltagere;
        }

        public override string ToString()
        {
            return $"ID: {ID}\nNavn: {Navn}\nAldersgruppe: {Aldersgruppe}\nAntal deltagere: {AntalDeltagere}";
        }
    } 
}
