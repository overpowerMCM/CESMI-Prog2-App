using CRUD.Aplicacion.DTO;
using CRUD.Aplicacion.Servicios;
using CRUD.DatosSQLite.Repositorios;
using CRUD.Dominio.Enumeradores;
using CRUD.PresentacionWinForms.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.ComboBox;

namespace CRUD.PresentacionWinForms.Controladores
{
    public class ControladorEmpleado : ControladorBase<VistaEmpleado>
    {
        public enum EEstado
        { 
            NORMAL = 0,
            INSERTAR,
            EDITAR,
            BORRAR,
            MAX
        }

        EEstado _estadoActual = EEstado.NORMAL;

        List<EmpleadoDTO> _listaEmpleados;
        EmpleadoDTO _empleadoSeleccionado;
        ServicioEmpleado _servicioEmpleado;

        public ControladorEmpleado()
        {
            ConfigurarEventos();
            ConfigurarComponentes();

            _servicioEmpleado = new ServicioEmpleado(new RepositorioEmpleado());

            PoblarGrillaEmpleados(_servicioEmpleado.ObtenerTodos());

            EstablecerEstadoActual(EEstado.NORMAL);
        }

        void ConfigurarEventos()
        {
            Vista.BotonInsertOk.Click += BotonInsertOk_Click;
            Vista.BotonEditCancel.Click += BotonEditCancel_Click;
            Vista.BotonBorrar.Click += BotonBorrar_Click;

            Vista.GridListado.RowEnter += GridListado_RowEnter;
        }
        void ConfigurarComponentes()
        {
            List<string> _items = new List<string>();

            for (int i = 0; i < (int)ETipoPuesto.MAX; i++)
            {
                _items.Add( ((ETipoPuesto)i).ToString() );
            }

            Vista.ComboBoxPuesto.Items.AddRange( _items.ToArray() );
        }

        void PoblarGrillaEmpleados( List<EmpleadoDTO> lista )
        {
            _listaEmpleados = lista;
            Vista.GridListado.DataSource = _listaEmpleados;
       
        }

        private void GridListado_RowEnter(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (_listaEmpleados != null && _listaEmpleados.Count > e.RowIndex)
            {
                _empleadoSeleccionado = _listaEmpleados[e.RowIndex];

                RellenarCasillasConEmpleado(_empleadoSeleccionado);
            }
        }

        void EstablecerEstadoActual( EEstado nuevoEstado )
        {
            _estadoActual = nuevoEstado;
            HabilitarCasillas( _estadoActual == EEstado.INSERTAR || _estadoActual == EEstado.EDITAR );
            Establecer_Visibilidad_Y_Nombre_De_Botones_Segun_Estado();
        }

        void HabilitarCasillas( bool habilitado )
        {
            Vista.TextBoxApellido.ReadOnly = !habilitado;
            Vista.TextBoxNombre.ReadOnly = !habilitado;
            Vista.TextBoxDNI.ReadOnly = !habilitado;
            Vista.TextBoxLegajo.ReadOnly = !habilitado;

            Vista.ComboBoxPuesto.Enabled = habilitado;

            Vista.DatePickerIngreso.Enabled = habilitado;
            Vista.DatePickerNacimiento.Enabled = habilitado;
        }

        void BorrarTextosCasillas()
        {
            Vista.TextBoxNombre.Text = "";
            Vista.TextBoxApellido.Text = "";
            Vista.TextBoxDNI.Text = "";
            Vista.TextBoxLegajo.Text = "";

            Vista.ComboBoxPuesto.SelectedIndex = 0;

            Vista.DatePickerIngreso.Value = DateTime.Now;
            Vista.DatePickerNacimiento.Value = DateTime.Now;
        }

        private void RellenarCasillasConEmpleado(EmpleadoDTO empleado)
        {
            Vista.TextBoxNombre.Text = empleado.Nombre;
            Vista.TextBoxApellido.Text = empleado.Apellido;
            Vista.TextBoxDNI.Text = empleado.DNI.ToString();
            Vista.TextBoxLegajo.Text = empleado.Legajo;

            Vista.ComboBoxPuesto.SelectedIndex = (int)empleado.Puesto;

            Vista.DatePickerIngreso.Value = empleado.FechaIngreso;
            Vista.DatePickerNacimiento.Value = empleado.FechaNacimiento;
        }

        void Establecer_Visibilidad_Y_Nombre_De_Botones_Segun_Estado( )
        {
            // visibilidad
            Vista.BotonBorrar.Visible = _estadoActual == EEstado.NORMAL;

            // textos de botones
            Vista.BotonInsertOk.Text = _estadoActual == EEstado.NORMAL ? "Nuevo" : "Ok";
            Vista.BotonEditCancel.Text = _estadoActual == EEstado.NORMAL ? "Editar" : "Cancelar";
        }

        private void BotonBorrar_Click(object sender, EventArgs e)
        {
            if (_estadoActual == EEstado.NORMAL && _empleadoSeleccionado != null)
            {
                EstablecerEstadoActual(EEstado.BORRAR);
            }
        }

        private void BotonEditCancel_Click(object sender, EventArgs e)
        {
            if (_estadoActual == EEstado.NORMAL && _empleadoSeleccionado != null)
            {
                EstablecerEstadoActual(EEstado.EDITAR);
            }
            else 
            {
                if (_empleadoSeleccionado != null)
                    RellenarCasillasConEmpleado(_empleadoSeleccionado);
                else
                    BorrarTextosCasillas();
                
                EstablecerEstadoActual(EEstado.NORMAL);
            }

        }

        EmpleadoDTO MapearVistaADTO()
        {
            int valor = 0;
            Int32.TryParse(Vista.TextBoxDNI.Text, out valor);

            return new EmpleadoDTO()
            {
                Nombre = Vista.TextBoxNombre.Text,
                Apellido = Vista.TextBoxApellido.Text,
                Legajo = Vista.TextBoxLegajo.Text,
                DNI = valor,
                FechaNacimiento = Vista.DatePickerNacimiento.Value,
                FechaIngreso = Vista.DatePickerIngreso.Value,
                Puesto = (ETipoPuesto)Vista.ComboBoxPuesto.SelectedIndex
            };
        }

        private void BotonInsertOk_Click(object sender, EventArgs e)
        {
            if (_estadoActual == EEstado.NORMAL)
            {
                BorrarTextosCasillas();
                EstablecerEstadoActual(EEstado.INSERTAR);
                return;
            }
            else if (_estadoActual == EEstado.INSERTAR)
            {
                _servicioEmpleado.InsertarEmpleado(MapearVistaADTO());
                PoblarGrillaEmpleados(_servicioEmpleado.ObtenerTodos());
            }
            else if (_estadoActual == EEstado.EDITAR)
            {
                _servicioEmpleado.ActualizarEmpleado(MapearVistaADTO());
            }
            else 
            {
                _servicioEmpleado.BorrarEmpleadoPorId( _empleadoSeleccionado.Id );
                PoblarGrillaEmpleados(_servicioEmpleado.ObtenerTodos());
            }
            EstablecerEstadoActual(EEstado.NORMAL);
        }
    }
}
