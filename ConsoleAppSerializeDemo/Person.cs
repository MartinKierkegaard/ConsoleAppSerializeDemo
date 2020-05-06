using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppSerializeDemo
{
    [Serializable]
    public class Person
    {
        public string Navn { get; set; }

        public string Adresse { get; set; }

        public Person(string navn, string adresse)
        {
            this.Navn = navn;
            this.Adresse = adresse;
        }

        public Person()
        {

        }

        public override string ToString()
        {
            return $"navn:{Navn} adresse: {Adresse}";
        }
    }
}
