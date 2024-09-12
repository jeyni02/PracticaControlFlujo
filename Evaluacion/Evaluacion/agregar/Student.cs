using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion.agregar
{
    // Clase Student para representar a un estudiante con nombre completo.
    internal class Student
    {
        // Propiedad para almacenar el nombre completo del estudiante.
        public string NombreCompleto { get; set; }

        // Constructor para inicializar el nombre del estudiante.
        public Student(string nombreCompleto)
        {
            NombreCompleto = nombreCompleto;
        }

        // Método para verificar si el nombre tiene más de 25 caracteres.
        public bool TieneNombreLargo()
        {
            return NombreCompleto.Length > 25;
        }
    }
}
