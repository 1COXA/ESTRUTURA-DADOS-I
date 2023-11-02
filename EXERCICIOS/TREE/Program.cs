public class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cargo { get; set; }

    public Pessoa() { }

    public Pessoa(int id, string nome, string cargo)
    {
        Id = id;
        Nome = nome;
        Cargo = cargo;
    }
}

Árvore<Pessoa> empresa = new Árvore<Pessoa>();
empresa.Raiz = new Nó<Pessoa>()
{
    Dados = new Pessoa(100, "Marcin Jamro", "CEO"),
    Pai = null
};

empresa.Raiz.Filhos = new List<Nó<Pessoa>>()
{
    new Nó<Pessoa>()
    {
        Dados = new Pessoa(1, "John Smith", "Chefe de Desenvolvimento"),
        Pai = empresa.Raiz
    },
    new Nó<Pessoa>()
    {
        Dados = new Pessoa(50, "Mary Fox", "Chefe de Pesquisa"),
        Pai = empresa.Raiz
    },
    new Nó<Pessoa>()
    {
        Dados = new Pessoa(150, "Lily Smith", "Chefe de Vendas"),
        Pai = empresa.Raiz
    }
};

empresa.Raiz.Filhos[2].Filhos = new List<Nó<Pessoa>>()
{
    new Nó<Pessoa>()
    {
        Dados = new Pessoa(30, "Anthony Black", "Especialista de Vendas"),
        Pai = empresa.Raiz.Filhos[2]
    }
};
