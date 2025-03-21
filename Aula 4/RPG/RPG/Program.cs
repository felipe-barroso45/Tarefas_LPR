using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha sua classe:");
        Console.WriteLine("1. Guerreiro");
        Console.WriteLine("2. Mago");
        Console.WriteLine("3. Arqueiro");
        Console.Write("Digite o número da classe escolhida: ");

        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                ExibirHabilidadesGuerreiro();
                break;
            case 2:
                ExibirHabilidadesMago();
                break;
            case 3:
                ExibirHabilidadesArqueiro();
                break;
            default:
                Console.WriteLine("Por favor, escolha uma classe válida.");
                break;
        }
    }

    static void ExibirHabilidadesGuerreiro()
    {
        Console.WriteLine("\nHabilidades do Guerreiro:");
        Console.WriteLine("- Corte Furioso: Causa dano extra em um ataque.");
        Console.WriteLine("- Benção da Deusa: Aumenta a defesa por um curto período.");
        Console.WriteLine("- Onda de Choque: Causa dano em área.");
    }

    static void ExibirHabilidadesMago()
    {
        Console.WriteLine("\nHabilidades do Mago:");
        Console.WriteLine("- Bola de Fogo: Causa dano em área.");
        Console.WriteLine("- Vento Gélido: Congela os inimigos por um curto período.");
        Console.WriteLine("- Teleportar: Move-se rapidamente para uma posição próxima.");
    }

    static void ExibirHabilidadesArqueiro()
    {
        Console.WriteLine("\nHabilidades do Arqueiro:");
        Console.WriteLine("- Disparo de precisão: Causa um acerto crítico.");
        Console.WriteLine("- Chuva de Flechas: Causa dano em área.");
        Console.WriteLine("- Camuflagem: Se fora da visão do inimigo, fica invisível por um curto período.");
    }
}