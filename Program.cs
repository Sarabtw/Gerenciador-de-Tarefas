using Layout;
using GerenciadorTarefas;
using Tarefas;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            
            Formatacao.Cor("1 - Adicionar Tarefa\n", ConsoleColor.Green);
            Formatacao.Cor("2 - Listar Tarefas\n", ConsoleColor.Green);
            Formatacao.Cor("3 - Concluir Tarefa\n", ConsoleColor.Green);
             Formatacao.Cor("4 - Remover Tarefa\n", ConsoleColor.Green);
            Formatacao.Cor("0 - Sair\n", ConsoleColor.Green);
            Formatacao.Cor("Digite a opção aqui: \n");
            string opcao = Console.ReadLine();
            if (opcao == "0")
            {
                Formatacao.Cor("Saindo...", ConsoleColor.Red);
                break;
            }
             string descricao = AdicionarTarefa(descricao);

            switch(opcao)
            {
               case "1":
               AdicionarTarefa(descricao);
               break;
               case "2":
               ListarTarefa();
               break;
               case "3":
               ConcluirTarefa(id);
               break;
               case "4":
               RemoverTarefa(id);
               break;
               default:

               Formatacao.Cor("Opção inválida! Tente novamente.\n", ConsoleColor.Red);
               break;
            }
            Console.ReadKey();
        }
    }
}

