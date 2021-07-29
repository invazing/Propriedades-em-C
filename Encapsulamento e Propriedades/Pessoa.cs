public class Pessoa
{
    // Precisa ser a privada 
    private string nome;
    private string genero;
    private int idade;
    private string cor;

   
    public Pessoa(string nome)
    {
        this.Nome = nome;
    }
    /* precisa ser publica com metodos get e set (Deixando a inicial Maiuscula)
     * get { return nome;}
     * set { nome = value;}
    */
    public string Cor
    {
        set
        {
            if (value == "Amarelo")
            {
                System.Console.WriteLine("Voce n pode escolher Amarelo");
                           
            }
            else
            {
                cor = value;
            }
            
        }
        get { return cor; }
    }
    
public string Nome { get; }

    public string Genero
    {
        set
        {
            genero = value;
            System.Console.WriteLine(genero);
        }
    }

    public int Idade
    {
        set
        {
            if (value < 18)
            {
                System.Console.WriteLine("Idade tem que ser maior que 18");
            }
            else
            {
                this.idade = value;
            }
        }
        get { return idade; }
    }
}