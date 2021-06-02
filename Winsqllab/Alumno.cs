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
    public partial class Alumno : Form
    {
        string mensj = "";
        ManejaSQL modelo2 = new ManejaSQL();
        LogicaDeNegocios logica = new LogicaDeNegocios();
        VistaSQL vista = new VistaSQL();

        public Alumno()
        {
            InitializeComponent();
            modelo2.CadCone = ConfigurationManager.ConnectionStrings["cnsql1"].ConnectionString;
        }

        private void Alumno_Load(object sender, EventArgs e)
        {
            SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
            vista.LlenarComboDias(comboDia, logica.ConsultaDias(cn2,ref mensj));
            vista.LlenarComboBoxTodosGrupos(comboBox1, logica.ConsultaGrupos(cn2,ref mensj));
            //vista.LlenarComboBoxCuatrimestres(comboCuatri,logica.ConsultaCuatri(cn2, ref mensj));
            vista.LlenarAula(comboAula);
            vista.LlenarEdificio(comboEdificio);
            vista.LlenarHoras(comboHE);
            vista.LlenarHoras(comboHS);
            vista.LlenarComboBoxAlumno(comboAlumno,logica.ConsultaAlumnos(cn2,ref mensj));
            //comboCuatri.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDia.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAula.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEdificio.DropDownStyle = ComboBoxStyle.DropDownList;
            comboHE.DropDownStyle = ComboBoxStyle.DropDownList;
            comboHS.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAlumno.DropDownStyle = ComboBoxStyle.DropDownList;
            vista.LlenarListNoDisponibles(listBox1,logica.ConsultaAsignaciones3(cn2,ref mensj));
        }

        private void botonAgregaProfe_Click(object sender, EventArgs e)
        {
            SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
            logica.InsertarPrestamoAlumn(cn2,txtnombreProfe.Text, txtApePatProfe.Text, txtApeMatProfe.Text, txtMatriProfe.Text,
                comboBox1.SelectedIndex,comboDia.SelectedIndex,comboAula.Text, comboEdificio.Text, comboHE.Text, comboHS.Text,ref mensj);
            cn2.Close();
            cn2.Dispose();
            vista.MiLetrero(mensj);
            txtnombreProfe.Text = "";
            txtApePatProfe.Text = "";
            txtApeMatProfe.Text = "";
            txtMatriProfe.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Principal princi = new Principal();
            princi.Show();
            this.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
            //vista.LlenarListNoDisponibles(listBox1, logica.ConsultaNoDisponibles(cn2, comboDia.SelectedIndex, ref mensj));
        }

        private void comboAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
            DataSet atrapa = null;
            atrapa = logica.DTConsultarAlumnos(cn2, comboAlumno.SelectedIndex, ref mensj);
            vista.muestraDataTable(atrapa.Tables[0], dataGridView1);
            this.dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells);
           this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
