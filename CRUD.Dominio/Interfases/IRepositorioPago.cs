using CRUD.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Dominio.Interfases
{
    public interface IRepositorioPago
    {
        List<Pago> Listar();
        void Insertar(Pago entidad);
        void Actualizacion(Pago entidad);
        void Borrar(Pago entidad);
    }
}
