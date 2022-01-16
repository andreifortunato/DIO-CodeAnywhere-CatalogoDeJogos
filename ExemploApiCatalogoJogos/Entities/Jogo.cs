using System;

namespace ExemploApiCatalogoJogos.Entities
{
    public class Jogo
    {

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Produtora { get; set; }
        public double Preco { get; set; }
        public Jogo(Guid id, string nome, string produtora, double preco)
        {
            Id = id;
            Nome = nome;
            Produtora = produtora;
            Preco = preco;
        }
    }
}
