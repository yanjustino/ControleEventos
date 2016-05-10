using ControleEventos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eventoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            foreach (var item in eventoBindingSource.List)
            {
                Console.WriteLine(((Evento)item).Titulo);
            }
        }
    }
}
