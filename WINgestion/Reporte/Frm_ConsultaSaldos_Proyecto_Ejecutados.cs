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
    public partial class Frm_ConsultaSaldos_Proyecto_Ejecutados : DevExpress.XtraEditors.XtraForm
    {

        private SRgestion.WCFgestionEClient objWCF = new SRgestion.WCFgestionEClient();

        public Frm_ConsultaSaldos_Proyecto_Ejecutados()
        {
            InitializeComponent();
        }

        public bool blnMostrarFormato = true;
        public DataTable DT_Requerimiento = new DataTable();

    

        public void ShowMe(string strAñoProceso,
                              string strCodProyecto,
                              string strCodClasificador
                            )
            {


                if (MyStuff.UsaWCF == true)
                {
                    DT_Requerimiento = objWCF.Lista_Ejecutado_Proyecto(strAñoProceso,
                                                                                strCodProyecto,
                                                                                strCodClasificador
                                                                                    ).Tables[0];
                }
                else
                {
                    Service.Requerimiento_Detalle SF = new Service.Requerimiento_Detalle();
                    DT_Requerimiento = SF.Lista_Ejecutado_Proyecto(strAñoProceso,
                                                                                strCodProyecto,
                                                                                strCodClasificador
                                                                                ).Tables[0];
                }

                if (DT_Requerimiento.Rows.Count > 0)
                {
                    Grd_Buscados.DataSource = DT_Requerimiento;
                    if (blnMostrarFormato == true)
                    {
                        blnMostrarFormato = false;
                        FormatoGrid();
                    this.AdicionaImagenesGrilla();
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

            Infragistics.Win.UltraWinGrid.UltraGridBand oBandPantalla;
            oBandPantalla = Grd_Buscados.DisplayLayout.Bands[0];

            oBandPantalla.Columns[0].Header.Caption = "Requerimiento";
            oBandPantalla.Columns[0].Width = 110;
            oBandPantalla.Columns[1].Header.Caption = "Fecha";
            oBandPantalla.Columns[1].Width = 80;
            oBandPantalla.Columns[2].Header.Caption = "Objeto Contratación";
            oBandPantalla.Columns[2].Width = 445;
            oBandPantalla.Columns[3].Header.Caption = "Tipo";
            oBandPantalla.Columns[3].Width = 60;
            oBandPantalla.Columns[4].Header.Caption = "Importe";
            oBandPantalla.Columns[4].Width = 110;
        }


        private void Frm_Requerimientos_Comprometidos_Load(object sender, EventArgs e)
        {

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


        private void AdicionaImagenesGrilla()
        {

            UltraGridBand band = this.Grd_Buscados.DisplayLayout.Bands[0];

            foreach (UltraGridRow row in band.GetRowEnumerator(GridRowType.DataRow))
            {
                RefrescarCeldaGrilla(row);
            }

        }

        private void RefrescarCeldaGrilla(Infragistics.Win.UltraWinGrid.UltraGridRow oRow)
        {
            oRow.Cells[0].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            oRow.Cells[0].Appearance.Image = this.imageList2.Images[0];
            oRow.Cells[0].ButtonAppearance.Image = this.imageList2.Images[0];
            oRow.Cells[0].ButtonAppearance.TextHAlign = HAlign.Right;

        }

        private void Grd_Buscados_ClickCellButton(object sender, CellEventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_Buscados.ActiveRow;
            string strNumRequerimiento = Convert.ToString(oRow.Cells[0].Value);

            if (e.Cell.Column.Index == 0)
            {
                WINgestion.Frm_Requerimiento frm = new WINgestion.Frm_Requerimiento();

                frm.ShowMe(strNumRequerimiento);

            }
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
