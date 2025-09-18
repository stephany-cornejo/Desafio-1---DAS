using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms; 

namespace DAS_Desafio_1
{
    public class clsPrestamos
    {
        public string TituloLibro { get; set; }
        public string NombreUsuario { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }

        public clsPrestamos(string title, string nom, DateTime fechaPre, DateTime fechaDe)
        {
            TituloLibro = title;
            NombreUsuario = nom;
            FechaPrestamo = fechaPre;
            FechaDevolucion = fechaDe;
        }
    }
}
