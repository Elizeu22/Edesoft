using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Edesoft.Models;
using System.Data;
using System.Data.SqlClient;

namespace Edesoft.Repositorio
{
    public class Crud:Conexao
    {


        public bool CadastrarCliente(Cliente CadastroCliente)
        {
            try
            {
                AbreConexao();
                Cmd = new SqlCommand("Inserecliente", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@Nome", CadastroCliente.NomeCliente);

                int i = Cmd.ExecuteNonQuery();

                if (i >= 1)
                {
                    return true;
                }

                else
                {
                    return false;
                }



            }
            catch (Exception e)
            {
                throw new Exception("Erro ao inserir dados:" + e.Message);
            }

            finally
            {
                FecharConexao();
            }
        }





        public bool SelecionarPorId(string Nome)
        {


            try
            {
                AbreConexao();
                Cmd = new SqlCommand("Selecionar", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@Id", Nome);

                Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    var filtro = new Cliente();


                    filtro.NomeCliente = Dr["Nome"].ToString();
                    filtro.NomeCao = Dr["NomeCao"].ToString();
                    filtro.Raca = Dr["Raca"].ToString();


                    return true;

                }

                else
                {
                    return false;
                }


            }

            catch (Exception e)
            {
                throw new Exception("Erro ao Selecionar os dados:" + e.Message);
            }

            finally
            {
                FecharConexao();
            }
        }







    }
}