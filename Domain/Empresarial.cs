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
        set { this.email = value;}
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
        //Regra de Negocio
        if(IsEmailValido(email)){
            this.email = email;
        }else{
            throw new ArgumentException("Email invalido!!");
        }
        this.endereco = endereco;
    }

    public Empresarial(string nome, string numeroTelefone, string email, string endereco, Cidade cidade)
        : base(nome, numeroTelefone, cidade) // Chama o construtor da classe base para inicializar os atributos id, nome, numeroTelefone e cidade
    {

        if(IsEmailValido(email)){
            this.email = email;
        }else{
            throw new ArgumentException("Email invalido!!");
        }
        this.endereco = endereco;
    }


    public Empresarial(string nome, string numeroTelefone, string email, string endereco, string nomeDaCidade , string ufcidade) : base(nome, numeroTelefone, nomeDaCidade, ufcidade)// Chama o construtor da classe base para inicializar os atributos id, nome, numeroTelefone e cidade
    {
        if(IsEmailValido(email)){
            this.email = email;
        }else{
            throw new ArgumentException("Email invalido!!");
        }
        
        this.endereco = endereco;
    }

    // Método ToString para exibir informações do contato empresarial
    public override string ToString()
    {
        // Utiliza o ToString da classe base e adiciona informações dos atributos adicionais
        return base.ToString() + $", Email: {email}, Endereco: {endereco}";
    }


    
    //Método de negócio: Verifica se o e-mail é válido 
    private bool IsEmailValido( string emailAVerificar) 
    { 
      //Lógica para verificar a validade do e-mail 
      //Aqui, uma implementação simples que verifica s e o e-mail contém "@" e "."
      if(emailAVerificar.Contains("@") && emailAVerificar.Contains(".com")){
        return true;
      }
       return false;
    } 



}

    
    
