using CRUD.Aplicacion.DTO;
using CRUD.Dominio.Entidades;
using CRUD.Dominio.Interfases;
using System;
using System.Collections.Generic;

namespace CRUD.Aplicacion.Servicios
{
    public class ServicioPago
    {
        IRepositorioPago _repositorio;
        public ServicioPago( IRepositorioPago repo )
        {
            _repositorio = repo;
        }

        public List<PagoDTO> ObtenerTodos()
        {
            List<PagoDTO> listado = new List<PagoDTO>();

            List<Pago> entidades = _repositorio.Listar();

            for (int i = 0; i < entidades.Count; i++)
            {
                Pago entidad = entidades[i];

                PagoDTO pago = new PagoDTO();
                pago.Id = entidad.Id;
                pago.Fecha = entidad.Fecha;
                pago.IdEmpleado = entidad.IdEmpleado;
                pago.SueldoBruto = entidad.SueldoBruto;

                listado.Add(pago);
            }

            return listado;
        }

        public List<PagoDTO> ObtenerPagoEmpleado( int idEmpleado )
        {
            List<PagoDTO> listadoPagos = ObtenerTodos();
            List<PagoDTO> listadoFiltrado = new List<PagoDTO>();

            for (int p = 0; p < listadoPagos.Count; p++)
            {
                PagoDTO pago = listadoPagos[p];
                if (pago.IdEmpleado == idEmpleado)
                {
                    listadoFiltrado.Add(pago);
                }
            }
            return listadoFiltrado;
        }

        public void InsertarPago( PagoDTO pago )
        {
            if ( pago.SueldoBruto > 0 )//&& DateTime.Now.CompareTo( pago.Fecha ) <= 0 ) 
            {
                Pago entidad = new Pago();

                entidad.Id = pago.Id;
                entidad.Fecha = pago.Fecha;
                entidad.IdEmpleado = pago.IdEmpleado;
                entidad.SueldoBruto = pago.SueldoBruto;

                _repositorio.Insertar(entidad);

            }
        }
    }
}
