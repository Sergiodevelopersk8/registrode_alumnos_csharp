using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModeloSql;
using VistaSql;
using System.Data.SqlClient;
using System.Configuration;

namespace Winsqllab
{
    public partial class Profesores : Form
    {
        string mensj = "";
        ManejaSQL modelo2 = new ManejaSQL();
        LogicaDeNegocios logica = new LogicaDeNegocios();
        VistaSQL vista = new VistaSQL();
        public Profesores()
        {
            InitializeComponent();
            modelo2.CadCone = ConfigurationManager.ConnectionStrings["cnsql1"].ConnectionString;
        }

        private void Profesores_Load(object sender, EventArgs e) 
        {
            SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
            vista.LlenarListProfesor(listProfess, logica.ConsultaProfesor(cn2, ref mensj));
            cn2 = modelo2.AbrirConexion(ref mensj);
        }

        private void botonAgregaProfe_Click(object sender, EventArgs e)
        {
            string nombre = txtnombreProfe.Text;
            string paterno = txtApePatProfe.Text;
            string materno = txtApeMatProfe.Text;
            string matricula = txtMatriProfe.Text;
            SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
            logica.InsertarProfesor(cn2, nombre,paterno, materno,matricula,ref mensj);
            cn2.Close();
            cn2.Dispose();
            vista.MiLetrero(mensj);
            txtnombreProfe.Text = "";
            txtApePatProfe.Text = "";
            txtApeMatProfe.Text = "";
            txtMatriProfe.Text = "";
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
                logica.EliminarProfesor(cn2, listProfess.SelectedIndex, ref mensj);
                cn2.Close();
                cn2.Dispose();
                vista.MiLetrero(mensj);
                listProfess.Items.Clear();
                Profesores_Load(sender, e);
            }
            catch(Exception g)
            {
                vista.MiLetrero("Error: " + g);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Principal princi = new Principal();
            princi.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = textBox4.Text;
            string paterno = textBox3.Text;
            string materno = textBox2.Text;
            string matricula = textBox1.Text;
            SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
            logica.ModificarProfesor(cn2, listProfess.SelectedIndex, nombre, paterno, materno, matricula, ref mensj);
            cn2.Close();
            cn2.Dispose();
            vista.MiLetrero(mensj);
            listProfess.Items.Clear();
            Profesores_Load(sender, e);
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
        }
    }
}
