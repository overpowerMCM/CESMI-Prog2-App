using CRUD.Aplicacion.DTO;
using CRUD.Aplicacion.Servicios;
using CRUD.DatosSQLite.Repositorios;
using CRUD.Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace CRUD.PresentacionConsola
{
    class Program
    {
        static void Main(string[] args)
        {

            // configuracion de los servicion
            ServicioEmpleado _servicioEmpleado = new ServicioEmpleado( new RepositorioEmpleado() );
            ServicioPago _servicioPago = new ServicioPago( new RepositorioPago() );

            List<EmpleadoDTO> listadoEmpleados = _servicioEmpleado.ObtenerTodos();
            List<PagoDTO> listadoPagos = _servicioPago.ObtenerTodos();

            PagoDTO pagoDTO = new PagoDTO();
            pagoDTO.IdEmpleado = 2;
            pagoDTO.Fecha = DateTime.Now;
            pagoDTO.SueldoBruto = 100000f;

            _servicioPago.InsertarPago(pagoDTO);

            for (int e = 0; e < listadoEmpleados.Count; e++)
            {
                EmpleadoDTO empleado = listadoEmpleados[e];
                Console.WriteLine(string.Format("{0} {1} - Puesto: {2}", empleado.Nombre, empleado.Apellido, empleado.Puesto));

                List<PagoDTO> pagosEmpleado = _servicioPago.ObtenerPagoEmpleado(empleado.Id);

                for (int p = 0; p < pagosEmpleado.Count; p++)
                {
                    PagoDTO pago = pagosEmpleado[p];
                    Console.WriteLine(string.Format("   Monto: {0:0.00} - Fecha: {1}", pago.SueldoBruto, pago.Fecha));                    
                }

            }

            Console.ReadKey();
        }
    }
}
