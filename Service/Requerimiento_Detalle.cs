using System;
using System.Data;

namespace Service
{
    public class Requerimiento_Detalle
    {
        public DataSet Lista_Formulado_CentroCosto(string strAñoProceso,
                                                    string strCodCentroCosto_Gestor,
                                                    string strCodCentroCosto,
                                                    string strCodClasificador
                                                  )
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Lista_Formulado_CentroCosto( strAñoProceso,
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

        public DataSet Formato_Requerimiento( string strNumRequerimiento )
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Formato_Requerimiento(strNumRequerimiento);
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
                                                    string strMotivodescarte
                                                   )
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Formato_Requerimiento_DescarteFirma(strCodCentro_Gestor, strPaso, strNumRequerimiento, strMotivodescarte);
        }

        public DataSet Lista_EjecucionPresupuestal_CentroCosto(string strAñoProceso, string strCodCentroCosto_Gestor)
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Lista_EjecucionPresupuestal_CentroCosto(  strAñoProceso,  strCodCentroCosto_Gestor);
        }

        public DataSet Lista_EjecucionPresupuestal_Proyecto(string strAñoProceso, string strCodProyecto)
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Lista_EjecucionPresupuestal_Proyecto(strAñoProceso, strCodProyecto);
        }


        public DataSet Lista_Ejecutado_CentroCosto(string strAñoProceso,
                                                    string strCodCentroCosto_Gestor,
                                                    string strCodCentroCosto,
                                                    string strCodClasificador
                                                  )
        {
            Repository.Requerimiento_Detalle objDs = new Repository.Requerimiento_Detalle();
            return objDs.Lista_Ejecutado_CentroCosto(   strAñoProceso, 
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



    }
}
