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
        private string _connectionString;
        IWfProjekt WfProjektView;
        WfProjektBll _service;
        public WfProjektPresenter (IWfProjekt aView, string aConnectionString)
        {
            _connectionString = aConnectionString;
            WfProjektView = aView;
            _service = new WfProjektBll(_connectionString);
        }
        public void InsertValues(WfProjektModel aModel)
        {
            _service.InsertValues(aModel);
        }

        public void UpdateValues(WfProjektModel aModel)
        {
            _service.UpdateValues(aModel);
        }

        public void SelectValues()
        {
            WfProjektView.PrikaziPodatke(_service.SelectValues());
        }
    }
}
