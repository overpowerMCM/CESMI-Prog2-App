using CRUD.Aplicacion.DTO;
using CRUD.Aplicacion.Servicios;
using CRUD.DatosSQLite.Repositorios;
using CRUD.PresentacionWinForms.Vistas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUD.PresentacionWinForms.Controladores
{
    public class ControladorMain : ControladorBase<Main>
    {
        IControladorBase _controladorActual = null;

        public ControladorMain()
        {
            ConfigurarEventos();
        }

        void ConfigurarEventos()
        {
            Vista.BotonEmpleados.Click += BotonEmpleados_Click;
            Vista.BotonPago.Click += BotonPago_Click;
        }

        void AnidarVistaAPanelTrabajo<T>( ControladorBase<T> controlador ) where T : Form, new()
        {
            if (_controladorActual != null)
            {
                _controladorActual.LiberarRecursos();
                _controladorActual = null;
                Vista.PanelTrabajo.Controls.Clear();
            }

            controlador.Vista.TopLevel = false;
            controlador.Vista.FormBorderStyle = FormBorderStyle.None;
            controlador.Vista.Dock = DockStyle.Fill;

            Vista.PanelTrabajo.Controls.Add(controlador.Vista);

            _controladorActual = controlador;


            controlador.Vista.Show();
        }

        private void BotonPago_Click(object sender, EventArgs e)
        {
            AnidarVistaAPanelTrabajo( new ControladorEmpleado() );
        }

        private void BotonEmpleados_Click(object sender, EventArgs e)
        {
            AnidarVistaAPanelTrabajo(new ControladorPago());
        }
    }
}
