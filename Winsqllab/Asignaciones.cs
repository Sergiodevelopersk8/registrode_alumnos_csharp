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
    public partial class Asignaciones : Form
    {
        string mensj = "";
        ManejaSQL modelo2 = new ManejaSQL();
        LogicaDeNegocios logica = new LogicaDeNegocios();
        VistaSQL vista = new VistaSQL();

        public Asignaciones()
        {
            InitializeComponent();
            modelo2.CadCone = ConfigurationManager.ConnectionStrings["cnsql1"].ConnectionString;
        }

        private void Asignaciones_Load(object sender, EventArgs e)
        {
            SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
            
            vista.LlenarListTodosGrupos(listBoxGrupo,logica.ConsultaGrupos(cn2, ref mensj));
            vista.LlenarListAulas(listBoxLaboratorio, logica.ConsultaLaboratorios(cn2,ref mensj));
            vista.LlenarListDias(listBoxDia, logica.ConsultaDias(cn2,ref mensj));
            vista.LlenarListHoras(listBoxHora, logica.ConsultaHoras(cn2,ref mensj));
            vista.LlenarListMaterias(listBoxMateria, logica.ConsultaMaterias(cn2,ref mensj));
            vista.LlenarListProfesor(listBoxProfesor, logica.ConsultaProfesor(cn2,ref mensj));
            vista.LlenarComboBoxTodosGrupos(comboGrupo, logica.ConsultaGrupos(cn2, ref mensj));
            comboGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            vista.LlenarComboBoxLaboratorio(comboLabo, logica.ConsultaLaboratorios(cn2, ref mensj));
            comboLabo.DropDownStyle = ComboBoxStyle.DropDownList;
            vista.LlenarComboBoxHorarios(comboHora, logica.ConsultaHoras(cn2, ref mensj));
            comboHora.DropDownStyle = ComboBoxStyle.DropDownList;
            vista.LlenarComboBoxMateria(comboMateria, logica.ConsultaMaterias(cn2, ref mensj));
            comboMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            vista.LlenarComboBoxProfesor(comboDocente, logica.ConsultaProfesor(cn2, ref mensj));
            comboDocente.DropDownStyle = ComboBoxStyle.DropDownList;
            vista.LlenarComboDias(comboDia, logica.ConsultaDias(cn2, ref mensj));
            comboDia.DropDownStyle = ComboBoxStyle.DropDownList;
            vista.LlenarComboBoxCuatrimestres(comboBox1, logica.ConsultaCuatri(cn2, ref mensj));
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            vista.LlenarListTodaasASignaciones(listTodasAsigna, logica.ConsultaAsiganciones(cn2,ref mensj));
        }

        private void botonAgregaHorario_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
                logica.InsertarAsignacionesLabo(cn2, listBoxGrupo.SelectedIndex, listBoxLaboratorio.SelectedIndex, listBoxDia.SelectedIndex,
                    listBoxMateria.SelectedIndex, listBoxProfesor.SelectedIndex, listBoxHora.SelectedIndex, ref mensj);
                cn2.Close();
                cn2.Dispose();
                vista.MiLetrero(mensj);
            }
            catch (Exception g)
            {
                vista.MiLetrero("Error: " + g);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal princi = new Principal();
            princi.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
                logica.EliminaAsignaciones(cn2, listTodasAsigna.SelectedIndex, ref mensj);
                cn2.Close();
                cn2.Dispose();
                vista.MiLetrero(mensj);
                listTodasAsigna.Items.Clear();
                Asignaciones_Load(sender,e);
            }
            catch(Exception g)
            {
                vista.MiLetrero("Error: "+g);
            }
        }

        private void btnModificR_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
                logica.ModificarAsignaciones(cn2, listTodasAsigna.SelectedIndex,comboGrupo.SelectedIndex,comboLabo.SelectedIndex, comboDia.SelectedIndex,
                    comboMateria.SelectedIndex, comboDocente.SelectedIndex,comboHora.SelectedIndex,ref mensj);
                cn2.Close();
                cn2.Dispose();
                vista.MiLetrero(mensj);
                listTodasAsigna.Items.Clear();
                comboGrupo.Items.Clear();
                comboLabo.Items.Clear();
                comboDia.Items.Clear();
                comboMateria.Items.Clear();
                comboDocente.Items.Clear();
                comboHora.Items.Clear();
                Asignaciones_Load(sender, e);
            }
            catch (Exception g)
            {
                vista.MiLetrero("Error: " + g);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn2 = modelo2.AbrirConexion(ref mensj);
            DataSet atrapa = null;
            atrapa = logica.DTConsultarHorario(cn2,comboBox1.SelectedIndex ,ref mensj);
            vista.muestraDataTable(atrapa.Tables[0], dataGridView1);
            this.dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells);
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            vista.muestraDataTable(atrapa.Tables[0], dataGridView1);
        }
    }
}
