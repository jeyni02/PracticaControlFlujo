using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class Form1 : Form
    {
        List<Person> persons;
        public Form1()
        {
            InitializeComponent();
            persons = new List<Person>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            persons.FirstName = tbFirstName.Text;
            persons.LastName = tbLastName.Text;
            person. Birthdate = dtpBirthday.value;
            persons.Add(person);
            ShowPersons();
            ClearTb();
        }

        private void ShowPersons()
        {
            dgvPerson.DataSource = null;
            dgvPerson.DataSource = persons;

        }

        private void ClearTb()
        {
            tbFirstName.Clear();
            tbLastName.Clear();
            dtpBirthday.Value = DateTime.Now;
            tbLastName.Focus();
        }

    }
}
