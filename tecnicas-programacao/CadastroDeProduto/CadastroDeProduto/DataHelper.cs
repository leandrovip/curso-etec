using System.Data;
using System.Data.SqlClient;

namespace CadastroDeProduto
{
    public class DataHelper
    {
        //Lista contendo todos os parâmetros de entrada de um procedimento (nome x valor).
        private readonly SqlParameterCollection listaParametrosSql;

        public DataHelper()
        {
            listaParametrosSql = new SqlCommand().Parameters;
        }

        //Método que inicia uma conexão com um banco de dados.
        private SqlConnection ObterConexao()
        {
            var connectionString =
                @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=D:\Users\leand\CadastroProduto.mdf;Initial Catalog=CadastroProduto;Integrated Security=True";

            //Os dados de acesso ao banco de dados estão configurados nas propriedades do projeto.
            return new SqlConnection(connectionString);
        }

        //Método que permite adicionar a lista de parâmetros de entrada de uma procedure um novo
        //parâmetro (nome x valor), este parâmetro será enviado da regra de negócios.
        public void AdicionarParametro(SqlParameter parametro)
        {
            //Método Add adiciona um novo elemento a lista de parâmetros.
            listaParametrosSql.Add(parametro);
        }

        //Remove todos os elementos contidos na lista de parâmetros de entrada.
        public void LimparParametros()
        {
            //Método Clear() remove todos os elementos da lista.
            listaParametrosSql.Clear();
        }

        //Adiciona os parâmetros informados da regra negócios a instrução SQL que será executada.
        private void AdicionarParametrosComando(SqlCommand sqlCommand)
        {
            //Remove todos os parâmetros associados ao comando.
            sqlCommand.Parameters.Clear();
            //Percorre todos os elementos contidos na lista de parâmetros adicionando-os
            //ao comando que será executados no BD.
            foreach (SqlParameter sqlParameter in listaParametrosSql)
                sqlCommand.Parameters.Add(
                    new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
        }

        //Método responsável por enviar comando que modificam dados no BD (insert, update e delete)
        public object ExecutarScalar(string strComando)
        {
            using (var sqlConnection = ObterConexao())
            {
                sqlConnection.Open(); //Abre a conexão com o BD.
                var sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandTimeout = 7200;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = strComando;
                //Adiciona os parâmetros ao comando que será executado.
                AdicionarParametrosComando(sqlCommand);

                //Envia o comando para o BD.
                return sqlCommand.ExecuteScalar();
            }
        }

        //Método responsável por obter o resultado de um select executado no BD.
        public DataTable GetDataTable(string strComando)
        {
            using (var sqlConnection = ObterConexao())
            {
                sqlConnection.Open();
                var sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandTimeout = 7200;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = strComando;
                AdicionarParametrosComando(sqlCommand);

                var sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                var dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                return dataSet.Tables[0];
            }
        }
    }
}