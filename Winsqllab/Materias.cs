using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using ModeloSql;
using VistaSql;

namespace Winsqllab
{
    public partial class Materias : Form
    {
        string mensj = "";
        ManejaSQL modelo2 = new ManejaSQL();
        LogicaDeNegocios logica = new LogicaDeNegocios();
        VistaSQL vista = new VistaSQL();

        public Materias()
        {
            InitializeComponent();
            modelo2.CadCone = ConfigurationManager.ConnectionStrings["cnsql1"].ConnectionString;
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
            vista.LlenarListMaterias(listMateriass, logica.ConsultaMaterias(cn2, ref mensj));
            cn2 = modelo2.AbrirConexion(ref mensj);
        }

        private void botonAgregaMateria_Click(object sender, EventArgs e)
        {
            string materia = txtAsignatura.Text;
            SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
            logica.InsertarMateria(cn2, materia, ref mensj);
            cn2.Close();
            cn2.Dispose();
            vista.MiLetrero(mensj);
            txtAsignatura.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
                logica.EliminarMateria(cn2, listMateriass.SelectedIndex, ref mensj);
                cn2.Close();
                cn2.Dispose();
                vista.MiLetrero(mensj);
                listMateriass.Items.Clear();
                Materias_Load(sender, e);
            }
            catch (Exception g)
            {
                vista.MiLetrero("Error: " + g);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Principal princi = new Principal();
            princi.Show();
            this.Close();
        }

        private void btnModificaMate_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
                string nuevaMate = textBox1.Text;
                logica.ModificarMateria(cn2, listMateriass.SelectedIndex, nuevaMate, ref mensj);
                cn2.Close();
                cn2.Dispose();
                vista.MiLetrero(mensj);
                listMateriass.Items.Clear();
                textBox1.Text = "";
                Materias_Load(sender,e);
            }
            catch (Exception g)
            {
                vista.MiLetrero("Error: " + g);
            }
        }
    }
}
