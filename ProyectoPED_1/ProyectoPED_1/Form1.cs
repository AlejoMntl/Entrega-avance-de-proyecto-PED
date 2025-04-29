
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Framework UI
using MetroFramework.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Components;

namespace ProyectoPED_1
{
    public partial class FrmMenu : MetroFramework.Forms.MetroForm
	{

		public FrmMenu()
        {
            InitializeComponent();

			metroLabel4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);


		}

		private void txtclave_TextChanged(object sender, EventArgs e)
        {
            string clave = "1234";

            if(txtclave.Text == clave)
            {
                btnGestor.Enabled = true;
            }
            else
            {
                btnGestor.Enabled = false;
            }
        }

       

        private bool ValidarCarnet(string carnet)
        {
            //eliminar espacios en blanco
            carnet = carnet.Trim();

            if (carnet.Length != 8) //considerando formato de UDB para carnet
                return false;

            // Verificar primeros 2 caracteres son letras
            if (!char.IsLetter(carnet[0]) || !char.IsLetter(carnet[1])) return false;

            // Verificar últimos 6 caracteres son números
            for (int i = 2; i < 8; i++)
            {
                if (!char.IsDigit(carnet[i])) return false;
            }

            return true;

        }

        private void btnGestor_Click(object sender, EventArgs e)
        {
            FrmGestionLibros Gestor = new FrmGestionLibros(this);
            this.Hide();
            Gestor.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo del programa..."
                );
            this.Close();
        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void FrmMenu_Load(object sender, EventArgs e)
		{

		}

		private void btnCliente_Click_1(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtCarnet.Text) ||
			  string.IsNullOrEmpty(txtNombre.Text))
			{
				MessageBox.Show("Debe llenar sus datos por completo.", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (!ValidarCarnet(txtCarnet.Text))
			{
				MessageBox.Show("No hay un formato valido del carnet.", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtCarnet.Focus();
				return;
			}

			//si todo es valido, se procede:                 
			FrmUsuario usuario = new FrmUsuario(this);
			this.Hide();
			usuario.Show();

		}
	}
}
