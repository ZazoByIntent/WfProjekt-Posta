using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WfProjekt.Model;

namespace WfProjekt.Bll.Views
{
    public interface IWfProjekt
    {
        long stRacunaText { get; set; }
        int IDPosteText { get; set; }
        int IDUporabnikaText { get; set; }
        int IDDelovnegaMestaText { get; set; }
        double vrednostText { get; set; }
        double znesekPostnineText { get; set; }
        string oznakaValute { get; set; }
        string imeText { get; set; }
        string hisnaStevilkaText { get; set; }
        string namenText { get; set; }


        WfProjektModel nastaviPodatke(WfProjektModel aModel);
        void prikaziPodatke(WfProjektModel aModel);
        

    
    }
}
