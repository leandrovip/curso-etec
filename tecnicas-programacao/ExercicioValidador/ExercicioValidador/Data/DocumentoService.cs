using System.Data.SqlClient;

namespace ExercicioValidador.Data
{
    public class DocumentoService
    {
        public bool InserirRegistro(string valor, bool valido, string mensagem)
        {
            var data = new DataHelper();
            data.LimparParametros();

            data.AdicionarParametro(new SqlParameter("@Valor", valor));
            data.AdicionarParametro(new SqlParameter("@Valido", valido));
            data.AdicionarParametro(new SqlParameter("@Mensagem", mensagem));

            var result = data.ExecutarScalar("sp_InserirRegistro");

            return true;
        }
    }
}