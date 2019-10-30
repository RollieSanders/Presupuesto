using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using SMARTgestion.Views;
using SMARTgestion.Models;

namespace SMARTgestion.ViewModels
{
    public class RequerimientoItemViewModel : Requerimientos
    {
        public ICommand SelectRequerimientoCommand
        {
            get
            {
                return new RelayCommand(SelectRequerimiento);
            }
        }

        private async void SelectRequerimiento()
        {
            
            MainViewModel.GetInstance().Requerimiento = new RequerimientoViewModel(this);
            await Application.Current.MainPage.Navigation.PushAsync(new RequerimientoTabbedPage());
        }
    }
}
