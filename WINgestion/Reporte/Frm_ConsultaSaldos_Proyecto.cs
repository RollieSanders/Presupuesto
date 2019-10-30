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
    public partial class Frm_ConsultaSaldos_Proyecto : Form
    {
        private SRgestion.WCFgestionEClient objWCF = new SRgestion.WCFgestionEClient();
        private WINgestion.Framework FS = new WINgestion.Framework();
        private DataSet DS_Proyecto = new DataSet();
        private DataSet DS_Ejecucion = new DataSet();
        private Boolean blnPintaFormato = true;

        public Frm_ConsultaSaldos_Proyecto()
        {
            InitializeComponent();
        }

        private void Frm_ConsultaSaldos_Load(object sender, EventArgs e)
        {
            if (MyStuff.UsaWCF == true)
            {
                this.Cbo_AñoProceso.CargaDT(objWCF.Combo_AñoProceso("000000"));
                DS_Proyecto = objWCF.Ayuda_Proyecto();
                this.Txt_CodProyecto.nombreDS = DS_Proyecto;
            }
            else
            {
                Service.Proyecto SP = new Service.Proyecto();
                Service.Formulacion_Cabecera SFC = new Service.Formulacion_Cabecera();
                this.Cbo_AñoProceso.CargaDT(SFC.Combo_AñoProceso("000000"));
                DS_Proyecto = SP.Ayuda_Proyecto();
                this.Txt_CodProyecto.nombreDS = DS_Proyecto;


            }
            if (DS_Proyecto.Tables[0].Rows.Count > 1)
            {
                this.Txt_CodProyecto.Enabled = true;
            }
            else
            {
                this.Txt_CodProyecto.Enabled = false;
                this.Txt_CodProyecto.Value = Convert.ToString(DS_Proyecto.Tables[0].Rows[0][0]);
                this.Txt_NomProyecto.Value = Convert.ToString(DS_Proyecto.Tables[0].Rows[0][1]);
            }
        }

        private void Btn_Mostrar_Click(object sender, EventArgs e)
        {
            string strAñoProceso = Convert.ToString(this.Cbo_AñoProceso.SelectedValue);
            string strCodProyecto = Convert.ToString(this.Txt_CodProyecto.Value);
            Service.Requerimiento_Detalle SRD = new Service.Requerimiento_Detalle();
            if ( MyStuff.UsaWCF == true  )
            {
                DS_Ejecucion = objWCF.Lista_EjecucionPresupuestal_Proyecto( strAñoProceso, strCodProyecto  );
            }
            else
            {
                DS_Ejecucion = SRD.Lista_EjecucionPresupuestal_Proyecto(strAñoProceso, strCodProyecto);
            }
            this.Grd_Saldos.DataSource = DS_Ejecucion;
            if (blnPintaFormato == true)
            {
                blnPintaFormato = false;
                this.FormatoGrid();
            }
            this.AdicionaImagenesGrilla();
        }

        private void FormatoGrid()
        {
            Grd_Saldos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            Grd_Saldos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Saldos.DisplayLayout.Bands)
            {
                if (oBand.Columns.Exists("fFormulado"))
                {
                    oBand.Summaries.Add("Sum_fFormulado", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fFormulado"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fFormulado"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fFormulado"].Appearance.TextHAlign = HAlign.Right;
                }

                if (oBand.Columns.Exists("fComprometido"))
                {
                    oBand.Summaries.Add("Sum_fComprometido", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fComprometido"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fComprometido"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fComprometido"].Appearance.TextHAlign = HAlign.Right;
                }

                if (oBand.Columns.Exists("fEjecutado"))
                {
                    oBand.Summaries.Add("Sum_fEjecutado", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fEjecutado"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fEjecutado"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fEjecutado"].Appearance.TextHAlign = HAlign.Right;
                }

                if (oBand.Columns.Exists("fDisponible"))
                {
                    oBand.Summaries.Add("Sum_fDisponible", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fDisponible"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fDisponible"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fDisponible"].Appearance.TextHAlign = HAlign.Right;
                }
            }
            this.Grd_Saldos.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Saldos.DisplayLayout.Bands)
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
            oBandPantalla = Grd_Saldos.DisplayLayout.Bands[0];

            oBandPantalla.Columns[0].Header.Caption = "Proyecto";
            oBandPantalla.Columns[0].Width = 100;
            oBandPantalla.Columns[1].Header.Caption = "Nombre Proyecto";
            oBandPantalla.Columns[1].Width = 130;
            oBandPantalla.Columns[2].Header.Caption = "Clasificador";
            oBandPantalla.Columns[2].Width = 70;
            oBandPantalla.Columns[3].Header.Caption = "Nombre Clasificador";
            oBandPantalla.Columns[3].Width = 280;
            oBandPantalla.Columns[4].Header.Caption = "Formulado";
            oBandPantalla.Columns[4].Width = 110;
            oBandPantalla.Columns[5].Header.Caption = "Comprometido";
            oBandPantalla.Columns[5].Width = 110;
            oBandPantalla.Columns[6].Header.Caption = "Real";
            oBandPantalla.Columns[6].Width = 110;
            oBandPantalla.Columns[7].Header.Caption = "Disponible";
            oBandPantalla.Columns[7].Width = 110;
            oBandPantalla.Columns[8].Header.Caption = "Real vs Formulado";
            oBandPantalla.Columns[8].Width = 110;
            oBandPantalla.Columns[8].Format = "#,###,###,###,###.00 %"; ;
            oBandPantalla.Columns[9].Header.Caption = "Comprometido vs Formulado";
            oBandPantalla.Columns[9].Width = 110;
            oBandPantalla.Columns[9].Format = "#,###,###,###,###.00 %"; ;
            oBandPantalla.Columns[10].Header.Caption = "Disponible vs Formulado";
            oBandPantalla.Columns[10].Width = 110;
            oBandPantalla.Columns[10].Format = "#,###,###,###,###.00 %";
            oBandPantalla.Columns[0].Hidden = true;
        }

        private void Grd_Saldos_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            e.Layout.Override.FilterUIType = FilterUIType.FilterRow;

            FilterOperatorDropDownItems val = FilterOperatorDropDownItems.Contains;
            Grd_Saldos.DisplayLayout.Override.FilterOperatorDropDownItems = val;

            FilterOperatorDefaultValue val1 = FilterOperatorDefaultValue.Contains;
            Grd_Saldos.DisplayLayout.Override.FilterOperatorDefaultValue = val1;

            Grd_Saldos.DisplayLayout.ScrollStyle = ScrollStyle.Immediate;
            Grd_Saldos.DisplayLayout.Scrollbars = Scrollbars.Both;
            Grd_Saldos.DisplayLayout.ColumnScrollbarSmallChange = 100;
            Grd_Saldos.DisplayLayout.UseScrollWindow = UseScrollWindow.None;
            //Grd_Saldos.DisplayLayout.UseFixedHeaders = true;
        }

        private void AdicionaImagenesGrilla()
        {

            UltraGridBand band = this.Grd_Saldos.DisplayLayout.Bands[0];

            foreach (UltraGridRow row in band.GetRowEnumerator(GridRowType.DataRow))
            {
                RefrescarCeldaGrilla(row);
            }

        }

        private void RefrescarCeldaGrilla(Infragistics.Win.UltraWinGrid.UltraGridRow oRow)
        {
            if (Convert.ToDouble(oRow.Cells[4].Value) != 0) // Formulado
            {
                oRow.Cells[4].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                oRow.Cells[4].Appearance.Image = this.imageList2.Images[0];
                oRow.Cells[4].ButtonAppearance.Image = this.imageList2.Images[0];
                oRow.Cells[4].ButtonAppearance.TextHAlign = HAlign.Right;
            }

            if (Convert.ToDouble(oRow.Cells[5].Value) != 0) // Comprometido
            {
                oRow.Cells[5].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                oRow.Cells[5].Appearance.Image = this.imageList2.Images[0];
                oRow.Cells[5].ButtonAppearance.Image = this.imageList2.Images[0];
                oRow.Cells[5].ButtonAppearance.TextHAlign = HAlign.Right;
            }

            if (Convert.ToDouble(oRow.Cells[6].Value) != 0) // Real
            {
                oRow.Cells[6].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                oRow.Cells[6].Appearance.Image = this.imageList2.Images[0];
                oRow.Cells[6].ButtonAppearance.Image = this.imageList2.Images[0];
                oRow.Cells[6].ButtonAppearance.TextHAlign = HAlign.Right;
            }
            if (Convert.ToDouble(oRow.Cells[7].Value) != 0) // Disponible
            {
                oRow.Cells[7].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                oRow.Cells[7].Appearance.Image = this.imageList2.Images[0];
                oRow.Cells[7].ButtonAppearance.Image = this.imageList2.Images[0];
                oRow.Cells[7].ButtonAppearance.TextHAlign = HAlign.Right;
            }

        }

        private void Txt_CodCentroCosto_Leave(object sender, EventArgs e)
        {
            this.Txt_NomProyecto.Value = FS.TraerDescripcion_DataTable(DS_Proyecto.Tables[0],
                                                                                   0,
                                                                                   1,
                                                                                   Convert.ToString(this.Txt_CodProyecto.Value)
                                                                                 );
        }

        private void Grd_Saldos_ClickCellButton(object sender, CellEventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_Saldos.ActiveRow;
            string strAñoProceso = Convert.ToString(this.Cbo_AñoProceso.SelectedValue);
            string strCodProyecto = Convert.ToString(oRow.Cells[0].Value);
            string strCodClasificador = Convert.ToString(oRow.Cells[2].Value);

            if (e.Cell.Column.Index == 4)
            {
                if (Convert.ToDouble(oRow.Cells[4].Value) > 0)
                {
                    WINgestion.Frm_ConsultaSaldos_Proyecto_Formulado frm = new WINgestion.Frm_ConsultaSaldos_Proyecto_Formulado();

                    frm.ShowMe(strAñoProceso,
                                strCodProyecto,
                                strCodClasificador
                              );

                }
            }

            if (e.Cell.Column.Index == 5)
            {
                if (Convert.ToDouble(  oRow.Cells[5].Value ) > 0 )
                {
                    WINgestion.Frm_ConsultaSaldos_Proyecto_Comprometidos frm = new WINgestion.Frm_ConsultaSaldos_Proyecto_Comprometidos();

                    frm.ShowMe(strAñoProceso,
                                strCodProyecto,
                                strCodClasificador
                              );

                }
            }

            if (e.Cell.Column.Index == 6)
            {
                if (Convert.ToDouble(oRow.Cells[6].Value) > 0)
                {
                    WINgestion.Frm_ConsultaSaldos_Proyecto_Ejecutados frm = new WINgestion.Frm_ConsultaSaldos_Proyecto_Ejecutados();

                    frm.ShowMe(strAñoProceso,
                                strCodProyecto,
                                strCodClasificador
                              );
                }

                    
            }

            if (e.Cell.Column.Index == 7)
            {
                if (Convert.ToDouble(oRow.Cells[7].Value) > 0)
                {
                    WINgestion.Frm_ConsultaSaldos_Proyecto_Disponible frm = new WINgestion.Frm_ConsultaSaldos_Proyecto_Disponible();

                    frm.ShowMe(strAñoProceso,
                                strCodProyecto,
                                strCodClasificador
                              );
                }


            }

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

                        this.UltraGridExcelExporter1.Export(this.Grd_Saldos, strFile);

                    }
                    catch
                    {
                        MessageBox.Show("Error", "Error");
                    }
                }
    
        }
    }
}
