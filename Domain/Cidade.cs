using System;

// Classe Cidade
class Cidade
{
    // Atributos privados
    private static int contadorIds = 1; // Variável estática para controlar os IDs das cidades
    private int id;
    private string nome;
    private string uf;

    private static List<Contato> ListaDeContatos = new List<Contato>();

    // Propriedades públicas para acesso aos atributos encapsulados
    public int Id
    {
        get { return id; }
        private set { id = value; }
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string UF
    {
        get { return uf; }
        set { uf = value; }
    }

    // Construtor com parâmetros
    public Cidade(string nome, string uf)
    {
        this.Id = contadorIds; // Define o ID da cidade usando o contador
        contadorIds++; // Incrementa o contador para o próximo ID disponível
        this.nome = nome;
        this.uf = uf;
    }

    // Método ToString para exibir informações da cidade
    public override string ToString()
    {
        return $"ID: {Id}, Nome: {nome}, UF: {uf}";
    }
}
