using System;

class Empresarial : Contato
{
    private string email;
    private string endereco;


    public Empresarial(int id, string nome, int phoneNumber, string email, string endereco)
    : base(id, nome, phoneNumber)
    {
        Set_Email(email);
        Set_Endereco(endereco);
    }


    private void Set_Email(string email)
    {
        this.email = email;
    }

    public void Set_Endereco(string endereco)
    {
        this.endereco = endereco;
    }

    private string Get_Email()
    {
        return email;
    }

    public string Get_Endereco()
    {
        return endereco;
    }

    // Método de negócio: Verifica se o e-mail é válido
    public bool IsEmailValido()
    {
        // Lógica para verificar a validade do e-mail
        // Aqui, uma implementação simples que verifica se o e-mail contém "@" e "."
        return Email.Contains("@") && Email.Contains(".");
    }

    // Método de negócio: Imprime informações detalhadas do contato empresarial
    public void ImprimirInformacoesDetalhadas()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Telefone: {PhoneNumber}");
        Console.WriteLine($"E-mail: {Email}");
        Console.WriteLine($"Endereço: {Endereco}");
    }
}