using OmniUser.Domain.Models;

namespace OmniUser.Domain.Interfaces;

public interface IViaCepRepository
{
    Task<EnderecoViaCepDto?> ObterEndereco(string cep);
}