using CRUD.Aplicacion.DTO;
using CRUD.Dominio.Entidades;
using CRUD.Dominio.Enumeradores;
using CRUD.Dominio.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Aplicacion.Servicios
{
    public class ServicioEmpleado
    {
        IRepositorioEmpleado _repositorio;
        public ServicioEmpleado(IRepositorioEmpleado repositorio)
        {
            _repositorio = repositorio;
        }

        public List<EmpleadoDTO> ObtenerTodos()
        {
            List<EmpleadoDTO> listado = new List<EmpleadoDTO>();

            List<Empleado> entidades = _repositorio.Listar();

            for (int i = 0; i < entidades.Count; i++)
            {
                Empleado entidad = entidades[i];
                EmpleadoDTO empleado = new EmpleadoDTO();

                empleado.Id = entidad.Id;
                empleado.Nombre = entidad.Nombre;
                empleado.Apellido = entidad.Apellido; // Automapper
                empleado.DNI = entidad.DNI;
                empleado.FechaIngreso = entidad.FechaIngreso;
                empleado.FechaNacimiento = entidad.FechaNacimiento;
                empleado.Legajo = entidad.Legajo;
                empleado.Puesto = (ETipoPuesto)entidad.Puesto;

                listado.Add(empleado);
            }

            return listado;
        }

        public void InsertarEmpleado( EmpleadoDTO empleado )
        {
            if (DateTime.Now.Subtract(empleado.FechaNacimiento).TotalDays < (65*365) )
            {
                Empleado entidad = new Empleado();

                entidad.Nombre = empleado.Nombre;
                entidad.Apellido = empleado.Apellido; // Automapper
                entidad.DNI = empleado.DNI;
                entidad.FechaIngreso = empleado.FechaIngreso;
                entidad.FechaNacimiento = empleado.FechaNacimiento;
                entidad.Legajo = empleado.Legajo;
                entidad.Puesto = (int)empleado.Puesto;

                _repositorio.Insertar(entidad);

            }
        }

    }
}
