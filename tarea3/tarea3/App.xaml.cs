using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using tarea3.Controller;
using System.IO;

namespace tarea3
{
    public partial class App : Application
    {
        static DBpersonas db;

        public static DBpersonas dbpersona
        {
            get
            {
                if(db == null)
                {
                    string FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "persona.db3");
                    db = new DBpersonas(FolderPath);

                }
                return db;
            }
        }




        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new menuprincipal());


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
