using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAS_Desafio_1
{
    public class clsUsuarios
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Correo { get; set; }

        private bool DatosCompletos;

        private string ultimoError =  string.Empty;

        public bool datosCompletos_aceptados => DatosCompletos;

        public string UltimoError => ultimoError;

        public clsUsuarios(string nom, string correo)
        {
            FullName = nom;
            Correo = correo;

            DatosCompletos = false;
        }

        public bool ValidarDatos(string nom, string correo)
        {
            ultimoError  = string.Empty;
            DatosCompletos = false;

            if (string.IsNullOrWhiteSpace(nom) && string.IsNullOrWhiteSpace(correo))
            {
                ultimoError = "Faltan datos obligatorios";
                return false;
            }

            FullName = nom.Trim();
            Correo = correo.Trim();

            DatosCompletos = true;
            return true;
        }
    }
}
