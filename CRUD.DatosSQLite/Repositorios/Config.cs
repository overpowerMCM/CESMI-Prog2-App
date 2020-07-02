using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.DatosSQLite.Repositorios
{
    public static class Config
    {
        public static string ConnectionString { get => string.Format(@"Data Source={0}\BaseDatos\CRUD.db;Version=3;",Directory.GetCurrentDirectory()); }
        
    }
}
