using Examen3PA.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examen3PA.Repositories
{
    public class AñoRepos
    {
        SQLiteConnection connection;
        public AñoRepos()
        {
            connection = new SQLiteConnection(Constants.Constants.DatabasePath, Constants.Constants.Flags);
            connection.CreateTable<Año>();
        }

        public void Init()
        {
            connection.CreateTable<Año>();
        }
        public void InsertOrUpdate(Año año)
        {
            if (año.Id == 0)
            {

                connection.Insert(año);

            }
            else
            {

                connection.Update(año);

            }
        }

        public Año GetById(int Id)
        {
            return connection.Table<Año>().FirstOrDefault(item => item.Id == Id);
        }

        public List<Año> GetAll()
        {

            return connection.Table<Año>().ToList();
        }


        public void DeleteItem(int Id)
        {
            Año año = GetById(Id);
            connection.Delete(año);
        }
    }
}
