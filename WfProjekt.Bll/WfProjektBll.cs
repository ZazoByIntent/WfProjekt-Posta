using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WfProjekt.Bll.Views;
using WfProjekt.Dal.Manager;
using WfProjekt.Model;

namespace WfProjekt.Bll
{
    public class WfProjektBll
    {
        /*
        public static WfProjektModel createModel(IWfProjekt WfProjektView)
        {
            return new WfProjektModel(WfProjektView.stRacunaText, WfProjektView.IDPosteText, WfProjektView.IDUporabnikaText, WfProjektView.IDDelovnegaMestaText,
                WfProjektView.oznakaValute, WfProjektView.vrednostText, WfProjektView.znesekPostnineText, WfProjektView.imeText, WfProjektView.hisnaStevilkaText, WfProjektView.namenText);
        }
        */
        private string _connectionString;

        public WfProjektBll(string aConnectionString)
        {
            _connectionString = aConnectionString;
        }

        public void InsertValues(WfProjektModel aModel)
        {

            new WfProjektManager(_connectionString).InsertValues(aModel); // Ne naredis globalnega, ker se rabi samo parkrat
        }

        public void UpdateValues(WfProjektModel aModel)
        {
            new WfProjektManager(_connectionString).UpdateValues(aModel);
        }

        public WfProjektModel SelectValues()
        {
            return new WfProjektManager(_connectionString).SelectValues();
        }
    }
}
