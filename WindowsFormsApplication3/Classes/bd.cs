using System;
using Npgsql;
using FirebirdSql.Data.FirebirdClient;

namespace WindowsFormsApplication3.Classes
{
    class bd
    {
        //atributos 
        private String _stringconexao = null;
        private FbConnection conexao = new FbConnection();
        //private NpgsqlConnection conexao = new NpgsqlConnection();
        private FbCommand comando = new FbCommand();
        //private NpgsqlCommand comando = new NpgsqlCommand();
        private FbDataReader reader;
        //private NpgsqlDataReader reader;

       // private String stringconexao { get { return _stringconexao = "server=127.0.0.1;port=5432;userid=robson;password=r3cr1s!;database=ControleEmails"; } }
        private String stringconexao { get { return _stringconexao = "User=sysdba; password=r3cr1s!; Database= C:\\base\\dados.fdb;"; } }
        

        private void conecta()
        {
            try
            {
                if(conexao.State != System.Data.ConnectionState.Open){
                  conexao.ConnectionString = stringconexao;
                conexao.Open();
                comando.Connection = conexao;
                }

            }catch(Exception){
                throw;
            }
            
          }

        public FbDataReader datareader(String sql)
        {
            try
            {
                conecta();

                comando.CommandText = sql;
                reader = comando.ExecuteReader();

                return reader;

               conexao.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void executasql(String sql)
        {
             conecta();
                FbTransaction transacao;
                transacao = conexao.BeginTransaction();
                comando.Transaction = transacao;
            try
            {
               
                
                comando.CommandText = sql;
                comando.ExecuteNonQuery();

                transacao.Commit();
            }
            catch (Exception)
            {
              transacao.Rollback();
               throw;
            }
        }
        
        
        //abrir a conexão com o banco de dados 
        
    }
}
