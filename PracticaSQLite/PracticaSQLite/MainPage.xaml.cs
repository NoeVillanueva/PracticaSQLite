using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace PracticaSQLite
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SQLiteAsyncConnection database;
            string db;
            db = DependencyService.Get<ISQLite>().GetLocalFilePath("Practica.db");
            database = new SQLiteAsyncConnection(db);
            database.CreateTableAsync<TESHDatos>().Wait();

            var elemento = new TESHDatos
            {
            Matricula = "13090301",
            Nombre = "Noe",
            Apellidos = "Villanueva",
            Direccion = "Rio Bravo",
            Telefono = "5556575859",
            Carrera = "Sistemas",
            Semestre = "Noveno",
            Correo = "Noe@hotmail.com",
            Github = "NoeVillanueva"
            };

            database.InsertAsync(elemento);
        }
    }
}
