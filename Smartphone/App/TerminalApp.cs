namespace Smartphone.App;

public class TerminalApp
{
    private string NomeDev {get; set;}
    private const string Opcoes = @"
    1 - Listar estoque
    2 - Adicionar Nokia
    3 - Adicionar Iphone
    4 - Sobre
    5 - Sair
    "; 

    public TerminalApp(string nome)
    {
        this.NomeDev = nome;
    }

    public void Inicio()
    {
        Console.WriteLine($"Loja de Smartphones");
        Console.WriteLine($"\n{Opcoes}\n");

        Console.WriteLine($"\n\n=-=-=Desenvolvido por {NomeDev} durante DecolaTech 2024=-=-=");
    }
}
