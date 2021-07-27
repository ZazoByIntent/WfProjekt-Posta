using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WfProjekt.Bll.Views;
using WfProjekt.Dal.Manager;
using WfProjekt.Model;

namespace WfProjekt.Bll.Presenters
{
    public class WfProjektPresenter
    {
        IWfProjekt WfProjektView;
        public WfProjektPresenter (IWfProjekt view)
        {
            WfProjektView = view;
        }

        /*
        private WfProjektModel createModel()
        {
            return WfProjektBll.createModel(WfProjektView);
        }
        */

        private WfProjektModel nastaviPodatke()
        {
            return WfProjektView.nastaviPodatke(new WfProjektModel());
        }
        public void insertValues()
        {
            WfProjektBll.insertValues(nastaviPodatke());
        }

        public void updateValues()
        {
            WfProjektBll.updateValues(nastaviPodatke());
        }

        public void selectValues()
        {
            WfProjektView.prikaziPodatke(WfProjektBll.selectValues());
        }
    }
}
