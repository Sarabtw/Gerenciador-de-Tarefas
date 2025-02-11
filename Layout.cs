namespace Layout
{
    class Formatacao
    {
        public static void Cor(string mensagem, ConsoleColor cor) 
        {
            Console.ForegroundColor = cor;
            Console.Write(mensagem);
            Console.ResetColor();
        }
        public static void ImprimirCabecalho(string titulo)
        {
          int largura = 40;
          string borda = new string('=', largura);

          Formatacao.Cor("╔" + borda + "╗", ConsoleColor.White);
          Formatacao.Cor("║" + titulo.PadLeft((largura + titulo.Length) / 2).PadRight(largura) + "║");
          Formatacao.Cor("╚" + borda + "╝");

        }
    }
}