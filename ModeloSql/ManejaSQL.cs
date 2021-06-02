﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ModeloSql
{
    public class ManejaSQL
    {
        public string CadCone { get; set; }

        public SqlConnection AbrirConexion(ref string mensaje)
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = CadCone;
            try
            {
                conexion.Open();
                mensaje = "Conexion exitosa";
            }
            catch (Exception w)
            {

                mensaje = "ERROR" + w.Message;
                conexion = null;
            }
            return conexion;
        }

        public Boolean Op_ModificarBD(SqlConnection carretera, string sentenciaSQL, ref string mensj)
        {
            Boolean salida = false;
            SqlCommand carrito = new SqlCommand();
            if (carretera != null)
            {
                carrito.Connection = carretera;
                carrito.CommandText = sentenciaSQL;
                try
                {
                    carrito.ExecuteNonQuery();
                    salida = true;
                    mensj = "Modificacion correcta";
                }
                catch (Exception h)
                {
                    salida = false;
                    mensj = "Error " + h.Message;
                }
                carretera.Close();
            }
            else
            {
                salida = false;
                mensj = "No hay conexion abierta";
            }
            return salida;
        }
        public SqlDataReader ConsultaDataReader(ref SqlConnection cn_abierta, string query1, ref string mensj)
        {
            SqlDataReader contenedor = null;
            SqlCommand carrito = new SqlCommand();

            if (cn_abierta != null)
            {
                carrito.Connection = cn_abierta;
                carrito.CommandText = query1;
                try
                {
                    contenedor = carrito.ExecuteReader();
                    mensj = "Consulta correcta";
                }
                catch (Exception g)
                {
                    mensj = "Error: " + g.Message;
                    contenedor = null;
                }
            }
            else
            {
                mensj = "No hay conexión abierta";
                contenedor = null;
            }
            return contenedor;
        }

        // FUNCIÓN DATASET
        public System.Data.DataSet ConsultaDataSet(SqlConnection cn_abierta, string query2, ref string mensj)
        {
            System.Data.DataSet cajagrande = new System.Data.DataSet();
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            if (cn_abierta != null)
            {
                carrito.Connection = cn_abierta;
                carrito.CommandText = query2;
                trailer.SelectCommand = carrito;
                try
                {
                    trailer.Fill(cajagrande);
                    mensj = "Consulta en DS exitosa.";
                }
                catch (Exception d)
                {
                    cajagrande = null;
                    mensj = "Error: " + d.Message;
                }
                cn_abierta.Close();
                cn_abierta.Dispose();
            }
            else
            {
                cajagrande = null;
                mensj = "No hay conexión abierta";
            }
            return cajagrande;
        }

        //esto debería ir en la lógica de negocios porque el siguiente método va a depender del problema
        public List<string> DevuelveMarcas(SqlConnection abierta, ref string mens, ref List<int> ids)
        {
            List<string> misMarcas = new List<string>();
            ids = new List<int>();

            SqlDataReader tablita = null;

            tablita = ConsultaDataReader(ref abierta, "Select * from MArcas", ref mens);
            if (tablita != null)
            {
                while (tablita.Read())
                {
                    ids.Add((int)tablita[0]);
                    misMarcas.Add((string)tablita[1]);
                }
                abierta.Close();
                abierta.Dispose();
            }
            else
            {
                mens = mens + ", no hay datos";
                misMarcas = null;
                ids = null;
            }

            return misMarcas;
        }
        public SqlDataReader ConsultaDataReaderconParametross(ref SqlConnection cn_abierta, string query1, ref string mensj, SqlParameter campo)
        {
            SqlDataReader contenedor = null;
            SqlCommand carrito = new SqlCommand();
            carrito.Parameters.Add(campo);

            if (cn_abierta != null)
            {
                carrito.Connection = cn_abierta;
                carrito.CommandText = query1;
                try
                {
                    contenedor = carrito.ExecuteReader();
                    mensj = "Consulta correcta";
                }
                catch (Exception g)
                {
                    mensj = "Error: " + g.Message;
                    contenedor = null;
                }
            }
            else
            {
                mensj = "No hay conexión abierta";
                contenedor = null;
            }
            return contenedor;
        }
        //SqlConnection conexion;

        //public SqlConnection AbrirConexion(ref string mensaje)
        //{
        //    try
        //    {
        //        conexion = new SqlConnection(@"Data Source=CORONA-LAPTOP;Initial Catalog=Laboratorios;Integrated Security=True");
        //        conexion.Open();
        //        mensaje = "Conexion exitosa";
        //    }
        //    catch (Exception w)
        //    {

        //        mensaje = "ERROR" + w.Message;
        //        conexion = null;
        //    }
        //    return conexion;
        //}



    }
}
