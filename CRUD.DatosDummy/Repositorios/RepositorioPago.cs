using CRUD.Dominio.Entidades;
using CRUD.Dominio.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.DatosDummy.Repositorios
{
    public class RepositorioPago : IRepositorioPago
    {
        List<Pago> pagos = new List<Pago>();
        public RepositorioPago()
        {
            Pago pago1 = new Pago();
            pago1.Id = 1;
            pago1.IdEmpleado = 1;
            pago1.SueldoBruto = 999.0f;
            pago1.Fecha = new DateTime(2020, 1, 5);

            Pago pago2 = new Pago();
            pago2.Id = 2;
            pago2.IdEmpleado = 1;
            pago2.SueldoBruto = 499.0f;
            pago2.Fecha = new DateTime(2020, 2, 5);

            Pago pago3 = new Pago();
            pago3.Id = 3;
            pago3.IdEmpleado = 2;
            pago3.SueldoBruto = 749.0f;
            pago3.Fecha = new DateTime(2020, 1, 5);

            pagos.Add(pago1);
            pagos.Add(pago2);
            pagos.Add(pago3);
        }

        public void Insertar(Pago entidad)
        {
            entidad.Id = pagos.Count + 1;
            pagos.Add(entidad);
        }

        public List<Pago> Listar()
        {
            return pagos;
        }

        public void Actualizacion(Pago entidad)
        {
            throw new NotImplementedException();
        }

        public void Borrar(Pago entidad)
        {
            throw new NotImplementedException();
        }
    }
}
