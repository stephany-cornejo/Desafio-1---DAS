using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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
            ValidarDatos(nom, correo);
        }

        public bool ValidarDatos(string nom, string correo)
        {
            ultimoError  = string.Empty;
            DatosCompletos = false;

            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(correo))
            {
                ultimoError = "Faltan datos obligatorios";
                return false;
            }

            FullName = nom.Trim();
            Correo = correo.Trim();

            DatosCompletos = true;
            return true;
        }

        public void generarListaUsuarios(ref DataGridView dgvUsuarios)
        {
            dgvUsuarios.SuspendLayout();
            dgvUsuarios.Rows.Clear();
            dgvUsuarios.Columns.Clear();

            dgvUsuarios.Columns.Add("Nombre", "Nombre");
            dgvUsuarios.Columns.Add("Correo", "Correo");

            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (var usuario in Form1.usuarios.OrderBy(u => u.Id))
            {
                dgvUsuarios.Rows.Add(usuario.FullName, usuario.Correo);
            }

            dgvUsuarios.ResumeLayout();
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
