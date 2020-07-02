using CRUD.Dominio.Entidades;
using CRUD.Dominio.Interfases;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace CRUD.DatosSQLite.Repositorios
{

    public class RepositorioPago : IRepositorioPago
    {
        public List<Pago> Listar()
        {
            using (IDbConnection conn = new SQLiteConnection(Config.ConnectionString))
            {
                var query = conn.Query<Pago>("SELECT * FROM Pago WHERE 1");
                return query.ToList();
            }
        }
        public void Actualizacion(Pago entidad)
        {
            
        }

        public void Borrar(Pago entidad)
        {
            throw new System.NotImplementedException();
        }

        public void Insertar(Pago entidad)
        {
            using (IDbConnection conn = new SQLiteConnection(Config.ConnectionString))
            {
                int rows = conn.Execute("INSERT INTO Pago (IdEmpleado,Fecha,SueldoBruto) VALUES (@IdEmpleado,@Fecha,@SueldoBruto)", entidad);
            }
        }

    }
}
