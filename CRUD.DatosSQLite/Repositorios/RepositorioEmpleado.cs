using CRUD.Dominio.Entidades;
using CRUD.Dominio.Interfases;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace CRUD.DatosSQLite.Repositorios
{
    public class RepositorioEmpleado : IRepositorioEmpleado
    {
        public List<Empleado> Listar()
        {
            using (var conn = new SQLiteConnection(Config.ConnectionString))
            {
                var query = conn.Query<Empleado>("SELECT * FROM Empleado WHERE 1");
                return query.ToList();
            }
        }

        public void Actualizacion(Empleado entidad)
        {
            //Config.DDBBPath
        }

        public void Borrar(Empleado entidad)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Empleado entidad)
        {
            throw new NotImplementedException();
        }

    }
}
