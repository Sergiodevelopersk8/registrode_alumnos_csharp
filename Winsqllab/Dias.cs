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
    public partial class Dias : Form
    {
        string mensj = "";
        ManejaSQL modelo2 = new ManejaSQL();
        LogicaDeNegocios logica = new LogicaDeNegocios();
        VistaSQL vista = new VistaSQL();

        public Dias()
        {
            InitializeComponent();
            modelo2.CadCone = ConfigurationManager.ConnectionStrings["cnsql1"].ConnectionString;
        }

        private void Dias_Load(object sender, EventArgs e)
        {
            SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
            vista.LlenarDias(comboBox1);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            vista.LlenarListDias(listDias, logica.ConsultaDias(cn2,ref mensj));
        }

        private void botonAgregaProfe_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
                logica.InsertarDias(cn2, comboBox1.SelectedItem.ToString(), ref mensj);
                cn2.Close();
                cn2.Dispose();
                vista.MiLetrero(mensj);
                comboBox1.Items.Clear();
            }
            catch(Exception g)
            {
                vista.MiLetrero("Error: "+ g);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
                logica.ElimimarDias(cn2, listDias.SelectedIndex, ref mensj);
                cn2.Close();
                cn2.Dispose();
                vista.MiLetrero(mensj);
                listDias.Items.Clear();
                Dias_Load(sender,e);
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
    }
}
