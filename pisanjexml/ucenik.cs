using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pisanjexml
{
    public class ucenik
    {
        public int id;
        public string ime;
        public string prezime;
        public double prosek;

        public ucenik(int id, string ime, string prezime, double prosek)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.prosek = prosek;
        }

    }
}