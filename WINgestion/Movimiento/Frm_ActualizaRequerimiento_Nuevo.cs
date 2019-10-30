using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;

namespace WINgestion
{
    public partial class Frm_ActualizaRequerimiento_Nuevo : DevExpress.XtraEditors.XtraForm
    {
        private SRgestion.WCFgestionEClient objWCF = new SRgestion.WCFgestionEClient();
        private Model.Requerimiento_Cabecera MRC = new Model.Requerimiento_Cabecera();
        private Model.Requerimiento_Detalle MRD = new Model.Requerimiento_Detalle();
        private Model.Requerimiento_Detalle_Bien MRDB = new Model.Requerimiento_Detalle_Bien();
        private Model.Requerimiento_Detalle_Servicio MRDS = new Model.Requerimiento_Detalle_Servicio();
        public Frm_ActualizaRequerimiento_Nuevo()
        {
            InitializeComponent();
        }

        private void TSMI_NuevoItem_Click(object sender, EventArgs e)
        {

            if ( string.IsNullOrEmpty( Convert.ToString( this.Edt_Nota.Value  )  ) )
            {
                MessageBox.Show("Debe Ingresar la descripción de la adjudicación");
            }
            else
            {
                //Model.Requerimiento_Cabecera MRC = new Model.Requerimiento_Cabecera();
                if (string.IsNullOrEmpty(Convert.ToString(this.txt_NumRequerimiento.Value)))
                {

                    MRC.CañoProceso = MyStuff.AñoProceso;
                    MRC.CcodCeCo_Gestor = Convert.ToString(this.Txt_CodCentroCosto.Value);
                    MRC.DfecRequerimiento = Convert.ToDateTime(this.txt_FecRequerimiento.Value);
                    MRC.Tnota = Convert.ToString(this.Edt_Nota.Value);
                    MRC.Tjustificacion = Convert.ToString(this.Edt_Justificacion.Value);
                    if ( this.Opt_Bien.Checked == true  )
                    {
                        MRC.CcodTipoAdquisicion = "B";
                    }
                    else
                    {
                        MRC.CcodTipoAdquisicion = "S";
                    }
                    MRC.CcodPrioridad = Convert.ToString(this.Cbo_CodPrioridad.SelectedValue);
                    MRC.CcodTipoMoneda = Convert.ToString(this.Cbo_CodTipoMoneda.SelectedValue);
                    MRC.FtipoCambio = Convert.ToDouble(this.Txt_TipoCambio.Value);
                }

                MRD = new Model.Requerimiento_Detalle();
                MRDB = new Model.Requerimiento_Detalle_Bien();
                MRDS = new Model.Requerimiento_Detalle_Servicio();

                WINgestion.Frm_ActualizaRequerimiento_Nuevo_D frm = new WINgestion.Frm_ActualizaRequerimiento_Nuevo_D();
                frm.ShowMe(MRC, MRD, MRDB, MRDS,
                           "", "", "", "", "", "", "", "",
                           this.grd_mvto_Activo,
                           this.txt_NumRequerimiento
                           );
                MRC = frm.MRC;

            }
        }

        private void TSMI_ModificarItem_Click(object sender, EventArgs e)
        {
            MRD = new Model.Requerimiento_Detalle();
            MRDB = new Model.Requerimiento_Detalle_Bien();
            MRDS = new Model.Requerimiento_Detalle_Servicio();

            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.grd_mvto_Activo.ActiveRow;

            MRC.IidRequerimiento_Cabecera = Convert.ToInt32(oRow.Cells[0].Value);
            MRC.CnumRequerimiento = Convert.ToString(oRow.Cells[1].Value);
            MRC.DfecRequerimiento = Convert.ToDateTime(oRow.Cells[2].Value);
            MRC.Tnota = Convert.ToString(oRow.Cells[3].Value);
            MRD.IidRequerimiento_Detalle = Convert.ToInt32(oRow.Cells[4].Value);
            MRD.CcodFuenteFinanciamiento = Convert.ToString(oRow.Cells[5].Value);
            string strNomFuenteFinanciamiento = Convert.ToString(oRow.Cells[6].Value);  
            MRD.CcodCeCo = Convert.ToString(oRow.Cells[7].Value);
            string strNomCentroCosto = Convert.ToString(oRow.Cells[8].Value);
            MRD.CcodProyecto = Convert.ToString(oRow.Cells[9].Value);
            string strNomProyecto = Convert.ToString(oRow.Cells[10].Value);
            MRD.CcodComponente = Convert.ToString(oRow.Cells[11].Value);
            MRD.CcodPosPre = Convert.ToString(oRow.Cells[12].Value);
            string strNomPosicionPresupuestal = Convert.ToString(oRow.Cells[13].Value);
            MRD.CcodClasificador = Convert.ToString(oRow.Cells[14].Value);
            string strNomClasificador = Convert.ToString(oRow.Cells[15].Value);
            MRD.CcodTipoGasto = Convert.ToString(oRow.Cells[16].Value);
            string strNomTipoGasto = Convert.ToString(oRow.Cells[17].Value);
            string strNomTipoAdquisicion = Convert.ToString(oRow.Cells[19].Value);
            MRD.FimporteTotal = Convert.ToDouble(oRow.Cells[20].Value);
            MRDB.IidRequerimiento_Detalle_Bien = Convert.ToInt32(oRow.Cells[21].Value);
            MRDB.CcodMaterial = Convert.ToString(oRow.Cells[22].Value);
            string strNomMaterial = Convert.ToString(oRow.Cells[23].Value);
            MRDB.TespecificacionTecnica = Convert.ToString(oRow.Cells[24].Value);
            MRDB.CcodUnidadMedida = Convert.ToString(oRow.Cells[25].Value);
            string strNomUnidadMedida = Convert.ToString(oRow.Cells[26].Value);
            MRDB.Fcantidad = Convert.ToDouble(oRow.Cells[27].Value);
            MRDB.FprecioUnitario = Convert.ToDouble(oRow.Cells[28].Value);
            MRDB.Fstock = Convert.ToDouble(oRow.Cells[29].Value);
            MRDS.IidRequerimiento_Detalle_Servicio = Convert.ToInt32(oRow.Cells[30].Value);
            MRDS.CcodServicio = Convert.ToString(oRow.Cells[31].Value);
            string strNomServicio = Convert.ToString(oRow.Cells[32].Value);
            MRDS.TespecificacionTecnica = Convert.ToString(oRow.Cells[33].Value);

           WINgestion.Frm_ActualizaRequerimiento_Nuevo_D frm = new WINgestion.Frm_ActualizaRequerimiento_Nuevo_D();
            frm.ShowMe(MRC, MRD, MRDB, MRDS,
                       strNomFuenteFinanciamiento, strNomCentroCosto, strNomProyecto, strNomPosicionPresupuestal, 
                       strNomClasificador, strNomTipoGasto, strNomMaterial, strNomServicio,
                       this.grd_mvto_Activo,
                       this.txt_NumRequerimiento
                       );
            MRC = frm.MRC;
        }

        private void Frm_ActualizaRequerimiento_Nuevo_Load(object sender, EventArgs e)
        {
            this.Txt_CodCentroCosto.Value = MyStuff.CodigoCentroCosto;
            this.Txt_NomCentroCosto.Value = MyStuff.NombreCentroCosto;
            Service.Requerimiento_Detalle SRD = new Service.Requerimiento_Detalle();
            Service.DataGeneral SDG = new Service.DataGeneral();
            DataSet ds = new DataSet();
            txt_FecRequerimiento.Value = DateTime.Now.ToString("dd/MM/yyyy");
            if ( MyStuff.UsaWCF == true )
            {
                ds = objWCF.Lista_Requerimiento_Detalle("");
                this.Cbo_CodPrioridad.CargaDT( objWCF.Combo_Prioridad().Tables[0] );
                this.Cbo_CodTipoMoneda.CargaDT(objWCF.Combo_TipoMoneda().Tables[0]);
            }
            else
            {
                ds = SRD.Lista_Requerimiento_Detalle("");
                this.Cbo_CodPrioridad.CargaDT(SDG.Combo_Prioridad().Tables[0]);
                this.Cbo_CodTipoMoneda.CargaDT(SDG.Combo_TipoMoneda().Tables[0]);
            }
            
            this.grd_mvto_Activo.DataSource = ds;
            this.FormatoGrid();
        }

        private void FormatoGrid()
        {
            //Infragistics.Win.UltraWinGrid.UltraGridBand oBand;
            //Infragistics.Win.UltraWinGrid.UltraGridColumn oColumn;
            this.grd_mvto_Activo.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.grd_mvto_Activo.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.grd_mvto_Activo.DisplayLayout.Bands)
            {
                if (oBand.Columns.Exists("FimporteTotal"))
                {
                    oBand.Summaries.Add("Sum_FimporteTotal", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["FimporteTotal"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_FimporteTotal"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_FimporteTotal"].Appearance.TextHAlign = HAlign.Right;
                }
            }
            this.grd_mvto_Activo.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default


            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand  oBand in this.grd_mvto_Activo.DisplayLayout.Bands)
            {
                foreach (Infragistics.Win.UltraWinGrid.UltraGridColumn  oColumn in oBand.Columns)
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
                    if (oColumn.DataType.ToString() == "System.Int32")
                    {
                        oColumn.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right;
                        oColumn.Format = "#,###,###,###,###";
                    }
                }
            }

            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.grd_mvto_Activo.DisplayLayout.Bands[0];
            oBand0.Columns[6].Header.Caption = "Fuente Financiamiento";
            oBand0.Columns[6].Width = 150;
            oBand0.Columns[8].Header.Caption = "Centro de Costo";
            oBand0.Columns[8].Width = 150;
            oBand0.Columns[10].Header.Caption = "Proyecto";
            oBand0.Columns[10].Width = 150;
            oBand0.Columns[13].Header.Caption = "Posición Presupuestal";
            oBand0.Columns[13].Width = 150;
            oBand0.Columns[15].Header.Caption = "Clasificador";
            oBand0.Columns[15].Width = 150;
            oBand0.Columns[17].Header.Caption = "Tipo de Gasto";
            oBand0.Columns[17].Width = 100;
            oBand0.Columns[19].Header.Caption = "Adquisición";
            oBand0.Columns[19].Width = 80;
            oBand0.Columns[20].Header.Caption = "Requerido";
            oBand0.Columns[20].Width = 100;

            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[1].Hidden = true;
            oBand0.Columns[2].Hidden = true;
            oBand0.Columns[3].Hidden = true;
            oBand0.Columns[4].Hidden = true;
            oBand0.Columns[5].Hidden = true;

            oBand0.Columns[7].Hidden = true;
            oBand0.Columns[9].Hidden = true;
            oBand0.Columns[11].Hidden = true;
            oBand0.Columns[12].Hidden = true;

            oBand0.Columns[14].Hidden = true;
            oBand0.Columns[16].Hidden = true;
            oBand0.Columns[18].Hidden = true;


            oBand0.Columns[21].Hidden = true;
            oBand0.Columns[22].Hidden = true;
            oBand0.Columns[23].Hidden = true;
            oBand0.Columns[24].Hidden = true;
            oBand0.Columns[25].Hidden = true;
            oBand0.Columns[26].Hidden = true;
            oBand0.Columns[27].Hidden = true;
            oBand0.Columns[28].Hidden = true;
            oBand0.Columns[29].Hidden = true;
            oBand0.Columns[30].Hidden = true;
            oBand0.Columns[31].Hidden = true;
            oBand0.Columns[32].Hidden = true;
            oBand0.Columns[33].Hidden = true;

        }

        private void grd_mvto_Activo_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            e.Layout.Override.FilterUIType = FilterUIType.FilterRow;

            FilterOperatorDropDownItems val = FilterOperatorDropDownItems.Contains;
            this.grd_mvto_Activo.DisplayLayout.Override.FilterOperatorDropDownItems = val;

            FilterOperatorDefaultValue val1 = FilterOperatorDefaultValue.Contains;
            this.grd_mvto_Activo.DisplayLayout.Override.FilterOperatorDefaultValue = val1;

            this.grd_mvto_Activo.DisplayLayout.ScrollStyle = ScrollStyle.Immediate;
            this.grd_mvto_Activo.DisplayLayout.Scrollbars = Scrollbars.Both;
            this.grd_mvto_Activo.DisplayLayout.ColumnScrollbarSmallChange = 100;
            this.grd_mvto_Activo.DisplayLayout.UseScrollWindow = UseScrollWindow.None;
            //Grd_Buscados.DisplayLayout.UseFixedHeaders = true;
        }
    }
}