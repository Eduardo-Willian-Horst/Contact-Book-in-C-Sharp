using System;

class Cidade
{
    private int id;
    private string nome;
    private string uf;

    public Cidade() {
    }

    public Cidade(int id) {
        this.id = id;
    }

    public Cidade(int id, string nome, string uf) {
        this.id = id;
        this.nome = nome;
        this.uf = uf;
    }
    
    public int get_Id() {
        return id;
    }

    public void set_Id(int id) {
        this.id = id;
    }

    public string get_Nome() {
        return nome;
    }

    public void set_Nome(string nome) {
        this.nome = nome;
    }

    public string get_Uf() {
        return uf;
    }

    public void set_Uf(string uf) {
        this.uf = uf;
    }

}