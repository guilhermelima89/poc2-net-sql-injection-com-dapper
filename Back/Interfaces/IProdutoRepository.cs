using Api.Models;
using Api.Pagination;

namespace Api.Interfaces;

public interface IProdutoRepository
{
    Task<IEnumerable<Produto>> TesteUm(string request);
    Task<IEnumerable<Produto>> TesteDois(string request);
    Task<IEnumerable<Produto>> TesteTres(string request);
}