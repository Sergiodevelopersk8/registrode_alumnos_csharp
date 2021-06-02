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
    public partial class Horas : Form
    {
        string mensj = "";
        ManejaSQL modelo2 = new ManejaSQL();
        LogicaDeNegocios logica = new LogicaDeNegocios();
        VistaSQL vista = new VistaSQL();

        public Horas()
        {
            InitializeComponent();
            modelo2.CadCone = ConfigurationManager.ConnectionStrings["cnsql1"].ConnectionString;
        }

        private void Horas_Load(object sender, EventArgs e)
        {
            SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
            vista.LlenarHoras(comboBox1);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            vista.LlenarHoras(comboBox2);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            vista.LlenarHoras(comboBox3);
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            vista.LlenarHoras(comboBox4);
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            vista.LlenarListHoras(listHorass, logica.ConsultaHoras(cn2, ref mensj));
            cn2 = modelo2.AbrirConexion(ref mensj);
        }

        private void botonAgregaProfe_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
                logica.InsertarHoras(cn2, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), ref mensj);
                cn2.Close();
                cn2.Dispose();
                vista.MiLetrero(mensj);
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
            }
            catch(Exception g)
            {
                vista.MiLetrero("Error: " + g);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
                logica.ModificarHoras(cn2, listHorass.SelectedIndex, comboBox4.SelectedItem.ToString(), comboBox3.SelectedItem.ToString(), ref mensj);
                cn2.Close();
                cn2.Dispose();
                vista.MiLetrero(mensj);
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                listHorass.Items.Clear();
                Horas_Load(sender, e);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
                logica.EliminarHorarios(cn2, listHorass.SelectedIndex, ref mensj);
                cn2.Close();
                cn2.Dispose();
                vista.MiLetrero(mensj);
                listHorass.Items.Clear();
                Horas_Load(sender, e);
            }
            catch (Exception g)
            {
                vista.MiLetrero("Error: " + g);
            }
        }
    }
}
