using CRUD.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Dominio.Interfases
{
    public interface IRepositorioEmpleado
    {
        List<Empleado> Listar(  );
        void Insertar( Empleado entidad);
        void Actualizacion( Empleado entidad );
        void Borrar( Empleado entidad );
    }
}
