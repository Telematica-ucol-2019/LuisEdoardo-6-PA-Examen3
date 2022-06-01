using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen3PA.Models
{
    public class Año
    {
        [Table("Años")]
        public class FechaPublicacion
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }
            public DateTime AñoCreacion { get; set; }
        }
    }
}
