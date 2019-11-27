using System.Data;
using System.Data.SqlClient;

namespace ExercicioValidador.Data
{
    public class DataHelper
    {
        #region Propriedades

        private readonly SqlParameterCollection listaParametrosSql;

        #endregion

        #region Construtores

        public DataHelper()
        {
            listaParametrosSql = new SqlCommand().Parameters;
        }

        #endregion

        #region Métodos

        private SqlConnection ObterConexao()
        {
            var connectionString =
                @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=D:\Users\leand\Validador.mdf;Initial Catalog=Validador;Integrated Security=True";

            return new SqlConnection(connectionString);
        }

        public void AdicionarParametro(SqlParameter parametro)
        {
            listaParametrosSql.Add(parametro);
        }

        public void LimparParametros()
        {
            listaParametrosSql.Clear();
        }

        private void AdicionarParametrosComando(SqlCommand sqlCommand)
        {
            sqlCommand.Parameters.Clear();

            foreach (SqlParameter sqlParameter in listaParametrosSql)
                sqlCommand.Parameters.Add(
                    new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
        }

        public object ExecutarScalar(string strComando)
        {
            using (var sqlConnection = ObterConexao())
            {
                sqlConnection.Open(); //Abre a conexão com o BD.
                var sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandTimeout = 7200;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = strComando;

                AdicionarParametrosComando(sqlCommand);

                //Envia o comando para o BD.
                return sqlCommand.ExecuteScalar();
            }
        }

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

        #endregion
    }
}