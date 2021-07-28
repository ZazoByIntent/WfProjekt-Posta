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
        #region Constants

        #endregion


        #region Private Members

        #endregion

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
        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            WfProjektPresenter presenter = new WfProjektPresenter(this); // Ne bi kreacija presenterja mogla biti v View?
            presenter.selectValues();
        }

        private void btnSendInfo_Click(object sender, EventArgs e)
        {
            WfProjektPresenter presenter = new WfProjektPresenter(this);
            presenter.updateValues();
        }

        private void btnInsertInfo_Click(object sender, EventArgs e)
        {
            WfProjektPresenter presenter = new WfProjektPresenter(this);
            presenter.insertValues();
        }

        public void prikaziPodatke(WfProjektModel aModel)
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

        public WfProjektModel nastaviPodatke(WfProjektModel aModel)
        {
            aModel.stRacuna = Convert.ToInt64(txtStevilkaRacuna.Text);
            aModel.IDPoste = Convert.ToInt32(txtPostaID.Text);
            aModel.IDUporabnika = Convert.ToInt32(txtUporabnikID.Text);
            aModel.IDDelovnegaMesta = Convert.ToInt32(txtDelovnoMestoID.Text);
            aModel.vrednost = Convert.ToDouble(txtVrednost.Text);
            aModel.znesekPostnine = Convert.ToDouble(txtZnesekPostnine.Text);
            aModel.oznakaValute = txtOznakaValute.Text;
            aModel.ime = txtIme.Text;
            aModel.hisnaStevilka = txtHisnaStevilka.Text;
            aModel.namen = txtNamen.Text;
            return aModel;
        }
    }
}
