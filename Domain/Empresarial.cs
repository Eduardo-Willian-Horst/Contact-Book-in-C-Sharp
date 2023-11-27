using System;

// Classe Empresarial que herda da classe Contato
class Empresarial : Contato
{
    // Atributos adicionais
    private string email;
    private string endereco;

    // Propriedades públicas para acesso aos atributos encapsulados
    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public string Endereco
    {
        get { return endereco; }
        set { endereco = value; }
    }

    // Construtor padrão
    public Empresarial()
    {
        // Inicialização dos atributos adicionais
        email = "";
        endereco = "";
    }

    // Construtor com parâmetros, aproveitando construtor da classe base (Contato)
    public Empresarial(string nome, string numeroTelefone, string email, string endereco)
        : base(nome, numeroTelefone) // Chama o construtor da classe base para inicializar os atributos id, nome e numeroTelefone
    {
        this.email = email;
        this.endereco = endereco;
    }

    public Empresarial(string nome, string numeroTelefone, string email, string endereco, Cidade cidade)
        : base(nome, numeroTelefone, cidade) // Chama o construtor da classe base para inicializar os atributos id, nome, numeroTelefone e cidade
    {
        this.email = email;
        this.endereco = endereco;
    }


    // Método ToString para exibir informações do contato empresarial
    public override string ToString()
    {
        // Utiliza o ToString da classe base e adiciona informações dos atributos adicionais
        return base.ToString() + $", Email: {email}, Endereco: {endereco}";
    }
}

    /* // Método de negócio: Verifica se o e-mail é válido */
    /* public bool IsEmailValido() */
    /* { */
    /*     // Lógica para verificar a validade do e-mail */
    /*     // Aqui, uma implementação simples que verifica s e o e-mail contém "@" e "."
    /*     return Email.Contains("@") && Email.Contains(".") ;
    /* } */

    /* // Método de negócio: Imprime informações detalhadas  do contato empresarial
    /* public void ImprimirInformacoesDetalhadas() */
    /* { */
    /*     Console.WriteLine($"ID: {Id}"); */
    /*     Console.WriteLine($"Nome: {Nome}"); */
    /*     Console.WriteLine($"Telefone: {PhoneNumber}"); */
    /*     Console.WriteLine($"E-mail: {Email}"); */
    /*     Console.WriteLine($"Endereço: {Endereco}"); */
    /* } */
