using System;

abstract class Contato
{
    private int id;
    private string nome;
    private int phoneNumber;

    public Contato(int id, string nome, int phoneNumber)
    {
        Set_ID(id);
        Set_Nome(nome);
        Set_phoneNumber(phoneNumber);
    }

    private void Set_ID(int id)
    {
        this.id = id;
    }

    public void Set_Nome(string nome)
    {
        this.nome = nome;
    }

    public void Set_phoneNumber(int phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }

    private int Get_ID()
    {
        return id;
    }

    public string Get_Nome()
    {
        return nome;
    }

    public int Get_phoneNumber()
    {
       return phoneNumber;
    }





}