using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFgestion
{

    public class WCFgestionE : IWCFgestionE
    {
        #region Requerimiento_Cabecera
        public Model.Requerimiento_Cabecera Recupera_Requerimiento_Cabecera(int intIdRequrimiento_Cabecera)
        {
            Repository.Requerimiento_Cabecera objDs = new Repository.Requerimiento_Cabecera();
            return objDs.Recupera_Requerimiento_Cabecera(intIdRequrimiento_Cabecera);

        }

        public Model.Requerimiento_Cabecera Graba_Requerimiento_Cabecera(Model.Requerimiento_Cabecera obj)
        {
            Repository.Requerimiento_Cabecera objDs = new Repository.Requerimiento_Cabecera();
            return objDs.Graba_Requerimiento_Cabecera(obj);
        }

        public int Modifica_Requerimiento_Cabecera(Model.Requerimiento_Cabecera obj)
        {
            Repository.Requerimiento_Cabecera objDs = new Repository.Requerimiento_Cabecera();
            return objDs.Modifica_Requerimiento_Cabecera(obj);
        }

        public int Elimina_Requerimiento_Cabecera(int intIdRequerimiento_Cabecera)
        {
            Repository.Requerimiento_Cabecera objDs = new Repository.Requerimiento_Cabecera();
            return objDs.Elimina_Requerimiento_Cabecera(intIdRequerimiento_Cabecera);
        }
        public DataTable Combo_AñoProceso(string strCodCompañia)
        {
            Repository.Formulacion_Cabecera objDs = new Repository.Formulacion_Cabecera();
            return objDs.Combo_AñoProceso(strCodCompañia);
        }
        #endregion

        #region Requerimiento_Detalle
        public DataSet Lista_Formulado_CentroCosto(string strAñoProceso,
                                                   string strCodCentroCosto_Gestor,
                                                   string strCodCentroCosto,
                                                   string strCodClasificador
                                                 )
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Lista_Formulado_CentroCosto(strAñoProceso,
                                                      strCodCentroCosto_Gestor,
                                                      strCodCentroCosto,
                                                      strCodClasificador
                                                    );
        }

        public DataSet Lista_Disponible_CentroCosto(string strAñoProceso,
                                                    string strCodCentroCosto_Gestor,
                                                    string strCodCentroCosto,
                                                    string strCodClasificador
                                                  )
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Lista_Disponible_CentroCosto(strAñoProceso,
                                                      strCodCentroCosto_Gestor,
                                                      strCodCentroCosto,
                                                      strCodClasificador
                                                    );
        }
        public DataSet Lista_Ejecutado_CentroCosto(string strAñoProceso,
                                                    string strCodCentroCosto_Gestor,
                                                    string strCodCentroCosto,
                                                    string strCodClasificador
                                                  )
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Lista_Ejecutado_CentroCosto(strAñoProceso,
                                                        strCodCentroCosto_Gestor,
                                                        strCodCentroCosto,
                                                        strCodClasificador
                                                    );
        }

        public DataSet Lista_Comprometido_CentroCosto(string strAñoProceso,
                                                    string strCodCentroCosto_Gestor,
                                                    string strCodCentroCosto,
                                                    string strCodClasificador
                                                  )
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Lista_Comprometido_CentroCosto(strAñoProceso,
                                                        strCodCentroCosto_Gestor,
                                                        strCodCentroCosto,
                                                        strCodClasificador
                                                    );
        }
        public DataSet Lista_EjecucionPresupuestal_CentroCosto(string strAñoProceso, string strCodCentroCosto_Gestor)
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Lista_EjecucionPresupuestal_CentroCosto(strAñoProceso, strCodCentroCosto_Gestor);
        }
        public DataSet Lista_EjecucionPresupuestal_Proyecto(string strAñoProceso, string strCodProyecto)
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Lista_EjecucionPresupuestal_Proyecto(strAñoProceso, strCodProyecto);
        }
        public DataSet Formato_Requerimiento(string strNumRequerimiento)
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Formato_Requerimiento(strNumRequerimiento);
        }
        public DataSet Lista_Requerimiento_Detalle_Requerido(Model.Formulacion_Saldo obj)
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Lista_Requerimiento_Detalle_Requerido(obj);
        }

        public DataSet Lista_Requerimiento_Detalle_Ejecutado(Model.Formulacion_Saldo obj)
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Lista_Requerimiento_Detalle_Ejecutado(obj);
        }
        public Model.Requerimiento_Detalle Recupera_Requerimiento_Detalle(int intIdRequrimiento_Cabecera)
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Recupera_Requerimiento_Detalle(intIdRequrimiento_Cabecera);

        }

        public int Graba_Requerimiento_Detalle(Model.Requerimiento_Detalle obj)
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Graba_Requerimiento_Detalle(obj);
        }

        public int Modifica_Requerimiento_Detalle(Model.Requerimiento_Detalle obj)
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Modifica_Requerimiento_Detalle(obj);
        }

        public int Elimina_Requerimiento_Detalle(int intIdRequerimiento_Detalle)
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Elimina_Requerimiento_Detalle(intIdRequerimiento_Detalle);
        }

        public DataSet Lista_Requerimiento_Detalle(string strNumRequerimiento)
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Lista_Requerimiento_Detalle(strNumRequerimiento);
        }

        public DataSet Formato_Requerimiento_Estado(string strCodCentro_Gestor,
                                                     string strEstado,
                                                     string strCodEmpleado
                                                    )
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Formato_Requerimiento_Estado(strCodCentro_Gestor, strEstado, strCodEmpleado);
        }

        public DataSet Formato_Requerimiento_Ceco(string strCodCentro_Gestor,
                                                     string strEstado,
                                                     string strCodEmpleado
                                                    )
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Formato_Requerimiento_Ceco(strCodCentro_Gestor, strEstado, strCodEmpleado);
        }

        public Boolean Formato_Requerimiento_Firma(string strCodCentro_Gestor,
                                                    string strPaso,
                                                    string strNumRequerimiento
                                                   )
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Formato_Requerimiento_Firma(strCodCentro_Gestor, strPaso, strNumRequerimiento);
        }

        public Boolean Formato_Requerimiento_DescarteFirma(string strCodCentro_Gestor,
                                                    string strPaso,
                                                    string strNumRequerimiento,
                                                    string strMotivoDescarte
                                                   )
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Formato_Requerimiento_DescarteFirma(strCodCentro_Gestor, strPaso, strNumRequerimiento,strMotivoDescarte);
        }

        #endregion

        #region Requerimiento_Detalle_Bien
        public Model.Requerimiento_Detalle_Bien Recupera_Requerimiento_Detalle_Bien(int intIdRequrimiento_Detalle_Bien)
        {
            Repository.Requerimiento_Detalle_Bien objDs = new Repository.Requerimiento_Detalle_Bien();
            return objDs.Recupera_Requerimiento_Detalle_Bien(intIdRequrimiento_Detalle_Bien);

        }

        public int Graba_Requerimiento_Detalle_Bien(Model.Requerimiento_Detalle_Bien obj)
        {
            Repository.Requerimiento_Detalle_Bien objDs = new Repository.Requerimiento_Detalle_Bien();
            return objDs.Graba_Requerimiento_Detalle_Bien(obj);
        }

        public int Modifica_Requerimiento_Detalle_Bien(Model.Requerimiento_Detalle_Bien obj)
        {
            Repository.Requerimiento_Detalle_Bien objDs = new Repository.Requerimiento_Detalle_Bien();
            return objDs.Modifica_Requerimiento_Detalle_Bien(obj);
        }

        public int Elimina_Requerimiento_Detalle_Bien(int intIdRequerimiento_Detalle_Bien)
        {
            Repository.Requerimiento_Detalle_Bien objDs = new Repository.Requerimiento_Detalle_Bien();
            return objDs.Elimina_Requerimiento_Detalle_Bien(intIdRequerimiento_Detalle_Bien);
        }

        #endregion

        #region Requerimiento_Detalle_Servicio
        public Model.Requerimiento_Detalle_Servicio Recupera_Requerimiento_Detalle_Servicio(int intIdRequrimiento_Cabecera)
        {
            Repository.Requerimiento_Detalle_Servicio objDs = new Repository.Requerimiento_Detalle_Servicio();
            return objDs.Recupera_Requerimiento_Detalle_Servicio(intIdRequrimiento_Cabecera);

        }

        public int Graba_Requerimiento_Detalle_Servicio(Model.Requerimiento_Detalle_Servicio obj)
        {
            Repository.Requerimiento_Detalle_Servicio objDs = new Repository.Requerimiento_Detalle_Servicio();
            return objDs.Graba_Requerimiento_Detalle_Servicio(obj);
        }

        public int Modifica_Requerimiento_Detalle_Servicio(Model.Requerimiento_Detalle_Servicio obj)
        {
            Repository.Requerimiento_Detalle_Servicio objDs = new Repository.Requerimiento_Detalle_Servicio();
            return objDs.Modifica_Requerimiento_Detalle_Servicio(obj);
        }

        public int Elimina_Requerimiento_Detalle_Servicio(int intIdRequerimiento_Detalle_Servicio)
        {
            Repository.Requerimiento_Detalle_Servicio objDs = new Repository.Requerimiento_Detalle_Servicio();
            return objDs.Elimina_Requerimiento_Detalle_Servicio(intIdRequerimiento_Detalle_Servicio);
        }

        #endregion

        #region Material
        public Model.Material Recupera_Material(string strCodMaterial)
        {
            Repository.Material ds = new Repository.Material();
            return ds.Recupera_Material(strCodMaterial);
        }

        public Model.Servicio Recupera_Servicio(string strCodServicio)
        {
            Repository.Material ds = new Repository.Material();
            return ds.Recupera_Servicio(strCodServicio);
        }

        public DataSet Ayuda_Material(string strTexto)
        {
            Repository.Material ds = new Repository.Material();
            return ds.Ayuda_Material(strTexto);
        }

        public DataSet Ayuda_Servicio(string strCodPosPre )
        {
            Repository.Material ds = new Repository.Material();
            return ds.Ayuda_Servicio( strCodPosPre );
        }

        public DataSet Combo_UnidadMedida()
        {
            Repository.DataGeneral objDs = new Repository.DataGeneral();
            return objDs.Combo_UnidadMedida();
        }

        #endregion

        #region Formulacion
        public DataSet Ayuda_Formulacion(string strCodCompañia,
                                         string strAñoProceso,
                                         string strCodCentroCosto_Gestor,
                                         string strCodFuenteFinanciamiento,
                                         string strCodCentroCosto,
                                         string strCodProyecto,
                                         string strCodTipoAdquisicion
                                       )
        {
            Repository.Formulacion objDs = new Repository.Formulacion();
            return objDs.Ayuda_Formulacion(strCodCompañia,
                                           strAñoProceso,
                                           strCodCentroCosto_Gestor,
                                           strCodFuenteFinanciamiento,
                                           strCodCentroCosto,
                                           strCodProyecto,
                                           strCodTipoAdquisicion
                                          );
        }
        #endregion

        #region Requerimiento
        public Model.Formulacion_Saldo Recupera_Formulacion_Sado(Model.Formulacion_Saldo obj)
        {
            Repository.Requerimiento objDs = new Repository.Requerimiento();
            return objDs.Recupera_Formulacion_Sado(obj);
        }
        public Modelo.RequerimientoWCF Recupera_Requerimiento(string strNumRequerimiento)
        {
            Data.RequerimientoWCF objDs  = new Data.RequerimientoWCF();

            return objDs.Recupera_Requerimiento(strNumRequerimiento);
        }

        public List<Modelo.RequerimientoWCF> Lista_Requerimiento(string strCodCentroCosto_Gestor)
        {
            Data.RequerimientoWCF objDs = new Data.RequerimientoWCF();
            return objDs.Lista_Requerimiento(strCodCentroCosto_Gestor);
        }
        #endregion

        #region Usuario
        public Model.Usuario Recupera_Usuario(int intIdeUsuario)
        {
            Repository.Usuario obj = new Repository.Usuario();
            return obj.Recupera_Usuario(intIdeUsuario);
        }

        public Model.Usuario Recupera_Usuario_Codigo(string strCodempresa, string strLogUsuario)
        {
            Repository.Usuario obj = new Repository.Usuario();
            return obj.Recupera_Usuario_Codigo(strCodempresa, strLogUsuario);
        }
        public DataSet Combo_Usuario_Modulo_DataTable(string strCodempresa, string strLogUsuario)
        {
            Repository.Usuario obj = new Repository.Usuario();
            return obj.Combo_Usuario_Modulo_DataTable(strCodempresa, strLogUsuario);
        }

        public DataSet OpcionesMenu_Top(string strCodempresa, string strCodUsuario, string strCodModulo)
        {
            Repository.Usuario obj = new Repository.Usuario();
            return obj.OpcionesMenu_Top(strCodempresa, strCodUsuario, strCodModulo);
        }
        public DataSet OpcionesMenu_Lateral(string strCodempresa, string strCodUsuario, string strCodModulo)
        {
            Repository.Usuario obj = new Repository.Usuario();
            return obj.OpcionesMenu_Lateral(strCodempresa, strCodUsuario, strCodModulo);
        }
        public DataSet Ayuda_Proyecto_Spring_Help(string strCodCompañia)
        {
            Repository.Proyecto obj = new Repository.Proyecto();
            return obj.Ayuda_Proyecto_Spring_Help(strCodCompañia);
        }
        #endregion

        #region Empleado
        public DataSet Ayuda_Empleado_Jefatura()
        {
            Repository.Empleado obj = new Repository.Empleado();
            return obj.Ayuda_Empleado_Jefatura();
        }

        public Model.Empleado Recupera_Empleado_Codigo(string strCodEmpleado)
        {
            Repository.Empleado objE = new Repository.Empleado();
            return objE.Recupera_Empleado_Codigo(strCodEmpleado);
        }

        public DataSet Ayuda_Empleado()
        {
            Repository.Empleado objE = new Repository.Empleado();
            return objE.Ayuda_Empleado();
        }
        #endregion

        #region PeriodoProceso
        public DataSet Combo_PeriodoProceso_DataTable()
        {
            Repository.PeriodoProceso objRPeriodoProceso = new Repository.PeriodoProceso();
            return objRPeriodoProceso.Combo_PeriodoProceso_DataTable();
        }
        #endregion

        #region Empresa
        public DataSet Combo_Empresa_DataTable()
        {
            Repository.Empresa obj = new Repository.Empresa();
            return obj.Combo_Empresa_DataTable();
        }
        #endregion

        #region Gestion

        public DataSet Formato_4E(string strCodCompañia,
                                  string strAñoProceso,
                                  string strCodFuenteFinanciamiento,
                                  string strCodCentroCosto,
                                  string strCodProyecto
                                )
        {
            Repository.Reporte objDs = new Repository.Reporte();
            return objDs.Formato_4E(strCodCompañia, strAñoProceso, strCodFuenteFinanciamiento, strCodCentroCosto, strCodProyecto);
        }

        public DataSet Ayuda_FuenteFinanciamiento_Reporte(string strCodCompañia)
        {
            Repository.DataGeneral objDs = new Repository.DataGeneral();
            return objDs.Ayuda_FuenteFinanciamiento_Reporte(strCodCompañia);
        }

        public DataSet Ayuda_CentroCosto_Reporte(string strCodFuenteFinanciamiento)
        {
            Repository.DataGeneral objDs = new Repository.DataGeneral();
            return objDs.Ayuda_CentroCosto_Reporte(strCodFuenteFinanciamiento);
        }

        public DataSet Ayuda_Proyecto_Reporte(string strCodFuenteFinanciamiento, string strCodCentroCosto)
        {
            Repository.DataGeneral objDs = new Repository.DataGeneral();
            return objDs.Ayuda_Proyecto_Reporte(strCodFuenteFinanciamiento, strCodCentroCosto);
        }

        public DataSet Lista_Formulado_Proyecto(string strAñoProceso,
                                    string strCodProyecto,
                                    string strCodClasificador
                                  )
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Lista_Formulado_Proyecto(strAñoProceso,
                                                      strCodProyecto,
                                                      strCodClasificador
                                                    );
        }

        public DataSet Lista_Disponible_Proyecto(string strAñoProceso,
                                                    string strCodProyecto,
                                                    string strCodClasificador
                                                  )
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Lista_Disponible_Proyecto(strAñoProceso,
                                                      strCodProyecto,
                                                      strCodClasificador
                                                    );
        }




        public DataSet Lista_Ejecutado_Proyecto(string strAñoProceso,
                                                    string strCodProyecto,
                                                    string strCodClasificador
                                                  )
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Lista_Ejecutado_Proyecto(strAñoProceso,
                                                        strCodProyecto,
                                                        strCodClasificador
                                                    );
        }

        public DataSet Lista_Comprometido_Proyecto(string strAñoProceso,
                                                    string strCodProyecto,
                                                    string strCodClasificador
                                                  )
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Lista_Comprometido_Proyecto(strAñoProceso,
                                                        strCodProyecto,
                                                        strCodClasificador
                                                    );
        }


        public DataSet Ayuda_Proyecto()
        {

            Repository.Proyecto obj = new Repository.Proyecto();

            return obj.Ayuda_Proyecto();
        }
        public DataSet Combo_Prioridad()
        {
            Repository.DataGeneral objDs = new Repository.DataGeneral();
            return objDs.Combo_Prioridad();
        }
        public DataSet Combo_TipoMoneda()
        {
            Repository.DataGeneral objDs = new Repository.DataGeneral();
            return objDs.Combo_TipoMoneda();
        }
        public DataSet Ayuda_Proyecto_CentroCosto(string strCodCentroGestor, int intDigito, string strCodEmpleado)
        {
            Repository.DataGeneral objDs = new Repository.DataGeneral();
            return objDs.Ayuda_Proyecto_CentroCosto(strCodCentroGestor, intDigito, strCodEmpleado);
        }
        #endregion



    }
}
