using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using SMARTgestion.Data;
using SMARTgestion.Models;
using SMARTgestion.Services;
using Xamarin.Forms;

namespace SMARTgestion.ViewModels
{
    public class RequerimientosViewModel : BaseViewModel
    {
        private ObservableCollection<RequerimientoItemViewModel> requerimientos;
        private bool isRefreshing;
        private bool isRunning;
        private string filter;
        private List<Requerimientos> requerimientosList;
       

        public ObservableCollection<RequerimientoItemViewModel> Requerimientos
        {
            get { return this.requerimientos; }
            set { SetValue(ref this.requerimientos, value); }
        }

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }

        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }

        public string Filter
        {
            get { return this.filter; }
            set {
                SetValue(ref this.filter, value);
                this.Search();
            }
        }

        public ICommand SearchCommand
        {
            get
            {
                return new RelayCommand(Search);
            }
        }

        private void Search()
        {
            if (string.IsNullOrEmpty(this.filter))
            {
                this.Requerimientos = new ObservableCollection<RequerimientoItemViewModel>(
                this.ToRequerimientoItemViewModel());
            }
            else
            {
                this.Requerimientos = new ObservableCollection<RequerimientoItemViewModel>(
                    this.ToRequerimientoItemViewModel().Where (s => s.CnumRequerimiento.Contains(this.filter)));
            }

        }

        public RequerimientosViewModel( string strCodEmpleado,
                                        string strCentroCosto_Gestor
                                        )
        {
            //this.PintaSequerimientos();
            this.PintaRequerimientosAsync(  strCodEmpleado,
                                            strCentroCosto_Gestor
                                          );
        }

    
        private async void PintaRequerimientosAsync(string strCodEmpleado, 
                                                    string strCentroCosto_Gestor
                                                   )
        {
            this.IsRefreshing = true;

            this.isRunning = true;

            WebService obj = new WebService();
            
            var connection = await obj.CheckConnection();
            if (!connection.IsSuccess)
            {
                this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert(
                    "error",
                    connection.Message,
                    "Aceptar");
                await Application.Current.MainPage.Navigation.PopAsync();
            }


            var requerimientosRepository = new RequerimientosRepository();
            var response = await requerimientosRepository.GetList<Requerimientos>(
                                  "http://aplicacion.amsac.pe/aGESTION",
                                  "/api",
                                  "/Requerimientos",
                                  "/" + strCodEmpleado.TrimEnd() + strCentroCosto_Gestor.TrimEnd()
                                 );

            if (!response.IsSuccess)
            {
                this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Aceptar");
            }
            
            this.requerimientosList = (List<Requerimientos>)response.Result;
            this.Requerimientos = new ObservableCollection<RequerimientoItemViewModel>(
                this.ToRequerimientoItemViewModel());

            this.isRunning = true;
            this.IsRefreshing = false;
        }

        private IEnumerable<RequerimientoItemViewModel> ToRequerimientoItemViewModel()
        {
            return this.requerimientosList.Select(s => new RequerimientoItemViewModel
            {
                IidRequerimiento_Cabecera = s.IidRequerimiento_Cabecera,
                CnumRequerimiento = s.CnumRequerimiento,
                DfecRequerimiento = s.DfecRequerimiento,
                Tnota = s.Tnota,
                IidRequerimiento_Detalle = s.IidRequerimiento_Detalle,
                cCodFuenteFinanciamiento = s.cCodFuenteFinanciamiento,
                vNomFuenteFinanciamiento = s.vNomFuenteFinanciamiento,
                CcodCeCo = s.CcodCeCo,
                vNomCeCo = s.vNomCeCo,
                CcodProyecto = s.CcodProyecto,
                vNomCortoProyecto = s.vNomCortoProyecto,
                CcodComponente = s.CcodComponente,
                CcodPosPre = s.CcodPosPre,
                vNomPosPre = s.vNomPosPre,
                CcodClasificador = s.CcodClasificador,
                vNomClasificador = s.vNomClasificador,
                CcodTipoGasto = s.CcodTipoGasto,
                vNomClaseGasto = s.vNomClaseGasto,
                CcodTipoAdquisicion = s.CcodTipoAdquisicion,
                vNomTipoAdquisicion = s.vNomTipoAdquisicion,
                FimporteTotal = s.FimporteTotal,
                IidRequerimiento_Detalle_Bien = s.IidRequerimiento_Detalle_Bien,
                CcodMaterial = s.CcodMaterial,
                vNomMaterial = s.vNomMaterial,
                TespecificacionTecnica_B = s.TespecificacionTecnica_B,
                CcodUnidadMedida = s.CcodUnidadMedida,
                vNomUnidadMedida = s.vNomUnidadMedida,
                Fcantidad = s.Fcantidad,
                FprecioUnitario = s.FprecioUnitario,
                Fstock = s.Fstock,
                IidRequerimiento_Detalle_Servicio = s.IidRequerimiento_Detalle_Servicio,
                CcodServicio = s.CcodServicio,
                vNomServicio = s.vNomServicio,
                TespecificacionTecnica_S = s.TespecificacionTecnica_S,
                Cpaso = s.Cpaso
            }
            );
        }

        //public ICommand RefreshCommand
        //{
        //    get
        //    {
        //        return new RelayCommand(PintaRequerimientosAsync(string strCentroCosto_Gestor));
        //    }
        //}
    }
}
