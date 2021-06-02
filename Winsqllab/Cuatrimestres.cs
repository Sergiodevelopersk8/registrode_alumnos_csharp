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
    public partial class Cuatrimestres : Form
    {
        string mensj = "";
        ManejaSQL modelo2 = new ManejaSQL();
        LogicaDeNegocios logica = new LogicaDeNegocios();
        VistaSQL vista = new VistaSQL();
        //List<int> ids = null;

        public Cuatrimestres()
        {
            InitializeComponent();
            modelo2.CadCone = ConfigurationManager.ConnectionStrings["cnsql1"].ConnectionString;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Cuatrimestres_Load(object sender, EventArgs e)
        {
            SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
            vista.LlenarMeses(comboMeses);
            comboMeses.DropDownStyle = ComboBoxStyle.DropDownList;
            vista.LlenarA(comboAnualidad);
            comboAnualidad.DropDownStyle = ComboBoxStyle.DropDownList;
            vista.LlenarA(comboAnual);
            comboAnual.DropDownStyle = ComboBoxStyle.DropDownList;
            vista.LlenarMeses(comboPeriodo);
            comboPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            vista.LlenarListCuatris(listBox1, logica.ConsultaCuatri(cn2,ref mensj));
            cn2 = modelo2.AbrirConexion(ref mensj);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
                logica.InsertarCuatri(cn2, comboMeses.SelectedItem.ToString(), comboAnualidad.SelectedItem.ToString(), ref mensj);
                cn2.Close();
                cn2.Dispose();
                vista.MiLetrero(mensj);
                comboMeses.Text = "";
                comboAnualidad.Text = "";
            }
            catch
            {
                vista.MiLetrero("Asegurese de llenar todos los campos");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
                logica.ElimimarCuatri(cn2, listBox1.SelectedIndex, ref mensj);
                cn2.Close();
                cn2.Dispose();
                vista.MiLetrero(mensj);
                listBox1.Items.Clear();
                Cuatrimestres_Load(sender, e);
            }
            catch (Exception g)
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
                logica.ModificarCuatri(cn2, listBox1.SelectedIndex, comboPeriodo.SelectedItem.ToString(), comboAnual.SelectedItem.ToString(), ref mensj);
                cn2.Close();
                cn2.Dispose();
                vista.MiLetrero(mensj);
                comboPeriodo.Text = "";
                comboAnual.Text = "";
                listBox1.Items.Clear();
                Cuatrimestres_Load(sender, e);
            }
            catch (Exception g)
            {
                vista.MiLetrero("Error: " + g);
            }
        }
    }
}
