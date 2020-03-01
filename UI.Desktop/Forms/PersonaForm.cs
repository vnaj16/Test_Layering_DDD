using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Desktop.ApplicationController;

namespace UI.Desktop.Forms
{
    public partial class PersonaForm : Form
    {
        private PersonaController Persona;
        public PersonaForm()
        {
            InitializeComponent();
            Persona = new PersonaController();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PersonaForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Persona.GetPersonas("");
        }

        private void TextBox_Filtrar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Persona.GetPersonas(TextBox_Filtrar.Text);
        }
    }
}
