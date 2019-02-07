using MVVM_Simpel.Models;
using MVVM_Simpel.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace MVVM_Simpel.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            // Kontrollfreak-Antipattern:
            service = new PersonenService();
            GetPersonenCommand = new Command(GetPersonen);
        }

        private void GetPersonen(object obj)
        {
            Personenliste = service.GetPersonen();
        }

        private readonly PersonenService service;

        public Command GetPersonenCommand { get; set; }
        private List<Person> personenliste;
        public List<Person> Personenliste
        {
            get => personenliste; 
            set => SetValue(ref personenliste, value); 
        }
    }
}
