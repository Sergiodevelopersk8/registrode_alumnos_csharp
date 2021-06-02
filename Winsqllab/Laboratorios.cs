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
    public partial class Laboratorios : Form
    {
        string mensj = "";
        ManejaSQL modelo2 = new ManejaSQL();
        LogicaDeNegocios logica = new LogicaDeNegocios();
        VistaSQL vista = new VistaSQL();

        public Laboratorios()
        {
            InitializeComponent();
            modelo2.CadCone = ConfigurationManager.ConnectionStrings["cnsql1"].ConnectionString;
        }

        private void Laboratorios_Load(object sender, EventArgs e)
        {
            SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
            vista.LlenarAula(comboBox1);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            vista.LlenarEdificio(comboBox2);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            vista.LlenarAula(comboBox4);
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            vista.LlenarEdificio(comboBox3);
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            vista.LlenarListAulas(listAulass, logica.ConsultaLaboratorios(cn2, ref mensj));
            cn2 = modelo2.AbrirConexion(ref mensj);
        }

        private void botonAgregaAula_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
                logica.InsertarAula(cn2, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), ref mensj);
                cn2.Close();
                cn2.Dispose();
                vista.MiLetrero(mensj);
            }
            catch(Exception g)
            {
                vista.MiLetrero("Error: " + g);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
                logica.EliminarAulas(cn2, listAulass.SelectedIndex, ref mensj);
                cn2.Close();
                cn2.Dispose();
                vista.MiLetrero(mensj);
                listAulass.Items.Clear();
                //listAulass.ClearSelected();
                Laboratorios_Load(sender,e);
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

        private void btnModificaAula_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
                logica.ModificarAula(cn2, listAulass.SelectedIndex, comboBox4.SelectedItem.ToString(), comboBox3.SelectedItem.ToString(), ref mensj);
                cn2.Close();
                cn2.Dispose();
                vista.MiLetrero(mensj);
                listAulass.Items.Clear();
                Laboratorios_Load(sender, e);
            }
            catch (Exception g)
            {
                vista.MiLetrero("Error: " + g);
            }
        }
    }
}
