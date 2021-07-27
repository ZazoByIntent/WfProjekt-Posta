using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfProjekt.Model
{
    public class WfProjektModel
    {
        #region Constructors
        public WfProjektModel() {
            this.stRacuna = 9000000000;
            this.IDPoste = 1000;
            this.IDUporabnika = 5;
            this.IDDelovnegaMesta = 5;
            this.oznakaValute = "EUR";
            this.vrednost = 1.0f;
            this.znesekPostnine = 1.0f;
            this.ime = "John";
            this.hisnaStevilka = "50a";
            this.namen = "GDSV";
    }
        public WfProjektModel(long stRacuna, int iDPoste, int iDUporabnika, int iDDelovnegaMesta, string oznakaValute, double vrednost, double znesekPostnine, string ime, string hisnaStevilka, string namen)
        {
            this.stRacuna = stRacuna;
            IDPoste = iDPoste;
            IDUporabnika = iDUporabnika;
            IDDelovnegaMesta = iDDelovnegaMesta;
            this.oznakaValute = oznakaValute;
            this.vrednost = vrednost;
            this.znesekPostnine = znesekPostnine;
            this.ime = ime;
            this.hisnaStevilka = hisnaStevilka;
            this.namen = namen;
        }

        #endregion

        #region Getters, setters

        public long stRacuna { get; set; }
        public int IDPoste { get; set; }
        public int IDUporabnika { get; set; }
        public int IDDelovnegaMesta { get; set; }
        public string oznakaValute { get; set; }
        public double vrednost { get; set; }
        public double znesekPostnine { get; set; }
        public string ime { get; set; }
        public string hisnaStevilka { get; set; }
        public string namen { get; set; }

        #endregion

    }
}
