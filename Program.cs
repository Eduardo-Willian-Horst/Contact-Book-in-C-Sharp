using System;

namespace _01Conceito
{

    class Program
    {

        static void Main(string[] args)
        {
            
            List<Contato> ListaDeContatos = new List<Contato>();
            
            try{
                Contato Contato1 = new Amigo("Eduardo", "54991139901", "dudu");
                Contato Contato2 = new Amigo("Lucas", "54991234123", "luquinhas");
                Contato Contato3 = new Amigo("Andre", "55981234344", "degua");
                ListaDeContatos.Add(Contato1);
            }catch (Exception ex){
                Console.WriteLine(ex);
            }
            

            

            

            Console.WriteLine(ListaDeContatos[0]);
            
            





            
        }
    }
}