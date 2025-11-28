using invencivelAPIoficial.Models;

namespace invencivelAPIoficial
{
    public interface TremInterface
    {
        public Task<List<string>> ObterTremNomesTrem();
    }
}
