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
    public partial class Grupos : Form
    {
        string mensj = "";
        ManejaSQL modelo2 = new ManejaSQL();
        LogicaDeNegocios logica = new LogicaDeNegocios();
        VistaSQL vista = new VistaSQL();
        List<int> losID = new List<int>();

        public Grupos()
        {
            InitializeComponent();
            modelo2.CadCone = ConfigurationManager.ConnectionStrings["cnsql1"].ConnectionString;
        }

        private void Grupos_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Clear();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Items.Clear();
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Items.Clear();
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.Items.Clear();
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.Items.Clear();
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxgrado.Items.Clear();
            comboBoxgrado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxgrupo.Items.Clear();
            comboBoxgrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxturno.Items.Clear();
            comboBoxturno.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxespecialidad.Items.Clear();
            comboBoxespecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxcuatrimestre.Items.Clear();
            comboBoxcuatrimestre.DropDownStyle = ComboBoxStyle.DropDownList;

            SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
            vista.LlenarGrados(comboBox1);
            vista.LlenarGrupos(comboBox2);
            vista.LlenarTurno(comboBox3);
            vista.LlenarEspecialidad(comboBox5);
            vista.LlenarGrados(comboBoxgrado);
            vista.LlenarGrupos(comboBoxgrupo);
            vista.LlenarTurno(comboBoxturno);
            vista.LlenarEspecialidad(comboBoxespecialidad);
            vista.LlenarComboBoxCuatrimestres(comboBoxcuatrimestre, logica.ConsultaCuatri(cn2, ref mensj));
            vista.LlenarComboBoxCuatrimestres(comboBox4, logica.ConsultaCuatri(cn2, ref mensj));
            vista.LlenarListTodosGrupos(listElimina_Modifica, logica.ConsultaGrupos(cn2, ref mensj));
            cn2 = modelo2.AbrirConexion(ref mensj);
        }

        private void botonAgregaGrupo_Click(object sender, EventArgs e)
        {
            int cuatris = comboBox4.SelectedIndex;
            SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
            logica.InsertarGrupos(cn2,comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), comboBox3.SelectedItem.ToString(),
                comboBox5.SelectedItem.ToString(), cuatris, ref mensj);
            cn2.Close();
            cn2.Dispose();
            vista.MiLetrero(mensj);

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
                logica.ModificarGrupos(cn2, listElimina_Modifica.SelectedIndex, comboBoxgrado.SelectedItem.ToString(), comboBoxgrupo.SelectedItem.ToString(), comboBoxturno.SelectedItem.ToString(),
                    comboBoxespecialidad.SelectedItem.ToString(), comboBoxcuatrimestre.SelectedIndex, ref mensj);
                cn2.Close();
                cn2.Dispose();
                vista.MiLetrero(mensj);
                comboBoxgrado.Text = "";
                comboBoxgrupo.Text = "";
                comboBoxturno.Text = "";
                comboBoxespecialidad.Text = "";
                comboBoxcuatrimestre.Text = "";

                listElimina_Modifica.Items.Clear();
                Grupos_Load(sender, e);
            }
            catch(Exception g)
            {
                MessageBox.Show("Error: " + g);
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
               
                //int miID = losID[listGrupos1.SelectedIndices];
                SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);

                int indice = 0;

                indice = listElimina_Modifica.SelectedIndex;


                logica.ElimimarGrupo(cn2,indice, ref mensj);

             
                cn2.Close();
                cn2.Dispose();
                vista.MiLetrero(mensj);
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";
                comboBox5.Text = "";
                comboBoxgrado.Text = "";
                comboBoxgrupo.Text = "";
                comboBoxturno.Text = "";
                comboBoxespecialidad.Text = "";
                comboBoxcuatrimestre.Text = "";

                listElimina_Modifica.Items.Clear();
                Grupos_Load(sender,e);
               
            }
            catch(Exception g)
            {
                MessageBox.Show("Error: " + g);
            }

        }
    }
}
