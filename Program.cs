using System;

namespace _01Conceito
{

    class Program
    {

        static void Main(string[] args)
        {
            
            List<Contato> ListaDeContatos = new List<Contato>();
           

             

            Cidade PassoFundo = new Cidade("Passo Fundo", "RS");
            Cidade Ibiruba = new Cidade("Ibiruba", "RS");
            Cidade Palmas = new Cidade("Palma", "TC");
            Cidade RioDeJaneiro = new Cidade("Rio de Janeiro", "RJ");

            

            try{
                Contato Contato1 = new Amigo("Eduardo", "54991139901", "dudu", PassoFundo);
                Contato Contato2 = new Amigo("Lucas", "54991239096", "luquinhas");
                Contato Contato3 = new Amigo("Andre", "55981234344", "degua", Ibiruba);
                Contato Contato4 = new Familia("Joao", "55981238855", "Primo", Palmas);
                Contato Contato5 = new Empresarial("Financeira Dinheiro a Vista", "55957837890", "financeira@gmayl.com", "Rua das Flores", RioDeJaneiro);
                Contato Contato6 = new Empresarial("Pedreiro Clovis", "55123467457", "clovis@hottmail.com", "Rua Sao Cristovao", Palmas);
                Contato Contato7 = new Amigo("Eduardo", "54991137901", "dudu", "Sao Paulo", "SP");
                ListaDeContatos.Add(Contato1);
                ListaDeContatos.Add(Contato2);
                ListaDeContatos.Add(Contato3);
                ListaDeContatos.Add(Contato4);
                ListaDeContatos.Add(Contato5);
                ListaDeContatos.Add(Contato6);
                ListaDeContatos.Add(Contato7);
            }catch (Exception ex){
                Console.WriteLine(ex);
            }




            for( int i = 0; i < ListaDeContatos.Count; i++){
                Console.WriteLine(ListaDeContatos[i]);
            }
            
            for( int i = 0; i < Cidade.ListaDeCidades.Count; i++){
                Console.WriteLine(Cidade.ListaDeCidades[i]);
            }
            
        }
    }
}