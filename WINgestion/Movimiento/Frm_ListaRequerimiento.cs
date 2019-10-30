using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
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
    public partial class Frm_ListaRequerimiento : Form
    {
        private SRgestion.WCFgestionEClient objWCF = new SRgestion.WCFgestionEClient();
        private DataSet DS_ListaRequerimiento = new DataSet();
        private string strCodCentro_Gestor = MyStuff.CodigoCentroCosto;
        private Boolean blnMuestraFormato = true;
        public Frm_ListaRequerimiento()
        {
            InitializeComponent();
        }

        private void Frm_ListaRequerimiento_Load(object sender, EventArgs e)
        {
            this.VerRequerimiento("2");
        }

        private void VerRequerimiento(string strCodEstado)

        {

            Service.Requerimiento_Detalle SRD = new Service.Requerimiento_Detalle();
            if (MyStuff.UsaWCF == true)
            {
                DS_ListaRequerimiento = objWCF.Formato_Requerimiento_Ceco(strCodCentro_Gestor,
                                                                              strCodEstado,
                                                                              MyStuff.CodigoEmpleado
                                                                            );
            }
            else
            {
                DS_ListaRequerimiento = SRD.Formato_Requerimiento_Ceco(strCodCentro_Gestor,
                                                                         strCodEstado,
                                                                         MyStuff.CodigoEmpleado
                                                                            );
            }
            this.Grd_Buscados.DataSource = DS_ListaRequerimiento;
            if (blnMuestraFormato == true)
            {
                blnMuestraFormato = false;
                this.FormatoGrid();
            }

            if (DS_ListaRequerimiento.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow oRow in DS_ListaRequerimiento.Tables[0].Rows)
                {
                    string strNumRequerimiento = Convert.ToString(oRow["cNumRequerimiento"]);
                    string strNomTipoAdquisicion = Convert.ToString(oRow["vNomTipoAdquisicion"]);
                    string strPaso = Convert.ToString(oRow["cPaso"]);
                    this.MostrarRequerimiento(strNumRequerimiento, strNomTipoAdquisicion, strPaso);
                    break;
                }
            }
            else
            {
                this.OcultarRequerimiento();
            }


        }

        private void FormatoGrid()
        {
            //Infragistics.Win.UltraWinGrid.UltraGridBand oBand;
            //Infragistics.Win.UltraWinGrid.UltraGridColumn oColumn;
            this.Grd_Buscados.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_Buscados.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Buscados.DisplayLayout.Bands)
            {
                if (oBand.Columns.Exists("fImporteTotal"))
                {
                    oBand.Summaries.Add("Sum_fImporteTotal", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fImporteTotal"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fImporteTotal"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fImporteTotal"].Appearance.TextHAlign = HAlign.Right;
                }
            }

            this.Grd_Buscados.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Buscados.DisplayLayout.Bands)
            {
                foreach (Infragistics.Win.UltraWinGrid.UltraGridColumn oColumn in oBand.Columns)
                {
                    if (oColumn.DataType.ToString() == "System.Double")
                    {
                        oColumn.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right;
                        oColumn.Format = "#,###,###,###,###.00";
                    }

                    if (oColumn.DataType.ToString() == "System.Decimal")
                    {
                        oColumn.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right;
                        oColumn.Format = "#,###,###,###,###.00";
                    }
                }
            }

            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.Grd_Buscados.DisplayLayout.Bands[0];

            oBand0.Columns[0].Header.Caption = "Requerimiento";
            oBand0.Columns[0].Width = 100;
            oBand0.Columns[1].Header.Caption = "Fecha";
            oBand0.Columns[1].Width = 80;
            oBand0.Columns[1].CellActivation = Activation.NoEdit;
            oBand0.Columns[2].Header.Caption = "Importe";
            oBand0.Columns[2].Width = 110;
            oBand0.Columns[5].Header.Caption = "Tipo Adquisición";
            oBand0.Columns[5].Width = 110;
            oBand0.Columns[6].Header.Caption = "Detalle de Adquisición";
            oBand0.Columns[6].Width = 250;

            oBand0.Columns[3].Hidden = true;
            oBand0.Columns[4].Hidden = true;

        }

        private void MostrarRequerimiento(string strNumRequerimiento,
                                          string strNomTipoAdquisicion,
                                          string strPaso
                                         )
        {
            Service.Requerimiento_Detalle SRD = new Service.Requerimiento_Detalle();
            DataSet DS_Requerimiento = new DataSet();
            //if (this.opt_SinAutorizacion.Checked == true)
            //{
            //    if (strPaso.TrimEnd() == "01")
            //    {
            //        this.Btn_Descartar.Visible = false;
            //    }
            //    else
            //    {
            //        this.Btn_Descartar.Visible = true;
            //    }
            //    this.Btn_FirmaDigital.Visible = true;
            //}
            this.Crv_Requerimiento.Visible = true;

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



            //SplashScreenManager.CloseForm();
        }

        private void Grd_Buscados_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            e.Layout.Override.FilterUIType = FilterUIType.FilterRow;

            FilterOperatorDropDownItems val = FilterOperatorDropDownItems.Contains;
            Grd_Buscados.DisplayLayout.Override.FilterOperatorDropDownItems = val;

            FilterOperatorDefaultValue val1 = FilterOperatorDefaultValue.Contains;
            Grd_Buscados.DisplayLayout.Override.FilterOperatorDefaultValue = val1;

            Grd_Buscados.DisplayLayout.ScrollStyle = ScrollStyle.Immediate;
            Grd_Buscados.DisplayLayout.Scrollbars = Scrollbars.Both;
            Grd_Buscados.DisplayLayout.ColumnScrollbarSmallChange = 100;
            Grd_Buscados.DisplayLayout.UseScrollWindow = UseScrollWindow.None;
            this.Grd_Buscados.UseOsThemes = DefaultableBoolean.False;
        }

        private void Grd_Buscados_AfterSelectChange(object sender, Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_Buscados.ActiveRow;
            string strNumRequerimiento = Convert.ToString(oRow.Cells[0].Value);
            string strNomTipoAdquisicion = Convert.ToString(oRow.Cells[5].Value);
            string strPaso = Convert.ToString(oRow.Cells[3].Value);
            this.MostrarRequerimiento(strNumRequerimiento, strNomTipoAdquisicion, strPaso);
        }


        private void OcultarRequerimiento()
        {
            this.Crv_Requerimiento.Visible = false;
 
        }
    }
}
