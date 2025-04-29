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
   
    public partial class FrmGestionLibros : MetroFramework.Forms.MetroForm
	{
        //referencia al formualrio principal para regresar al mismo
        private FrmMenu menu;

        //referencia de la clase de la ListaEnlazada
        private ListaEnlazada enlazada;

        //Constructor que recibe la referencia del menu principal
        public FrmGestionLibros(FrmMenu Menu)
        {
            InitializeComponent();
            menu = Menu; //agina el formulario del menu principal al atributo de clase

            enlazada = new ListaEnlazada();
            ConfigurarDataGridView();//crea las columnas al iniciar el programa
            
        }

        private void ConfigurarDataGridView()
        {
            // Configurar columnas del DataGridView
           DGVLibros.AutoGenerateColumns = false;

            //configura la columna del ID
            DGVLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ID",
                HeaderText = "ID",
                DataPropertyName = "ID"
            });

            //configura la columna del titulo
            DGVLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Titulo",
                HeaderText = "Título",
                DataPropertyName = "Titulo",
                Width = 200
            });

            //configura la columna del autor
           DGVLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Autor",
                HeaderText = "Autor",
                DataPropertyName = "Autor",
                Width = 150
            });

           //configuracion para la columna de la fecha, dandole un formato
              DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
              colFecha.Name = "FechaPublicacion";
              colFecha.HeaderText = "Fecha Publicación";
              colFecha.DataPropertyName = "FechaPublicacion";
              colFecha.DefaultCellStyle.Format = "dd/MM/yyyy";
               DGVLibros.Columns.Add(colFecha);

            //configuracion para la columna para verificar si esta disponible
            DataGridViewCheckBoxColumn colDisponible = new DataGridViewCheckBoxColumn();
            colDisponible.Name = "DisponibleParaReserva";
            colDisponible.HeaderText = "Disponible";
            colDisponible.DataPropertyName = "DisponibleParaReserva"; // Debe coincidir exactamente con la propiedad
            DGVLibros.Columns.Add(colDisponible);

        }


        private void ActualizarDGV()
        {
            //obtiene los libros y los muestra en el dgv
            var libros = enlazada.ObtenerLibros();
            DGVLibros.DataSource = null;
            DGVLibros.DataSource = enlazada.ObtenerLibros();
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            menu.Show(); //muestra el formulario del menu principal
            this.Close(); //cierra el form actual
        }

        private void FrmGestionLibros_Load(object sender, EventArgs e)
        {
            DGVLibros.AutoGenerateColumns = false; //evita que se generen columnas automaticamente
        }
            
        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                string autor = txtAutor.Text;
                string titulo = txtTitulo.Text;
                DateTime fechapublic = dtpFecha.Value;
                bool disponible = chkDisponible.Checked;

                if(string.IsNullOrWhiteSpace(autor) || string.IsNullOrWhiteSpace(titulo))
                {
                    MessageBox.Show("Por favor, complete los campos de autor y titulo",
                        "Datos incompletos", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                enlazada.AgregarLibro(autor, titulo, fechapublic, disponible);
                ActualizarDGV();


                MessageBox.Show("Libro agregado correctamente", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error al agregar libro: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!int.TryParse(txtID.Text, out int id))
                {
                    MessageBox.Show("Por favor, ingrese un ID válido", "ID Invalido",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Libro libro = enlazada.BuscarLibro(id);
                if(libro != null)
                {
                    txtAutor.Text = libro.Autor;
                    txtTitulo.Text = libro.Titulo;
                    dtpFecha.Value = libro.FechaPubli;
                    chkDisponible.Checked = libro.Disponibilidad;

                    MessageBox.Show("Libro encontrado", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No se encontró un libro con el ID {id}", "Libro no encontrdo",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error al buscar libro: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtID2.Text, out int id))
                {
                    MessageBox.Show("Por favor, ingrese un ID válido", "ID Invalido",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                bool eliminado = enlazada.EliminarLibro(id);

                if (eliminado)
                {
                    ActualizarDGV();
                    LimpiarCampos();
                    MessageBox.Show($"Libro con ID {id} eliminado correctamente", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No se encontro un libro con el ID {id}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el libro: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void LimpiarCampos()
        {
            txtID.Text = "";
            txtAutor.Text = "";
            txtTitulo.Text = "";
            dtpFecha.Value = DateTime.Today;
            chkDisponible.Checked = true;
        }
	}
}
