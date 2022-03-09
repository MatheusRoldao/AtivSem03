using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace web_app.Repository
{
    public class Departamento
    {
        public static void save(Models.Departamento departamento)
        {
            using (SqlConnection conexaoSQL = new SqlConnection(Configuration.Parameters.getConnectionString()))
            {
                conexaoSQL.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexaoSQL;
                    cmd.CommandText = "Insert into Departamento(Nome,Rg,Sexo) values (@Nome,@Rg,@Sexo)";
                    cmd.Parameters.Add(new SqlParameter("@Nome", System.Data.SqlDbType.VarChar, 100)).Value = departamento.Nome;
                    cmd.Parameters.Add(new SqlParameter("@Rg", System.Data.SqlDbType.VarChar, 18)).Value = departamento.Rg;
                    cmd.Parameters.Add(new SqlParameter("@Sexo", System.Data.SqlDbType.VarChar, 20)).Value = departamento.Sexo;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Models.Departamento> getAll()
        {
            List<Models.Departamento> departamentos = new List<Models.Departamento>();

            using (SqlConnection conexaoSQL = new SqlConnection(Configuration.Parameters.getConnectionString()))
            {
                conexaoSQL.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexaoSQL;
                    cmd.CommandText = "select Codigo, Nome,Rg,Sexo from Departamento";
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Models.Departamento departamento = new Models.Departamento();
                        departamento.Id = (int) dr["Codigo"];
                        departamento.Nome = (string) dr["Nome"];
                        departamento.Rg = (string)dr["Rg"];
                        departamento.Sexo = (string)dr["Sexo"];
                        departamentos.Add(departamento);
                    }
                }
            }
            return departamentos;
        }

        public static Models.Departamento getById(int id)
        {
            Models.Departamento departamento = new Models.Departamento();

            using (SqlConnection conexaoSQL = new SqlConnection(Configuration.Parameters.getConnectionString()))
            {
                conexaoSQL.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexaoSQL;
                    cmd.CommandText = "select codigo, nome,rg,sexo from departamento where codigo = @codigo";
                    cmd.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int)).Value = id;
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        departamento.Id = (int)dr["Codigo"];
                        departamento.Nome = (string)dr["Nome"];
                        departamento.Rg = (string)dr["Rg"];
                        departamento.Sexo = (string)dr["Sexo"];
                    }
                }
            }
            return departamento;
        }
        public static void update(Models.Departamento departamento)
        {
            using (SqlConnection conexaoSQL = new SqlConnection(Configuration.Parameters.getConnectionString()))
            {
                conexaoSQL.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexaoSQL;
                    cmd.CommandText = "update Departamento set Nome = @Nome ,Rg = @Rg,Sexo = @Sexo where Codigo = @Codigo";
                    cmd.Parameters.Add(new SqlParameter("@Codigo", System.Data.SqlDbType.Int)).Value = departamento.Id;
                    cmd.Parameters.Add(new SqlParameter("@Nome", System.Data.SqlDbType.VarChar, 100)).Value = departamento.Nome;
                    cmd.Parameters.Add(new SqlParameter("@Rg", System.Data.SqlDbType.VarChar, 18)).Value = departamento.Rg;
                    cmd.Parameters.Add(new SqlParameter("@Sexo", System.Data.SqlDbType.VarChar, 20)).Value = departamento.Sexo;
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void deleteById(int id)
        {
            using (SqlConnection conexao = new SqlConnection(Configuration.Parameters.getConnectionString()))
            {
                conexao.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexao;
                    cmd.CommandText = "delete from Departamento where codigo = @codigo";
                    cmd.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int)).Value = id;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}