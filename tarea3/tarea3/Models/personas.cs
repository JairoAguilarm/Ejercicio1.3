using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace tarea3.Models
{
    public class personas
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public int edad { get; set; }
        public String correo { get; set; }
        public string direccion { get; set; }


    }
}
