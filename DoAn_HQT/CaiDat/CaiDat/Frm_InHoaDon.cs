using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace CaiDat
{
    public partial class Frm_InHoaDon : Form
    {
        DBConnect con = new DBConnect();
        public string maHD = "";
        public Frm_InHoaDon()
        {
            InitializeComponent();
        }

        private void Frm_InHoaDon_Load(object sender, EventArgs e)
        {
            rp_HoaDon hoaDon = new rp_HoaDon();
            hoaDon.SetDatabaseLogon(con.StrServerName, con.StrDatabaseName);
            ParameterFieldDefinitions pField = hoaDon.DataDefinition.ParameterFields;
            ParameterFieldDefinition pfdMaHD = pField["pMaHD"];
            ParameterDiscreteValue pdvMaHD = new ParameterDiscreteValue();
            pdvMaHD.Value = maHD;
            pfdMaHD.CurrentValues.Clear();
            pfdMaHD.CurrentValues.Add(pdvMaHD);
            pfdMaHD.ApplyCurrentValues(pfdMaHD.CurrentValues);
            crystalReportViewer1.ReportSource = hoaDon;
            crystalReportViewer1.Refresh();
        }
    }
}
