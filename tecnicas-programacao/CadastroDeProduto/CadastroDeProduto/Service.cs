using System.Data.SqlClient;

namespace CadastroDeProduto
{
    public class Service
    {
        public bool InserirProduto(string codigo, string descricao, string medida, decimal valorCusto, decimal valorVenda, decimal estoque,
            string observacao)
        {
            var data = new DataHelper();
            data.LimparParametros();

            data.AdicionarParametro(new SqlParameter("@Codigo", codigo));
            data.AdicionarParametro(new SqlParameter("@Descricao", descricao));
            data.AdicionarParametro(new SqlParameter("@Medida", medida));
            data.AdicionarParametro(new SqlParameter("@ValorCusto", valorCusto));
            data.AdicionarParametro(new SqlParameter("@ValorVenda", valorVenda));
            data.AdicionarParametro(new SqlParameter("@Estoque", estoque));
            data.AdicionarParametro(new SqlParameter("@Observacao", observacao));

            var result = data.ExecutarScalar("sp_inserirproduto");

            return true;
        }
    }
}