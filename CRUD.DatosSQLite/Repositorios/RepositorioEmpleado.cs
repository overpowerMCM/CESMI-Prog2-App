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
            using (var conn = new SQLiteConnection(Config.ConnectionString))
            {
                conn.Execute("UPDATE Empleado SET Nombre=@Nombre,Apellido=@Apellido,FechaNacimiento=@FechaNacimiento,FechaIngreso=@FechaIngreso,Legajo=@Legajo,Puesto=@Puesto,DNI=@DNI WHERE Id=@Id", entidad);
            }
        }

        public void Borrar(Empleado entidad)
        {
            using (var conn = new SQLiteConnection(Config.ConnectionString))
            {
                conn.Execute("DELETE FROM Empleado WHERE Id=@Id", entidad);
            }
        }

        public void Insertar(Empleado entidad)
        {
            using (var conn = new SQLiteConnection(Config.ConnectionString))
            {
                conn.Execute("INSERT INTO Empleado (Nombre,Apellido,FechaNacimiento,FechaIngreso,Legajo,Puesto,DNI) VALUES (@Nombre,@Apellido,@FechaNacimiento,@FechaIngreso,@Legajo,@Puesto,@DNI)", entidad);
            }
        }

    }
}
