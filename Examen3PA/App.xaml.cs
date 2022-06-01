using Examen3PA.Repositories;
using Examen3PA.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen3PA
{
    public partial class App : Application
    {
        #region Repository
        private static VehiculoRepos _VehiculosDb;
        public static VehiculoRepos VehiculosDb
        {
            get
            {
                if (_VehiculosDb == null)
                {
                    _VehiculosDb = new VehiculoRepos();
                }
                return _VehiculosDb;

            }
        }

        private static AñoRepos _AñosDb;
        public static AñoRepos AñosDb
        {
            get
            {
                if (_AñosDb == null)
                {
                    _AñosDb = new AñoRepos();
                }
                return _AñosDb;

            }
        }
        #endregion
        public App()
        {
            InitializeComponent();
            AñosDb.Init();
            VehiculosDb.Init();

            MainPage = new NavigationPage(new Principal());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
