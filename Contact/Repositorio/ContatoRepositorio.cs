using Contact.Data;
using Contact.Models;
using Microsoft.EntityFrameworkCore.Storage.Json;

namespace Contact.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        //injeção de dependencias
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public ContatoModel ListarPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public List<ContatoModel> BuscaContatos()
        {
            return _bancoContext.Contatos.ToList();
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            //gravando no banco de dados
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();

            return contato;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarPorId(contato.Id);

            if (contatoDB == null) throw new SystemException("Erro ao atualizar o contato!");

            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Celular = contato.Celular;

            _bancoContext.Contatos.Update(contatoDB);
            _bancoContext.SaveChanges();

            return contatoDB;
        }

        public bool Apagar(int id)
        {
            ContatoModel contatoDB = ListarPorId(id);

            if (contatoDB == null) throw new SystemException("Erro ao apagar o contato!");

            _bancoContext.Contatos.Remove(contatoDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
