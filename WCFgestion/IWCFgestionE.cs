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
    [ServiceContract]
    public interface IWCFgestionE
    {
        #region Requerimiento_Cabecera
        [OperationContract]
        DataTable Combo_AñoProceso(string strCodCompañia);
        [OperationContract]
        Model.Requerimiento_Cabecera Recupera_Requerimiento_Cabecera(int intIdRequrimiento_Cabecera);
        [OperationContract]
        Model.Requerimiento_Cabecera Graba_Requerimiento_Cabecera(Model.Requerimiento_Cabecera obj);
        [OperationContract]
        int Modifica_Requerimiento_Cabecera(Model.Requerimiento_Cabecera obj);
        [OperationContract]
        int Elimina_Requerimiento_Cabecera(int intIdRequerimiento_Cabecera);
        #endregion

        #region Requerimiento_Detalle
        [OperationContract]
        DataSet Lista_Formulado_CentroCosto(string strAñoProceso,
                                                   string strCodCentroCosto_Gestor,
                                                   string strCodCentroCosto,
                                                   string strCodClasificador
                                                 );
        [OperationContract]
        DataSet Lista_Disponible_CentroCosto(string strAñoProceso,
                                                    string strCodCentroCosto_Gestor,
                                                    string strCodCentroCosto,
                                                    string strCodClasificador
                                                  );
        [OperationContract]
        DataSet Lista_Ejecutado_CentroCosto(string strAñoProceso,
                                                    string strCodCentroCosto_Gestor,
                                                    string strCodCentroCosto,
                                                    string strCodClasificador
                                                  );
        [OperationContract]
        DataSet Lista_Comprometido_CentroCosto(string strAñoProceso,
                                                    string strCodCentroCosto_Gestor,
                                                    string strCodCentroCosto,
                                                    string strCodClasificador
                                                  );
        [OperationContract]
        DataSet Lista_EjecucionPresupuestal_CentroCosto(string strAñoProceso, string strCodCentroCosto_Gestor);
        [OperationContract]
        DataSet Lista_EjecucionPresupuestal_Proyecto(string strAñoProceso, string strCodProyecto);
        [OperationContract]
        DataSet Formato_Requerimiento(string strNumRequerimiento);
        [OperationContract]
        DataSet Lista_Requerimiento_Detalle_Requerido(Model.Formulacion_Saldo obj);
        [OperationContract]
        DataSet Lista_Requerimiento_Detalle_Ejecutado(Model.Formulacion_Saldo obj);

        [OperationContract]
        Model.Requerimiento_Detalle Recupera_Requerimiento_Detalle(int intIdRequrimiento_Cabecera);
        [OperationContract]
        int Graba_Requerimiento_Detalle(Model.Requerimiento_Detalle obj);
        [OperationContract]
        int Modifica_Requerimiento_Detalle(Model.Requerimiento_Detalle obj);
        [OperationContract]
        int Elimina_Requerimiento_Detalle(int intIdRequerimiento_Detalle);
        [OperationContract]
        DataSet Lista_Requerimiento_Detalle(string strNumRequerimiento);
        [OperationContract]
        DataSet Formato_Requerimiento_Estado(string strCodCentro_Gestor,
                                                     string strEstado,
                                                     string strCodEmpleado
                                                    );
        [OperationContract]
        Boolean Formato_Requerimiento_Firma(string strCodCentro_Gestor,
                                                    string strPaso,
                                                    string strNumRequerimiento
                                                   );

        [OperationContract]
        DataSet Formato_Requerimiento_Ceco(string strCodCentro_Gestor,
                                                    string strPaso,
                                                    string strNumRequerimiento
                                                   );
        [OperationContract]
        Boolean Formato_Requerimiento_DescarteFirma(string strCodCentro_Gestor,
                                                    string strPaso,
                                                    string strNumRequerimiento,
                                                    string strMotivoDescarte
                                                   );


        #endregion

        #region Requerimiento_Detalle_Bien
        [OperationContract]
        Model.Requerimiento_Detalle_Bien Recupera_Requerimiento_Detalle_Bien(int intIdRequrimiento_Detalle_Bien);
        [OperationContract]
        int Graba_Requerimiento_Detalle_Bien(Model.Requerimiento_Detalle_Bien obj);
        [OperationContract]
        int Modifica_Requerimiento_Detalle_Bien(Model.Requerimiento_Detalle_Bien obj);
        [OperationContract]
        int Elimina_Requerimiento_Detalle_Bien(int intIdRequerimiento_Detalle_Bien);

        #endregion

        #region Requerimiento_Detalle_Servicio
        [OperationContract]
        Model.Requerimiento_Detalle_Servicio Recupera_Requerimiento_Detalle_Servicio(int intIdRequrimiento_Cabecera);
        [OperationContract]
        int Graba_Requerimiento_Detalle_Servicio(Model.Requerimiento_Detalle_Servicio obj);
        [OperationContract]
        int Modifica_Requerimiento_Detalle_Servicio(Model.Requerimiento_Detalle_Servicio obj);
        [OperationContract]
        int Elimina_Requerimiento_Detalle_Servicio(int intIdRequerimiento_Detalle_Servicio);

        #endregion

        #region Material
        [OperationContract]
        Model.Material Recupera_Material(string strCodMaterial);
        [OperationContract]
        Model.Servicio Recupera_Servicio(string strCodServicio);
        [OperationContract]
        DataSet Ayuda_Material(string strTexto);
        [OperationContract]
        DataSet Ayuda_Servicio(string strCodPosPre );
        [OperationContract]
        DataSet Combo_UnidadMedida();

        #endregion

        #region Formulacion
        [OperationContract]
        DataSet Ayuda_Formulacion(string strCodCompañia,
                                         string strAñoProceso,
                                         string strCodCentroCosto_Gestor,
                                         string strCodFuenteFinanciamiento,
                                         string strCodCentroCosto,
                                         string strCodProyecto,
                                         string strCodTipoAdquisicion
                                       );
        #endregion

        #region Requerimiento
        [OperationContract]
        Model.Formulacion_Saldo Recupera_Formulacion_Sado(Model.Formulacion_Saldo obj);
        [OperationContract]
        Modelo.RequerimientoWCF Recupera_Requerimiento(string strNumRequerimiento);
        [OperationContract]
        List<Modelo.RequerimientoWCF> Lista_Requerimiento(string strCodCentroCosto_Gestor);
        #endregion

        #region Usuario
        [OperationContract]
        Model.Usuario Recupera_Usuario(int intIdeUsuario);
        [OperationContract]
        Model.Usuario Recupera_Usuario_Codigo(string strCodempresa, string strLogUsuario);
        [OperationContract]
        DataSet Combo_Usuario_Modulo_DataTable(string strCodempresa, string strLogUsuario);
        [OperationContract]
        DataSet OpcionesMenu_Top(string strCodempresa, string strCodUsuario, string strCodModulo);
        [OperationContract]
        DataSet OpcionesMenu_Lateral(string strCodempresa, string strCodUsuario, string strCodModulo);
        [OperationContract]
        DataSet Ayuda_Proyecto_Spring_Help(string strCodCompañia);

        #endregion

        #region Empleado
        [OperationContract]
        DataSet Ayuda_Empleado_Jefatura();
        [OperationContract]
        Model.Empleado Recupera_Empleado_Codigo(string strCodEmpleado);
        [OperationContract]
        DataSet Ayuda_Empleado();
        #endregion

        #region PeriodoProceso
        [OperationContract]
        DataSet Combo_PeriodoProceso_DataTable();
        #endregion

        #region Empresa
        [OperationContract]
        DataSet Combo_Empresa_DataTable();
        #endregion
        [OperationContract]
        DataSet Formato_4E(string strCodCompañia,
                                  string strAñoProceso,
                                  string strCodFuenteFinanciamiento,
                                  string strCodCentroCosto,
                                  string strCodProyecto
                                );
        [OperationContract]
        DataSet Lista_Formulado_Proyecto(string strAñoProceso,
                                    string strCodProyecto,
                                    string strCodClasificador
                                  );
        [OperationContract]
        DataSet Lista_Disponible_Proyecto(string strAñoProceso,
                                                    string strCodProyecto,
                                                    string strCodClasificador
                                                  );
        [OperationContract]
        DataSet Lista_Ejecutado_Proyecto(string strAñoProceso,
                                                    string strCodProyecto,
                                                    string strCodClasificador
                                                  );
        [OperationContract]
        DataSet Lista_Comprometido_Proyecto(string strAñoProceso,
                                                    string strCodProyecto,
                                                    string strCodClasificador
                                                  );



        #region Gestion
        [OperationContract]
        DataSet Ayuda_FuenteFinanciamiento_Reporte(string strCodCompañia);
        [OperationContract]
        DataSet Ayuda_CentroCosto_Reporte(string strCodFuenteFinanciamiento);
        [OperationContract]
        DataSet Ayuda_Proyecto_Reporte(string strCodFuenteFinanciamiento, string strCodCentroCosto);
        [OperationContract]
        DataSet Ayuda_Proyecto();
        [OperationContract]
        DataSet Combo_Prioridad();
        [OperationContract]
        DataSet Combo_TipoMoneda();
        [OperationContract]
        DataSet Ayuda_Proyecto_CentroCosto(string strCodCentroGestor, int intDigito, string strCodEmpleado);
        #endregion
    }
}
