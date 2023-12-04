using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VereinsBeitragVerwaltung
{
    public class Mitglied
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; } 
        public double Beitrag {  get; set; }
        public Mitglied(long id, string name, int age, double beitrag)
        {
            Id = id;
            Name = name;
            Age = age;
            Beitrag = beitrag;
        }

        public override string ToString()
        {
            return Name + " (Beitrag: " + Beitrag + "€)" + " Ist: " + Age + " alt.";
        }
    }
}
