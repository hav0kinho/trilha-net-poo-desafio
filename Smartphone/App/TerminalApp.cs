using System.Collections;
using Smartphone.Models;

namespace Smartphone.App;

public class TerminalApp
{
    public string NomeDev {get; set;}
    ArrayList<Nokia> ListaNokia {get; set;}
    ArrayList<Iphone> ListaIphone {get; set;}

    public TerminalApp(string nome)
    {
        this.NomeDev = nome;
        this.ListaNokia = new ArrayList();
        this.ListaIphone = new ArrayList();
    }

    public void Inicializar()
    {
        int opcao = 0;
        while(true)
        {
            this.Inicio();
            switch(opcao)
            {
                case 1:
                    ListarEstoque();
                    break;
                case 2:
                    AdicionarNokia();
                    break;
                case 3:
                    AdicionarIphone();
                    break;
                case 4:
                    Sobre();
                    break;
                case 5:
                    Sair();
                    break;  
            }
        }

    }


    private void Inicio()
    {
        string Inicio = 
$@"
=-=-=-=-=-=-=-=-=-=-=-=-=Loja de Smartphones=-=-=-=-=-=-=-=-=-=-=-=-=

1 - Listar estoque
2 - Adicionar Nokia
3 - Adicionar Iphone
4 - Sobre
5 - Sair

=-=-=Desenvolvido por {NomeDev} durante DecolaTech 2024=-=-=
"; 
        Console.WriteLine(Inicio);
    }
}
