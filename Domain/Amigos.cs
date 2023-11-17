using System;

class Amigos : Contato
{
    private string apelido;
    

    public Amigos(int id, string nome, int phoneNumber,string apelido) 
    : base(id, nome, phoneNumber)
    {   
        Set_Apelido(apelido);

    }


    private void Set_Apelido(string apelido)
    {
        this.apelido = apelido;
    }

    
}