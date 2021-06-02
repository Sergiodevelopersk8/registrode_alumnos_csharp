using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace VistaSql
{
    public class VistaSQL
    {
        public void LlenarComboBox(ComboBox box, SqlDataReader readerr)
        {
            while (readerr.Read()) {
                box.Items.Add(readerr["Nombregrup"].ToString());
            }
            readerr.Close();
        }

        public void LlenarComboBoxProfesor(ComboBox box, SqlDataReader readerr)
        {
            while (readerr.Read())
            {
                box.Items.Add(readerr["Nombre_P"].ToString() + " " + readerr["Apellido_P"].ToString() + " " + readerr["Apellido_M"].ToString());
            }
            readerr.Close();
        }

        public void LlenarComboBoxAlumno(ComboBox box, SqlDataReader readerr)
        {
            while (readerr.Read())
            {
                box.Items.Add(readerr["NombreA"].ToString() + " " + readerr["apellidoPA"].ToString() + " " + readerr["apellidoMA"].ToString()
                    + " - " + readerr["MatriculaA"].ToString());
            }
            readerr.Close();
        }

        public void LlenarComboBoxHorarios(ComboBox box, SqlDataReader readerr)
        {
            while (readerr.Read())
            {
                box.Items.Add(readerr["Hora_Entrada"].ToString() + " a " + readerr["Hora_Salida"].ToString());
            }
            readerr.Close();
        }

        public void LlenarComboBoxLaboratorio(ComboBox box, SqlDataReader readerr)
        {
            while (readerr.Read())
            {
                box.Items.Add(readerr["Aula"].ToString() + " del " + readerr["Edificio"].ToString());
            }
            readerr.Close();
        }

        public void LlenarComboDias(ComboBox combo, SqlDataReader readerr)
        {
            while (readerr.Read())
            {
                combo.Items.Add(readerr["Dia"].ToString());
            }
            readerr.Close();
        }

        public void LlenarComboBoxMateria(ComboBox box, SqlDataReader readerr)
        {
            while (readerr.Read())
            {
                box.Items.Add(readerr["Asignatura"].ToString());
            }
            readerr.Close();
        }

        public void LlenarComboBoxCuatrimestres(ComboBox box, SqlDataReader readerr)
        {
            while (readerr.Read())
            {
                box.Items.Add(readerr["Periodo"].ToString() + " " + readerr["Año"].ToString());
            }
            readerr.Close();
        }

        public void LlenarComboBoxGrupos(ComboBox box, SqlDataReader readerr)
        {
            while (readerr.Read())
            {
                box.Items.Add(readerr["Grupos"].ToString());
            }
            readerr.Close();
        }

        public void LlenarComboBoxTodosGrupos(ComboBox combo, SqlDataReader readerr)
        {
            while (readerr.Read())
            {
                combo.Items.Add(readerr[0].ToString() + " " + readerr[1].ToString() + ", " + readerr[2].ToString() + ", " + readerr[3].ToString() + ", " + readerr[4].ToString() + " - "
                    + readerr[5].ToString());
            }
            readerr.Close();
        }

        public void LlenarListTodosGrupos(ListBox lista, SqlDataReader readerr)
        {
            while (readerr.Read())
            {
                lista.Items.Add(readerr[0].ToString() + " " + readerr[1].ToString() + ", " + readerr[2].ToString() + ", " + readerr[3].ToString() + ", " + readerr[4].ToString() + " - "
                    + readerr[5].ToString()/* + " " + readerr[6].ToString()*/);
            }
            readerr.Close();
        }

        public void LlenarListNoDisponibles(ListBox lista, SqlDataReader readerr)
        {
            while (readerr.Read())
            {
                lista.Items.Add(readerr[0].ToString() + ", " + readerr[1].ToString() + ", " + readerr[2].ToString() + ", " + 
                    readerr[3].ToString() + ", " +
                    readerr[4].ToString() + ", " + readerr[5].ToString());
            }
            readerr.Close();
        }

        public void LlenarListTodaasASignaciones(ListBox lista, SqlDataReader readerr)
        {
            while (readerr.Read())
            {
                lista.Items.Add(readerr[0].ToString() + ", " + readerr[1].ToString() + " " + readerr[2].ToString() + ", " + readerr[3].ToString() + ", " + readerr[4].ToString() + " del "
                    + readerr[5].ToString() + ", " + readerr[6].ToString() +", " + readerr[7].ToString() + ", " + readerr[8].ToString() + ", " + readerr[9].ToString());
            }
            readerr.Close();
        }

        public void LlenarListAulas(ListBox lista, SqlDataReader readerr)
        {
            while (readerr.Read())
            {
                lista.Items.Add(readerr["Aula"].ToString() + " del " + readerr["Edificio"].ToString());
            }
            readerr.Close();
        }

        public void LlenarListDias(ListBox lista, SqlDataReader readerr)
        {
            while (readerr.Read())
            {
                lista.Items.Add(readerr["Dia"].ToString());
            }
            readerr.Close();
        }

        public void LlenarListHoras(ListBox lista, SqlDataReader readerr)
        {
            while (readerr.Read())
            {
                lista.Items.Add(readerr["Hora_Entrada"].ToString() + " a " + readerr["Hora_Salida"].ToString());
            }
            readerr.Close();
        }

        public void LlenarListMaterias(ListBox lista, SqlDataReader readerr)
        {
            while (readerr.Read())
            {
                lista.Items.Add(readerr["Asignatura"].ToString());
            }
            readerr.Close();
        }

        public void LlenarListProfesor(ListBox lista, SqlDataReader readerr)
        {
            while (readerr.Read())
            {
                lista.Items.Add(readerr["Nombre_P"].ToString() + " " + readerr["Apellido_P"].ToString() + " " + readerr["Apellido_M"].ToString());
            }
            readerr.Close();
        }

        public void LlenarListCuatris(ListBox lista, SqlDataReader readerr)
        {
            while (readerr.Read())
            {
                lista.Items.Add(readerr["Periodo"].ToString() + " " + readerr["Año"].ToString());
            }
            readerr.Close();
        }

        public void MiLetrero(string j)
        {
            MessageBox.Show(j);
        }

        public void LlenarMeses(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("Enero - Abril");
            combo.Items.Add("Mayo - Agosto");
            combo.Items.Add("Septiembre - Diciembre");
        }

        public void LlenarA(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("2010");
            combo.Items.Add("2011");
            combo.Items.Add("2012");
            combo.Items.Add("2013");
            combo.Items.Add("2014");
            combo.Items.Add("2015");
            combo.Items.Add("2016");
            combo.Items.Add("2017");
            combo.Items.Add("2018");
            combo.Items.Add("2019");
            combo.Items.Add("2020");
            combo.Items.Add("2021");
            combo.Items.Add("2022");
            combo.Items.Add("2023");
            combo.Items.Add("2024");
            combo.Items.Add("2025");
            combo.Items.Add("2026");
            combo.Items.Add("2027");
            combo.Items.Add("2028");
            combo.Items.Add("2029");
            combo.Items.Add("2030");
        }

        public void LlenarDias(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("Lunes");
            combo.Items.Add("Martes");
            combo.Items.Add("Miércoles");
            combo.Items.Add("Jueves");
            combo.Items.Add("Viernes");
            combo.Items.Add("Sábado");
            combo.Items.Add("Domingo");
        }

        public void LlenarGrados(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("Primero");
            combo.Items.Add("Segundo");
            combo.Items.Add("Tercero");
            combo.Items.Add("Cuarto");
            combo.Items.Add("Quinto");
            combo.Items.Add("Sexto");
            combo.Items.Add("Septimo");
            combo.Items.Add("Octavo");
            combo.Items.Add("Noveno");
            combo.Items.Add("Décimo");
            combo.Items.Add("Undécimo");
        }

        public void LlenarGrupos(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("A");
            combo.Items.Add("B");
            combo.Items.Add("C");
            combo.Items.Add("D");
            combo.Items.Add("E");
            combo.Items.Add("F");
            combo.Items.Add("G");
            combo.Items.Add("H");
            combo.Items.Add("I");
            combo.Items.Add("J");
            combo.Items.Add("K");
        }

        public void LlenarTurno(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("Matutino");
            combo.Items.Add("Vespertino");
        }

        public void LlenarEspecialidad(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("Sistemas Informaticos");
            combo.Items.Add("Redes y Telecomunicaciones");
        }

        public void LlenarHoras(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("7:00");
            combo.Items.Add("8:00");
            combo.Items.Add("9:00");
            combo.Items.Add("10:00");
            combo.Items.Add("11:00");
            combo.Items.Add("12:00");
            combo.Items.Add("13:00");
            combo.Items.Add("14:00");
            combo.Items.Add("15:00");
            combo.Items.Add("16:00");
            combo.Items.Add("17:00");
            combo.Items.Add("18:00");
            combo.Items.Add("19:00");
            combo.Items.Add("20:00");
            combo.Items.Add("21:00");
        }

        public void LlenarAula(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("200");
            combo.Items.Add("201");
            combo.Items.Add("202");
            combo.Items.Add("203");
            combo.Items.Add("204");
            combo.Items.Add("205");
            combo.Items.Add("206");
            combo.Items.Add("207");
            combo.Items.Add("208");
            combo.Items.Add("209");
            combo.Items.Add("210");
            combo.Items.Add("211");
            combo.Items.Add("212");
            combo.Items.Add("213");
            combo.Items.Add("214");
            combo.Items.Add("215");
            combo.Items.Add("216");
            combo.Items.Add("217");
            combo.Items.Add("218");
            combo.Items.Add("219");
            combo.Items.Add("220");
        }

        public void LlenarEdificio(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("D-5");
            combo.Items.Add("K-5");
        }

        // /////////////////////////////////////////////// PARA DATASET ////////////////////////////////////////////////////////////////////////////////////////
        public void muestraDataTable(System.Data.DataTable tabla, DataGridView celdas)
        {
            if (tabla != null)
            {
                celdas.DataSource = tabla;
            }
            else
            {
                MiLetrero("La tabla no tiene datos");
            }
        }
    }
}
