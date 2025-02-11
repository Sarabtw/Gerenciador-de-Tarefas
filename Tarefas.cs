using System.Dynamic;
using Layout;

namespace Tarefas
{
    
    

        public class Tarefa
        {
            public int Id { get; private set; }

            public string Descricao { get; set;}

            public bool Concluida { get; set}

            public Tarefa(int id, string descricao)
            {
                Id = id;
                Descricao = descricao;
                Concluida = false;
            }
        }
        public static string ExibirTarefa()
        {

        }
    
}