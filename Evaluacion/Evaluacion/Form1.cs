using Evaluacion.agregar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Form1 : Form
    {
        // Lista que almacena los estudiantes agregados.
        private List<Student> estudiantes;

        public Form1()
        {
            InitializeComponent();
            // Inicializamos la lista de estudiantes.
            estudiantes = new List<Student>();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Obtenemos el nombre ingresado y eliminamos espacios en blanco adicionales.
            string nombreCompleto = txtName.Text.Trim();

            // Validación: el nombre no puede estar vacío.
            if (string.IsNullOrEmpty(nombreCompleto))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return; // Salimos del método si no se cumple esta condición.
            }

            // Validación: el nombre no debe contener números.
            if (nombreCompleto.Any(char.IsDigit))
            {
                MessageBox.Show("El nombre no puede contener números.");
                return; // Salimos del método si el nombre contiene números.
            }

            // Si las validaciones anteriores son correctas, creamos un nuevo estudiante.
            Student estudiante = new Student(nombreCompleto);
            estudiantes.Add(estudiante);

            // Limpiamos el campo de texto para que el usuario pueda ingresar un nuevo nombre.
            txtName.Clear();

            // Llamamos al método para mostrar los nombres con más de 25 caracteres.
            MostrarNombresLargos();
        }

        // Método para mostrar solo los estudiantes cuyos nombres tienen más de 25 caracteres.
        private void MostrarNombresLargos()
        {
            // Limpiamos la lista visual antes de actualizarla.
            lstStudent.Items.Clear();

            // Recorremos la lista de estudiantes y mostramos solo los nombres largos.
            for (int i = 0; i < estudiantes.Count; i++)
            {
                Student estudiante = estudiantes[i];
                if (estudiante.TieneNombreLargo())
                {
                    lstStudent.Items.Add(estudiante.NombreCompleto); // Agregamos el nombre al ListBox.
                }

            }
        }
    }
}