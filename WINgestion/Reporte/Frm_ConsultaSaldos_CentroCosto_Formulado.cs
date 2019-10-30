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
using Infragistics.Win;
using System.IO;

namespace WINgestion
{
    public partial class Frm_ConsultaSaldos_CentroCosto_Formulado : DevExpress.XtraEditors.XtraForm
    {
        

        private SRgestion.WCFgestionEClient objWCF = new SRgestion.WCFgestionEClient();

        public Frm_ConsultaSaldos_CentroCosto_Formulado()
        {
            InitializeComponent();
        }

        public bool blnMostrarFormato = true;
        public DataTable DT_Formulacion = new DataTable();

        public void ShowMe( string strAñoProceso,
                            string strCodCentroCosto_Gestor,
                            string strCodCentroCosto,
                            string strCodClasificador
                          )
        {
            

            if (MyStuff.UsaWCF == true)
            {
                DT_Formulacion = objWCF.Lista_Formulado_CentroCosto( strAñoProceso,
                                                        strCodCentroCosto_Gestor,
                                                        strCodCentroCosto,
                                                        strCodClasificador
                                                     ).Tables[0];
            }
            else
            {
                Service.Requerimiento_Detalle SRD = new Service.Requerimiento_Detalle();
                DT_Formulacion = SRD.Lista_Formulado_CentroCosto(strAñoProceso,
                                                        strCodCentroCosto_Gestor,
                                                        strCodCentroCosto,
                                                        strCodClasificador
                                                     ).Tables[0];
            }

            if (DT_Formulacion.Rows.Count > 0)
            {
                Grd_Buscados.DataSource = DT_Formulacion;
                if (blnMostrarFormato == true)
                {
                    blnMostrarFormato = false;
                    FormatoGrid();
                }

            }
            ShowDialog();
        }
       
 
        private void FormatoGrid()
        {
            Grd_Buscados.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            Grd_Buscados.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Buscados.DisplayLayout.Bands)
            {
                if (oBand.Columns.Exists("fImporte"))
                {
                    oBand.Summaries.Add("Sum_fImporte", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fImporte"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fImporte"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fImporte"].Appearance.TextHAlign = HAlign.Right;
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

            Infragistics.Win.UltraWinGrid.UltraGridBand oBandPantalla;
            oBandPantalla = Grd_Buscados.DisplayLayout.Bands[0];

            //oBandPantalla.Columns[1].Header.Caption = "Clase Gasto";
            //oBandPantalla.Columns[1].Width = 110;
            oBandPantalla.Columns[3].Header.Caption = "F.Financiamiento";
            oBandPantalla.Columns[3].Width = 145;
            oBandPantalla.Columns[5].Header.Caption = "C.Costo";
            oBandPantalla.Columns[5].Width = 150;
            oBandPantalla.Columns[7].Header.Caption = "Proyecto";
            oBandPantalla.Columns[7].Width = 150;
            oBandPantalla.Columns[9].Header.Caption = "Clasificador";
            oBandPantalla.Columns[9].Width = 150;
            oBandPantalla.Columns[11].Header.Caption = "Cuenta Contable";
            oBandPantalla.Columns[11].Width = 150;
            oBandPantalla.Columns[12].Header.Caption = "Descripción";
            oBandPantalla.Columns[12].Width = 150;
            oBandPantalla.Columns[13].Header.Caption = "Formulado";
            oBandPantalla.Columns[13].Width = 100;

            oBandPantalla.Columns[0].Hidden = true;
            oBandPantalla.Columns[1].Hidden = true;
            oBandPantalla.Columns[2].Hidden = true;
            oBandPantalla.Columns[4].Hidden = true;
            oBandPantalla.Columns[6].Hidden = true;
            oBandPantalla.Columns[8].Hidden = true;
            oBandPantalla.Columns[10].Hidden = true;
        }

        private void Btn_Exportar_Click(object sender, EventArgs e)
        {
            string strFile = "";
            if (this.SaveDocumento.ShowDialog() == DialogResult.OK)
            {
                strFile = this.SaveDocumento.FileName;
                DateTime start;
                TimeSpan timespan;

                start = DateTime.Now;

                try
                {
                    timespan = DateTime.Now.Subtract(start);

                    this.UltraGridExcelExporter1.Export(this.Grd_Buscados, strFile);

                }
                catch
                {
                    MessageBox.Show("Error", "Error");
                }
            }
        }

        private void Frm_ConsultaSaldos_CentroCosto_Formulado_Load(object sender, EventArgs e)
        {

        }

        private void Grd_Buscados_InitializeLayout(object sender, InitializeLayoutEventArgs e)
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
            //Grd_Buscados.DisplayLayout.UseFixedHeaders = true;
        }
    }
}
