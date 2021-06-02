using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winsqllab
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cuatrimestres cuatri = new Cuatrimestres();
            cuatri.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profesores profe = new Profesores();
            profe.Show();
            this.Close();
        }

        private void Principal_Load(object sender, EventArgs e) {

        }

        private void botonGrupos_Click(object sender, EventArgs e)
        {
            Grupos grupitos = new Grupos();
            grupitos.Show();
            this.Close();
        }

        private void botonLabora_Click(object sender, EventArgs e)
        {
            Laboratorios labo = new Laboratorios();
            labo.Show();
            this.Close();
        }

        private void BotonDias_Click(object sender, EventArgs e)
        {
            Dias losDias = new Dias();
            losDias.Show();
            this.Close();
        }

        private void botonHoras_Click(object sender, EventArgs e)
        {
            Horas lasHoras = new Horas();
            lasHoras.Show();
            this.Close();
        }

        private void botonMaterias_Click(object sender, EventArgs e)
        {
            Materias lasMaterias = new Materias();
            lasMaterias.Show();
            this.Close();
        }

        private void botonAsignaciones_Click(object sender, EventArgs e)
        {
            Asignaciones lasAulas = new Asignaciones();
            lasAulas.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Alumno losAlumnos = new Alumno();
            losAlumnos.Show();
            this.Close();
        }
    }
}
