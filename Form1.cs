using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAS_Desafio_1
{
    public partial class Form1 : Form
    {
        public static List<clsUsuarios> usuarios = new List<clsUsuarios>();
        public static List<clsLibros> libros = new List<clsLibros>();
        public Form1()
        {
            InitializeComponent();
            InicializarColumnasUsuarios();
            InicializarColumnasLibros();
            InicializarColumnasPrestamos();
            CargarMaterialesIniciales();
            ActualizarLibros();
            ActualizarUsuarios();
            ActualizarPrestamos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var libro = new clsLibros(txtTitulo.Text, txtAutor.Text, txtAnio.Text);
            if (libro.datosCompletos_aceptados)
            {
                libros.Add(libro);
                ActualizarLibros();
            }
            else
            {
                MessageBox.Show(libro.UltimoError);
            }
        }

        private void btnAñadirUsuario_Click(object sender, EventArgs e)
        {
            var usuario = new clsUsuarios(txtFullName.Text, txtCorreo.Text);
            if (usuario.datosCompletos_aceptados)
            {
                usuarios.Add(usuario); 
                ActualizarUsuarios();
            }
            else
            {
                MessageBox.Show(usuario.UltimoError);
            }
        }

        private void CargarMaterialesIniciales()
        {
            libros.Add(new clsLibros("Cien Años de Soledad", "Gabriel García Márquez", "1967"));
            libros.Add(new clsLibros("La Casa de los Espiritus", "Isabel Allende", "1982"));
            libros.Add(new clsLibros("Como Agua para Chocolate", "Laura Esquivel", "1989"));
            libros.Add(new clsLibros("Delirios", "Laura Restrepo", "2004"));
            libros.Add(new clsLibros("La Fiesta del Chivo", "Mario Vargas LLosa", "2000"));
            libros.Add(new clsLibros("Los Pasos Perdidos", "Alejo Carpentier", "1953"));
        }

        private void ActualizarUsuarios()
        {
            dgvUsuarios.Rows.Clear();
            cmbUsuarios.Items.Clear();
            foreach (var usuario in usuarios)
            {
                dgvUsuarios.Rows.Add(usuario.FullName, usuario.Correo);
                cmbUsuarios.Items.Add(usuario);
            }
            
        }

        private void ActualizarLibros()
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnio.Clear();

            dgvLibros.Rows.Clear();

            foreach (var libro in libros)
            {
                cmbLibro.Items.Add(libro);
                dgvLibros.Rows.Add(libro.Titulo, libro.Autor, libro.Anio);
            }
        }

        private void ActualizarPrestamos()
        {
            dgvPrestamos.Rows.Clear();

            foreach (var libro in libros)
            {
                dgvPrestamos.Rows.Add(libro.Titulo, libro.FechaPrestamo, libro.FechaDevolucion);
            }
        }

        private void InicializarColumnasUsuarios()
        {
            dgvUsuarios.Columns.Clear();
            dgvUsuarios.Columns.Add("FullName", "Nombre Completo");
            dgvUsuarios.Columns.Add("Correo", "Correo Electrónico");
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void InicializarColumnasLibros()
        {
            dgvLibros.Columns.Clear();
            dgvLibros.Columns.Add("Titulo", "Título");
            dgvLibros.Columns.Add("Autor", "Autor");
            dgvLibros.Columns.Add("Anio", "Año");
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.AllowUserToAddRows = false;
        }

        private void InicializarColumnasPrestamos()
        {
            dgvPrestamos.Columns.Clear();
            dgvPrestamos.Columns.Add("Titulo", "Título");
            dgvPrestamos.Columns.Add("FechaPrestamo", "Fecha de Préstamo");
            dgvPrestamos.Columns.Add("FechaDevolucion", "Fecha de Devolución");
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                string  tituloEliminar = dgvLibros.SelectedRows[0].Cells["Titulo"].Value.ToString();
                var libroEliminar = libros.FirstOrDefault(l => l.Titulo == tituloEliminar);

                if (libroEliminar != null)
                {
                    libros.Remove(libroEliminar);
                    ActualizarLibros();
                }
            else
                {
                    MessageBox.Show("Seleccione un libro para eliminar.");
                }
            }
        }
    }
}
