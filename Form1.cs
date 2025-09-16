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
        List<clsUsuarios> usuarios = new List<clsUsuarios>();
        List<clsLibros> libros = new List<clsLibros>();
        public Form1()
        {
            InitializeComponent();
            InicializarColumnasUsuarios();
            InicializarColumnasLibros();
            InicializarColumnasPrestamos();
            CarcarMaterialesIniciales();
            ActualizarLibros();
            ActualizarUsuarios();
            ActualizarPrestamos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAñadirUsuario_Click(object sender, EventArgs e)
        {
            var usuario = new clsUsuarios(txtFullName.Text, txtCorreo.Text);
            if (usuario.datosCompletos_aceptados)
            {
                usuarios.Add(usuario); // Fix: Add the usuario object, not usuario.FullName
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
            foreach (var usuario in usuarios)
            {
                dgvUsuarios.Rows.Add(new object[] { usuario.Id, usuario.FullName, usuario.Correo });
            }
        }
    }
}
