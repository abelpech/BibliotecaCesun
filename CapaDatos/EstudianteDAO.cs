﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaCesun.CapaEntidades;

namespace BibliotecaCesun.CapaDatos
{
    class EstudianteDAO
    {
        #region "PATRON SINGLETON"
        private static EstudianteDAO alumnoDAO = null;
        private EstudianteDAO()
        {

        }
        public static EstudianteDAO GetInstance()
        {
            if (alumnoDAO == null)
            {
                alumnoDAO = new EstudianteDAO();
            }
            else
            {
                Debug.WriteLine("Ya existe una instancia del objeto.");
            }
            return alumnoDAO;
        }
        #endregion
        //Va a retornar un objeto del tipo empleado

        public Estudiante AccesoSitema(String matricula, String password)
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            Estudiante objEstudiante = null;
            SqlDataReader dr = null;
            try
            {
                conexion = Conexion.GetInstance().ConexionBD();
                cmd = new SqlCommand("spAccesoSistema", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmMatricula", matricula);
                cmd.Parameters.AddWithValue("@prmPassword", password);
                cmd.Parameters.AddWithValue("@prmTipo", 3);
                conexion.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    objEstudiante = new Estudiante();
                    objEstudiante.matricula = dr["matricula"].ToString();
                    objEstudiante.nombre = dr["usuario"].ToString();
                    objEstudiante.apellido = dr["apellido"].ToString();
                    objEstudiante.telefono = dr["telefono"].ToString();
                    objEstudiante.email = dr["email"].ToString();
                    objEstudiante.direccion = dr["direccion"].ToString();
                    objEstudiante.password = dr["password"].ToString();
                }
            }
            catch (Exception ex)
            {
                objEstudiante = null;
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            return objEstudiante;

        }
    }
}
