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

namespace WINgestion
{
    public partial class Frm_ActualizaRequerimiento_Nuevo_D : DevExpress.XtraEditors.XtraForm
    {
        private SRgestion.WCFgestionEClient objWCF = new SRgestion.WCFgestionEClient();
        DataSet DS_Bien = new DataSet();
        DataSet DS_Servicio = new DataSet();

        public Model.Requerimiento_Cabecera MRC = new Model.Requerimiento_Cabecera();
        private Model.Requerimiento_Detalle MRD = new Model.Requerimiento_Detalle();
        private Model.Requerimiento_Detalle_Bien MRDB = new Model.Requerimiento_Detalle_Bien();
        private Model.Requerimiento_Detalle_Servicio MRDS = new Model.Requerimiento_Detalle_Servicio();
        private WINgestion.Framework FS = new WINgestion.Framework();

        //private SRformulacion.WCFformulacionEClient objWCF = new SRformulacion.WCFformulacionEClient();

        private Infragistics.Win.UltraWinGrid.UltraGrid m_Grid;
        Infragistics.Win.UltraWinEditors.UltraTextEditor m_text;

        public Frm_ActualizaRequerimiento_Nuevo_D()
        {
            InitializeComponent();
        }

        public void ShowMe( Model.Requerimiento_Cabecera _MRC,
                            Model.Requerimiento_Detalle _MRD,
                            Model.Requerimiento_Detalle_Bien _MRDB,
                            Model.Requerimiento_Detalle_Servicio _MRDS,
                            string strNomFuenteFinanciamiento,
                            string strNomCentroCosto,
                            string strNomProyecto,
                            string strNomPosicionPresupuestal,
                            string strNomClasificador,
                            string strNomTipoGasto,
                            string strNomMaterial,
                            string strNomServicio,
                            Infragistics.Win.UltraWinGrid.UltraGrid Grid,
                            Infragistics.Win.UltraWinEditors.UltraTextEditor text
                          )
        {
            if (_MRC.CcodTipoAdquisicion.TrimEnd() == "B")
            {
                this.UTC_Principal.SelectedTab = this.UTC_Principal.Tabs["Bien"];
                this.Text = "REQUERIMIENTO DE BIEN";
            }
            else
            {
                this.UTC_Principal.SelectedTab = this.UTC_Principal.Tabs["Servicio"];
                this.Text = "REQUERIMIENTO DE SERVICIO";
            }
                


            MRC = _MRC;
            MRD = _MRD;
            MRDB = _MRDB;
            MRDS = _MRDS;

            m_Grid = Grid;
            m_text = text;

            Model.PosicionPresupuestal MPP = new Model.PosicionPresupuestal();
            Service.PosicionPresupuestal SPP = new Service.PosicionPresupuestal();
            Service.Clasificacion SC = new Service.Clasificacion();

            if (MyStuff.UsaWCF == true)
            {
                DS_Bien = objWCF.Ayuda_Material("");
                DS_Servicio = objWCF.Ayuda_Servicio("");
                this.Cbo_CodUnidadMedida.CargaDT( objWCF.Combo_UnidadMedida().Tables[0] );
            }
            else
            {
                Service.Material SM = new Service.Material();
                Service.DataGeneral SDG = new Service.DataGeneral();

                DS_Bien = SM.Ayuda_Material("");
                DS_Servicio = SM.Ayuda_Servicio("");
                this.Cbo_CodUnidadMedida.CargaDT( SDG.Combo_UnidadMedida().Tables[0] );
            }

            this.Txt_CodMaterial.nombreDS = DS_Bien;
            this.Txt_CodServicio.nombreDS = DS_Servicio;

            if ( MRD.IidRequerimiento_Detalle != 0  )
            {
                this.Btn_Grabar_Salir.Visible = false;

                this.Txt_CodFuenteFinanciamiento.Value = MRD.CcodFuenteFinanciamiento;
                this.Txt_NomFuenteFinanciamiento.Value = strNomFuenteFinanciamiento;
                this.Txt_CodCentroCosto.Value = MRD.CcodCeCo;
                this.Txt_NomCentroCosto.Value = strNomCentroCosto;
                this.Txt_CodProyecto.Value = MRD.CcodProyecto;
                this.Txt_NomProyecto.Value = strNomProyecto;
                this.Txt_CodPosicionPresupuestal.Value = MRD.CcodPosPre;
                this.Txt_NomPosicionPresupuestal.Value = strNomPosicionPresupuestal;
                this.Txt_CodClasificacion.Value = MRD.CcodClasificador;
                this.Txt_NomClasificacion.Value = strNomClasificador;
                this.Txt_CodTipoGasto.Value = MRD.CcodTipoGasto;
                this.Txt_NomTipoGasto.Value = strNomTipoGasto;

                if ( MRC.CcodTipoAdquisicion.TrimEnd() == "B"  )
                {

                    this.Txt_CodMaterial.Value = MRDB.CcodMaterial;
                    this.Txt_NomMaterial.Value = strNomMaterial;
                    this.Txt_Stock.Value = MRDB.Fstock;
                    this.Edt_EspecificacionTecnica.Value = MRDB.TespecificacionTecnica;
                    this.Txt_Cantidad.Value = MRDB.Fcantidad;
                    this.Cbo_CodUnidadMedida.SelectedValue = MRDB.CcodUnidadMedida;
                    this.Txt_Precio.Value = MRDB.FprecioUnitario;
                    this.Txt_ImporteTotal_B.Value = MRD.FimporteTotal;
                }
                else
                {
                    this.Txt_CodServicio.Value = MRDS.CcodServicio;
                    this.Txt_NomServicio.Value = strNomServicio;
                    this.Txt_EspecificacionServicio.Value = MRDS.TespecificacionTecnica;
                    this.Txt_ImporteTotal_S.Value = MRD.FimporteTotal;
                }
            }

            this.ShowDialog();
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            string strCodCompañia = "000000";
            string strAñoProceso = MyStuff.AñoProceso;
            string strCodCentroCosto_Gestor = MyStuff.CodigoCentroCosto;
            string strCodFuenteFinanciamiento = Convert.ToString(this.Txt_CodFuenteFinanciamiento.Value);
            string strCodCentroCosto = Convert.ToString(this.Txt_CodCentroCosto.Value);
            string strCodProyecto = Convert.ToString(this.Txt_CodProyecto.Value);

            Frm_Formulacion frm = new Frm_Formulacion();
            frm.Showme( strCodCompañia, 
                        strAñoProceso, 
                        strCodCentroCosto_Gestor, 
                        strCodFuenteFinanciamiento, 
                        strCodCentroCosto, 
                        strCodProyecto,
                        MRC.CcodTipoAdquisicion
                        );
            if ( frm.blnEligio == true )
            {
                this.Txt_CodFuenteFinanciamiento.Value = frm.strCodFuenteFinanciamiento;
                this.Txt_NomFuenteFinanciamiento.Value = frm.strNomFuenteFinanciamiento;
                this.Txt_CodCentroCosto.Value = frm.strCodCentroCosto;
                this.Txt_NomCentroCosto.Value = frm.strNomCentroCosto;
                this.Txt_CodProyecto.Value = frm.strCodProyecto;
                this.Txt_NomProyecto.Value = frm.strNomProyecto;

                this.Txt_CodPosicionPresupuestal.Value = frm.strCodPosPre;
                this.Txt_NomPosicionPresupuestal.Value = frm.strNomPosPre;
                this.Txt_CodClasificacion.Value = frm.strCodClasificacion;
                this.Txt_NomClasificacion.Value = frm.strNomClasificacion;
                this.Txt_CodTipoGasto.Value = frm.strCodTipoGasto;
                this.Txt_NomTipoGasto.Value = frm.strNomTipoGasto;

                this.Edt_EspecificacionTecnica.Value = frm.strDescripcion;
                this.Txt_EspecificacionServicio.Value = frm.strDescripcion;

                Model.Formulacion_Saldo MFS = new Model.Formulacion_Saldo();
                MFS.CañoProceso = MyStuff.AñoProceso;
                MFS.CcodFuenteFinanciamiento = frm.strCodFuenteFinanciamiento;
                MFS.CcodCeCo_Gestor = frm.strCodCentroCosto;
                MFS.CcodProyecto = frm.strCodProyecto;
                MFS.CcodClasificador = frm.strCodClasificacion;
                MFS.CcodPosPre = frm.strCodPosPre;
                MFS.CcodTipoGasto = frm.strCodTipoGasto;

                if ( MRC.CcodTipoAdquisicion.TrimEnd() == "S" )
                {
                    if (  MyStuff.UsaWCF == true )
                    {
                        DS_Servicio = objWCF.Ayuda_Servicio(frm.strCodPosPre);
                    }
                    else
                    {
                        Service.Material SM = new Service.Material ();
                        DS_Servicio = SM.Ayuda_Servicio(frm.strCodPosPre);
                    }
                    this.Txt_CodServicio.nombreDS = DS_Servicio;
                }


                Service.Requerimiento SFS = new Service.Requerimiento();
                if ( MyStuff.UsaWCF == true )
                {
                        MFS = objWCF.Recupera_Formulacion_Sado(MFS);
                }
                else
                {
                    MFS = SFS.Recupera_Formulacion_Sado(MFS);
                }

                this.Txt_Formulado_B.Value = MFS.fFormulado;
                this.Txt_Ejecutado_B.Value = MFS.FimporteEjecutado;
                this.Txt_Comprometido_B.Value = MFS.FimporteComprometido;
                this.Txt_Saldo_B.Value = MFS.fFormulado - (MFS.FimporteEjecutado + MFS.FimporteComprometido);

                this.Txt_Formulado_S.Value = MFS.fFormulado;
                this.Txt_Ejecutado_S.Value = MFS.FimporteEjecutado;
                this.Txt_Comprometido_S.Value = MFS.FimporteComprometido;
                this.Txt_Saldo_S.Value = MFS.fFormulado - (MFS.FimporteEjecutado + MFS.FimporteComprometido);

                if (MFS.FimporteEjecutado>0)
                {
                    this.Btn_Ejecutado_B.Visible = true;
                    this.Btn_Ejecutado_S.Visible = true;
                }
                else
                {
                    this.Btn_Ejecutado_B.Visible = false;
                    this.Btn_Ejecutado_S.Visible = false;
                }
                if (MFS.FimporteComprometido > 0)
                {
                    this.Btn_Comprometido_B.Visible = true;
                    this.Btn_Comprometido_S.Visible = true;
                }
                else
                {
                    this.Btn_Comprometido_B.Visible = false;
                    this.Btn_Comprometido_S.Visible = false;
                }
            }
        }

        private void Frm_ActualizaRequerimiento_Nuevo_D_Load(object sender, EventArgs e)
        {
            //if (MyStuff.UsaWCF == true)
            //{

            //}
            //else
            //{
            //    Service.Material SM = new Service.Material();
            //    Service.DataGeneral SDG = new Service.DataGeneral();

            //    DS_Bien = SM.Ayuda_Material("");
            //    DS_Servicio = SM.Ayuda_Servicio();
            //    this.Cbo_CodUnidadMedida.CargaDT( SDG.Combo_UnidadMedida().Tables[0] );
            //}

            //this.Txt_CodMaterial.nombreDS = DS_Bien;
            //this.Txt_CodServicio.nombreDS = DS_Servicio;
        }

        private void Txt_CodMaterial_Leave(object sender, EventArgs e)
        {
            string strCodMaterial = FS.TraerDescripcion_DataTable(DS_Bien.Tables[0],
                                                                                   1,
                                                                                   2,
                                                                                   Convert.ToString(this.Txt_CodMaterial.Value)
                                                                                 );

            if ( string.IsNullOrEmpty( strCodMaterial ) )
            {
                this.Txt_NomMaterial.Value = "";
                this.Txt_Stock.Value = 0;
                this.Cbo_CodUnidadMedida.SelectedValue = "";
            }
            else
            {
                this.Txt_NomMaterial.Value = FS.TraerDescripcion_DataTable(DS_Bien.Tables[0],
                                                                                       1,
                                                                                       2,
                                                                                       Convert.ToString(this.Txt_CodMaterial.Value)
                                                                                     );

                this.Txt_Stock.Value = Convert.ToDouble(FS.TraerDescripcion_DataTable(DS_Bien.Tables[0],
                                                                                       1,
                                                                                       3,
                                                                                       Convert.ToString(this.Txt_CodMaterial.Value)
                                                                                     )
                                                        );

                this.Cbo_CodUnidadMedida.SelectedValue = FS.TraerDescripcion_DataTable(DS_Bien.Tables[0],
                                                                                       1,
                                                                                       4,
                                                                                       Convert.ToString(this.Txt_CodMaterial.Value)
                                                                                     );

                this.Cbo_CodUnidadMedida.Enabled = false;

            }
        }

        private void Txt_CodServicio_Leave(object sender, EventArgs e)
        {

            this.Txt_NomServicio.Value = FS.TraerDescripcion_DataTable(DS_Servicio.Tables[0],
                                                                                   0,
                                                                                   1,
                                                                                   Convert.ToString(this.Txt_CodServicio.Value)
                                                                                 );
        }

        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            string strMensaje = "";

            if (MRC.CcodTipoAdquisicion.TrimEnd() == "B")
            {
                if (string.IsNullOrEmpty(Convert.ToString(this.Txt_CodMaterial.Value)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Código del Material";
                }


                if (string.IsNullOrEmpty(Convert.ToString(this.Edt_EspecificacionTecnica.Value)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar la Especificación técnica del Material";
                }

                if (string.IsNullOrEmpty(Convert.ToString(this.Cbo_CodUnidadMedida.SelectedValue)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar la Unidad de Medida";
                }

                if (Convert.ToDouble(this.Txt_Precio.Value) == 0)
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Precio Unitario";
                }

                if (Convert.ToDouble(this.Txt_ImporteTotal_B.Value) > Convert.ToDouble(this.Txt_Saldo_B.Value) )
                {
                    blnVerifica = false;
                    strMensaje = "El Total NO debe ser mayor que el Saldo";
                }


            }
            else
            {
                if (string.IsNullOrEmpty(Convert.ToString(this.Txt_CodServicio.Value)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Código del Servicio";
                }


                if (string.IsNullOrEmpty(Convert.ToString(this.Txt_EspecificacionServicio.Value)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar la Especificación del Servicio";
                }


                if (Convert.ToDouble(this.Txt_ImporteTotal_S.Value) == 0)
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Valor del Servicio";
                }

                if (Convert.ToDouble(this.Txt_ImporteTotal_S.Value) > Convert.ToDouble(this.Txt_Saldo_S.Value))
                {
                    blnVerifica = false;
                    strMensaje = "El Total NO debe ser mayor que el Saldo";
                }
            }



            if (blnVerifica == false)
            {
                MessageBox.Show(strMensaje,
                                "Error", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Error
                           );
            }
            return blnVerifica;
        }

        private void Txt_Cantidad_Leave(object sender, EventArgs e)
        {
            this.Txt_ImporteTotal_B.Value = Convert.ToDouble(this.Txt_Cantidad.Value)  * Convert.ToDouble( this.Txt_Precio.Value);
        }

        private void Txt_Precio_Leave(object sender, EventArgs e)
        {
            this.Txt_ImporteTotal_B.Value = Convert.ToDouble(this.Txt_Cantidad.Value) * Convert.ToDouble(this.Txt_Precio.Value);
        }

        private void btn_Grabar_Salir_Click(object sender, EventArgs e)
        {
            if ( Grabar() == true  )
            {
                this.Close();
            }
        }

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            if ( MRD.IidRequerimiento_Detalle != 0 && this.Btn_Grabar_Salir.Visible == false  )
            {
                if (Grabar() == true)
                {
                    this.Close();
                }
            }
            else
            {
                if (Grabar() == true)
                {
                    if (MRC.CcodTipoAdquisicion.TrimEnd() == "B")
                    {
                        this.BlanquearDatosBien();
                        this.Txt_CodMaterial.Focus();
                    }
                    else
                    {
                        this.BlanquearDatosServicio();
                        this.Txt_CodServicio.Focus();
                    }
                }
            }

            
        }


        private Boolean Grabar()
        {
            Boolean blnGrabo = false;

            if (VerificaIngresoMovimiento() == true )
            {
            Model.Requerimiento_Cabecera _SRC = new Model.Requerimiento_Cabecera();
            Service.Requerimiento_Cabecera SRC = new Service.Requerimiento_Cabecera();

            if ( MRC.IidRequerimiento_Cabecera == 0 )
            {
                if (MyStuff.UsaWCF == true)
                {
                    _SRC = objWCF.Graba_Requerimiento_Cabecera(MRC);
                }
                else
                {
                    _SRC = SRC.Graba_Requerimiento_Cabecera(MRC);
                }
                

                MRC.IidRequerimiento_Cabecera = _SRC.IidRequerimiento_Cabecera;
                MRC.CnumRequerimiento = _SRC.CnumRequerimiento;
                m_text.Value = _SRC.CnumRequerimiento;
            }
            else
            {
                if (MyStuff.UsaWCF == true)
                {
                    MRC.IidRequerimiento_Cabecera = objWCF.Modifica_Requerimiento_Cabecera(MRC);
                }
                else
                {
                    MRC.IidRequerimiento_Cabecera = SRC.Modifica_Requerimiento_Cabecera(MRC);
                }
                    
            }
            MRD.IidRequerimiento_Cabecera = MRC.IidRequerimiento_Cabecera;
            MRD.CcodFuenteFinanciamiento = Convert.ToString(this.Txt_CodFuenteFinanciamiento.Value);
            MRD.CcodCeCo = Convert.ToString(this.Txt_CodCentroCosto.Value);
            MRD.CcodProyecto = Convert.ToString(this.Txt_CodProyecto.Value);
            MRD.CcodComponente = "";

            MRD.CcodPosPre = Convert.ToString(this.Txt_CodPosicionPresupuestal.Value);
            MRD.CcodClasificador = Convert.ToString(this.Txt_CodClasificacion.Value);
            MRD.CcodTipoGasto = Convert.ToString(this.Txt_CodTipoGasto.Value);
            if(MRC.CcodTipoAdquisicion.TrimEnd() == "B" )
            {
                MRD.FimporteTotal = Convert.ToDouble(this.Txt_ImporteTotal_B.Value);
                this.Txt_Comprometido_B.Value = Convert.ToDouble( this.Txt_Comprometido_B.Value ) + MRD.FimporteTotal;
                this.Txt_Saldo_B.Value = Convert.ToDouble( this.Txt_Saldo_B.Value ) - MRD.FimporteTotal;
            }
            else
            {
                MRD.FimporteTotal = Convert.ToDouble( this.Txt_ImporteTotal_S.Value );
                this.Txt_Comprometido_S.Value = Convert.ToDouble(this.Txt_Comprometido_S.Value) + MRD.FimporteTotal;
                this.Txt_Saldo_S.Value = Convert.ToDouble(this.Txt_Saldo_S.Value) - MRD.FimporteTotal;
            }

            Service.Requerimiento_Detalle SRD = new Service.Requerimiento_Detalle();
            if ( MRD.IidRequerimiento_Detalle == 0  )
            {
                if (MyStuff.UsaWCF == true)
                {
                    MRD.IidRequerimiento_Detalle = objWCF.Graba_Requerimiento_Detalle(MRD);
                }
                else
                {
                    MRD.IidRequerimiento_Detalle = SRD.Graba_Requerimiento_Detalle(MRD);
                }
                    
            }
            else
            {
                if (MyStuff.UsaWCF == true)
                {
                    MRD.IidRequerimiento_Detalle = objWCF.Modifica_Requerimiento_Detalle(MRD);
                }
                else
                {
                    MRD.IidRequerimiento_Detalle = SRD.Modifica_Requerimiento_Detalle(MRD);
                }
                    
            }

            if (MRC.CcodTipoAdquisicion.TrimEnd() == "B")
                {
                MRDB.IidRequerimiento_Detalle = MRD.IidRequerimiento_Detalle;
                MRDB.CcodMaterial = Convert.ToString(this.Txt_CodMaterial.Value);
                MRDB.TespecificacionTecnica = Convert.ToString(this.Edt_EspecificacionTecnica.Value);
                MRDB.Fcantidad = Convert.ToDouble(this.Txt_Cantidad.Value);
                if ( MRC.CcodTipoMoneda.TrimEnd() == "LO"  )
                {
                   MRDB.FprecioUnitario = Convert.ToDouble(this.Txt_Precio.Value);
                   MRDB.FprecioUnitario_Extranjero = Convert.ToDouble(this.Txt_Precio.Value);
                }
                else
                {
                   MRDB.FprecioUnitario = Convert.ToDouble(this.Txt_Precio.Value);
                   MRDB.FprecioUnitario_Extranjero = Convert.ToDouble(this.Txt_Precio.Value) * MRC.FtipoCambio;
                }
                
                MRDB.CcodUnidadMedida = Convert.ToString(this.Cbo_CodUnidadMedida.SelectedValue);

                Service.Requerimiento_Detalle_Bien SRDB = new Service.Requerimiento_Detalle_Bien();
                if ( MRDB.IidRequerimiento_Detalle_Bien == 0)
                {
                    if (MyStuff.UsaWCF == true)
                    {
                        MRDB.IidRequerimiento_Detalle_Bien = objWCF.Graba_Requerimiento_Detalle_Bien(MRDB);
                    }
                    else
                    {
                        MRDB.IidRequerimiento_Detalle_Bien = SRDB.Graba_Requerimiento_Detalle_Bien(MRDB);
                    }
                        
                }
                else
                {
                    if (MyStuff.UsaWCF == true)
                    {
                        MRDB.IidRequerimiento_Detalle_Bien = objWCF.Modifica_Requerimiento_Detalle_Bien(MRDB);
                    }
                    else
                    {
                        MRDB.IidRequerimiento_Detalle_Bien = SRDB.Modifica_Requerimiento_Detalle_Bien(MRDB);
                    }
                        
                }
            }
            else
            {
                MRDS.IidRequerimiento_Detalle = MRD.IidRequerimiento_Detalle;
                MRDS.CcodServicio = Convert.ToString(this.Txt_CodServicio.Value);
                MRDS.TespecificacionTecnica = Convert.ToString(this.Txt_EspecificacionServicio.Value);
                if (MRC.CcodTipoMoneda.TrimEnd() == "LO")
                {
                   MRDS.Fprecio = Convert.ToDouble(this.Txt_ImporteTotal_S.Value);
                   MRDS.Fprecio_Extranjero = Convert.ToDouble(this.Txt_ImporteTotal_S.Value);
                }
                else
                {
                   MRDS.Fprecio = Convert.ToDouble(this.Txt_ImporteTotal_S.Value);
                   MRDS.Fprecio_Extranjero = Convert.ToDouble(this.Txt_ImporteTotal_S.Value) * MRC.FtipoCambio;
                }

                    Service.Requerimiento_Detalle_Servicio SRDS = new Service.Requerimiento_Detalle_Servicio();
                if ( MRDS.IidRequerimiento_Detalle_Servicio == 0 )
                {
                    if (MyStuff.UsaWCF == true)
                    {
                        MRDS.IidRequerimiento_Detalle_Servicio = objWCF.Graba_Requerimiento_Detalle_Servicio(MRDS);
                    }
                    else
                    {
                        MRDS.IidRequerimiento_Detalle_Servicio = SRDS.Graba_Requerimiento_Detalle_Servicio(MRDS);
                    }
                        
                }
                else
                {
                    if (MyStuff.UsaWCF == true)
                    {
                        MRDS.IidRequerimiento_Detalle_Servicio = objWCF.Modifica_Requerimiento_Detalle_Servicio(MRDS);
                    }
                    else
                    {
                        MRDS.IidRequerimiento_Detalle_Servicio = SRDS.Modifica_Requerimiento_Detalle_Servicio(MRDS);
                    }
                        
                }
            }

            if ( this.Btn_Grabar_Salir.Visible == true  )
            {
                this.RegistroMovimiento();
            }
            this.PintarDatosRegistro();
            blnGrabo = true;

            }


            return blnGrabo;
        }

        private void BlanquearDatosBien()
        {
            this.Txt_CodMaterial.Value = "";
            this.Txt_NomMaterial.Value = "";
            this.Edt_EspecificacionTecnica.Value = "";
            this.Txt_Stock.Value = 0;
            this.Txt_Cantidad.Value = 0;
            this.Txt_Precio.Value = 0;
            this.Txt_ImporteTotal_B.Value = 0;
            this.Cbo_CodUnidadMedida.SelectedValue = "";
        }

        private void BlanquearDatosServicio()
        {
            this.Txt_CodServicio.Value = "";
            this.Txt_NomServicio.Value = "";
            this.Txt_EspecificacionServicio.Value = "";
            this.Txt_ImporteTotal_S.Value = 0;
        }

        private void RegistroMovimiento()
        {
            try
            {
                m_Grid.DisplayLayout.Bands[0].AddNew();
                PintarDatosRegistro();

            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message.ToString());
            }
        }

        private void PintarDatosRegistro()
        {
            try
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = m_Grid.ActiveRow;


                oRow.Cells[0].Value = MRC.IidRequerimiento_Cabecera;
                oRow.Cells[1].Value = MRC.CnumRequerimiento;
                oRow.Cells[2].Value = MRC.DfecRequerimiento;
                oRow.Cells[3].Value = MRC.Tnota;
                oRow.Cells[4].Value = MRD.IidRequerimiento_Detalle;
                oRow.Cells[5].Value = MRD.CcodFuenteFinanciamiento;
                oRow.Cells[6].Value = Convert.ToString(  this.Txt_NomFuenteFinanciamiento.Value );
                oRow.Cells[7].Value = MRD.CcodCeCo;
                oRow.Cells[8].Value = Convert.ToString(this.Txt_NomCentroCosto.Value);
                oRow.Cells[9].Value = MRD.CcodProyecto;
                oRow.Cells[10].Value = Convert.ToString(this.Txt_NomProyecto.Value);
                oRow.Cells[11].Value = MRD.CcodComponente;
                oRow.Cells[12].Value = MRD.CcodPosPre;
                oRow.Cells[13].Value = Convert.ToString(this.Txt_NomPosicionPresupuestal.Value);
                oRow.Cells[14].Value = MRD.CcodClasificador;
                oRow.Cells[15].Value = Convert.ToString(this.Txt_NomClasificacion.Value);
                oRow.Cells[16].Value = MRD.CcodTipoGasto;
                oRow.Cells[17].Value = Convert.ToString(this.Txt_NomTipoGasto.Value);
                oRow.Cells[18].Value = MRC.CcodTipoAdquisicion;
                if ( MRC.CcodTipoAdquisicion.TrimEnd() == "B" )
                {
                    oRow.Cells[19].Value = "BIEN";
                }
                else
                {
                    oRow.Cells[19].Value = "SERVICIO";
                }
                
                oRow.Cells[20].Value = MRD.FimporteTotal;
                oRow.Cells[21].Value = MRDB.IidRequerimiento_Detalle_Bien;
                oRow.Cells[22].Value = MRDB.CcodMaterial;
                oRow.Cells[23].Value = Convert.ToString(this.Txt_NomMaterial.Value);
                oRow.Cells[24].Value = MRDB.TespecificacionTecnica;
                oRow.Cells[25].Value = MRDB.CcodUnidadMedida;
                oRow.Cells[26].Value = Convert.ToString(this.Cbo_CodUnidadMedida.Text);
                oRow.Cells[27].Value = MRDB.Fcantidad;
                oRow.Cells[28].Value = MRDB.FprecioUnitario;
                oRow.Cells[29].Value = MRDB.Fstock;
                oRow.Cells[30].Value = MRDS.IidRequerimiento_Detalle_Servicio;
                oRow.Cells[31].Value = MRDS.CcodServicio;
                oRow.Cells[32].Value = Convert.ToString(this.Txt_NomServicio.Value);
                oRow.Cells[33].Value = MRDS.TespecificacionTecnica;

            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Btn_Comprometido_B_Click(object sender, EventArgs e)
        {
            Model.Formulacion_Saldo MFS = new Model.Formulacion_Saldo();
            MFS.CañoProceso = MyStuff.AñoProceso;
            MFS.CcodFuenteFinanciamiento = Convert.ToString(this.Txt_CodFuenteFinanciamiento.Value);
            MFS.CcodCeCo_Gestor = Convert.ToString(this.Txt_CodCentroCosto.Value);
            MFS.CcodProyecto = Convert.ToString(this.Txt_CodProyecto.Value);
            MFS.CcodClasificador = Convert.ToString(this.Txt_CodClasificacion.Value);
            MFS.CcodPosPre = Convert.ToString(this.Txt_CodPosicionPresupuestal.Value);
            MFS.CcodTipoGasto = Convert.ToString(this.Txt_CodTipoGasto.Value);

            WINgestion.Frm_Requerimientos_Comprometidos frm = new WINgestion.Frm_Requerimientos_Comprometidos();
            frm.Showme(MFS);
        }

        private void Btn_Ejecutado_B_Click(object sender, EventArgs e)
        {
            Model.Formulacion_Saldo MFS = new Model.Formulacion_Saldo();
            MFS.CañoProceso = MyStuff.AñoProceso;
            MFS.CcodFuenteFinanciamiento = Convert.ToString(this.Txt_CodFuenteFinanciamiento.Value);
            MFS.CcodCeCo_Gestor = Convert.ToString(this.Txt_CodCentroCosto.Value);
            MFS.CcodProyecto = Convert.ToString(this.Txt_CodProyecto.Value);
            MFS.CcodClasificador = Convert.ToString(this.Txt_CodClasificacion.Value);
            MFS.CcodPosPre = Convert.ToString(this.Txt_CodPosicionPresupuestal.Value);
            MFS.CcodTipoGasto = Convert.ToString(this.Txt_CodTipoGasto.Value);

            WINgestion.Frm_Requerimientos_Ejecutados frm = new WINgestion.Frm_Requerimientos_Ejecutados();
            frm.Showme(MFS);
        }

        private void Btn_Comprometido_S_Click(object sender, EventArgs e)
        {
            Model.Formulacion_Saldo MFS = new Model.Formulacion_Saldo();
            MFS.CañoProceso = MyStuff.AñoProceso;
            MFS.CcodFuenteFinanciamiento = Convert.ToString(this.Txt_CodFuenteFinanciamiento.Value);
            MFS.CcodCeCo_Gestor = Convert.ToString(this.Txt_CodCentroCosto.Value);
            MFS.CcodProyecto = Convert.ToString(this.Txt_CodProyecto.Value);
            MFS.CcodClasificador = Convert.ToString(this.Txt_CodClasificacion.Value);
            MFS.CcodPosPre = Convert.ToString(this.Txt_CodPosicionPresupuestal.Value);
            MFS.CcodTipoGasto = Convert.ToString(this.Txt_CodTipoGasto.Value);

            WINgestion.Frm_Requerimientos_Comprometidos frm = new WINgestion.Frm_Requerimientos_Comprometidos();
            frm.Showme(MFS);
        }

        private void Btn_Ejecutado_S_Click(object sender, EventArgs e)
        {
            Model.Formulacion_Saldo MFS = new Model.Formulacion_Saldo();
            MFS.CañoProceso = MyStuff.AñoProceso;
            MFS.CcodFuenteFinanciamiento = Convert.ToString(this.Txt_CodFuenteFinanciamiento.Value);
            MFS.CcodCeCo_Gestor = Convert.ToString(this.Txt_CodCentroCosto.Value);
            MFS.CcodProyecto = Convert.ToString(this.Txt_CodProyecto.Value);
            MFS.CcodClasificador = Convert.ToString(this.Txt_CodClasificacion.Value);
            MFS.CcodPosPre = Convert.ToString(this.Txt_CodPosicionPresupuestal.Value);
            MFS.CcodTipoGasto = Convert.ToString(this.Txt_CodTipoGasto.Value);

            WINgestion.Frm_Requerimientos_Ejecutados frm = new WINgestion.Frm_Requerimientos_Ejecutados();
            frm.Showme(MFS);
        }
    }
}