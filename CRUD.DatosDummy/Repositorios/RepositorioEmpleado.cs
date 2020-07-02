using CRUD.Dominio.Entidades;
using CRUD.Dominio.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.DatosDummy.Repositorios
{
    public class RepositorioEmpleado : IRepositorioEmpleado
    {
        List<Empleado> listadoEntidades = new List<Empleado>();
        public RepositorioEmpleado()
        {
            Empleado emp1 = new Empleado();
            emp1.Id = 1;
            emp1.Nombre = "Juan";
            emp1.Apellido = "Perez";
            emp1.DNI = 30111222;
            emp1.FechaIngreso = new DateTime(2019, 11, 12);
            emp1.FechaNacimiento = new DateTime(1999, 5, 5);
            emp1.Puesto = 3;
            emp1.Legajo = "L123456789";

            Empleado emp2 = new Empleado();
            emp2.Id = 2;
            emp2.Nombre = "Roberto";
            emp2.Apellido = "Bolaños";
            emp2.DNI = 20135698;
            emp2.FechaIngreso = new DateTime(2015, 05, 05);
            emp2.FechaNacimiento = new DateTime(1970, 11, 5);
            emp2.Puesto = 0;
            emp2.Legajo = "1";

            listadoEntidades.Add(emp1);
            listadoEntidades.Add(emp2);
        }
        public List<Empleado> Listar()
        {
            return listadoEntidades;
        }
        public void Insertar(Empleado entidad)
        {
            throw new NotImplementedException();
        }
        public void Actualizacion(Empleado entidad)
        {
            throw new NotImplementedException();
        }

        public void Borrar(Empleado entidad)
        {
            throw new NotImplementedException();
        }
    }
}
