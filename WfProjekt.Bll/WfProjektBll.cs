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
    public static class WfProjektBll
    {
        /*
        public static WfProjektModel createModel(IWfProjekt WfProjektView)
        {
            return new WfProjektModel(WfProjektView.stRacunaText, WfProjektView.IDPosteText, WfProjektView.IDUporabnikaText, WfProjektView.IDDelovnegaMestaText,
                WfProjektView.oznakaValute, WfProjektView.vrednostText, WfProjektView.znesekPostnineText, WfProjektView.imeText, WfProjektView.hisnaStevilkaText, WfProjektView.namenText);
        }
        */

        public static void insertValues(WfProjektModel aModel)
        {
            WfProjektManager manager = new WfProjektManager();
            manager.insertValues(aModel);
        }

        public static void updateValues(WfProjektModel aModel)
        {
            WfProjektManager manager = new WfProjektManager();
            manager.updateValues(aModel);
        }

        public static WfProjektModel selectValues()
        {
            return WfProjektManager.selectValues();
        }
    }
}
