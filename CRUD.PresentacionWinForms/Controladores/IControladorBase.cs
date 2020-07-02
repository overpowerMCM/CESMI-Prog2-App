using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.PresentacionWinForms.Controladores
{
    public interface IControladorBase<T> where T : Form, new()
    {
        T Vista { get; }
    }
}
