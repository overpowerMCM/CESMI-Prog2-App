using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.PresentacionWinForms.Controladores
{
    public class ControladorBase<T> : IControladorBase<T> where T : Form, new()
    {
        T _vista;

        public T Vista => _vista ?? (_vista = new T());

    }
}
