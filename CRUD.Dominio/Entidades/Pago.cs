using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Dominio.Entidades
{
    public class Pago
    {
        public int Id { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public float SueldoBruto { get; set; }
    }
}
