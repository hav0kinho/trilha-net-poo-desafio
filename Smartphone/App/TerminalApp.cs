﻿using System.Collections;
using Smartphone.Models;

namespace Smartphone.App;

public class TerminalApp
{
    public string NomeDev {get; set;}
    List<Nokia> ListaNokia {get; set;}
    List<Iphone> ListaIphone {get; set;}

    public TerminalApp(string nome)
    {
        this.NomeDev = nome;
        this.ListaNokia = new List<Nokia>();
        this.ListaIphone = new List<Iphone>();
    }

    public void Inicializar()
    {
        int opcao = 0;
        while(true)
        {
            Console.Clear();
            this.Inicio();
            opcao =  int.Parse(Console.ReadLine());
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

    private void ListarEstoque()
    {
        Console.Clear();
        string listagem = "*********************NOKIAS**********************\n";
        
        if(ListaNokia.Count > 0)
        {
            foreach(Nokia nokia in ListaNokia)
            {
                listagem += $"Modelo: {nokia.Modelo} | IMEI: {nokia.IMEI}\n";
            }
        } 
        else
        {
            listagem += "\n[Não existe smartphones da marca Nokia no estoque!]\n";
        }


        listagem += "\n*********************IPHONES*********************\n";

        if(ListaIphone.Count > 0)
        {
            foreach(Iphone iphone in ListaIphone)
            {
                listagem += $"Modelo: {iphone.Modelo} | IMEI: {iphone.IMEI}\n";
            }
        }
        else
        {
            listagem += "\n[Não existe smartphones da marca iPhone no estoque!]\n";
        }

        Console.WriteLine(listagem);

        Console.ReadLine();
    }

    private void AdicionarNokia()
    {

    }

    private void AdicionarIphone()
    {

    }

    private void Sobre()
    {

    }

    private void Sair()
    {
        Console.Clear();
        Environment.Exit(0);
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
