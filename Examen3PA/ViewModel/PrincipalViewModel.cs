using Bogus;
using Examen3PA.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Examen3PA.ViewModel
{
    public class PrincipalViewModel : BaseViewModel
    {
        public ObservableCollection<Vehiculo> Vehiculos { get; set; }

        public ICommand cmdAgregaVehiculo { get; set; }
        public PrincipalViewModel()
        {
            Vehiculos = new ObservableCollection<Vehiculo>();
            cmdAgregaVehiculo = new Command(() => cmdAgregaVehiculoMetodo());
        }

        private void cmdAgregaVehiculoMetodo()
        {

            Vehiculo vehiculo = new Faker<Vehiculo>()
                .RuleFor(c => c.Modelo, f => f.Name.FindName())
                .RuleFor(c => c.Marca, f => f.Company.CompanyName());


            Random rnd = new Random();
            DateTime datetoday = DateTime.Now;

            int rndYear = rnd.Next(1960, datetoday.Year);

            DateTime generateDate = new DateTime(rndYear);

            vehiculo.Año = new Año() { AñoCreacion = generateDate };
        }

        public void GetAll()

        {
            if (Vehiculos != null)
            {
                Vehiculos.Clear();
                App.VehiculosDb.GetAll().ForEach(item => Vehiculos.Add(item));
            }
            else
            {
                Vehiculos = new ObservableCollection<Vehiculo>(App.VehiculosDb.GetAll());

            }
            OnPropertyChanged();
        }
    }
}
