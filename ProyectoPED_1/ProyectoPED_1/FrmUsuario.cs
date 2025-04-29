using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPED_1
{
    public partial class FrmUsuario : Form
    {
        //referencia al formulario principal para regresar al mismo
        private FrmMenu menu;
        public FrmUsuario(FrmMenu Menu)
        {
            InitializeComponent();
            menu = Menu; //asgina el formulario del menú principal al atributo de la clase
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            menu.Show();//muestra el menu 
            this.Close();//cierra el form actual
        }
    }
}
