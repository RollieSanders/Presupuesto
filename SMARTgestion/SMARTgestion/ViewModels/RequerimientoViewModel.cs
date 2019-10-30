using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using SMARTgestion.Models;
using SMARTgestion.Views;
using Xamarin.Forms;

namespace SMARTgestion.ViewModels
{
    public class RequerimientoViewModel
    {
        public Requerimientos Requerimiento
        {
            get;
            set;
        }

        public RequerimientoViewModel(Requerimientos requerimiento)
        {
            this.Requerimiento = requerimiento;
        }

        public ICommand FirmaCommand
        {
            get
            {
                return new Command(Firma);
            }


        }

        public async void Firma()
        {
            string strPaso = this.Requerimiento.Cpaso;
            string strCodCentroGestor = this.Requerimiento.CcodCeCo;
            string strNumRequerimiento = Requerimiento.CnumRequerimiento.TrimEnd();
            
             bool res =  await Application.Current.MainPage.DisplayAlert(
                    "Firma",
                    "Numero de Requerimiento: " + strNumRequerimiento.TrimEnd(),
                    "Acepta", "Cancela");

            if (res == true)
            {
                strNumRequerimiento = Requerimiento.CnumRequerimiento.TrimEnd() + 
                                      strPaso.TrimEnd() +
                                      Services.Helpers.UserSettings.CentroCosto_Gestor.TrimEnd();
                string url = "http://aplicacion.amsac.pe/aGESTION" +
                "/api" +
                "/Paso" +
                "/" + strNumRequerimiento.TrimEnd();

                Services.WebService objS = new Services.WebService();
                var response = objS.Get(url);
                var objME = Newtonsoft.Json.JsonConvert.DeserializeObject<Paso_Requerimiento>(response.Content);

                MainViewModel.GetInstance().Requerimientos = new RequerimientosViewModel(Services.Helpers.UserSettings.Empleado,
                                                                                        Services.Helpers.UserSettings.CentroCosto_Gestor
                                                                                        );
                await Application.Current.MainPage.Navigation.PushAsync(new RequerimientosPage());

            }

            
        }


    }
}
