namespace WebAssemby_PickingByVoice
{
    public static class Sequencial
    {
        public static int ProdutoIndex { get; set; } = 0;
        public static int UnidadeIndex { get; set; } = 0;

      

        // Método para reiniciar os índices, caso seja necessário
        public static void Reiniciar()
        {
            ProdutoIndex = 0;
            UnidadeIndex = 0;
        }
    }
}
