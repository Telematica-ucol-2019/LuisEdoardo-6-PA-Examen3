using Examen3PA.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen3PA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principal : ContentPage
    {
        PrincipalViewModel vm = new PrincipalViewModel();
        public Principal()
        {
            InitializeComponent();
            BindingContext = vm;


        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            vm.GetAll();

        }
    }
}