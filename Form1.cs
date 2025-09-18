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
        public static List<clsPrestamos> prestamos = new List<clsPrestamos>();
        public Form1()
        {
            InitializeComponent();
            cmbLibro.Items.Clear();
            cmbUsuarios.Items.Clear();
            InicializarColumnasUsuarios();
            InicializarColumnasLibros();
            InicializarColumnasPrestamos();
            CargarMaterialesIniciales();
            CargarUsuariosIniciales();
            CargarPrestamosIniciales();
            ActualizarLibros();
            ActualizarUsuarios();
            ActualizarPrestamos();
            dgvLibros.CellDoubleClick += dgvLibros_CellDoubleClick;
            dgvUsuarios.CellDoubleClick += dgvUsuarios_CellDoubleClick;
            dgvPrestamos.CellDoubleClick += dgvPrestamos_CellDoubleClick;
        }

        private int indexPresEditar = -1;

        private void CargarMaterialesIniciales()
        {
            libros.Add(new clsLibros("Cien Años de Soledad", "Gabriel García Márquez", "1967"));
            libros.Add(new clsLibros("La Casa de los Espiritus", "Isabel Allende", "1982"));
            libros.Add(new clsLibros("Como Agua para Chocolate", "Laura Esquivel", "1989"));
            libros.Add(new clsLibros("Delirios", "Laura Restrepo", "2004"));
            libros.Add(new clsLibros("La Fiesta del Chivo", "Mario Vargas LLosa", "2000"));
            libros.Add(new clsLibros("Los Pasos Perdidos", "Alejo Carpentier", "1953"));
            libros.Add(new clsLibros("Romeo y Julieta", "William Shakespeare", "1597"));
            libros.Add(new clsLibros("Don Quijote de la Mancha", "Miguel de Cervantes", "1605"));
            libros.Add(new clsLibros("Orgullo y Prejuicio", "Jane Austen", "1813"));
            libros.Add(new clsLibros("Frankenstein", "Mary Shelley", "1818"));
            libros.Add(new clsLibros("Los 3 Mosqueteros", "Alexandre Dumas", "1844"));
            libros.Add(new clsLibros("Cumbres Borrascosas", "Emily Bronte", "1847"));
            libros.Add(new clsLibros("Jane Eyre", "Charlotte Bronte", "1847"));

        }

        private void CargarUsuariosIniciales()
        {
            usuarios.Add(new clsUsuarios("Ana García", "anagarcia78@gmail.com"));
            usuarios.Add(new clsUsuarios("Antonio Barrientos", "barrientos99@gmail.com"));
            usuarios.Add(new clsUsuarios("Miguel Anaya", "anaya.miguel@hotmail.com"));
            usuarios.Add(new clsUsuarios("Marcos Cortejo", "cor-mar238@gmail.com"));
            usuarios.Add(new clsUsuarios("Maribel Guardado", "mariguardado@gmail.com"));
            usuarios.Add(new clsUsuarios("Lisbeth Argueta", "liss34@gmail.com"));
            usuarios.Add(new clsUsuarios("Lily Acosta", "lilies09@hotmail.com"));
            usuarios.Add(new clsUsuarios("Ana Castro", "castro32@gmail.com"));
            usuarios.Add(new clsUsuarios("Bryan Castillo", "castillo27@gmail.com"));
            usuarios.Add(new clsUsuarios("Jose Bonilla", "josee36bonilla@gmail.com"));
            usuarios.Add(new clsUsuarios("Kimberly Chacón", "chaconchacon@gmail.com"));
            usuarios.Add(new clsUsuarios("Katerin Gonzalez", "rosesarered@gmail.com"));
            usuarios.Add(new clsUsuarios("Kevin Trujillo", "trujillo3kevin@gmail.com"));
        }

        private void CargarPrestamosIniciales()
        {
            prestamos.Add(new clsPrestamos(
                libros[0].Titulo,
                usuarios[7].FullName,
                DateTime.Now.AddDays(-10),
                DateTime.Now.AddDays(-4)
                ));
            prestamos.Add(new clsPrestamos(
                libros[5].Titulo,
                usuarios[3].FullName,
                DateTime.Now.AddDays(-70),
                DateTime.Now.AddDays(-64)
                ));
            prestamos.Add(new clsPrestamos(
                libros[7].Titulo,
                usuarios[3].FullName,
                DateTime.Now.AddDays(-15),
                DateTime.Now.AddDays(-2)
                ));
            prestamos.Add(new clsPrestamos(
                libros[10].Titulo,
                usuarios[2].FullName,
                DateTime.Now.AddDays(-101),
                DateTime.Now.AddDays(-95)
                ));
            prestamos.Add(new clsPrestamos(
                libros[0].Titulo,
                usuarios[5].FullName,
                DateTime.Now.AddDays(-56),
                DateTime.Now.AddDays(-43)
                ));
            prestamos.Add(new clsPrestamos(
                libros[2].Titulo,
                usuarios[11].FullName,
                DateTime.Now.AddDays(-67),
                DateTime.Now.AddDays(-60)
                ));
            prestamos.Add(new clsPrestamos(
                libros[6].Titulo,
                usuarios[5].FullName,
                DateTime.Now.AddDays(-19),
                DateTime.Now.AddDays(-11)
                ));
            prestamos.Add(new clsPrestamos(
                libros[8].Titulo,
                usuarios[3].FullName,
                DateTime.Now.AddDays(-45),
                DateTime.Now.AddDays(-40)
                ));
            prestamos.Add(new clsPrestamos(
                libros[3].Titulo,
                usuarios[9].FullName,
                DateTime.Now.AddDays(-23),
                DateTime.Now.AddDays(-14)
                ));
            prestamos.Add(new clsPrestamos(
                libros[6].Titulo,
                usuarios[10].FullName,
                DateTime.Now.AddDays(-7),
                DateTime.Now.AddDays(4)
                ));
            prestamos.Add(new clsPrestamos(
                libros[9].Titulo,
                usuarios[5].FullName,
                DateTime.Now.AddDays(-26),
                DateTime.Now.AddDays(-16)
                ));
            prestamos.Add(new clsPrestamos(
                libros[11].Titulo,
                usuarios[8].FullName,
                DateTime.Now.AddDays(-9),
                DateTime.Now.AddDays(4)
                ));
            prestamos.Add(new clsPrestamos(
                libros[3].Titulo,
                usuarios[4].FullName,
                DateTime.Now,
                DateTime.Now.AddDays(7)
                ));
            prestamos.Add(new clsPrestamos(
                libros[6].Titulo,
                usuarios[7].FullName,
                DateTime.Now,
                DateTime.Now.AddDays(8)
                ));
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

        private void registrarPrestamo() { 
            if (cmbUsuarios.SelectedItem is clsUsuarios usuario && cmbLibro.SelectedItem is clsLibros libro)
            {
                var nuevoPrestamo = new clsPrestamos
                    (
                        libro.Titulo,
                        usuario.FullName,
                        DateTime.Now,
                        DateTime.Now.AddDays(14)
                    );
                prestamos.Add(nuevoPrestamo);

                libro.UsuarioPrestamo = usuario;
                libro.Prestado += 1;

                ActualizarPrestamos();

            }
            else             {
                MessageBox.Show("Seleccione un usuario y un libro para registrar el préstamo.");
            }
        }

        private void ActualizarUsuarios()
        {
            txtFullName.Clear();
            txtCorreo.Clear();

            dgvUsuarios.Rows.Clear();
            cmbUsuarios.Items.Clear();
            foreach (var usuario in usuarios)
            {
                dgvUsuarios.Rows.Add(usuario.FullName, usuario.Correo);
                cmbUsuarios.Items.Add(usuario);
            }
            
            dgvUsuarios.ClearSelection();
        }

        private void ActualizarLibros()
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnio.Clear();

            dgvLibros.Rows.Clear();
            cmbLibro.Items.Clear();

            foreach (var libro in libros)
            {
                cmbLibro.Items.Add(libro);
                dgvLibros.Rows.Add(libro.Titulo, libro.Autor, libro.Anio);
            }

            dgvLibros.ClearSelection();
        }

        private void ActualizarPrestamos()
        {
            dgvPrestamos.Rows.Clear();

            foreach (var prestamo in prestamos)
            {
                dgvPrestamos.Rows.Add(prestamo.TituloLibro, prestamo.NombreUsuario, prestamo.FechaPrestamo.ToShortDateString(), prestamo.FechaDevolucion.ToShortDateString());
            }
        }

        private void InicializarColumnasUsuarios()
        {
            dgvUsuarios.Columns.Clear();
            dgvUsuarios.Columns.Add("FullName", "Nombre Completo");
            dgvUsuarios.Columns.Add("Correo", "Correo Electrónico");
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.AllowUserToAddRows = false;
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
            dgvPrestamos.Columns.Add("Usuario", "Usuario");
            dgvPrestamos.Columns.Add("FechaPrestamo", "Fecha de Préstamo");
            dgvPrestamos.Columns.Add("FechaDevolucion", "Fecha de Devolución");
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.AllowUserToAddRows = false;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                string tituloEditar = dgvLibros.SelectedRows[0].Cells["Titulo"].Value.ToString();
                var libroEditar = libros.FirstOrDefault(l => l.Titulo == tituloEditar);

                if (libroEditar != null)
                {
                    if (libroEditar.ValidarDatos(txtTitulo.Text, txtAutor.Text, txtAnio.Text))
                    {
                        ActualizarLibros();
                    }
                    else
                    {
                        MessageBox.Show(libroEditar.UltimoError);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un libro para editar.");
            }
        }

        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvLibros.ClearSelection();
                dgvLibros.Rows[e.RowIndex].Selected = true;

                string tituloEditar = dgvLibros.Rows[e.RowIndex].Cells["Titulo"].Value.ToString();
                var libroEditar = libros.FirstOrDefault(l => l.Titulo == tituloEditar);
                if (libroEditar != null)
                {
                    txtTitulo.Text = libroEditar.Titulo;
                    txtAutor.Text = libroEditar.Autor;
                    txtAnio.Text = libroEditar.Anio;
                }
            }
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvUsuarios.ClearSelection();
                dgvUsuarios.Rows[e.RowIndex].Selected = true;

                string nombreEditar = dgvUsuarios.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                var usuarioEditar = usuarios.FirstOrDefault(l => l.FullName == nombreEditar);
                if (usuarioEditar != null)
                {
                    txtFullName.Text = usuarioEditar.FullName;
                    txtCorreo.Text = usuarioEditar.Correo;
                }
            }
        }

        private void dgvPrestamos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvPrestamos.ClearSelection();
                dgvPrestamos.Rows[e.RowIndex].Selected = true;

                string tituloEditar = dgvPrestamos.Rows[e.RowIndex].Cells["Titulo"].Value.ToString();
                string nombreEditar = dgvPrestamos.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();
                string fechaPreEditar = dgvPrestamos.Rows[e.RowIndex].Cells["FechaPrestamo"].Value.ToString();
                string fechaDevEditar = dgvPrestamos.Rows[e.RowIndex].Cells["FechaDevolucion"].Value.ToString();

                var libroEditar = libros.FirstOrDefault(l => l.Titulo == tituloEditar);
                var usuarioEditar = usuarios.FirstOrDefault(u => u.FullName == nombreEditar);

                var registroEditar = prestamos.FirstOrDefault(p =>
                p.TituloLibro == tituloEditar &&
                p.NombreUsuario == nombreEditar &&
                p.FechaPrestamo.ToShortDateString() == fechaPreEditar &&
                p.FechaDevolucion.ToShortDateString() == fechaDevEditar
                );

                if (libroEditar != null && usuarioEditar != null)
                {
                    cmbLibro.SelectedItem = libroEditar;
                    cmbUsuarios.SelectedItem = usuarioEditar;
                    dtpFechaPrestado.Value = registroEditar.FechaPrestamo;
                    dtpFechaDevolver.Value = registroEditar.FechaDevolucion;

                    indexPresEditar = prestamos.IndexOf(registroEditar);

                    indexPresEditar = e.RowIndex;

                }
                else
                {
                    MessageBox.Show("Selección inválida.");
                    indexPresEditar = -1;
                }
            }   
        }



        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                string nombreEditar = dgvUsuarios.SelectedRows[0].Cells["FullName"].Value.ToString();
                var usuarioEditar = usuarios.FirstOrDefault(l => l.FullName == nombreEditar);

                if (usuarioEditar != null)
                {
                    if (usuarioEditar.ValidarDatos(txtFullName.Text, txtCorreo.Text))
                    {
                        ActualizarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show(usuarioEditar.UltimoError);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para editar.");
            }
        }

        private void btnEditarRegistro_Click(object sender, EventArgs e)
        {
            if (indexPresEditar >= 0 && cmbLibro.SelectedItem is clsLibros libro && cmbUsuarios.SelectedItem is clsUsuarios usuario)
            {
                prestamos[indexPresEditar].TituloLibro = libro.Titulo;
                prestamos[indexPresEditar].NombreUsuario = usuario.FullName;
                prestamos[indexPresEditar].FechaPrestamo = dtpFechaPrestado.Value;
                prestamos[indexPresEditar].FechaDevolucion = dtpFechaDevolver.Value;

                ActualizarPrestamos();
                indexPresEditar = -1;
            }
            else
            {
                MessageBox.Show("Selección inválida.");
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                string nombreEliminar = dgvUsuarios.SelectedRows[0].Cells["FullName"].Value.ToString();
                var usuarioEliminar = usuarios.FirstOrDefault(l => l.FullName == nombreEliminar);

                if (usuarioEliminar != null)
                {
                    usuarios.Remove(usuarioEliminar);
                    ActualizarUsuarios();
                }
                else
                {
                    MessageBox.Show("Seleccione un usuario para eliminar.");
                }
            }
        }

        private void btnAñadirRegistro_Click(object sender, EventArgs e)
        {
            registrarPrestamo();
        }

     
    }
}
