using invencivelAPIoficial.Models;

namespace invencivelAPIoficial
{
    public interface TremInterface
    {
        public Task<List<string>> ObterTremNomesTrem();
        public Task<Trem> ObterDadosPorNome(string nomeTrem);
    }
}
