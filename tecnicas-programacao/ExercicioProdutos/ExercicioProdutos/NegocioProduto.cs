using System.Data.SqlClient;

namespace ExercicioProdutos
{
    public class NegocioProduto
    {
        public bool InserirProduto(string codigo, string descricao, decimal valorCusto, decimal valorVenda)
        {
            var data = new DataHelper();
            data.LimparParametros();

            data.AdicionarParametro(new SqlParameter("@Codigo", codigo));
            data.AdicionarParametro(new SqlParameter("@Descricao", descricao));
            data.AdicionarParametro(new SqlParameter("@ValorCusto", valorCusto));
            data.AdicionarParametro(new SqlParameter("@ValorVenda", valorVenda));

            var result = data.ExecutarScalar("sp_inserirproduto");
            return true;
        }
    }
}