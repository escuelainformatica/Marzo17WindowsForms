using Marzo17.repo;
using Marzo17.ui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marzo17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var acerca = new AboutBox1();
            acerca.ShowDialog();
        }

        private void agregarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;

            var catrepo = new CategoriaRepo();

            comboBoxCategoria.DataSource = catrepo.ListarTodas();

        }

        private void listarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LibroUI libroUI = new LibroUI();
            LibroRepo libroRepo = new LibroRepo();
            var libro=libroUI.Factory(numericUpDown1, textBox2, comboBoxCategoria);

            var mensajeErrores = libroUI.Validar(libro);
            if (mensajeErrores.Count() == 0)
            {
                listView1.Visible = false;
                libroRepo.Insertar(libro);
            } else
            {
                listView1.Visible = true;
                listView1.Items.Clear();
                foreach(var error in mensajeErrores)
                {
                    listView1.Items.Add(new ListViewItem(error,0));
                }

                
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
