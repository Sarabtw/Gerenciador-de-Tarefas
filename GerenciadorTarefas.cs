using Layout;

namespace GerenciadorTarefa
{
    class GerenciarTarefa
    {
        public static string AdicionarTarefa(descricao)
        {
            Console.Clear();
           repetir:
            Formatacao.Cor("Descreva a tarefa: \n");
            if (!string.TryParse(Console.ReadLine(), out string descricao))
          {
            Console.WriteLine("Valor inválido! \n");
            goto repetir;
          }
            return valor;
        }
        public static string ConcluirTarefa(id)
        {
            
        }
        public static string ListarTarefa()
        {

        }
        public static string RemoverTarefa(id)
        {

        }

    }
}