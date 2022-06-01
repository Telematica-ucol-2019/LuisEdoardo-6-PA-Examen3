using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen3PA.Models
{
    [Table("Vehiculos")]
    public class Vehiculo
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }

        [ForeignKey(typeof(Año))]
        public int FKAñoId { get; set; }
        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public Año Año { get; set; }
    }
}
