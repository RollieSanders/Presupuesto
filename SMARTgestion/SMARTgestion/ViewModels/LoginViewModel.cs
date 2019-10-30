using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using SMARTgestion.Data;
using SMARTgestion.Models;
using SMARTgestion.Views;
using Xamarin.Forms;
using SMARTgestion.Services.Helpers;


namespace SMARTgestion.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Atrributes
        private string usuario;
        private string password;
        private bool isRunning;
        private bool isEnabled;
        //private List<Usuarios> usuariosList;
        private ObservableCollection<LoginViewModel> usuarios;

        public ObservableCollection<LoginViewModel> Usuarios
        {
            get { return this.usuarios; }
            set { SetValue(ref this.usuarios, value); }
        }
        #endregion


        #region Propiertes
        public string Usuario
        {
            get { return this.usuario; }
            set { SetValue(ref this.usuario, value); }
        }
        public string Password
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }
        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }

        public bool IsRemember
        {
            get;
            set;
        }
        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }


        #endregion

        #region Constructor
        public LoginViewModel()
        {
            this.IsRemember = true;
            this.IsEnabled = true;
            this.usuario = UserSettings.UserName;
            this.password = UserSettings.Password;
        }
        #endregion
        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new Command(Login);
            }


        }

        public async void Login()
        {


            if (string.IsNullOrEmpty(this.Usuario))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Ingrese el Usuario.",
                    "Acepta");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Ingrese la Contraseña.",
                    "Acepta");
                this.Password = string.Empty;
                return;
            }

            this.isRunning = true;
            this.IsEnabled = false;

            string strCodEmpleado = this.VerificaUsuario(this.Usuario.ToUpper(), this.Password.ToUpper());
            if ( string.IsNullOrEmpty(strCodEmpleado) )
                {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Autentificación Invalida",
                    "Acepta");
                this.isRunning = false;
                this.IsEnabled = true;
                this.Password = string.Empty;
                return;
            }

            string url = "http://aplicacion.amsac.pe/aGESTION" +
                        "/api" +
                        "/Empleado" +
                        "/" + strCodEmpleado.TrimEnd();

            Services.WebService objS = new Services.WebService();
            var response = objS.Get(url);
            var objME = Newtonsoft.Json.JsonConvert.DeserializeObject<Empleados>(response.Content);

            this.isRunning = false;
            this.IsEnabled = true;

            if ( this.IsRemember == false  )
            {
                this.Usuario = string.Empty;
                this.Password = string.Empty;
            }
                UserSettings.UserName = this.Usuario;
                UserSettings.Password = this.password;
                UserSettings.Empleado = objME.CCodPersonal;
                UserSettings.CentroCosto_Gestor = objME.CCodCentroCosto;


            


            MainViewModel.GetInstance().Requerimientos = new RequerimientosViewModel( UserSettings.Empleado, UserSettings.CentroCosto_Gestor);
            await Application.Current.MainPage.Navigation.PushAsync(new RequerimientosPage());



        }
        #endregion

        private String  VerificaUsuario( string strUsuario, string strContraseña  )
        {
            string strLogUsuario = "";
            string strCodEmpleado = "";
            if (strContraseña != "" || strUsuario != "") 
            {
                Services.FN_CifradoDato objCifrado = new Services.FN_CifradoDato();

                strLogUsuario = strUsuario.TrimEnd();
         
                string url = "http://aplicacion.amsac.pe/aGESTION" +
                            "/api" +
                            "/Usuario" +
                            "/" + strLogUsuario.TrimEnd();

                Services.WebService objS = new Services.WebService();
                var response = objS.Get(url);
                var objMU =  Newtonsoft.Json.JsonConvert.DeserializeObject<Usuarios>(response.Content);


                if (objMU.tPasUsuario.TrimEnd() != "") 
                {
                    string strClave = "";
                    strClave = objCifrado .Desencripta_Contraseña(  objMU.tPasUsuario.TrimEnd(),
                                                                    objMU.tClaUsuario.Trim(),
                                                                    objMU.tVecUsuario
                                                      );
                    if (strClave.TrimEnd() == strContraseña) 
                    {
                        strCodEmpleado = objMU.cCodEmpleado;
                    }

                }
            }
            return strCodEmpleado;

        }


    }
}
