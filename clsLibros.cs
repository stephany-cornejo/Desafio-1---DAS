using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private bool DatosCompletos;

        private string ultimoError = string.Empty;

        public bool datosCompletos_aceptados => DatosCompletos;

        public string UltimoError => ultimoError;

        public clsLibros(string titulo, string autor, string anio)
        {
            Titulo = titulo;
            Autor = autor;
            Anio = anio;
            Prestado = 0;

            DatosCompletos = false; 
        }

        public void AsignarUsuario(clsUsuarios usuario)
        {

        }

        public bool ValidarDatos(string titulo, string autor, string anio)
        {
            ultimoError = string.Empty;
            DatosCompletos = false;

            if (string.IsNullOrWhiteSpace(titulo) && string.IsNullOrWhiteSpace(autor) && string.IsNullOrWhiteSpace(anio))
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
    }
}
