using System;
// Classe Amigo que herda de Contato
class Amigo : Contato
{
    // Atributo específico da classe Amigo
    private string apelido;

    // Propriedade para acesso ao atributo encapsulado
    public string Apelido
    {
        get { return apelido; }
        set { apelido = value; }
    }

    // Construtor padrão que utiliza o construtor da classe base (Contato)
    public Amigo() : base()
    {
        apelido = "";
    }

    // Construtor com parâmetros que utiliza o construtor da classe base (Contato)
    public Amigo(string nome, string numeroTelefone, string apelido) : base(nome, numeroTelefone)
    {
        this.apelido = apelido;
    }

    public Amigo(string nome, string numeroTelefone, string apelido, Cidade cidade) : base(nome, numeroTelefone, cidade)
    {
        this.apelido = apelido;
    }

    public Amigo(string nome, string numeroTelefone, string apelido, string nomeDaCidade , string ufcidade) : base(nome, numeroTelefone, nomeDaCidade, ufcidade)
    {
        this.apelido = apelido;
    }

    // Substituição do método ToString para exibir informações do amigo
    public override string ToString()
    {
        return base.ToString() + $", Apelido: {apelido}";
    }
}
