using System;

// Classe abstrata Contato
abstract class Contato
{
    private static int proximoId = 1;
    // Atributos privados
    private int id;
    private string nome;
    private string numeroTelefone;  
    private Cidade? cidade;

    // Propriedades públicas para acesso aos atributos encapsulados
    public int Id
    {
        get { return id; }
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string NumeroTelefone
    {
        get { return numeroTelefone; }
        set {

                if(value.Length != 11){
                    throw new Exception("Numero de telefone inválido");
                }

                numeroTelefone = value; 
             
             }
    }


    // Construtor padrão
    public Contato()
    {
        // Valores padrão para os atributos
        id = proximoId++;
        nome = "";
        numeroTelefone = "";
    }

    // Construtor com parâmetros
    public Contato(string nome, string numeroTelefone)
    {
        if(numeroTelefone.Length != 11){
            throw new Exception("Numero de telefone inválido");
        }
        this.id = proximoId++;
        this.nome = nome;
        this.numeroTelefone = numeroTelefone;
    }

    public Contato(string nome, string numeroTelefone, Cidade cidade)
    {
        if(numeroTelefone.Length != 11){
            throw new Exception("Numero de telefone inválido");
        }

        this.id = proximoId++;
        this.nome = nome;
        this.numeroTelefone = numeroTelefone;
        this.cidade = cidade;
    }

    public Contato(string nome, string numeroTelefone, string nomeDaCidade, string UFCidade)
    {
        if(numeroTelefone.Length != 11){
            throw new Exception("Numero de telefone inválido");
        }

        this.id = proximoId++;
        this.nome = nome;
        this.numeroTelefone = numeroTelefone;
        cidade = new Cidade(nomeDaCidade, UFCidade);
    }


    // Método ToString para exibir informações do contato
    public override string ToString()
    {
        return $"ID: {id}, Nome: {nome}, Telefone: {numeroTelefone}";
    }
}
