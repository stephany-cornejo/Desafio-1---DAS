using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DAS_Desafio_1
{
    public class clsLibros
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Anio { get; set; }
        public clsUsuarios UsuarioPrestamo { get; private set; }
        public int Prestado { get; private set; }
        public DateTime FechaPrestamo { get; private set; }
        public DateTime FechaDevolucion { get; private set; }

        private bool DatosCompletos;

        private string ultimoError = string.Empty;

        public bool datosCompletos_aceptados => DatosCompletos;

        public string UltimoError => ultimoError;

        public clsLibros(string titulo, string autor, string anio)
        {
            ValidarDatos(titulo, autor, anio);
            Prestado = 0;
        }

        public void AsignarUsuario(clsUsuarios usuario)
        {

        }

        public bool ValidarDatos(string titulo, string autor, string anio)
        {
            ultimoError = string.Empty;
            DatosCompletos = false;

            if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(autor) || string.IsNullOrWhiteSpace(anio))
            {
                ultimoError = "Faltan datos obligatorios";
                return false;
            }

            Titulo = titulo.Trim();
            Autor = autor.Trim();
            Anio = anio.Trim();

            DatosCompletos = true;
            return true;
        }

        public void generarListaLibros(ref DataGridView dgvLibros)
        {
            dgvLibros.SuspendLayout();
            dgvLibros.Rows.Clear();
            dgvLibros.Columns.Clear();

            dgvLibros.Columns.Add("Id", "Id");
            dgvLibros.Columns.Add("Titulo", "Título");
            dgvLibros.Columns.Add("Autor", "Autor");
            dgvLibros.Columns.Add("Anio", "Año");

            dgvLibros.ReadOnly = true;
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (var libro in Form1.libros.OrderBy(l => l.Id))
            {
                dgvLibros.Rows.Add(libro.Id, libro.Titulo, libro.Autor, libro.Anio);
            }

            dgvLibros.ResumeLayout();
        }

        public override string ToString()
        {
            return Titulo;
        }

    }
}
