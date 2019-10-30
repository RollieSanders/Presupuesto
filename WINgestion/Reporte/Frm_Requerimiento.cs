using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINgestion
{
    public partial class Frm_Requerimiento : Form
    {
        private SRgestion.WCFgestionEClient objWCF = new SRgestion.WCFgestionEClient();
        public Frm_Requerimiento()
        {
            InitializeComponent();
        }

        public void ShowMe(string strNumRequerimiento)
        {
            Service.Requerimiento_Detalle SRD = new Service.Requerimiento_Detalle();
            DataSet DS_Requerimiento = new DataSet();
            if (MyStuff.UsaWCF == true)
            {
                DS_Requerimiento = objWCF.Formato_Requerimiento(strNumRequerimiento);
            }
            else
            {
                DS_Requerimiento = SRD.Formato_Requerimiento(strNumRequerimiento);
            }

            if (Convert.ToString(DS_Requerimiento.Tables[0].Rows[0][6]).TrimEnd() == "B")
            {
                Formato.CrystalReport.CR_Requerimiento_Bien crpt = new Formato.CrystalReport.CR_Requerimiento_Bien();
                crpt.Database.Tables["Requerimiento_Cabecera"].SetDataSource(DS_Requerimiento.Tables[0]);
                crpt.Database.Tables["Requerimiento_Detalle"].SetDataSource(DS_Requerimiento.Tables[1]);
                crpt.Database.Tables["Paso_Requerimiento"].SetDataSource(DS_Requerimiento.Tables[2]);
                Crv_Requerimiento.ReportSource = null;
                Crv_Requerimiento.ReportSource = crpt;
            }
            else
            {
                Formato.CrystalReport.CR_Requerimiento_Servicio crpt = new Formato.CrystalReport.CR_Requerimiento_Servicio();
                crpt.Database.Tables["Requerimiento_Cabecera"].SetDataSource(DS_Requerimiento.Tables[0]);
                crpt.Database.Tables["Requerimiento_Detalle"].SetDataSource(DS_Requerimiento.Tables[1]);
                crpt.Database.Tables["Paso_Requerimiento"].SetDataSource(DS_Requerimiento.Tables[2]);
                Crv_Requerimiento.ReportSource = null;
                Crv_Requerimiento.ReportSource = crpt;
            }
            this.ShowDialog();
        }

        private void Frm_Requerimiento_Load(object sender, EventArgs e)
        {

        }
    }
}
