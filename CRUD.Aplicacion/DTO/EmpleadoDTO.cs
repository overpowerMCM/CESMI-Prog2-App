using CRUD.Dominio.Enumeradores;
using System;

namespace CRUD.Aplicacion.DTO
{
    public class EmpleadoDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Legajo { get; set; }
        public ETipoPuesto Puesto { get; set; }
        public int DNI { get; set; }
    }
}
