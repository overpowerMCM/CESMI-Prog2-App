using CRUD.Aplicacion.DTO;
using CRUD.Aplicacion.Servicios;
using CRUD.DatosSQLite.Repositorios;
using CRUD.PresentacionWinForms.Vistas;
using System;
using System.Collections.Generic;

namespace CRUD.PresentacionWinForms.Controladores
{
    public class ControladorMain : ControladorBase<Main>
    {
        public ControladorMain()
        {
            Vista.BotonEmpleados.Click += BotonEmpleados_Click;
        }

        private void BotonEmpleados_Click(object sender, EventArgs e)
        {
            ServicioEmpleado _servicioEmpleado = new ServicioEmpleado(new RepositorioEmpleado());
            List<EmpleadoDTO> lista = _servicioEmpleado.ObtenerTodos();

            CrearVistaEmpleado( lista );

        }
    }
}
