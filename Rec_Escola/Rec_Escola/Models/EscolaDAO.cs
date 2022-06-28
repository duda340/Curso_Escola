using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Rec_Escola.Interface;
using Rec_Escola.Database;
using MySql.Data.MySqlClient;

namespace Rec_Escola.Models
{
    internal class EscolaDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Escola escola)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO Escola VALUES " +
                "(null, @nome_fantasia_esc, @razao_social_esc, @cnpj_esc, @insc_estadual_esc, @tipo_esc, @data_criacao_esc, @responsavel_esc, @responsavel_telefone_esc, " +
                "@email_esc, @telefone_esc, @rua_esc, @numero_esc, @bairro_esc, @complemento_esc, @cep_esc, @cidade_esc, @estado_esc);";

                comando.Parameters.AddWithValue("@nome_fantasia_esc", escola.NomeFantasia);
                comando.Parameters.AddWithValue("@razao_social_esc", escola.RazaoSocial);
                comando.Parameters.AddWithValue("@cnpj_esc", escola.Cnpj);
                comando.Parameters.AddWithValue("@insc_estadual_esc", escola.InscEstadual);
                comando.Parameters.AddWithValue("@tipo_esc", escola.Tipo);
                comando.Parameters.AddWithValue("@data_criacao_esc", escola.DataCriacao?.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@responsavel_esc", escola.Responsavel);
                comando.Parameters.AddWithValue("@responsavel_telefone_esc", escola.ResponsavelTelefone);
                comando.Parameters.AddWithValue("@email_esc", escola.Email);
                comando.Parameters.AddWithValue("@telefone_esc", escola.Telefone);
                comando.Parameters.AddWithValue("@rua_esc", escola.Rua);
                comando.Parameters.AddWithValue("@numero_esc", escola.Numero);
                comando.Parameters.AddWithValue("@bairro_esc", escola.Bairro);
                comando.Parameters.AddWithValue("@complemento_esc", escola.Complemento);
                comando.Parameters.AddWithValue("@cep_esc", escola.CEP);
                comando.Parameters.AddWithValue("@cidade_esc", escola.Cidade);
                comando.Parameters.AddWithValue("@estado_esc", escola.Estado);


                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao salvar as informações");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Escola> List()
        {
            try
            {
                var lista = new List<Escola>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM Escola";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var escola = new Escola();

                    escola.Id = reader.GetInt32("id_esc");
                    escola.NomeFantasia = DAO.GetString(reader, "nome_fantasia_esc");
                    escola.RazaoSocial = DAO.GetString(reader, "razao_social_esc");
                    escola.Cnpj = DAO.GetString(reader, "cnpj_esc");
                    escola.InscEstadual = DAO.GetString(reader, "insc_estadual_esc");
                    escola.Tipo = DAO.GetString(reader, "tipo_esc");
                    escola.DataCriacao = DAO.GetDateTime(reader, "data_criacao_esc");
                    escola.Responsavel = DAO.GetString(reader, "responsavel_esc");
                    escola.ResponsavelTelefone = DAO.GetString(reader, "responsavel_telefone_esc");
                    escola.Email = DAO.GetString(reader, "email_esc");
                    escola.Telefone = DAO.GetString(reader, "telefone_esc");
                    escola.Rua = DAO.GetString(reader, "rua_esc");
                    escola.Numero = DAO.GetString(reader, "numero_esc");
                    escola.Bairro = DAO.GetString(reader, "bairro_esc");
                    escola.Complemento = DAO.GetString(reader, "complemento_esc");
                    escola.CEP = DAO.GetString(reader, "cep_esc");
                    escola.Cidade = DAO.GetString(reader, "cidade_esc");
                    escola.Estado = DAO.GetString(reader, "estado_esc");

                    lista.Add(escola);
                }

                reader.Close();
                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public void Delete(Escola escola)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM Escola WHERE (id_esc = @id)";

                comando.Parameters.AddWithValue("@id", escola.Id);

                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao deletar as informações");
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(Escola escola)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "UPDATE Escola set" +
                    " nome_fantasia_esc = @nome  , razao_social_esc = @razao_social, @cnpj,  @inscricao, " +
                    " @tipo, @data_criacao, @resp, @resp_tel, " +
                    " @email,  @telefone,  @rua,  @numero, " +
                    "@bairro,  @complemento,@cep,  @cidade,  @estado " +
                    "WHERE id_esc = @id";

                comando.Parameters.AddWithValue("@id", escola.Id);
                comando.Parameters.AddWithValue("@nome", escola.NomeFantasia);
                comando.Parameters.AddWithValue("@razao_social", escola.RazaoSocial);
                comando.Parameters.AddWithValue("@cnpj", escola.Cnpj);
                comando.Parameters.AddWithValue("@inscricao", escola.InscEstadual);
                comando.Parameters.AddWithValue("@tipo", escola.Tipo);
                comando.Parameters.AddWithValue("@data_criacao", escola.DataCriacao?.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@resp", escola.Responsavel);
                comando.Parameters.AddWithValue("@resp_tel", escola.ResponsavelTelefone);
                comando.Parameters.AddWithValue("@email", escola.Email);
                comando.Parameters.AddWithValue("@telefone", escola.Telefone);
                comando.Parameters.AddWithValue("@rua", escola.Rua);
                comando.Parameters.AddWithValue("@numero", escola.Numero);
                comando.Parameters.AddWithValue("@bairro", escola.Bairro);
                comando.Parameters.AddWithValue("@complemento", escola.Complemento);
                comando.Parameters.AddWithValue("@cep", escola.CEP);
                comando.Parameters.AddWithValue("@cidade", escola.Cidade);
                comando.Parameters.AddWithValue("@estado", escola.Estado);

                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao salvar as informações");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
