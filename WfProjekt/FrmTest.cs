using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WfProjekt.Bll.Presenters;
using WfProjekt.Bll.Views;
using WfProjekt.Model;

namespace WfProjekt
{
    public partial class FrmTest : Form, IWfProjekt
    {

        private string _connectionString = "Data Source=172.26.160.19;Initial Catalog=UPODb;User ID=razvoj;Password=Razvoj3";

        #region Constructors

        public FrmTest()
        {
            InitializeComponent();
        }
        public long stRacunaText { get { return Convert.ToInt64(txtStevilkaRacuna.Text); } set { txtStevilkaRacuna.Text = value.ToString(); } } 
        public int IDPosteText { get { return Convert.ToInt32(txtPostaID.Text); } set { txtPostaID.Text = value.ToString(); } }
        public int IDUporabnikaText { get { return Convert.ToInt32(txtUporabnikID.Text); } set { txtUporabnikID.Text = value.ToString(); } }
        public int IDDelovnegaMestaText { get { return Convert.ToInt32(txtDelovnoMestoID.Text); } set { txtDelovnoMestoID.Text = value.ToString(); } }
        public double vrednostText { get { return Convert.ToDouble(txtVrednost.Text); } set { txtVrednost.Text = value.ToString(); } }
        public double znesekPostnineText { get { return Convert.ToDouble(txtZnesekPostnine.Text); } set { txtZnesekPostnine.Text = value.ToString(); } }
        public string oznakaValute { get { return txtOznakaValute.Text; } set { txtOznakaValute.Text = value; } }
        public string imeText { get { return txtIme.Text; } set { txtIme.Text = value; } }
        public string hisnaStevilkaText { get { return txtHisnaStevilka.Text; } set { txtHisnaStevilka.Text = value; } }
        public string namenText { get { return txtNamen.Text; } set { txtNamen.Text = value; } }

        #endregion
        

        public void PrikaziPodatke(WfProjektModel aModel)
        {
            txtStevilkaRacuna.Text = aModel.stRacuna.ToString();
            txtPostaID.Text = aModel.IDPoste.ToString();
            txtUporabnikID.Text = aModel.IDPoste.ToString();
            txtDelovnoMestoID.Text = aModel.IDDelovnegaMesta.ToString();
            txtVrednost.Text = aModel.vrednost.ToString();
            txtZnesekPostnine.Text = aModel.znesekPostnine.ToString();
            txtOznakaValute.Text = aModel.oznakaValute;
            txtIme.Text = aModel.ime;
            txtHisnaStevilka.Text = aModel.hisnaStevilka;
            txtNamen.Text = aModel.namen;
        }
        public WfProjektModel VrniPodatke()
        {
            /* 
             * Primer vrinjenega konstruktorja
            WfProjektModel model = new WfProjektModel
            {
                IDPoste = 1,
                ime = string.Empty
            };
            */

            WfProjektModel model = new WfProjektModel();
            model.stRacuna = Convert.ToInt64(txtStevilkaRacuna.Text);
            model.IDPoste = Convert.ToInt32(txtPostaID.Text);
            model.IDUporabnika = Convert.ToInt32(txtUporabnikID.Text);
            model.IDDelovnegaMesta = Convert.ToInt32(txtDelovnoMestoID.Text);
            model.vrednost = Convert.ToDouble(txtVrednost.Text);
            model.znesekPostnine = Convert.ToDouble(txtZnesekPostnine.Text);
            model.oznakaValute = txtOznakaValute.Text;
            model.ime = txtIme.Text;
            model.hisnaStevilka = txtHisnaStevilka.Text;
            model.namen = txtNamen.Text;
            return model;
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            new WfProjektPresenter(this, _connectionString).SelectValues(); // globalni presenter
        }

        private void btnSendInfo_Click(object sender, EventArgs e)
        {
            new WfProjektPresenter(this, _connectionString).UpdateValues(VrniPodatke());
        }

        private void btnInsertInfo_Click(object sender, EventArgs e)
        {
            new WfProjektPresenter(this, _connectionString).InsertValues(VrniPodatke());
        }
    }
}
