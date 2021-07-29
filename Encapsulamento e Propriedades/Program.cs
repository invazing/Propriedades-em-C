using System;

namespace Encapsulamento_e_Propriedades
{

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Maria");
            p1.Genero = "masculino";
            p1.Idade = 19;
            p1.Cor = "Rosa";

            Console.WriteLine(p1.Nome);
            Console.WriteLine(p1.Idade);
            Console.WriteLine(p1.Cor);
        }
    }




   
}
