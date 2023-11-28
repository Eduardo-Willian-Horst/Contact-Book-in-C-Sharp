using System;

// Classe Familia que herda de Contato
class Familia : Contato
{
    // Atributo específico da classe Familia
    private string lacosParentesco;

    // Propriedade para acesso ao atributo encapsulado
    public string LacosParentesco
    {
        get { return lacosParentesco; }
        set { lacosParentesco = value; }
    }

    // Construtor padrão que utiliza o construtor da classe base (Contato)
    public Familia() : base()
    {
        lacosParentesco = "";
    }

    // Construtor com parâmetros que utiliza o construtor da classe base (Contato)
    public Familia(string nome, string numeroTelefone, string lacosParentesco) : base(nome, numeroTelefone)
    {
        this.lacosParentesco = lacosParentesco;
    }

    public Familia(string nome, string numeroTelefone, string lacosParentesco, Cidade cidade) : base(nome, numeroTelefone, cidade)
    {
        this.lacosParentesco = lacosParentesco;
    }


    // Substituição do método ToString para exibir informações do Familia
    public override string ToString()
    {
        return base.ToString() + $", Laço Parentesco: {lacosParentesco}";
    }
}
